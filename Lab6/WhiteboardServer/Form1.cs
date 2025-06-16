using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using WhiteboardShared;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Text.Json;
using System.Threading;
using System.Collections.Concurrent;

namespace WhiteboardServer
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private ConcurrentDictionary<string, TcpClient> clients = new();
        private List<DrawingAction> drawingHistory = new();
        private List<WhiteboardImage> imageHistory = new();
        private const int MAX_CLIENTS = 5;
        private const int PORT = 8080;
        private CancellationTokenSource cancellationTokenSource;
        private readonly object syncLock = new object();

        public Form1()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
            InitializeServer();
        }

        private void InitializeServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, PORT);
                server.Start();
                UpdateStatus($"Server started on port {PORT}");
                UpdateClientCount();

                // Start accepting clients
                _ = AcceptClientsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting server: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatus(string status)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateStatus(status)));
                return;
            }
            lblStatus.Text = status;
        }

        private void UpdateClientCount()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateClientCount));
                return;
            }
            lblClients.Text = $"Connected clients: {clients.Count}";
        }

        private async Task AcceptClientsAsync()
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                try
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    string clientId = Guid.NewGuid().ToString();

                    if (clients.Count >= MAX_CLIENTS)
                    {
                        await SendEmailAlert();
                        await SendMessageToClient(client, "Server is full");
                        client.Close();
                        continue;
                    }

                    clients.TryAdd(clientId, client);
                    UpdateClientCount();
                    UpdateStatus($"New client connected: {clientId}");

                    // Send current state to new client
                    await SendCurrentStateToClient(client);

                    // Start handling client messages
                    _ = HandleClientAsync(client, clientId);
                }
                catch (Exception ex) when (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    UpdateStatus($"Error accepting client: {ex.Message}");
                }
            }
        }

        private async Task SendCurrentStateToClient(TcpClient client)
        {
            try
            {
                var state = new
                {
                    Type = "InitialState",
                    DrawingHistory = drawingHistory,
                    ImageHistory = imageHistory
                };

                string json = JsonSerializer.Serialize(state);
                byte[] buffer = Encoding.UTF8.GetBytes(json);
                
                NetworkStream stream = client.GetStream();
                await stream.WriteAsync(buffer, 0, buffer.Length);
                await stream.FlushAsync();
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error sending current state: {ex.Message}");
            }
        }

        private async Task HandleClientAsync(TcpClient client, string clientId)
        {
            byte[] buffer = new byte[8192];
            NetworkStream stream = client.GetStream();
            StringBuilder messageBuilder = new StringBuilder();

            try
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    messageBuilder.Append(receivedData);

                    // Process complete messages
                    string messages = messageBuilder.ToString();
                    int lastBraceIndex = messages.LastIndexOf('}');
                    if (lastBraceIndex >= 0)
                    {
                        string completeMessages = messages.Substring(0, lastBraceIndex + 1);
                        messageBuilder.Clear();
                        messageBuilder.Append(messages.Substring(lastBraceIndex + 1));

                        foreach (string message in completeMessages.Split('}'))
                        {
                            if (!string.IsNullOrEmpty(message))
                            {
                                await ProcessMessage(message + "}", clientId);
                            }
                        }
                    }
                }
            }
            catch (Exception) when (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                // Client disconnected
            }
            finally
            {
                clients.TryRemove(clientId, out _);
                UpdateClientCount();
                client.Close();
                UpdateStatus($"Client disconnected: {clientId}");
            }
        }

        private async Task ProcessMessage(string json, string senderId)
        {
            try
            {
                if (json.Contains("EndSession"))
                {
                    await BroadcastToClients(json);
                    return;
                }

                // Try as DrawingAction
                try
                {
                    var action = JsonSerializer.Deserialize<DrawingAction>(json);
                    lock (syncLock)
                    {
                        drawingHistory.Add(action);
                    }
                    await BroadcastToClients(json);
                    return;
                }
                catch { }

                // Try as WhiteboardImage
                try
                {
                    var image = JsonSerializer.Deserialize<WhiteboardImage>(json);
                    lock (syncLock)
                    {
                        var existingImage = imageHistory.Find(img => img.ClientId == image.ClientId);
                        if (existingImage != null)
                        {
                            imageHistory.Remove(existingImage);
                        }
                        imageHistory.Add(image);
                    }
                    await BroadcastToClients(json);
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Error processing message: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error processing message: {ex.Message}");
            }
        }

        private async Task BroadcastToClients(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            var disconnectedClients = new List<string>();

            foreach (var client in clients)
            {
                try
                {
                    NetworkStream stream = client.Value.GetStream();
                    await stream.WriteAsync(buffer, 0, buffer.Length);
                    await stream.FlushAsync();
                }
                catch
                {
                    disconnectedClients.Add(client.Key);
                }
            }

            // Remove disconnected clients
            foreach (var clientId in disconnectedClients)
            {
                clients.TryRemove(clientId, out _);
                UpdateClientCount();
                UpdateStatus($"Client disconnected: {clientId}");
            }
        }

        private async Task SendMessageToClient(TcpClient client, string message)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                NetworkStream stream = client.GetStream();
                await stream.WriteAsync(buffer, 0, buffer.Length);
                await stream.FlushAsync();
            }
            catch { }
        }

        private async Task SendEmailAlert()
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("your-email@gmail.com", "your-app-password");

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress("your-email@gmail.com");
                    message.To.Add("admin@example.com");
                    message.Subject = "Whiteboard Server Alert";
                    message.Body = "Maximum number of clients reached!";

                    await smtp.SendMailAsync(message);
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error sending email: {ex.Message}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            cancellationTokenSource.Cancel();
            server?.Stop();
            
            foreach (var client in clients.Values)
            {
                try
                {
                    client.Close();
                }
                catch { }
            }
        }
    }
}

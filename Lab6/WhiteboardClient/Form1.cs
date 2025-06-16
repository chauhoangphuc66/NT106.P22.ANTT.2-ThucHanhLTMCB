using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using WhiteboardShared;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Net.Http;

namespace WhiteboardClient
{
    public partial class Form1 : Form
    {
        private TcpClient? client;
        private NetworkStream? stream;
        private bool isDrawing = false;
        private Point lastPoint;
        private readonly string clientId;
        private CancellationTokenSource cancellationTokenSource;
        private List<DrawingAction> drawingHistory = new();
        private List<WhiteboardImage> imageHistory = new();
        private readonly object syncLock = new object();
        private readonly HttpClient httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            SetupForm();
            clientId = Guid.NewGuid().ToString();
            cancellationTokenSource = new CancellationTokenSource();
            
            // Initialize drawing surface
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);
            }

            ConnectToServer();
        }

        private void SetupForm()
        {
            // Set form properties
            ClientSize = new Size(800, 500);
            Text = "Whiteboard Client";

            // Configure controls
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Size = new Size(776, 397);
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

            lblStatus.Location = new Point(12, 9);
            lblStatus.Size = new Size(200, 23);
            lblStatus.Text = "Disconnected";

            lblClients.Location = new Point(218, 9);
            lblClients.Size = new Size(200, 23);
            lblClients.Text = "Connected clients: 0";

            txtImageUrl.Location = new Point(12, 444);
            txtImageUrl.Size = new Size(570, 23);

            btnInsertImage.Location = new Point(588, 444);
            btnInsertImage.Size = new Size(100, 23);
            btnInsertImage.Text = "Insert Image";

            btnEnd.Location = new Point(694, 444);
            btnEnd.Size = new Size(94, 23);
            btnEnd.Text = "End";
        }

        private async void ConnectToServer()
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync("127.0.0.1", 8080);
                stream = client.GetStream();
                UpdateStatus("Connected to server");

                // Start receiving messages
                _ = ReceiveMessagesAsync();
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error connecting to server: {ex.Message}");
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

        private async Task ReceiveMessagesAsync()
        {
            byte[] buffer = new byte[8192];
            StringBuilder messageBuilder = new StringBuilder();

            try
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested && stream != null)
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
                                await ProcessMessage(message + "}");
                            }
                        }
                    }
                }
            }
            catch (Exception) when (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                UpdateStatus("Disconnected from server");
            }
        }

        private async Task ProcessMessage(string json)
        {
            try
            {
                if (json.Contains("Server is full"))
                {
                    MessageBox.Show("Server is full. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                if (json.Contains("EndSession"))
                {
                    await HandleEndSession();
                    return;
                }

                // Try to deserialize as initial state first
                try
                {
                    var state = JsonSerializer.Deserialize<dynamic>(json);
                    if (state.GetProperty("Type").GetString() == "InitialState")
                    {
                        drawingHistory = JsonSerializer.Deserialize<List<DrawingAction>>(state.GetProperty("DrawingHistory"));
                        imageHistory = JsonSerializer.Deserialize<List<WhiteboardImage>>(state.GetProperty("ImageHistory"));
                        RedrawWhiteboard();
                        return;
                    }
                }
                catch { }

                // Try as DrawingAction
                try
                {
                    var action = JsonSerializer.Deserialize<DrawingAction>(json);
                    if (action.ClientId != clientId) // Don't process our own actions
                    {
                        lock (syncLock)
                        {
                            drawingHistory.Add(action);
                        }
                        DrawAction(action);
                    }
                }
                catch
                {
                    // Try as WhiteboardImage
                    try
                    {
                        var image = JsonSerializer.Deserialize<WhiteboardImage>(json);
                        if (image.ClientId != clientId) // Don't process our own images
                        {
                            lock (syncLock)
                            {
                                var existingImage = imageHistory.Find(img => img.ClientId == image.ClientId);
                                if (existingImage != null)
                                {
                                    imageHistory.Remove(existingImage);
                                }
                                imageHistory.Add(image);
                            }
                            RedrawWhiteboard();
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateStatus($"Error processing message: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error processing message: {ex.Message}");
            }
        }

        private void RedrawWhiteboard()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RedrawWhiteboard));
                return;
            }

            if (pictureBox1.Image == null) return;

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);

                // Draw all actions
                lock (syncLock)
                {
                    foreach (var action in drawingHistory)
                    {
                        using (Pen pen = new Pen(Color.Black, 2))
                        {
                            g.DrawLine(pen, action.StartPoint, action.EndPoint);
                        }
                    }

                    // Draw all images
                    foreach (var image in imageHistory)
                    {
                        DrawImage(image, g);
                    }
                }
            }
            pictureBox1.Invalidate();
        }

        private async void DrawImage(WhiteboardImage image, Graphics g = null)
        {
            try
            {
                if (pictureBox1.Image == null) return;

                var imageData = await httpClient.GetByteArrayAsync(image.Url);
                using (var ms = new System.IO.MemoryStream(imageData))
                using (var downloadedImage = Image.FromStream(ms))
                {
                    if (g == null)
                    {
                        using (g = Graphics.FromImage(pictureBox1.Image))
                        {
                            g.DrawImage(downloadedImage, image.Location.X, image.Location.Y, image.Size.Width, image.Size.Height);
                        }
                        pictureBox1.Invalidate();
                    }
                    else
                    {
                        g.DrawImage(downloadedImage, image.Location.X, image.Location.Y, image.Size.Width, image.Size.Height);
                    }
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error loading image: {ex.Message}");
            }
        }

        private void DrawAction(DrawingAction action)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => DrawAction(action)));
                return;
            }

            if (pictureBox1.Image == null) return;

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    g.DrawLine(pen, action.StartPoint, action.EndPoint);
                }
            }
            pictureBox1.Invalidate();
        }

        private async Task SendToServer(object data)
        {
            try
            {
                if (stream == null) return;

                string json = JsonSerializer.Serialize(data);
                byte[] buffer = Encoding.UTF8.GetBytes(json);
                await stream.WriteAsync(buffer, 0, buffer.Length);
                await stream.FlushAsync();
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error sending to server: {ex.Message}");
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private async void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            var action = new DrawingAction
            {
                ClientId = clientId,
                StartPoint = lastPoint,
                EndPoint = e.Location
            };

            lock (syncLock)
            {
                drawingHistory.Add(action);
            }
            DrawAction(action);
            await SendToServer(action);

            lastPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private async void btnInsertImage_Click(object sender, EventArgs e)
        {
            string url = txtImageUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter an image URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var imageData = await httpClient.GetByteArrayAsync(url);
                using (var ms = new System.IO.MemoryStream(imageData))
                using (var downloadedImage = Image.FromStream(ms))
                {
                    var image = new WhiteboardImage
                    {
                        ClientId = clientId,
                        Url = url,
                        Location = new Point(10, 10),
                        Size = new Size(200, (int)(200.0 * downloadedImage.Height / downloadedImage.Width))
                    };

                    lock (syncLock)
                    {
                        imageHistory.Add(image);
                    }
                    RedrawWhiteboard();
                    await SendToServer(image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEnd_Click(object sender, EventArgs e)
        {
            await HandleEndSession();
        }

        private async Task HandleEndSession()
        {
            try
            {
                if (pictureBox1.Image == null) return;

                // Save the whiteboard as PNG
                string filename = $"whiteboard_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                pictureBox1.Image.Save(filename, ImageFormat.Png);
                UpdateStatus($"Whiteboard saved as {filename}");

                // Close the form
                if (InvokeRequired)
                {
                    Invoke(new Action(() => Close()));
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error handling end session: {ex.Message}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            cancellationTokenSource.Cancel();
            client?.Close();
            httpClient.Dispose();
        }
    }
}


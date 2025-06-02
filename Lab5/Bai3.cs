using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LAB5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            string senderEmail = "23520139@gm.uit.edu.vn"; // Replace with your email address
            string senderPassword = "chrr diuh xlyi eese"; //Search for "App Passwords" in your Google Account settings to generate a password for this app.
            string recipientEmail = to_textbox.Text.Trim();
            string subject = subject_textbox.Text.Trim();
            string body = richTextBox1.Text;

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(senderEmail);
                message.To.Add(recipientEmail);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                // Add attachments from listBox1 (full file paths expected)
                foreach (var item in listBox1.Items)
                {
                    string filepath = item.ToString();
                    if (File.Exists(filepath))
                    {
                        Attachment attachment = new Attachment(filepath);
                        message.Attachments.Add(attachment);
                    }
                }

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;

                smtp.Send(message);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email:\n" + ex.Message);
            }
            subject_textbox.Clear();
            richTextBox1.Clear();
            listBox1.Items.Clear();
        }

        private void attach_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "All Files (*.*)|*.*",
                Title = "Select files to attach"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    if (!listBox1.Items.Contains(file)) // avoid duplicates
                    {
                        listBox1.Items.Add(file); // full file path
                    }
                }
            }
        }

        private void from_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

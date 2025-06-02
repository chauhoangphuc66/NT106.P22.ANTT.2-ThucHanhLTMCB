using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
namespace LAB5
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string email = email_textbox.Text.Trim();      // e.g., duc@localmail.com or minh@localmail.com
            string password = password_textbox.Text.Trim(); // e.g., 123

            using (var client = new ImapClient())
            {
                try
                {
                    client.Connect("127.0.0.1", 143, false); // connect to hMailServer IMAP
                    client.Authenticate(email, password);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);


                    // Setup ListView columns
                    listView1.Items.Clear();
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Email", 200);
                    listView1.Columns.Add("From", 100);
                    listView1.Columns.Add("Thời gian", 100);
                    listView1.View = View.Details;

                    // Add all messages
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem name = new ListViewItem(message.Subject);
                        name.SubItems.Add(message.From.ToString());
                        name.SubItems.Add(message.Date.Date.ToString("yyyy-MM-dd HH:mm"));
                        listView1.Items.Add(name);
                    }

                    // Show total and recent email info
                    total_textbox.Text = inbox.Count.ToString();

                    if (inbox.Count > 0)
                    {
                        var lastMessage = inbox.GetMessage(inbox.Count - 1);
                        recent_textbox.Text = lastMessage.Subject;
                    }
                    else
                    {
                        recent_textbox.Text = "No messages.";
                    }

                    client.Disconnect(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login failed or cannot fetch inbox:\n" + ex.Message);
                }
            }
        }
    }
}

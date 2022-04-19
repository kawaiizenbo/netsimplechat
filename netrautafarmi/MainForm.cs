using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;

namespace netrautafarmi
{
    public partial class MainForm : Form
    {
        private System.Timers.Timer messageCheckTimer;
        private string instanceBaseURL;
        private string oldHTML;

        public MainForm()
        {
            InitializeComponent();
            // set up timer
            messageCheckTimer = new System.Timers.Timer();
            messageCheckTimer.Interval = 1000;
            messageCheckTimer.Elapsed += CheckForMessages;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            // check for messages when refresh button is clicked
            CheckForMessages(null, null);
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            // do nothing if instance not selected
            if (instanceBaseURL == null) return;
            try
            {
                // make a POST request to the remote server instance
                using (WebClient wc = new WebClient())
                {
                    var data = new NameValueCollection();
                    data["name"] = nicknameBox.Text;
                    data["msg"] = textBox.Text;
                    wc.UploadValues(instanceBaseURL + "/post.php", data);
                }
                CheckForMessages(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Couldn't Post");
            }
            // clear text box after posting message
            textBox.Text = "";
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // send message if enter is pressed while in message writing box
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                postButton_Click(null, null);
            }
        }

        private void autoRefreshCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // turn on and off auto refresh with checkbox
            if(autoRefreshCheckBox.Checked) messageCheckTimer.Start();
            else messageCheckTimer.Stop();
        }

        private void CheckForMessages(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    // world's best html to rtf
                    string html = wc.DownloadString(instanceBaseURL + "/messages.txt");
                    if (html == oldHTML) return;
                    oldHTML = html;
                    html = "{\\rtf1\\ansi{}{\\colortbl;\\red114\\green114\\blue114;\\red28\\green135\\blue87;\\red44\\green73\\blue201;}\\pard\n" + html;
                    List<string> newHTML = new List<string>();
                    foreach (string s in html.Split('\n'))
                    {
                        newHTML.Add(s.Replace("</span>", "\\cf0 ")
                            .Replace("<span style='color: #727272;'>", "\\cf1 ")
                            .Replace("<span style='color: #1c8757;'>", "\\cf2 ")
                            .Replace("<span style='color: #2c49c9;'>", "\\cf3 "));
                    }
                    messagesView.BeginInvoke(new MethodInvoker(delegate ()
                    {
                        messagesView.Rtf = string.Join("\\par\n", newHTML.ToArray());
                    }));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void connectToInstanceButton_Click(object sender, EventArgs e)
        {
            // connect to instance from text box
            messageCheckTimer.Stop();
            instanceBaseURL = instanceTextBox.Text;
            try
            {
                CheckForMessages(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Couldnt connect.");
                return;
            }
            messageCheckTimer.Start();
        }

        private void instanceListButton_Click(object sender, EventArgs e)
        {
            InstanceSelectorForm instanceSelectorForm = new InstanceSelectorForm();
            if (instanceSelectorForm.ShowDialog() == DialogResult.OK && instanceSelectorForm.InstanceName != null)
            {
                instanceTextBox.Text = instanceSelectorForm.InstanceName;
            }
        }
    }
}

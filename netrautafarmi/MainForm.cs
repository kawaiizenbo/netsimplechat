using System;
using System.Collections.Specialized;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace netrautafarmi
{
    public partial class MainForm : Form
    {
        private System.Timers.Timer messageCheckTimer;

        public MainForm()
        {
            InitializeComponent();
            messageCheckTimer = new System.Timers.Timer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            messageCheckTimer.Interval = 1000;
            messageCheckTimer.Elapsed += CheckForMessages;
            messageCheckTimer.Start();
            CheckForMessages(null, null);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            CheckForMessages(null, null);
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                var data = new NameValueCollection();
                data["name"] = nicknameBox.Text;
                data["msg"] = textBox.Text;
                wc.UploadValues("http://donut.gq/rautafarmi/post.php", data);
                string html = wc.DownloadString("http://donut.gq/rautafarmi/messages.txt");
                messagesView.Text = Regex.Replace(html, "<.*?>", "");
            }
            textBox.Text = "";
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                postButton_Click(null, null);
            }
        }

        private void autoRefreshCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(autoRefreshCheckBox.Checked) messageCheckTimer.Start();
            else messageCheckTimer.Stop();
        }

        private void CheckForMessages(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                string html = wc.DownloadString("http://donut.gq/rautafarmi/messages.txt");
                messagesView.BeginInvoke(new MethodInvoker(delegate ()
                {
                    messagesView.Text = Regex.Replace(html, "<.*?>", "");
                }));
            }
        }
    }
}

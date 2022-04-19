using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace netrautafarmi
{
    public partial class MainForm : Form
    {
        private System.Timers.Timer messageCheckTimer;
        private string instanceBaseURL;
        private string oldHTML;

        public List<string> instancesList = new List<string>()
        {
            "http://donut.gq/rautafarmi",
            "http://kawaiizenbo.me:8080/kzrautafarmi"
        };
        public string lastUsedNickName = "";

        public MainForm()
        {
            InitializeComponent();
            // set up timer
            messageCheckTimer = new System.Timers.Timer();
            messageCheckTimer.Interval = 1000;
            messageCheckTimer.Elapsed += CheckForMessages;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // load config.ini if it exists
            if (File.Exists("config.ini"))
            {
                Dictionary<string, string> cfg = new Dictionary<string, string>();
                foreach (string s in File.ReadAllLines("config.ini"))
                {
                    if (!s.StartsWith("#") && !s.StartsWith(";") && !s.StartsWith("["))
                    {
                        cfg.Add(s.Split('=')[0].Trim(), s.Split('=')[1].Trim());
                    }
                }
                nicknameBox.Text = lastUsedNickName = cfg["nickname"];
                instancesList = new List<string>(cfg["instances"].Split(','));
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // save config.ini
            File.WriteAllText("config.ini", $"# netrautafarmi config file\n" +
                $"nickname = {lastUsedNickName}\n" +
                $"instances = {string.Join(",", instancesList.ToArray())}");
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
                    data["name"] = nicknameBox.Text.Trim();
                    data["msg"] = textBox.Text.Trim();
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
            lastUsedNickName = nicknameBox.Text.Trim();
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
            // create an instance selector form
            InstanceSelectorForm instanceSelectorForm = new InstanceSelectorForm();
            // add saved instance urls to control
            foreach (string s in instancesList)
            {
                instanceSelectorForm.instancesListBox.Items.Add(s);
            }
            // show form and get selected instance
            if (instanceSelectorForm.ShowDialog() == DialogResult.OK && instanceSelectorForm.InstanceName != null)
            {
                instanceTextBox.Text = instanceSelectorForm.InstanceName;
            }
            instancesList = instanceSelectorForm.ReturnedInstances;
        }
    }
}

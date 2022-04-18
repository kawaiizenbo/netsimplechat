using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace netrautafarmi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using(WebClient wc = new WebClient())
            {
                string html = wc.DownloadString("http://donut.gq/rautafarmi/messages.txt");
                messagesView.Text = Regex.Replace(html, "<.*?>", "");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                string html = wc.DownloadString("http://donut.gq/rautafarmi/messages.txt");
                messagesView.Text = Regex.Replace(html, "<.*?>", "");
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                var data = new NameValueCollection();
                data["name"] = nicknameBox.Text;
                data["msg"] = textBox.Text;
                wc.UploadValues("https://donut.gq/rautafarmi/post.php", data);
                string html = wc.DownloadString("http://donut.gq/rautafarmi/messages.txt");
                messagesView.Text = Regex.Replace(html, "<.*?>", "");
            }
        }
    }
}

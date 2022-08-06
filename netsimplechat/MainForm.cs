﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace netsimplechat
{
    public partial class MainForm : Form
    {
        private System.Timers.Timer messageCheckTimer;
        private string instanceBaseURL;
        private string oldHTML;

        public List<string> instancesList = new List<string>()
        {
            "http://donut.gq/rautafarmi",
            "http://kawaiizenbo.me:8080/kzrautafarmi",
            "http://api.sudaox.com/nativechat"
        };
        public string lastUsedNickName = "";
        public Color dateColor = Color.FromArgb(114, 114, 114);
        public Color nameColor = Color.FromArgb(28, 135, 87);
        public Color numberColor = Color.FromArgb(44, 73, 201);
        public Color gtTextColor = Color.FromArgb(120, 153, 34);
        public Color opNameColor = Color.FromArgb(0xaa, 0x2a, 0xc9);

        public MainForm()
        {
            InitializeComponent();
            // set up timer
            messageCheckTimer = new System.Timers.Timer();
            messageCheckTimer.Interval = 1000;
            messageCheckTimer.Elapsed += TimerTickHandler;
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
                dateColor = Color.FromArgb(int.Parse(cfg["dateColor"].Split(',')[0]), 
                    int.Parse(cfg["dateColor"].Split(',')[1]), 
                    int.Parse(cfg["dateColor"].Split(',')[2]));
                nameColor = Color.FromArgb(int.Parse(cfg["nameColor"].Split(',')[0]),
                    int.Parse(cfg["nameColor"].Split(',')[1]),
                    int.Parse(cfg["nameColor"].Split(',')[2]));
                numberColor = Color.FromArgb(int.Parse(cfg["numberColor"].Split(',')[0]),
                    int.Parse(cfg["numberColor"].Split(',')[1]),
                    int.Parse(cfg["numberColor"].Split(',')[2]));
                gtTextColor = Color.FromArgb(int.Parse(cfg["gtTextColor"].Split(',')[0]),
                    int.Parse(cfg["gtTextColor"].Split(',')[1]),
                    int.Parse(cfg["gtTextColor"].Split(',')[2]));
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // save config.ini
            File.WriteAllText("config.ini", 
                $"# netrautafarmi config file\n" +
                $"nickname = {lastUsedNickName}\n" +
                $"instances = {string.Join(",", instancesList.ToArray())}\n" +
                $"dateColor = {dateColor.R},{dateColor.G},{dateColor.B}\n" +
                $"nameColor = {nameColor.R},{nameColor.G},{nameColor.B}\n" +
                $"numberColor = {numberColor.R},{numberColor.G},{numberColor.B}\n" +
                $"gtTextColor = {gtTextColor.R},{gtTextColor.G},{gtTextColor.B}\n");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            // check for messages when refresh button is clicked
            // cant pass extra args for timer event
            CheckForMessages(true);
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            // do nothing if instance not selected
            if (instanceBaseURL == null) return;
            try
            {
                if (instanceBaseURL == "http://api.sudaox.com/nativechat")
                {
                    var str = new WebClient().DownloadString("http://api.sudaox.com/nativechat/send.php" +
                        "?u=" + Uri.EscapeUriString(nicknameBox.Text.Trim()) + 
                        "&m=" + Uri.EscapeUriString(textBox.Text.Trim()) + "&v=2");
                    if (str == "sendsuccess")
                    {
                        // that's cool, i dont care
                    }
                    if (str == "diag_updateSend")
                    {
                        MessageBox.Show("You must update your client to the latest version to send messages.", "Update Required");
                    }
                }
                else
                {
                    // make a POST request to the remote server instance
                    using (WebClient wc = new WebClient())
                    {
                        var data = new NameValueCollection();
                        data["name"] = Uri.EscapeUriString(nicknameBox.Text.Trim());
                        data["msg"] = Uri.EscapeUriString(textBox.Text.Trim());
                        wc.UploadValues(instanceBaseURL + "/post.php", data);
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Couldn't Post");
            }
            // clear text box after posting message
            textBox.Text = "";
            lastUsedNickName = nicknameBox.Text.Trim();
            CheckForMessages(false);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // send message if enter is pressed while in message writing box
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                postButton_Click(null, null);
            }
        }

        private void TimerTickHandler(object sender, EventArgs e)
        {
            // handle timer tick
            CheckForMessages(false);
        }
        private void CheckForMessages(bool forced)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    if (instanceBaseURL == "http://api.sudaox.com/nativechat")
                    {
                        string chat = new WebClient().DownloadString("http://api.sudaox.com/nativechat/chat.php");
                        if (chat == oldHTML && !forced) return;
                        oldHTML = chat;
                        messagesView.BeginInvoke(new MethodInvoker(delegate ()
                        {
                            messagesView.Rtf = "";
                            messagesView.Text = "";
                            messagesView.Text = chat;
                        }));
                    }
                    else
                    {
                        // world's best html to rtf
                        string html = wc.DownloadString(instanceBaseURL + "/messages.txt");
                        if (html == oldHTML && !forced) return;
                        oldHTML = html;
                        messagesView.BeginInvoke(new MethodInvoker(delegate ()
                        {
                            messagesView.Rtf = "";
                            messagesView.Text = "";
                        }));
                        html = "{\\rtf1\\ansi{}{\\colortbl;" +
                            $"\\red{dateColor.R}\\green{dateColor.G}\\blue{dateColor.B};" +
                            $"\\red{nameColor.R}\\green{nameColor.G}\\blue{nameColor.B};" +
                            $"\\red{numberColor.R}\\green{numberColor.G}\\blue{numberColor.B};" +
                            $"\\red{gtTextColor.R}\\green{gtTextColor.G}\\blue{gtTextColor.B};" +
                            $"\\red{opNameColor.R}\\green{opNameColor.G}\\blue{opNameColor.B};" +
                            "}\\pard\n" + html;
                        List<string> newHTML = new List<string>();
                        foreach (string s in html.Split('\n'))
                        {
                            newHTML.Add(s
                                .Replace("</span>", "\\cf0 ")
                                .Replace("<span style='color: #727272;'>", "\\cf1 ")
                                .Replace("<span style='color: #1c8757;'>", "\\cf2 ")
                                .Replace("<span style='color: #2c49c9;'>", "\\cf3 ")
                                .Replace("<span style='color: #789922;'>", "\\cf4 ")
                                .Replace("<span style='color: #aa2cc9;'>", "\\cf5 ")
                                .Replace("&gt;", ">")
                                .Replace("&lt;", "<")
                                .Replace("&amp;", "&")
                                .Replace("&quot;", "\""));
                        }
                        messagesView.BeginInvoke(new MethodInvoker(delegate ()
                        {
                            messagesView.Rtf = string.Join("\\cf0\\par\n", newHTML.ToArray());
                        }));
                    }
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
                CheckForMessages(true);
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
            SettingsForm instanceSelectorForm = new SettingsForm();
            // mad
            instanceSelectorForm.ReturnedInstances = instancesList;
            instanceSelectorForm.ReturnedDateColor = dateColor;
            instanceSelectorForm.ReturnedNameColor = nameColor;
            instanceSelectorForm.ReturnedNumberColor = numberColor;
            instanceSelectorForm.ReturnedGTTextColor = gtTextColor;
            instanceSelectorForm.ReturnedOPNameColor = opNameColor;
            // show form and get selected instance
            if (instanceSelectorForm.ShowDialog() == DialogResult.OK && instanceSelectorForm.InstanceName != null)
            {
                instanceTextBox.Text = instanceSelectorForm.InstanceName;
            }
            // even madder
            instancesList = instanceSelectorForm.ReturnedInstances;
            dateColor = instanceSelectorForm.ReturnedDateColor;
            nameColor = instanceSelectorForm.ReturnedNameColor;
            numberColor = instanceSelectorForm.ReturnedNumberColor;
            gtTextColor = instanceSelectorForm.ReturnedGTTextColor;
            opNameColor = instanceSelectorForm.ReturnedOPNameColor;
        }
    }
}

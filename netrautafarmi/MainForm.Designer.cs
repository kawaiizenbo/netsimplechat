namespace netrautafarmi
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.nicknameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autoRefreshCheckBox = new System.Windows.Forms.CheckBox();
            this.instanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectToInstanceButton = new System.Windows.Forms.Button();
            this.messagesView = new System.Windows.Forms.RichTextBox();
            this.instanceListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(76, 380);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(536, 20);
            this.textBox.TabIndex = 1;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(448, 406);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // postButton
            // 
            this.postButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.postButton.Location = new System.Drawing.Point(367, 406);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 23);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // nicknameBox
            // 
            this.nicknameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nicknameBox.Location = new System.Drawing.Point(76, 408);
            this.nicknameBox.Name = "nicknameBox";
            this.nicknameBox.Size = new System.Drawing.Size(285, 20);
            this.nicknameBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nickname:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message:";
            // 
            // autoRefreshCheckBox
            // 
            this.autoRefreshCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.autoRefreshCheckBox.AutoSize = true;
            this.autoRefreshCheckBox.Checked = true;
            this.autoRefreshCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefreshCheckBox.Location = new System.Drawing.Point(529, 410);
            this.autoRefreshCheckBox.Name = "autoRefreshCheckBox";
            this.autoRefreshCheckBox.Size = new System.Drawing.Size(83, 17);
            this.autoRefreshCheckBox.TabIndex = 9;
            this.autoRefreshCheckBox.Text = "Auto refresh";
            this.autoRefreshCheckBox.UseVisualStyleBackColor = true;
            this.autoRefreshCheckBox.CheckedChanged += new System.EventHandler(this.autoRefreshCheckBox_CheckedChanged);
            // 
            // instanceTextBox
            // 
            this.instanceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instanceTextBox.Location = new System.Drawing.Point(76, 12);
            this.instanceTextBox.Name = "instanceTextBox";
            this.instanceTextBox.Size = new System.Drawing.Size(374, 20);
            this.instanceTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Instance:";
            // 
            // connectToInstanceButton
            // 
            this.connectToInstanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectToInstanceButton.Location = new System.Drawing.Point(537, 10);
            this.connectToInstanceButton.Name = "connectToInstanceButton";
            this.connectToInstanceButton.Size = new System.Drawing.Size(75, 23);
            this.connectToInstanceButton.TabIndex = 12;
            this.connectToInstanceButton.Text = "Connect";
            this.connectToInstanceButton.UseVisualStyleBackColor = true;
            this.connectToInstanceButton.Click += new System.EventHandler(this.connectToInstanceButton_Click);
            // 
            // messagesView
            // 
            this.messagesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesView.BackColor = System.Drawing.Color.White;
            this.messagesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messagesView.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesView.Location = new System.Drawing.Point(12, 38);
            this.messagesView.Name = "messagesView";
            this.messagesView.Size = new System.Drawing.Size(600, 336);
            this.messagesView.TabIndex = 13;
            this.messagesView.Text = "";
            // 
            // instanceListButton
            // 
            this.instanceListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.instanceListButton.Location = new System.Drawing.Point(456, 10);
            this.instanceListButton.Name = "instanceListButton";
            this.instanceListButton.Size = new System.Drawing.Size(75, 23);
            this.instanceListButton.TabIndex = 14;
            this.instanceListButton.Text = "List";
            this.instanceListButton.UseVisualStyleBackColor = true;
            this.instanceListButton.Click += new System.EventHandler(this.instanceListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.instanceListButton);
            this.Controls.Add(this.messagesView);
            this.Controls.Add(this.connectToInstanceButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instanceTextBox);
            this.Controls.Add(this.autoRefreshCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nicknameBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MainForm";
            this.Text = "netrautafarmi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.TextBox nicknameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox autoRefreshCheckBox;
        private System.Windows.Forms.TextBox instanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectToInstanceButton;
        private System.Windows.Forms.RichTextBox messagesView;
        private System.Windows.Forms.Button instanceListButton;
    }
}


namespace netrautafarmi
{
    partial class SettingsForm
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
            this.instancesListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addInstanceTextbox = new System.Windows.Forms.TextBox();
            this.addInstanceButton = new System.Windows.Forms.Button();
            this.removeInstanceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gtTextColorSelectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numberColorSelectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameColorSelectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateColorSelectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.opNameColorSelectButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // instancesListBox
            // 
            this.instancesListBox.FormattingEnabled = true;
            this.instancesListBox.Location = new System.Drawing.Point(6, 19);
            this.instancesListBox.Name = "instancesListBox";
            this.instancesListBox.Size = new System.Drawing.Size(260, 186);
            this.instancesListBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(168, 237);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Select";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(365, 255);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addInstanceTextbox
            // 
            this.addInstanceTextbox.Location = new System.Drawing.Point(6, 211);
            this.addInstanceTextbox.Name = "addInstanceTextbox";
            this.addInstanceTextbox.Size = new System.Drawing.Size(260, 20);
            this.addInstanceTextbox.TabIndex = 4;
            // 
            // addInstanceButton
            // 
            this.addInstanceButton.Location = new System.Drawing.Point(87, 237);
            this.addInstanceButton.Name = "addInstanceButton";
            this.addInstanceButton.Size = new System.Drawing.Size(75, 23);
            this.addInstanceButton.TabIndex = 5;
            this.addInstanceButton.Text = "Add";
            this.addInstanceButton.UseVisualStyleBackColor = true;
            this.addInstanceButton.Click += new System.EventHandler(this.addInstanceButton_Click);
            // 
            // removeInstanceButton
            // 
            this.removeInstanceButton.Location = new System.Drawing.Point(6, 237);
            this.removeInstanceButton.Name = "removeInstanceButton";
            this.removeInstanceButton.Size = new System.Drawing.Size(75, 23);
            this.removeInstanceButton.TabIndex = 6;
            this.removeInstanceButton.Text = "Remove";
            this.removeInstanceButton.UseVisualStyleBackColor = true;
            this.removeInstanceButton.Click += new System.EventHandler(this.removeInstanceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.instancesListBox);
            this.groupBox1.Controls.Add(this.addInstanceButton);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.removeInstanceButton);
            this.groupBox1.Controls.Add(this.addInstanceTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 266);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Favorite Instances";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.opNameColorSelectButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gtTextColorSelectButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numberColorSelectButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nameColorSelectButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateColorSelectButton);
            this.groupBox2.Location = new System.Drawing.Point(290, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 164);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "\'>\' Text Label";
            // 
            // gtTextColorSelectButton
            // 
            this.gtTextColorSelectButton.Location = new System.Drawing.Point(6, 106);
            this.gtTextColorSelectButton.Name = "gtTextColorSelectButton";
            this.gtTextColorSelectButton.Size = new System.Drawing.Size(30, 23);
            this.gtTextColorSelectButton.TabIndex = 6;
            this.gtTextColorSelectButton.UseVisualStyleBackColor = true;
            this.gtTextColorSelectButton.Click += new System.EventHandler(this.gtTextColorSelectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number Label";
            // 
            // numberColorSelectButton
            // 
            this.numberColorSelectButton.Location = new System.Drawing.Point(6, 77);
            this.numberColorSelectButton.Name = "numberColorSelectButton";
            this.numberColorSelectButton.Size = new System.Drawing.Size(30, 23);
            this.numberColorSelectButton.TabIndex = 4;
            this.numberColorSelectButton.UseVisualStyleBackColor = true;
            this.numberColorSelectButton.Click += new System.EventHandler(this.numberColorSelectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nickname Label";
            // 
            // nameColorSelectButton
            // 
            this.nameColorSelectButton.Location = new System.Drawing.Point(6, 48);
            this.nameColorSelectButton.Name = "nameColorSelectButton";
            this.nameColorSelectButton.Size = new System.Drawing.Size(30, 23);
            this.nameColorSelectButton.TabIndex = 2;
            this.nameColorSelectButton.UseVisualStyleBackColor = true;
            this.nameColorSelectButton.Click += new System.EventHandler(this.nameColorSelectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Label";
            // 
            // dateColorSelectButton
            // 
            this.dateColorSelectButton.Location = new System.Drawing.Point(6, 19);
            this.dateColorSelectButton.Name = "dateColorSelectButton";
            this.dateColorSelectButton.Size = new System.Drawing.Size(30, 23);
            this.dateColorSelectButton.TabIndex = 0;
            this.dateColorSelectButton.UseVisualStyleBackColor = true;
            this.dateColorSelectButton.Click += new System.EventHandler(this.dateColorSelectButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "rautafarmi by donut.gq";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "netrautafarmi by KawaiiZenbo";
            // 
            // opNameColorSelectButton
            // 
            this.opNameColorSelectButton.Location = new System.Drawing.Point(6, 135);
            this.opNameColorSelectButton.Name = "opNameColorSelectButton";
            this.opNameColorSelectButton.Size = new System.Drawing.Size(30, 23);
            this.opNameColorSelectButton.TabIndex = 8;
            this.opNameColorSelectButton.UseVisualStyleBackColor = true;
            this.opNameColorSelectButton.Click += new System.EventHandler(this.opNameColorSelectButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "SysOp Name Color";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 290);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InstanceSelectorForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox instancesListBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox addInstanceTextbox;
        private System.Windows.Forms.Button addInstanceButton;
        private System.Windows.Forms.Button removeInstanceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gtTextColorSelectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button numberColorSelectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nameColorSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dateColorSelectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button opNameColorSelectButton;
    }
}
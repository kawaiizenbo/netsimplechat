namespace netrautafarmi
{
    partial class InstanceSelectorForm
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
            this.SuspendLayout();
            // 
            // instancesListBox
            // 
            this.instancesListBox.FormattingEnabled = true;
            this.instancesListBox.Location = new System.Drawing.Point(12, 12);
            this.instancesListBox.Name = "instancesListBox";
            this.instancesListBox.Size = new System.Drawing.Size(260, 186);
            this.instancesListBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(146, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(60, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(212, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addInstanceTextbox
            // 
            this.addInstanceTextbox.Location = new System.Drawing.Point(12, 200);
            this.addInstanceTextbox.Name = "addInstanceTextbox";
            this.addInstanceTextbox.Size = new System.Drawing.Size(260, 20);
            this.addInstanceTextbox.TabIndex = 4;
            // 
            // addInstanceButton
            // 
            this.addInstanceButton.Location = new System.Drawing.Point(80, 226);
            this.addInstanceButton.Name = "addInstanceButton";
            this.addInstanceButton.Size = new System.Drawing.Size(60, 23);
            this.addInstanceButton.TabIndex = 5;
            this.addInstanceButton.Text = "Add";
            this.addInstanceButton.UseVisualStyleBackColor = true;
            this.addInstanceButton.Click += new System.EventHandler(this.addInstanceButton_Click);
            // 
            // removeInstanceButton
            // 
            this.removeInstanceButton.Location = new System.Drawing.Point(14, 226);
            this.removeInstanceButton.Name = "removeInstanceButton";
            this.removeInstanceButton.Size = new System.Drawing.Size(60, 23);
            this.removeInstanceButton.TabIndex = 6;
            this.removeInstanceButton.Text = "Remove";
            this.removeInstanceButton.UseVisualStyleBackColor = true;
            this.removeInstanceButton.Click += new System.EventHandler(this.removeInstanceButton_Click);
            // 
            // InstanceSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.removeInstanceButton);
            this.Controls.Add(this.addInstanceButton);
            this.Controls.Add(this.addInstanceTextbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.instancesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstanceSelectorForm";
            this.Text = "Favourite Instances";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InstanceSelectorForm_FormClosed);
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
    }
}
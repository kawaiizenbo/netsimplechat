using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace netrautafarmi
{
    public partial class SettingsForm : Form
    {
        public string InstanceName { get; set; }
        public List<string> ReturnedInstances { get; set; } = new List<string>();
        public Color ReturnedDateColor { get; set;  }
        public Color ReturnedNameColor { get; set; }
        public Color ReturnedNumberColor { get; set; }
        public Color ReturnedGTTextColor { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (instancesListBox.SelectedItem != null)
            {
                InstanceName = instancesListBox.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addInstanceButton_Click(object sender, EventArgs e)
        {
            if (addInstanceTextbox.Text.Trim() == "") return;
            instancesListBox.Items.Add(addInstanceTextbox.Text.Trim());
        }

        private void removeInstanceButton_Click(object sender, EventArgs e)
        {
            if (instancesListBox.SelectedItem != null)
            instancesListBox.Items.Remove(instancesListBox.Items[instancesListBox.SelectedIndex]);
        }

        private void InstanceSelectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReturnedInstances.Clear();
            foreach (object s in instancesListBox.Items)
            {
                ReturnedInstances.Add(s.ToString());
            }
        }

        private void dateColorSelectButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) dateColorSelectButton.BackColor = ReturnedDateColor = colorDialog.Color;
        }

        private void nameColorSelectButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) nameColorSelectButton.BackColor = ReturnedNameColor = colorDialog.Color;
        }

        private void numberColorSelectButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) numberColorSelectButton.BackColor = ReturnedNumberColor = colorDialog.Color;
        }

        private void gtTextColorSelectButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) gtTextColorSelectButton.BackColor = ReturnedGTTextColor = colorDialog.Color;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            foreach (string s in ReturnedInstances)
            {
                instancesListBox.Items.Add(s);
            }
            dateColorSelectButton.BackColor = ReturnedDateColor;
            nameColorSelectButton.BackColor = ReturnedNameColor;
            numberColorSelectButton.BackColor = ReturnedNumberColor;
            gtTextColorSelectButton.BackColor = ReturnedGTTextColor;
        }
    }
}

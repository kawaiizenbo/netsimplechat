using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace netrautafarmi
{
    public partial class InstanceSelectorForm : Form
    {
        public string InstanceName { get; set; }
        public List<string> ReturnedInstances { get; } = new List<string>();
        public InstanceSelectorForm()
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
            instancesListBox.Items.Remove(instancesListBox.Items[instancesListBox.SelectedIndex]);
        }

        private void InstanceSelectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (object s in instancesListBox.Items)
            {
                ReturnedInstances.Add(s.ToString());
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace netrautafarmi
{
    public partial class InstanceSelectorForm : Form
    {
        public string InstanceName { get; set; }
        public InstanceSelectorForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                InstanceName = listBox1.SelectedItem.ToString();
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
    }
}

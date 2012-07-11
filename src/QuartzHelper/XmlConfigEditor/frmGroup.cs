using System;
using System.Windows.Forms;

namespace QuartzHelper.XmlConfigEditor
{
    public partial class frmGroup : Form
    {
        public string GroupValue { get; private set; }

        public frmGroup() : this(null)
        {
            
        }

        public frmGroup(string group)
        {
            InitializeComponent();

            txtGroup.Text = group ?? string.Empty;
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGroup.Text))
            {
                MessageBox.Show("Group Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GroupValue = txtGroup.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            GroupValue = string.Empty;

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

using System;
using System.Windows.Forms;
using QuartzHelper.XmlConfigEditor.Entities;

namespace QuartzHelper.XmlConfigEditor
{
    public partial class frmNameGroup : Form
    {
        public string NameValue { get; private set; }
        public string GroupValue { get; private set; }

        public frmNameGroup() : this(null)
        {
            
        }

        public frmNameGroup(NameGroupData data)
        {
            InitializeComponent();

            txtName.Text = data == null
                            ? string.Empty
                            : data.Name;

            txtGroup.Text = data == null
                             ? string.Empty
                             : data.Group;
        }

        private void frmNameGroup_Load(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NameValue = txtName.Text;
            GroupValue = txtGroup.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            NameValue = string.Empty;
            GroupValue = string.Empty;

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

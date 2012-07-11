using System;
using System.Windows.Forms;
using QuartzHelper.XmlConfigEditor.Entities;

namespace QuartzHelper.XmlConfigEditor
{
    public partial class frmKeyValue : Form
    {
        public string KeyValue { get; private set; }
        public string ValueValue { get; private set; }

        public frmKeyValue() : this(null)
        {
            
        }

        public frmKeyValue(JobDataMapEntry data)
        {
            InitializeComponent();

            txtKey.Text = data == null
                            ? string.Empty
                            : data.Key;

            txtValue.Text = data == null
                             ? string.Empty
                             : data.Value;
        }

        private void frmKeyValue_Load(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Key Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KeyValue = txtKey.Text;
            ValueValue = txtValue.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            KeyValue = string.Empty;
            ValueValue = string.Empty;

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

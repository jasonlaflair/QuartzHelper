using System;
using System.Windows.Forms;
using QuartzHelper.XmlConfigEditor;

namespace QuartzHelper
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void cmdXmlConfigEditor_Click(object sender, EventArgs e)
        {
            using (var frm = new frmEditor())
            {
                frm.ShowDialog();
            }
        }

        private void cmdCronTester_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon", "DOH!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

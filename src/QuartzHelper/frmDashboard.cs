using System;
using System.Windows.Forms;
using QuartzHelper.CronTester;
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
            MessageBox.Show("Coming Soon", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //using (var frm = new frmEditor())
            //{
            //    frm.ShowDialog();
            //}
        }

        private void cmdCronTester_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCronTester())
            {
                frm.ShowDialog();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

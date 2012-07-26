using System;
using System.Windows.Forms;
using Quartz;

namespace QuartzHelper.CronTester
{
    public partial class frmCronTester : Form
    {
        public frmCronTester()
        {
            InitializeComponent();
            
            SetToNow();
        }

        private void frmCronTester_Load(object sender, EventArgs e)
        {
            txtCron.Text = "0 0/5 2-19 ? * MON-FRI";
        }

        private void txtCron_TextChanged(object sender, EventArgs e)
        {
            if (CronExpression.IsValidExpression(txtCron.Text))
            {
                errorProvider1.SetError(txtCron, string.Empty);
                cmdNextFire.Enabled = true;
                cmdLoopNext.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtCron, "Invalid Cron Expression");
                cmdNextFire.Enabled = false;
                cmdLoopNext.Enabled = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cmdLoopNext.Text = string.Format("Next ({0:N0})", numericUpDown1.Value);
        }

        private void cmdNow_Click(object sender, EventArgs e)
        {
            SetToNow();
        }

        private void SetToNow()
        {
            dtpDateTime.Value = DateTime.Now;
        }

        private void cmdNextFire_Click(object sender, EventArgs e)
        {
            lbFires.Items.Clear();
            UpdateNext(dtpDateTime.Value);
        }

        private void cmdLoopNext_Click(object sender, EventArgs e)
        {
            lbFires.Items.Clear();
            var prev = (DateTime?)dtpDateTime.Value;

            for (var i = 0; i < numericUpDown1.Value; i++)
            {
                if (!prev.HasValue)
                {
                    break;
                }

                prev = UpdateNext(prev.Value);
            }
        }

        private DateTime? UpdateNext(DateTime previous)
        {
            var exp = new CronExpression(txtCron.Text);

            var next = exp.GetNextValidTimeAfter(previous.ToUniversalTime());

            if (next.HasValue)
            {
                var dt = next.Value.DateTime.ToLocalTime();

                lbFires.Items.Add(dt.ToString("MM/dd/yyyy hh:mm:ss tt"));
                
                return dt;
            }
         
            return null;
        }
    }
}

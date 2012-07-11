using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using QuartzHelper.XmlConfigEditor.Entities;

namespace QuartzHelper.XmlConfigEditor
{
    public partial class frmJob : Form
    {
        public Job JobValue { get; private set; }

        public frmJob()
            : this(null)
        {

        }

        public frmJob(Job job)
        {
            InitializeComponent();

            if (job == null)
            {
                return;
            }

            txtName.Text = job.Name;
            txtGroup.Text = job.Group;
            txtDescription.Text = job.Description;
            txtJobType.Text = job.JobType;

            cbxDurable.CheckState = job.Durable.HasValue
                                        ? job.Durable.Value
                                              ? CheckState.Checked
                                              : CheckState.Unchecked
                                        : CheckState.Indeterminate;

            cbxRecover.CheckState = job.Recover.HasValue
                                        ? job.Recover.Value
                                              ? CheckState.Checked
                                              : CheckState.Unchecked
                                        : CheckState.Indeterminate;

            if (job.JobDataMap == null || job.JobDataMap.Entries == null)
            {
                return;
            }

            foreach (var data in job.JobDataMap.Entries)
            {
                var item = new ListViewItem(data.Key)
                               {
                                   Tag = data
                               };

                item.SubItems.Add(data.Value);

                lvJobDataMap.Items.Add(item);
            }
        }

        private void frmJob_Load(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            JobValue = new Job
                           {
                               Name = txtName.Text,
                               Group = txtGroup.Text,
                               Description = txtDescription.Text,
                               JobType = txtJobType.Text,
                               Durable = GetCheckState(cbxDurable),
                               Recover = GetCheckState(cbxRecover),
                               JobDataMap = null
                           };

            if (lvJobDataMap.Items.Count != 0)
            {
                JobValue.JobDataMap = new JobDataMap
                                          {
                                              Entries = new List<JobDataMapEntry>()
                                          };

                JobValue.JobDataMap.Entries = lvJobDataMap.SelectedItems.Cast<ListViewItem>().Select(x => (JobDataMapEntry)x.Tag).ToList();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool? GetCheckState(CheckBox box)
        {
            switch (box.CheckState)
            {
                case CheckState.Unchecked:
                    return false;
                case CheckState.Checked:
                    return true;
                case CheckState.Indeterminate:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            JobValue = null;

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmKeyValue())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var entry = new JobDataMapEntry
                                {
                                    Key = frm.KeyValue,
                                    Value = frm.ValueValue
                                };

                var item = new ListViewItem(entry.Key)
                               {
                                   Tag = entry
                               };

                item.SubItems.Add(entry.Value);

                lvJobDataMap.Items.Add(item);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvJobDataMap.SelectedItems.Count != 1)
            {
                return;
            }

            var item = lvJobDataMap.SelectedItems[0];
            var data = (JobDataMapEntry)item.Tag;

            using (var frm = new frmKeyValue(data))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                data.Key = frm.KeyValue;
                data.Value = frm.ValueValue;

                item.SubItems[0].Text = data.Key;
                item.SubItems[1].Text = data.Value;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvJobDataMap.SelectedItems.Count == 0)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Are you sure you want to remove the {0} selected item(s)?", lvJobDataMap.SelectedItems.Count), "Verify Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            foreach (ListViewItem item in lvJobDataMap.SelectedItems)
            {
                lvJobDataMap.Items.Remove(item);
            }
        }

        private void cmsKeyValue_Opening(object sender, CancelEventArgs e)
        {
            var selected = lvJobDataMap.SelectedItems.Count;

            addToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = selected == 1;
            removeToolStripMenuItem.Enabled = selected > 0;
        }
    }
}

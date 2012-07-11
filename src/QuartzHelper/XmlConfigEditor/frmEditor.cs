using System;
using System.ComponentModel;
using System.Windows.Forms;
using QuartzHelper.XmlConfigEditor.Entities;

namespace QuartzHelper.XmlConfigEditor
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmiAddNameGroup_Click(object sender, EventArgs e)
        {
            var lv = GetListViewFromToolStripDropDownItem(sender);

            using (var frm = new frmNameGroup())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var nameGroup = new NameGroupData
                                    {
                                        Name = frm.NameValue,
                                        Group = frm.GroupValue
                                    };

                var item = new ListViewItem(nameGroup.Name)
                               {
                                   Tag = nameGroup
                               };

                item.SubItems.Add(nameGroup.Group);

                lv.Items.Add(item);
            }
        }

        private void tsmiEditNameGroup_Click(object sender, EventArgs e)
        {
            var lv = GetListViewFromToolStripDropDownItem(sender);

            if (lv.SelectedItems.Count != 1)
            {
                return;
            }

            var item = lv.SelectedItems[0];
            var data = (NameGroupData) item.Tag;

            using (var frm = new frmNameGroup(data))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                data.Name = frm.NameValue;
                data.Group = frm.GroupValue;

                item.SubItems[0].Text = data.Name;
                item.SubItems[1].Text = data.Group;
            }
        }

        private void tsmiRemoveNameGroup_Click(object sender, EventArgs e)
        {
            var lv = GetListViewFromToolStripDropDownItem(sender);

            if (lv.SelectedItems.Count == 0)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Are you sure you want to remove the {0} selected item(s)?", lv.SelectedItems.Count), "Verify Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            foreach (ListViewItem item in lv.SelectedItems)
            {
                lv.Items.Remove(item);
            }
        }

        private void cmsNameGroup_Opening(object sender, CancelEventArgs e)
        {
            var lv = GetListViewFromContextMenuStrip(sender);

            var selected = lv.SelectedItems.Count;

            tsmiAddNameGroup.Enabled = true;
            tsmiEditNameGroup.Enabled = selected == 1;
            tsmiRemoveNameGroup.Enabled = selected > 0;
        }

        private void tsmiAddJobTrigger_Click(object sender, EventArgs e)
        {
            var lv = GetListViewFromToolStripDropDownItem(sender);

            using (var frm = new frmJob())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var job = frm.JobValue;

                var item = new ListViewItem(job.Name)
                               {
                                   Tag = job
                               };

                item.SubItems.Add(job.Group);

                lv.Items.Add(item);
            }
        }

        private void tsmiEditJobTrigger_Click(object sender, EventArgs e)
        {
            var lv = GetListViewFromToolStripDropDownItem(sender);

            if (lv.SelectedItems.Count != 1)
            {
                return;
            }

            var item = lv.SelectedItems[0];
            var job = (Job)item.Tag;

            using (var frm = new frmJob(job))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                item.Tag = frm.JobValue;

                item.SubItems[0].Text = frm.JobValue.Name;
                item.SubItems[1].Text = frm.JobValue.Group;
            }
        }

        private void tsmiRemoveJobTrigger_Click(object sender, EventArgs e)
        {
            var lv = GetListViewFromToolStripDropDownItem(sender);

        }

        private void cmsJobTrigger_Opening(object sender, CancelEventArgs e)
        {
            var lv = GetListViewFromContextMenuStrip(sender);

            var selected = lv.SelectedItems.Count;

            tsmiAddJobTrigger.Enabled = true;
            tsmiEditJobTrigger.Enabled = selected == 1;
            tsmiRemoveJobTrigger.Enabled = selected > 0;
        }

        private ListView GetListViewFromContextMenuStrip(object sender)
        {
            var strip = (ContextMenuStrip)sender;
            var lv = (ListView)strip.SourceControl;

            return lv;
        }

        private ListView GetListViewFromToolStripDropDownItem(object sender)
        {
            var item = (ToolStripDropDownItem)sender;
            var strip = (ContextMenuStrip)item.Owner;
            var lv = (ListView)strip.SourceControl;

            return lv;
        }

        private void tsmiAddGroup_Click(object sender, EventArgs e)
        {
            var lv = GetListViewFromToolStripDropDownItem(sender);

            using (var frm = new frmGroup())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var item = new ListViewItem(frm.GroupValue)
                               {
                                   Tag = frm.GroupValue
                               };

                lv.Items.Add(item);
            }
        }

        private void tsmiEditGroup_Click(object sender, EventArgs e)
        {
            var lv = GetListViewFromToolStripDropDownItem(sender);

            if (lv.SelectedItems.Count != 1)
            {
                return;
            }

            var item = lv.SelectedItems[0];

            using (var frm = new frmGroup(item.Tag.ToString()))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                item.Tag = frm.GroupValue;

                item.SubItems[0].Text = frm.GroupValue;
            }
        }

        private void tsmiRemoveGroup_Click(object sender, EventArgs e)
        {
            var lv = GetListViewFromToolStripDropDownItem(sender);

            if (lv.SelectedItems.Count == 0)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Are you sure you want to remove the {0} selected group(s)?", lv.SelectedItems.Count), "Verify Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            foreach (ListViewItem item in lv.SelectedItems)
            {
                lv.Items.Remove(item);
            }
        }

        private void cmsGroup_Opening(object sender, CancelEventArgs e)
        {
            var lv = GetListViewFromContextMenuStrip(sender);

            var selected = lv.SelectedItems.Count;

            tsmiAddGroup.Enabled = true;
            tsmiEditGroup.Enabled = selected == 1;
            tsmiRemoveGroup.Enabled = selected > 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // RESET FORM
            MessageBox.Show("Coming Soon", "DOH", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // load config xml
            MessageBox.Show("Coming Soon", "DOH", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save to file
            MessageBox.Show("Coming Soon", "DOH", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

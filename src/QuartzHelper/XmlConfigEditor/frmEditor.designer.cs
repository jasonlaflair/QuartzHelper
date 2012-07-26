namespace QuartzHelper.XmlConfigEditor
{
    partial class frmEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.gbPreProcessingCommands = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDeleteTriggersInGroup = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.lvDeleteTriggers = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsNameGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddNameGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditNameGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveNameGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.lvDeleteJobsInGroup = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDeleteJobs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbProcessingDirectives = new System.Windows.Forms.GroupBox();
            this.cbxIgnoreDuplicates = new System.Windows.Forms.CheckBox();
            this.cbxOverwriteExistingData = new System.Windows.Forms.CheckBox();
            this.gbSchedule = new System.Windows.Forms.GroupBox();
            this.lvTriggers = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsJobTrigger = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddJobTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditJobTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveJobTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.lvJobs = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPreProcessingCommands.SuspendLayout();
            this.cmsGroup.SuspendLayout();
            this.cmsNameGroup.SuspendLayout();
            this.gbProcessingDirectives.SuspendLayout();
            this.gbSchedule.SuspendLayout();
            this.cmsJobTrigger.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPreProcessingCommands
            // 
            this.gbPreProcessingCommands.Controls.Add(this.label4);
            this.gbPreProcessingCommands.Controls.Add(this.label3);
            this.gbPreProcessingCommands.Controls.Add(this.label2);
            this.gbPreProcessingCommands.Controls.Add(this.label1);
            this.gbPreProcessingCommands.Controls.Add(this.lvDeleteTriggersInGroup);
            this.gbPreProcessingCommands.Controls.Add(this.lvDeleteTriggers);
            this.gbPreProcessingCommands.Controls.Add(this.lvDeleteJobsInGroup);
            this.gbPreProcessingCommands.Controls.Add(this.lvDeleteJobs);
            this.gbPreProcessingCommands.Location = new System.Drawing.Point(17, 32);
            this.gbPreProcessingCommands.Margin = new System.Windows.Forms.Padding(4);
            this.gbPreProcessingCommands.Name = "gbPreProcessingCommands";
            this.gbPreProcessingCommands.Padding = new System.Windows.Forms.Padding(4);
            this.gbPreProcessingCommands.Size = new System.Drawing.Size(713, 331);
            this.gbPreProcessingCommands.TabIndex = 0;
            this.gbPreProcessingCommands.TabStop = false;
            this.gbPreProcessingCommands.Text = "Pre-Processing Commands";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delete Triggers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Delete Triggers In Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delete Jobs In Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Jobs";
            // 
            // lvDeleteTriggersInGroup
            // 
            this.lvDeleteTriggersInGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lvDeleteTriggersInGroup.ContextMenuStrip = this.cmsGroup;
            this.lvDeleteTriggersInGroup.FullRowSelect = true;
            this.lvDeleteTriggersInGroup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDeleteTriggersInGroup.HideSelection = false;
            this.lvDeleteTriggersInGroup.Location = new System.Drawing.Point(463, 194);
            this.lvDeleteTriggersInGroup.Margin = new System.Windows.Forms.Padding(4);
            this.lvDeleteTriggersInGroup.Name = "lvDeleteTriggersInGroup";
            this.lvDeleteTriggersInGroup.Size = new System.Drawing.Size(232, 118);
            this.lvDeleteTriggersInGroup.TabIndex = 0;
            this.lvDeleteTriggersInGroup.UseCompatibleStateImageBehavior = false;
            this.lvDeleteTriggersInGroup.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Group";
            this.columnHeader6.Width = 150;
            // 
            // cmsGroup
            // 
            this.cmsGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddGroup,
            this.tsmiEditGroup,
            this.tsmiRemoveGroup});
            this.cmsGroup.Name = "cmsGroup";
            this.cmsGroup.Size = new System.Drawing.Size(153, 92);
            this.cmsGroup.Opening += new System.ComponentModel.CancelEventHandler(this.cmsGroup_Opening);
            // 
            // tsmiAddGroup
            // 
            this.tsmiAddGroup.Name = "tsmiAddGroup";
            this.tsmiAddGroup.Size = new System.Drawing.Size(152, 22);
            this.tsmiAddGroup.Text = "Add";
            this.tsmiAddGroup.Click += new System.EventHandler(this.tsmiAddGroup_Click);
            // 
            // tsmiEditGroup
            // 
            this.tsmiEditGroup.Name = "tsmiEditGroup";
            this.tsmiEditGroup.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditGroup.Text = "Edit";
            this.tsmiEditGroup.Click += new System.EventHandler(this.tsmiEditGroup_Click);
            // 
            // tsmiRemoveGroup
            // 
            this.tsmiRemoveGroup.Name = "tsmiRemoveGroup";
            this.tsmiRemoveGroup.Size = new System.Drawing.Size(152, 22);
            this.tsmiRemoveGroup.Text = "Remove";
            this.tsmiRemoveGroup.Click += new System.EventHandler(this.tsmiRemoveGroup_Click);
            // 
            // lvDeleteTriggers
            // 
            this.lvDeleteTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvDeleteTriggers.ContextMenuStrip = this.cmsNameGroup;
            this.lvDeleteTriggers.FullRowSelect = true;
            this.lvDeleteTriggers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDeleteTriggers.HideSelection = false;
            this.lvDeleteTriggers.Location = new System.Drawing.Point(21, 194);
            this.lvDeleteTriggers.Margin = new System.Windows.Forms.Padding(4);
            this.lvDeleteTriggers.Name = "lvDeleteTriggers";
            this.lvDeleteTriggers.Size = new System.Drawing.Size(432, 118);
            this.lvDeleteTriggers.TabIndex = 0;
            this.lvDeleteTriggers.UseCompatibleStateImageBehavior = false;
            this.lvDeleteTriggers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Group";
            this.columnHeader4.Width = 150;
            // 
            // cmsNameGroup
            // 
            this.cmsNameGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNameGroup,
            this.tsmiEditNameGroup,
            this.tsmiRemoveNameGroup});
            this.cmsNameGroup.Name = "cmsNameGroup";
            this.cmsNameGroup.Size = new System.Drawing.Size(114, 70);
            this.cmsNameGroup.Opening += new System.ComponentModel.CancelEventHandler(this.cmsNameGroup_Opening);
            // 
            // tsmiAddNameGroup
            // 
            this.tsmiAddNameGroup.Name = "tsmiAddNameGroup";
            this.tsmiAddNameGroup.Size = new System.Drawing.Size(113, 22);
            this.tsmiAddNameGroup.Text = "Add";
            this.tsmiAddNameGroup.Click += new System.EventHandler(this.tsmiAddNameGroup_Click);
            // 
            // tsmiEditNameGroup
            // 
            this.tsmiEditNameGroup.Name = "tsmiEditNameGroup";
            this.tsmiEditNameGroup.Size = new System.Drawing.Size(113, 22);
            this.tsmiEditNameGroup.Text = "Edit";
            this.tsmiEditNameGroup.Click += new System.EventHandler(this.tsmiEditNameGroup_Click);
            // 
            // tsmiRemoveNameGroup
            // 
            this.tsmiRemoveNameGroup.Name = "tsmiRemoveNameGroup";
            this.tsmiRemoveNameGroup.Size = new System.Drawing.Size(113, 22);
            this.tsmiRemoveNameGroup.Text = "Remove";
            this.tsmiRemoveNameGroup.Click += new System.EventHandler(this.tsmiRemoveNameGroup_Click);
            // 
            // lvDeleteJobsInGroup
            // 
            this.lvDeleteJobsInGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lvDeleteJobsInGroup.ContextMenuStrip = this.cmsGroup;
            this.lvDeleteJobsInGroup.FullRowSelect = true;
            this.lvDeleteJobsInGroup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDeleteJobsInGroup.HideSelection = false;
            this.lvDeleteJobsInGroup.Location = new System.Drawing.Point(463, 48);
            this.lvDeleteJobsInGroup.Margin = new System.Windows.Forms.Padding(4);
            this.lvDeleteJobsInGroup.Name = "lvDeleteJobsInGroup";
            this.lvDeleteJobsInGroup.Size = new System.Drawing.Size(232, 118);
            this.lvDeleteJobsInGroup.TabIndex = 0;
            this.lvDeleteJobsInGroup.UseCompatibleStateImageBehavior = false;
            this.lvDeleteJobsInGroup.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Group";
            this.columnHeader5.Width = 150;
            // 
            // lvDeleteJobs
            // 
            this.lvDeleteJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDeleteJobs.ContextMenuStrip = this.cmsNameGroup;
            this.lvDeleteJobs.FullRowSelect = true;
            this.lvDeleteJobs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDeleteJobs.HideSelection = false;
            this.lvDeleteJobs.Location = new System.Drawing.Point(21, 48);
            this.lvDeleteJobs.Margin = new System.Windows.Forms.Padding(4);
            this.lvDeleteJobs.Name = "lvDeleteJobs";
            this.lvDeleteJobs.Size = new System.Drawing.Size(432, 118);
            this.lvDeleteJobs.TabIndex = 0;
            this.lvDeleteJobs.UseCompatibleStateImageBehavior = false;
            this.lvDeleteJobs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Group";
            this.columnHeader2.Width = 150;
            // 
            // gbProcessingDirectives
            // 
            this.gbProcessingDirectives.Controls.Add(this.cbxIgnoreDuplicates);
            this.gbProcessingDirectives.Controls.Add(this.cbxOverwriteExistingData);
            this.gbProcessingDirectives.Location = new System.Drawing.Point(17, 370);
            this.gbProcessingDirectives.Margin = new System.Windows.Forms.Padding(4);
            this.gbProcessingDirectives.Name = "gbProcessingDirectives";
            this.gbProcessingDirectives.Padding = new System.Windows.Forms.Padding(4);
            this.gbProcessingDirectives.Size = new System.Drawing.Size(713, 66);
            this.gbProcessingDirectives.TabIndex = 1;
            this.gbProcessingDirectives.TabStop = false;
            this.gbProcessingDirectives.Text = "Processing Directives";
            // 
            // cbxIgnoreDuplicates
            // 
            this.cbxIgnoreDuplicates.AutoSize = true;
            this.cbxIgnoreDuplicates.Checked = true;
            this.cbxIgnoreDuplicates.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbxIgnoreDuplicates.Location = new System.Drawing.Point(223, 30);
            this.cbxIgnoreDuplicates.Margin = new System.Windows.Forms.Padding(4);
            this.cbxIgnoreDuplicates.Name = "cbxIgnoreDuplicates";
            this.cbxIgnoreDuplicates.Size = new System.Drawing.Size(140, 21);
            this.cbxIgnoreDuplicates.TabIndex = 2;
            this.cbxIgnoreDuplicates.Text = "Ignore Duplicates";
            this.cbxIgnoreDuplicates.ThreeState = true;
            this.cbxIgnoreDuplicates.UseVisualStyleBackColor = true;
            // 
            // cbxOverwriteExistingData
            // 
            this.cbxOverwriteExistingData.AutoSize = true;
            this.cbxOverwriteExistingData.Checked = true;
            this.cbxOverwriteExistingData.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbxOverwriteExistingData.Location = new System.Drawing.Point(21, 30);
            this.cbxOverwriteExistingData.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOverwriteExistingData.Name = "cbxOverwriteExistingData";
            this.cbxOverwriteExistingData.Size = new System.Drawing.Size(176, 21);
            this.cbxOverwriteExistingData.TabIndex = 2;
            this.cbxOverwriteExistingData.Text = "Overwrite Existing Data";
            this.cbxOverwriteExistingData.ThreeState = true;
            this.cbxOverwriteExistingData.UseVisualStyleBackColor = true;
            // 
            // gbSchedule
            // 
            this.gbSchedule.Controls.Add(this.lvTriggers);
            this.gbSchedule.Controls.Add(this.label6);
            this.gbSchedule.Controls.Add(this.lvJobs);
            this.gbSchedule.Controls.Add(this.label5);
            this.gbSchedule.Location = new System.Drawing.Point(739, 32);
            this.gbSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.gbSchedule.Name = "gbSchedule";
            this.gbSchedule.Padding = new System.Windows.Forms.Padding(4);
            this.gbSchedule.Size = new System.Drawing.Size(473, 405);
            this.gbSchedule.TabIndex = 2;
            this.gbSchedule.TabStop = false;
            this.gbSchedule.Text = "Schedule";
            // 
            // lvTriggers
            // 
            this.lvTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.lvTriggers.ContextMenuStrip = this.cmsJobTrigger;
            this.lvTriggers.FullRowSelect = true;
            this.lvTriggers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTriggers.HideSelection = false;
            this.lvTriggers.Location = new System.Drawing.Point(21, 233);
            this.lvTriggers.Margin = new System.Windows.Forms.Padding(4);
            this.lvTriggers.Name = "lvTriggers";
            this.lvTriggers.Size = new System.Drawing.Size(432, 155);
            this.lvTriggers.TabIndex = 0;
            this.lvTriggers.UseCompatibleStateImageBehavior = false;
            this.lvTriggers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Group";
            this.columnHeader10.Width = 150;
            // 
            // cmsJobTrigger
            // 
            this.cmsJobTrigger.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddJobTrigger,
            this.tsmiEditJobTrigger,
            this.tsmiRemoveJobTrigger});
            this.cmsJobTrigger.Name = "cmsJobTrigger";
            this.cmsJobTrigger.Size = new System.Drawing.Size(114, 70);
            this.cmsJobTrigger.Opening += new System.ComponentModel.CancelEventHandler(this.cmsJobTrigger_Opening);
            // 
            // tsmiAddJobTrigger
            // 
            this.tsmiAddJobTrigger.Name = "tsmiAddJobTrigger";
            this.tsmiAddJobTrigger.Size = new System.Drawing.Size(113, 22);
            this.tsmiAddJobTrigger.Text = "Add";
            this.tsmiAddJobTrigger.Click += new System.EventHandler(this.tsmiAddJobTrigger_Click);
            // 
            // tsmiEditJobTrigger
            // 
            this.tsmiEditJobTrigger.Name = "tsmiEditJobTrigger";
            this.tsmiEditJobTrigger.Size = new System.Drawing.Size(113, 22);
            this.tsmiEditJobTrigger.Text = "Edit";
            this.tsmiEditJobTrigger.Click += new System.EventHandler(this.tsmiEditJobTrigger_Click);
            // 
            // tsmiRemoveJobTrigger
            // 
            this.tsmiRemoveJobTrigger.Name = "tsmiRemoveJobTrigger";
            this.tsmiRemoveJobTrigger.Size = new System.Drawing.Size(113, 22);
            this.tsmiRemoveJobTrigger.Text = "Remove";
            this.tsmiRemoveJobTrigger.Click += new System.EventHandler(this.tsmiRemoveJobTrigger_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Triggers";
            // 
            // lvJobs
            // 
            this.lvJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvJobs.ContextMenuStrip = this.cmsJobTrigger;
            this.lvJobs.FullRowSelect = true;
            this.lvJobs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvJobs.HideSelection = false;
            this.lvJobs.Location = new System.Drawing.Point(21, 48);
            this.lvJobs.Margin = new System.Windows.Forms.Padding(4);
            this.lvJobs.Name = "lvJobs";
            this.lvJobs.Size = new System.Drawing.Size(432, 155);
            this.lvJobs.TabIndex = 0;
            this.lvJobs.UseCompatibleStateImageBehavior = false;
            this.lvJobs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Group";
            this.columnHeader8.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Jobs";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 451);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbSchedule);
            this.Controls.Add(this.gbProcessingDirectives);
            this.Controls.Add(this.gbPreProcessingCommands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xml Configuration Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPreProcessingCommands.ResumeLayout(false);
            this.gbPreProcessingCommands.PerformLayout();
            this.cmsGroup.ResumeLayout(false);
            this.cmsNameGroup.ResumeLayout(false);
            this.gbProcessingDirectives.ResumeLayout(false);
            this.gbProcessingDirectives.PerformLayout();
            this.gbSchedule.ResumeLayout(false);
            this.gbSchedule.PerformLayout();
            this.cmsJobTrigger.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPreProcessingCommands;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDeleteTriggersInGroup;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvDeleteTriggers;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvDeleteJobsInGroup;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvDeleteJobs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbProcessingDirectives;
        private System.Windows.Forms.CheckBox cbxIgnoreDuplicates;
        private System.Windows.Forms.CheckBox cbxOverwriteExistingData;
        private System.Windows.Forms.GroupBox gbSchedule;
        private System.Windows.Forms.ListView lvTriggers;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvJobs;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmsNameGroup;
        private System.Windows.Forms.ContextMenuStrip cmsJobTrigger;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNameGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditNameGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveNameGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddJobTrigger;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditJobTrigger;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveJobTrigger;
        private System.Windows.Forms.ContextMenuStrip cmsGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveGroup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}


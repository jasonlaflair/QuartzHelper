namespace QuartzHelper.CronTester
{
    partial class frmCronTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCronTester));
            this.txtCron = new System.Windows.Forms.TextBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdNow = new System.Windows.Forms.Button();
            this.cmdNextFire = new System.Windows.Forms.Button();
            this.cmdLoopNext = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbFires = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCron
            // 
            this.txtCron.Location = new System.Drawing.Point(20, 30);
            this.txtCron.Margin = new System.Windows.Forms.Padding(4);
            this.txtCron.Name = "txtCron";
            this.txtCron.Size = new System.Drawing.Size(215, 22);
            this.txtCron.TabIndex = 0;
            this.txtCron.TextChanged += new System.EventHandler(this.txtCron_TextChanged);
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(20, 86);
            this.dtpDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(215, 22);
            this.dtpDateTime.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "\"Current Time\":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cron Expression:";
            // 
            // cmdNow
            // 
            this.cmdNow.Location = new System.Drawing.Point(55, 130);
            this.cmdNow.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNow.Name = "cmdNow";
            this.cmdNow.Size = new System.Drawing.Size(87, 28);
            this.cmdNow.TabIndex = 2;
            this.cmdNow.TabStop = false;
            this.cmdNow.Text = "Now";
            this.cmdNow.UseVisualStyleBackColor = true;
            this.cmdNow.Click += new System.EventHandler(this.cmdNow_Click);
            // 
            // cmdNextFire
            // 
            this.cmdNextFire.Enabled = false;
            this.cmdNextFire.Location = new System.Drawing.Point(149, 130);
            this.cmdNextFire.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNextFire.Name = "cmdNextFire";
            this.cmdNextFire.Size = new System.Drawing.Size(87, 28);
            this.cmdNextFire.TabIndex = 2;
            this.cmdNextFire.Text = "Next";
            this.cmdNextFire.UseVisualStyleBackColor = true;
            this.cmdNextFire.Click += new System.EventHandler(this.cmdNextFire_Click);
            // 
            // cmdLoopNext
            // 
            this.cmdLoopNext.Enabled = false;
            this.cmdLoopNext.Location = new System.Drawing.Point(149, 180);
            this.cmdLoopNext.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLoopNext.Name = "cmdLoopNext";
            this.cmdLoopNext.Size = new System.Drawing.Size(87, 28);
            this.cmdLoopNext.TabIndex = 4;
            this.cmdLoopNext.Text = "Next (1)";
            this.cmdLoopNext.UseVisualStyleBackColor = true;
            this.cmdLoopNext.Click += new System.EventHandler(this.cmdLoopNext_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(55, 183);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbFires
            // 
            this.lbFires.FormattingEnabled = true;
            this.lbFires.ItemHeight = 16;
            this.lbFires.Location = new System.Drawing.Point(265, 11);
            this.lbFires.Margin = new System.Windows.Forms.Padding(4);
            this.lbFires.Name = "lbFires";
            this.lbFires.Size = new System.Drawing.Size(204, 196);
            this.lbFires.TabIndex = 6;
            this.lbFires.TabStop = false;
            // 
            // frmCronTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 220);
            this.Controls.Add(this.lbFires);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmdLoopNext);
            this.Controls.Add(this.cmdNextFire);
            this.Controls.Add(this.cmdNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.txtCron);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCronTester";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quartz.NET Cron Tester";
            this.Load += new System.EventHandler(this.frmCronTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCron;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button cmdLoopNext;
        private System.Windows.Forms.Button cmdNextFire;
        private System.Windows.Forms.Button cmdNow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFires;
    }
}


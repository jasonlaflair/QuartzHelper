namespace QuartzHelper
{
    partial class frmDashboard
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
            this.cmdXmlConfigEditor = new System.Windows.Forms.Button();
            this.cmdCronTester = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdXmlConfigEditor
            // 
            this.cmdXmlConfigEditor.Location = new System.Drawing.Point(12, 12);
            this.cmdXmlConfigEditor.Name = "cmdXmlConfigEditor";
            this.cmdXmlConfigEditor.Size = new System.Drawing.Size(136, 49);
            this.cmdXmlConfigEditor.TabIndex = 0;
            this.cmdXmlConfigEditor.Text = "Xml Configuration Editor";
            this.cmdXmlConfigEditor.UseVisualStyleBackColor = true;
            this.cmdXmlConfigEditor.Click += new System.EventHandler(this.cmdXmlConfigEditor_Click);
            // 
            // cmdCronTester
            // 
            this.cmdCronTester.Location = new System.Drawing.Point(154, 12);
            this.cmdCronTester.Name = "cmdCronTester";
            this.cmdCronTester.Size = new System.Drawing.Size(136, 49);
            this.cmdCronTester.TabIndex = 1;
            this.cmdCronTester.Text = "Cron Tester";
            this.cmdCronTester.UseVisualStyleBackColor = true;
            this.cmdCronTester.Click += new System.EventHandler(this.cmdCronTester_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(296, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(136, 49);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 72);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdCronTester);
            this.Controls.Add(this.cmdXmlConfigEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quartz.NET Helper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdXmlConfigEditor;
        private System.Windows.Forms.Button cmdCronTester;
        private System.Windows.Forms.Button cmdClose;
    }
}
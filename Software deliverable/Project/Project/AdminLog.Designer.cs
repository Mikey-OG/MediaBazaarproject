namespace Project
{
    partial class AdminLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.ltbAdminLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewLogs);
            this.panel1.Controls.Add(this.ltbAdminLog);
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 394);
            this.panel1.TabIndex = 3;
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnViewLogs.Image")));
            this.btnViewLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewLogs.Location = new System.Drawing.Point(13, 351);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(176, 34);
            this.btnViewLogs.TabIndex = 2;
            this.btnViewLogs.Text = "Open Logs";
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // ltbAdminLog
            // 
            this.ltbAdminLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbAdminLog.FormattingEnabled = true;
            this.ltbAdminLog.ItemHeight = 29;
            this.ltbAdminLog.Location = new System.Drawing.Point(13, 13);
            this.ltbAdminLog.Name = "ltbAdminLog";
            this.ltbAdminLog.Size = new System.Drawing.Size(1109, 323);
            this.ltbAdminLog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To Admin Log";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(303, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 65);
            this.panel2.TabIndex = 5;
            // 
            // AdminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminLog";
            this.Text = "AdminLog";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ltbAdminLog;

        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
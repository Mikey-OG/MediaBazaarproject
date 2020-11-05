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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltbAdminLog = new System.Windows.Forms.ListBox();
<<<<<<< HEAD
=======
            this.btnViewLogs = new System.Windows.Forms.Button();
>>>>>>> Osuntuyi-Michael
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
<<<<<<< HEAD
            this.panel1.Controls.Add(this.ltbAdminLog);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 370);
=======
            this.panel1.Controls.Add(this.btnViewLogs);
            this.panel1.Controls.Add(this.ltbAdminLog);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 419);
>>>>>>> Osuntuyi-Michael
            this.panel1.TabIndex = 3;
            // 
            // ltbAdminLog
            // 
            this.ltbAdminLog.FormattingEnabled = true;
            this.ltbAdminLog.ItemHeight = 16;
            this.ltbAdminLog.Location = new System.Drawing.Point(13, 13);
            this.ltbAdminLog.Name = "ltbAdminLog";
            this.ltbAdminLog.Size = new System.Drawing.Size(550, 340);
            this.ltbAdminLog.TabIndex = 1;
            // 
<<<<<<< HEAD
=======
            // btnViewLogs
            // 
            this.btnViewLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLogs.Location = new System.Drawing.Point(13, 371);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(124, 34);
            this.btnViewLogs.TabIndex = 2;
            this.btnViewLogs.Text = "Open Logs";
            this.btnViewLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
>>>>>>> Osuntuyi-Michael
            // AdminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(618, 408);
=======
            this.ClientSize = new System.Drawing.Size(683, 446);
>>>>>>> Osuntuyi-Michael
            this.Controls.Add(this.panel1);
            this.Name = "AdminLog";
            this.Text = "AdminLog";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ltbAdminLog;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Button btnViewLogs;
>>>>>>> Osuntuyi-Michael
    }
}
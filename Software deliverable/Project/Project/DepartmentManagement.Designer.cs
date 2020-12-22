namespace Project
{
    partial class DepartmentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentManagement));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVIewEmployeeDepartments = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnRemoveaDepartment = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.RowResetbtn = new System.Windows.Forms.Button();
            this.Seemorebtn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbAccountSecurity = new System.Windows.Forms.Label();
            this.lbSecureText = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbDepartmentName);
            this.panel3.Controls.Add(this.lblDepartmentName);
            this.panel3.Location = new System.Drawing.Point(535, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 95);
            this.panel3.TabIndex = 7;
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(189, 39);
            this.tbDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDepartmentName.Multiline = true;
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(252, 31);
            this.tbDepartmentName.TabIndex = 0;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(9, 43);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(163, 24);
            this.lblDepartmentName.TabIndex = 2;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department Information";
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(12, 38);
            this.dgvDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 24;
            this.dgvDepartments.Size = new System.Drawing.Size(517, 426);
            this.dgvDepartments.TabIndex = 6;
            this.dgvDepartments.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVIewEmployeeDepartments);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnReturnToMenu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddDepartment);
            this.panel1.Controls.Add(this.btnRemoveaDepartment);
            this.panel1.Location = new System.Drawing.Point(12, 472);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 132);
            this.panel1.TabIndex = 5;
            // 
            // btnVIewEmployeeDepartments
            // 
            this.btnVIewEmployeeDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIewEmployeeDepartments.Image = ((System.Drawing.Image)(resources.GetObject("btnVIewEmployeeDepartments.Image")));
            this.btnVIewEmployeeDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVIewEmployeeDepartments.Location = new System.Drawing.Point(7, 75);
            this.btnVIewEmployeeDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVIewEmployeeDepartments.Name = "btnVIewEmployeeDepartments";
            this.btnVIewEmployeeDepartments.Size = new System.Drawing.Size(373, 48);
            this.btnVIewEmployeeDepartments.TabIndex = 13;
            this.btnVIewEmployeeDepartments.Text = "View Employees and departments";
            this.btnVIewEmployeeDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVIewEmployeeDepartments.UseVisualStyleBackColor = true;
            this.btnVIewEmployeeDepartments.Click += new System.EventHandler(this.btnVIewEmployeeDepartments_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(385, 75);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 48);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(481, 23);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(252, 48);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Departments";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnToMenu.Image")));
            this.btnReturnToMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnToMenu.Location = new System.Drawing.Point(739, 23);
            this.btnReturnToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(175, 48);
            this.btnReturnToMenu.TabIndex = 8;
            this.btnReturnToMenu.Text = "Return Menu";
            this.btnReturnToMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Functions";
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDepartment.Image")));
            this.btnAddDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDepartment.Location = new System.Drawing.Point(7, 23);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(223, 48);
            this.btnAddDepartment.TabIndex = 3;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnRemoveaDepartment
            // 
            this.btnRemoveaDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveaDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveaDepartment.Image")));
            this.btnRemoveaDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveaDepartment.Location = new System.Drawing.Point(235, 23);
            this.btnRemoveaDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveaDepartment.Name = "btnRemoveaDepartment";
            this.btnRemoveaDepartment.Size = new System.Drawing.Size(240, 48);
            this.btnRemoveaDepartment.TabIndex = 4;
            this.btnRemoveaDepartment.Text = "Remove Department";
            this.btnRemoveaDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveaDepartment.UseVisualStyleBackColor = true;
            this.btnRemoveaDepartment.Click += new System.EventHandler(this.btnRemoveaDepartment_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(869, 38);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 37);
            this.btnHelp.TabIndex = 18;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // RowResetbtn
            // 
            this.RowResetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RowResetbtn.Location = new System.Drawing.Point(153, 609);
            this.RowResetbtn.Margin = new System.Windows.Forms.Padding(4);
            this.RowResetbtn.Name = "RowResetbtn";
            this.RowResetbtn.Size = new System.Drawing.Size(100, 36);
            this.RowResetbtn.TabIndex = 47;
            this.RowResetbtn.Text = "Resest";
            this.RowResetbtn.UseVisualStyleBackColor = true;
            this.RowResetbtn.Click += new System.EventHandler(this.RowResetbtn_Click);
            // 
            // Seemorebtn
            // 
            this.Seemorebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Seemorebtn.Location = new System.Drawing.Point(16, 608);
            this.Seemorebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Seemorebtn.Name = "Seemorebtn";
            this.Seemorebtn.Size = new System.Drawing.Size(129, 37);
            this.Seemorebtn.TabIndex = 46;
            this.Seemorebtn.Text = "See more";
            this.Seemorebtn.UseVisualStyleBackColor = true;
            this.Seemorebtn.Click += new System.EventHandler(this.Seemorebtn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(869, 609);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(117, 38);
            this.btnLogOut.TabIndex = 48;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbAccountSecurity
            // 
            this.lbAccountSecurity.AutoSize = true;
            this.lbAccountSecurity.Location = new System.Drawing.Point(115, 9);
            this.lbAccountSecurity.Name = "lbAccountSecurity";
            this.lbAccountSecurity.Size = new System.Drawing.Size(20, 17);
            this.lbAccountSecurity.TabIndex = 55;
            this.lbAccountSecurity.Text = "...";
            // 
            // lbSecureText
            // 
            this.lbSecureText.AutoSize = true;
            this.lbSecureText.Location = new System.Drawing.Point(9, 9);
            this.lbSecureText.Name = "lbSecureText";
            this.lbSecureText.Size = new System.Drawing.Size(108, 17);
            this.lbSecureText.TabIndex = 54;
            this.lbSecureText.Text = "Account Secure";
            // 
            // DepartmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.lbAccountSecurity);
            this.Controls.Add(this.lbSecureText);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.RowResetbtn);
            this.Controls.Add(this.Seemorebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DepartmentManagement";
            this.Text = "DepartmentManagement";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnRemoveaDepartment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnVIewEmployeeDepartments;
        private System.Windows.Forms.Button RowResetbtn;
        private System.Windows.Forms.Button Seemorebtn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbAccountSecurity;
        private System.Windows.Forms.Label lbSecureText;
    }
}
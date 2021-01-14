namespace Project
{
    partial class RoleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleManagement));
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVIewEmployeeandRoles = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnRemoveRole = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.cmbFormAccess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RowResetbtn = new System.Windows.Forms.Button();
            this.Seemorebtn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbAccountSecurity = new System.Windows.Forms.Label();
            this.lbSecureText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(12, 39);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(517, 431);
            this.dgvRoles.TabIndex = 10;
            this.dgvRoles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVIewEmployeeandRoles);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnReturnToMenu);
            this.panel1.Controls.Add(this.btnAddRole);
            this.panel1.Controls.Add(this.btnRemoveRole);
            this.panel1.Location = new System.Drawing.Point(559, 361);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 110);
            this.panel1.TabIndex = 9;
            // 
            // btnVIewEmployeeandRoles
            // 
            this.btnVIewEmployeeandRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIewEmployeeandRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnVIewEmployeeandRoles.Image")));
            this.btnVIewEmployeeandRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVIewEmployeeandRoles.Location = new System.Drawing.Point(7, 49);
            this.btnVIewEmployeeandRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVIewEmployeeandRoles.Name = "btnVIewEmployeeandRoles";
            this.btnVIewEmployeeandRoles.Size = new System.Drawing.Size(287, 42);
            this.btnVIewEmployeeandRoles.TabIndex = 20;
            this.btnVIewEmployeeandRoles.Text = "View Employees and Roles\r\n";
            this.btnVIewEmployeeandRoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVIewEmployeeandRoles.UseVisualStyleBackColor = true;
            this.btnVIewEmployeeandRoles.Click += new System.EventHandler(this.btnVIewEmployeeandRoles_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(300, 49);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 42);
            this.btnRefresh.TabIndex = 19;
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
            this.btnUpdate.Location = new System.Drawing.Point(317, -2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 42);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Role";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnToMenu.Image")));
            this.btnReturnToMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnToMenu.Location = new System.Drawing.Point(477, 0);
            this.btnReturnToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(149, 42);
            this.btnReturnToMenu.TabIndex = 8;
            this.btnReturnToMenu.Text = "Return Menu";
            this.btnReturnToMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRole.Image")));
            this.btnAddRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.Location = new System.Drawing.Point(7, 2);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(133, 42);
            this.btnAddRole.TabIndex = 3;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnRemoveRole
            // 
            this.btnRemoveRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRole.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveRole.Image")));
            this.btnRemoveRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveRole.Location = new System.Drawing.Point(147, 2);
            this.btnRemoveRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveRole.Name = "btnRemoveRole";
            this.btnRemoveRole.Size = new System.Drawing.Size(165, 42);
            this.btnRemoveRole.TabIndex = 4;
            this.btnRemoveRole.Text = "Remove Role";
            this.btnRemoveRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveRole.UseVisualStyleBackColor = true;
            this.btnRemoveRole.Click += new System.EventHandler(this.btnRemoveRole_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Functions";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(1085, 39);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 37);
            this.btnHelp.TabIndex = 18;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(7, 31);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(92, 20);
            this.lblDepartmentName.TabIndex = 2;
            this.lblDepartmentName.Text = "Role Name";
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(7, 54);
            this.tbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(263, 22);
            this.tbRole.TabIndex = 0;
            // 
            // cmbFormAccess
            // 
            this.cmbFormAccess.FormattingEnabled = true;
            this.cmbFormAccess.Location = new System.Drawing.Point(331, 53);
            this.cmbFormAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFormAccess.Name = "cmbFormAccess";
            this.cmbFormAccess.Size = new System.Drawing.Size(289, 24);
            this.cmbFormAccess.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Form Access";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbFormAccess);
            this.panel3.Controls.Add(this.tbRole);
            this.panel3.Controls.Add(this.lblDepartmentName);
            this.panel3.Location = new System.Drawing.Point(535, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 137);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Role Information";
            // 
            // RowResetbtn
            // 
            this.RowResetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RowResetbtn.Location = new System.Drawing.Point(151, 476);
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
            this.Seemorebtn.Location = new System.Drawing.Point(13, 475);
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
            this.btnLogOut.Location = new System.Drawing.Point(1085, 476);
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
            this.lbAccountSecurity.Location = new System.Drawing.Point(118, 9);
            this.lbAccountSecurity.Name = "lbAccountSecurity";
            this.lbAccountSecurity.Size = new System.Drawing.Size(20, 17);
            this.lbAccountSecurity.TabIndex = 55;
            this.lbAccountSecurity.Text = "...";
            // 
            // lbSecureText
            // 
            this.lbSecureText.AutoSize = true;
            this.lbSecureText.Location = new System.Drawing.Point(12, 9);
            this.lbSecureText.Name = "lbSecureText";
            this.lbSecureText.Size = new System.Drawing.Size(108, 17);
            this.lbSecureText.TabIndex = 54;
            this.lbSecureText.Text = "Account Secure";
            // 
            // RoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 536);
            this.Controls.Add(this.lbAccountSecurity);
            this.Controls.Add(this.lbSecureText);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.RowResetbtn);
            this.Controls.Add(this.Seemorebtn);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoleManagement";
            this.Text = "RoleManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnRemoveRole;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnVIewEmployeeandRoles;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.ComboBox cmbFormAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RowResetbtn;
        private System.Windows.Forms.Button Seemorebtn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbAccountSecurity;
        private System.Windows.Forms.Label lbSecureText;
    }
}
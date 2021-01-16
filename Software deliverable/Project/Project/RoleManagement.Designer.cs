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
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.btnVIewEmployeeandRoles = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnRemoveRole = new System.Windows.Forms.Button();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.Seemorebtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMenuAdminLogs = new System.Windows.Forms.Button();
            this.btnMenuDepartmentManagement = new System.Windows.Forms.Button();
            this.btnMenuRoleManagement = new System.Windows.Forms.Button();
            this.btnMenuScheduling = new System.Windows.Forms.Button();
            this.btnMenuEmployeeManagement = new System.Windows.Forms.Button();
            this.btnMenuStockManagement = new System.Windows.Forms.Button();
            this.btnMenuPersonalDetails = new System.Windows.Forms.Button();
            this.btnMenuSchedule = new System.Windows.Forms.Button();
            this.btnMenuStock = new System.Windows.Forms.Button();
            this.cmbFormAccess = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(1002, 205);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(0);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(472, 567);
            this.dgvRoles.TabIndex = 10;
            this.dgvRoles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnVIewEmployeeandRoles
            // 
            this.btnVIewEmployeeandRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnVIewEmployeeandRoles.FlatAppearance.BorderSize = 0;
            this.btnVIewEmployeeandRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVIewEmployeeandRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVIewEmployeeandRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIewEmployeeandRoles.ForeColor = System.Drawing.Color.White;
            this.btnVIewEmployeeandRoles.Location = new System.Drawing.Point(108, 24);
            this.btnVIewEmployeeandRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVIewEmployeeandRoles.Name = "btnVIewEmployeeandRoles";
            this.btnVIewEmployeeandRoles.Size = new System.Drawing.Size(418, 55);
            this.btnVIewEmployeeandRoles.TabIndex = 20;
            this.btnVIewEmployeeandRoles.Text = "View Employees and Roles\r\n";
            this.btnVIewEmployeeandRoles.UseVisualStyleBackColor = false;
            this.btnVIewEmployeeandRoles.Click += new System.EventHandler(this.btnVIewEmployeeandRoles_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(108, 83);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(418, 55);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(108, 203);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(418, 55);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Role";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRole.FlatAppearance.BorderSize = 0;
            this.btnAddRole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Location = new System.Drawing.Point(108, 138);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(418, 55);
            this.btnAddRole.TabIndex = 3;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnRemoveRole
            // 
            this.btnRemoveRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnRemoveRole.FlatAppearance.BorderSize = 0;
            this.btnRemoveRole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemoveRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRole.ForeColor = System.Drawing.Color.White;
            this.btnRemoveRole.Location = new System.Drawing.Point(108, 268);
            this.btnRemoveRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveRole.Name = "btnRemoveRole";
            this.btnRemoveRole.Size = new System.Drawing.Size(418, 55);
            this.btnRemoveRole.TabIndex = 4;
            this.btnRemoveRole.Text = "Remove Role";
            this.btnRemoveRole.UseVisualStyleBackColor = false;
            this.btnRemoveRole.Click += new System.EventHandler(this.btnRemoveRole_Click);
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(320, 85);
            this.tbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(206, 22);
            this.tbRole.TabIndex = 0;
            // 
            // Seemorebtn
            // 
            this.Seemorebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Seemorebtn.Location = new System.Drawing.Point(522, 417);
            this.Seemorebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Seemorebtn.Name = "Seemorebtn";
            this.Seemorebtn.Size = new System.Drawing.Size(129, 37);
            this.Seemorebtn.TabIndex = 46;
            this.Seemorebtn.Text = "See more";
            this.Seemorebtn.UseVisualStyleBackColor = true;
            this.Seemorebtn.Click += new System.EventHandler(this.Seemorebtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(334, 100);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1140, 66);
            this.panel6.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Role Management";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Location = new System.Drawing.Point(0, 698);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 74);
            this.panel4.TabIndex = 75;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 66);
            this.panel3.TabIndex = 73;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1502, 63);
            this.panel2.TabIndex = 72;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1354, 0);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(148, 63);
            this.btnLogOut.TabIndex = 48;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.btnMenuAdminLogs);
            this.panel5.Controls.Add(this.btnMenuDepartmentManagement);
            this.panel5.Controls.Add(this.btnMenuRoleManagement);
            this.panel5.Controls.Add(this.btnMenuScheduling);
            this.panel5.Controls.Add(this.btnMenuEmployeeManagement);
            this.panel5.Controls.Add(this.btnMenuStockManagement);
            this.panel5.Controls.Add(this.btnMenuPersonalDetails);
            this.panel5.Controls.Add(this.btnMenuSchedule);
            this.panel5.Controls.Add(this.btnMenuStock);
            this.panel5.Location = new System.Drawing.Point(0, 166);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 532);
            this.panel5.TabIndex = 71;
            // 
            // btnMenuAdminLogs
            // 
            this.btnMenuAdminLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuAdminLogs.FlatAppearance.BorderSize = 0;
            this.btnMenuAdminLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuAdminLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAdminLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAdminLogs.ForeColor = System.Drawing.Color.White;
            this.btnMenuAdminLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAdminLogs.Location = new System.Drawing.Point(0, 472);
            this.btnMenuAdminLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuAdminLogs.Name = "btnMenuAdminLogs";
            this.btnMenuAdminLogs.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuAdminLogs.Size = new System.Drawing.Size(295, 59);
            this.btnMenuAdminLogs.TabIndex = 57;
            this.btnMenuAdminLogs.Text = "Admin Logs";
            this.btnMenuAdminLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAdminLogs.UseVisualStyleBackColor = true;
            this.btnMenuAdminLogs.Click += new System.EventHandler(this.btnMenuAdminLogs_Click);
            // 
            // btnMenuDepartmentManagement
            // 
            this.btnMenuDepartmentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuDepartmentManagement.FlatAppearance.BorderSize = 0;
            this.btnMenuDepartmentManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuDepartmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDepartmentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDepartmentManagement.ForeColor = System.Drawing.Color.White;
            this.btnMenuDepartmentManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDepartmentManagement.Location = new System.Drawing.Point(0, 354);
            this.btnMenuDepartmentManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuDepartmentManagement.Name = "btnMenuDepartmentManagement";
            this.btnMenuDepartmentManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuDepartmentManagement.Size = new System.Drawing.Size(295, 59);
            this.btnMenuDepartmentManagement.TabIndex = 56;
            this.btnMenuDepartmentManagement.Text = "Department Management";
            this.btnMenuDepartmentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDepartmentManagement.UseVisualStyleBackColor = true;
            this.btnMenuDepartmentManagement.Click += new System.EventHandler(this.btnMenuDepartmentManagement_Click);
            // 
            // btnMenuRoleManagement
            // 
            this.btnMenuRoleManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuRoleManagement.FlatAppearance.BorderSize = 0;
            this.btnMenuRoleManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuRoleManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRoleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRoleManagement.ForeColor = System.Drawing.Color.White;
            this.btnMenuRoleManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRoleManagement.Location = new System.Drawing.Point(0, 295);
            this.btnMenuRoleManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuRoleManagement.Name = "btnMenuRoleManagement";
            this.btnMenuRoleManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuRoleManagement.Size = new System.Drawing.Size(295, 59);
            this.btnMenuRoleManagement.TabIndex = 55;
            this.btnMenuRoleManagement.Text = "Role Management";
            this.btnMenuRoleManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRoleManagement.UseVisualStyleBackColor = true;
            // 
            // btnMenuScheduling
            // 
            this.btnMenuScheduling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuScheduling.FlatAppearance.BorderSize = 0;
            this.btnMenuScheduling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuScheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuScheduling.ForeColor = System.Drawing.Color.White;
            this.btnMenuScheduling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuScheduling.Location = new System.Drawing.Point(0, 413);
            this.btnMenuScheduling.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuScheduling.Name = "btnMenuScheduling";
            this.btnMenuScheduling.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuScheduling.Size = new System.Drawing.Size(295, 59);
            this.btnMenuScheduling.TabIndex = 54;
            this.btnMenuScheduling.Text = "Scheduling";
            this.btnMenuScheduling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuScheduling.UseVisualStyleBackColor = true;
            this.btnMenuScheduling.Click += new System.EventHandler(this.btnMenuScheduling_Click);
            // 
            // btnMenuEmployeeManagement
            // 
            this.btnMenuEmployeeManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuEmployeeManagement.FlatAppearance.BorderSize = 0;
            this.btnMenuEmployeeManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEmployeeManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.btnMenuEmployeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEmployeeManagement.Location = new System.Drawing.Point(0, 236);
            this.btnMenuEmployeeManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuEmployeeManagement.Name = "btnMenuEmployeeManagement";
            this.btnMenuEmployeeManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuEmployeeManagement.Size = new System.Drawing.Size(295, 59);
            this.btnMenuEmployeeManagement.TabIndex = 53;
            this.btnMenuEmployeeManagement.Text = "Employee Management";
            this.btnMenuEmployeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnMenuEmployeeManagement.Click += new System.EventHandler(this.btnMenuEmployeeManagement_Click);
            // 
            // btnMenuStockManagement
            // 
            this.btnMenuStockManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuStockManagement.FlatAppearance.BorderSize = 0;
            this.btnMenuStockManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuStockManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStockManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuStockManagement.ForeColor = System.Drawing.Color.White;
            this.btnMenuStockManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuStockManagement.Location = new System.Drawing.Point(0, 177);
            this.btnMenuStockManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuStockManagement.Name = "btnMenuStockManagement";
            this.btnMenuStockManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuStockManagement.Size = new System.Drawing.Size(295, 59);
            this.btnMenuStockManagement.TabIndex = 52;
            this.btnMenuStockManagement.Text = "Stock Management";
            this.btnMenuStockManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuStockManagement.UseVisualStyleBackColor = true;
            this.btnMenuStockManagement.Click += new System.EventHandler(this.btnMenuStockManagement_Click);
            // 
            // btnMenuPersonalDetails
            // 
            this.btnMenuPersonalDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPersonalDetails.FlatAppearance.BorderSize = 0;
            this.btnMenuPersonalDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuPersonalDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPersonalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPersonalDetails.ForeColor = System.Drawing.Color.White;
            this.btnMenuPersonalDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPersonalDetails.Location = new System.Drawing.Point(0, 59);
            this.btnMenuPersonalDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuPersonalDetails.Name = "btnMenuPersonalDetails";
            this.btnMenuPersonalDetails.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuPersonalDetails.Size = new System.Drawing.Size(295, 59);
            this.btnMenuPersonalDetails.TabIndex = 51;
            this.btnMenuPersonalDetails.Text = "Personal Details";
            this.btnMenuPersonalDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPersonalDetails.UseVisualStyleBackColor = true;
            this.btnMenuPersonalDetails.Click += new System.EventHandler(this.btnMenuPersonalDetails_Click);
            // 
            // btnMenuSchedule
            // 
            this.btnMenuSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSchedule.FlatAppearance.BorderSize = 0;
            this.btnMenuSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSchedule.ForeColor = System.Drawing.Color.White;
            this.btnMenuSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSchedule.Location = new System.Drawing.Point(0, 118);
            this.btnMenuSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuSchedule.Name = "btnMenuSchedule";
            this.btnMenuSchedule.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuSchedule.Size = new System.Drawing.Size(295, 59);
            this.btnMenuSchedule.TabIndex = 50;
            this.btnMenuSchedule.Text = "Schedule";
            this.btnMenuSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSchedule.UseVisualStyleBackColor = true;
            this.btnMenuSchedule.Click += new System.EventHandler(this.btnMenuSchedule_Click);
            // 
            // btnMenuStock
            // 
            this.btnMenuStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuStock.FlatAppearance.BorderSize = 0;
            this.btnMenuStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuStock.ForeColor = System.Drawing.Color.White;
            this.btnMenuStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuStock.Location = new System.Drawing.Point(0, 0);
            this.btnMenuStock.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuStock.Name = "btnMenuStock";
            this.btnMenuStock.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuStock.Size = new System.Drawing.Size(295, 59);
            this.btnMenuStock.TabIndex = 49;
            this.btnMenuStock.Text = "Stock";
            this.btnMenuStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuStock.UseVisualStyleBackColor = true;
            this.btnMenuStock.Click += new System.EventHandler(this.btnMenuStock_Click);
            // 
            // cmbFormAccess
            // 
            this.cmbFormAccess.FormattingEnabled = true;
            this.cmbFormAccess.Location = new System.Drawing.Point(320, 41);
            this.cmbFormAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFormAccess.Name = "cmbFormAccess";
            this.cmbFormAccess.Size = new System.Drawing.Size(206, 24);
            this.cmbFormAccess.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(102, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 32);
            this.label5.TabIndex = 62;
            this.label5.Text = "Form Access:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 63;
            this.label4.Text = "Role Name:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.btnUpdate);
            this.panel8.Controls.Add(this.btnRemoveRole);
            this.panel8.Controls.Add(this.btnAddRole);
            this.panel8.Controls.Add(this.cmbFormAccess);
            this.panel8.Controls.Add(this.tbRole);
            this.panel8.Location = new System.Drawing.Point(334, 205);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(629, 366);
            this.panel8.TabIndex = 76;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel7.Controls.Add(this.btnVIewEmployeeandRoles);
            this.panel7.Controls.Add(this.btnRefresh);
            this.panel7.Location = new System.Drawing.Point(334, 610);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(629, 162);
            this.panel7.TabIndex = 77;
            // 
            // RoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Seemorebtn);
            this.Controls.Add(this.dgvRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoleManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoleManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnRemoveRole;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnVIewEmployeeandRoles;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Button Seemorebtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMenuAdminLogs;
        private System.Windows.Forms.Button btnMenuDepartmentManagement;
        private System.Windows.Forms.Button btnMenuRoleManagement;
        private System.Windows.Forms.Button btnMenuScheduling;
        private System.Windows.Forms.Button btnMenuEmployeeManagement;
        private System.Windows.Forms.Button btnMenuStockManagement;
        private System.Windows.Forms.Button btnMenuPersonalDetails;
        private System.Windows.Forms.Button btnMenuSchedule;
        private System.Windows.Forms.Button btnMenuStock;
        private System.Windows.Forms.ComboBox cmbFormAccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}
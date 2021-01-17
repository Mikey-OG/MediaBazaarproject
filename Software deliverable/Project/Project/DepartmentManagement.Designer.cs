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
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.btnVIewEmployeeDepartments = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnRemoveaDepartment = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMenuStockManagement = new System.Windows.Forms.Button();
            this.btnMenuEmployeeManagement = new System.Windows.Forms.Button();
            this.btnMenuRoleManagement = new System.Windows.Forms.Button();
            this.btnMenuStock = new System.Windows.Forms.Button();
            this.btnMenuAdminLogs = new System.Windows.Forms.Button();
            this.btnMenuDepartmentManagement = new System.Windows.Forms.Button();
            this.btnMenuScheduling = new System.Windows.Forms.Button();
            this.btnMenuPersonalDetails = new System.Windows.Forms.Button();
            this.btnMenuSchedule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(81, 65);
            this.tbDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDepartmentName.Multiline = true;
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(418, 31);
            this.tbDepartmentName.TabIndex = 0;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(553, 415);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(163, 24);
            this.lblDepartmentName.TabIndex = 2;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(957, 205);
            this.dgvDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 24;
            this.dgvDepartments.Size = new System.Drawing.Size(517, 567);
            this.dgvDepartments.TabIndex = 6;
            this.dgvDepartments.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnVIewEmployeeDepartments
            // 
            this.btnVIewEmployeeDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnVIewEmployeeDepartments.FlatAppearance.BorderSize = 0;
            this.btnVIewEmployeeDepartments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVIewEmployeeDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVIewEmployeeDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIewEmployeeDepartments.ForeColor = System.Drawing.Color.White;
            this.btnVIewEmployeeDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVIewEmployeeDepartments.Location = new System.Drawing.Point(18, 18);
            this.btnVIewEmployeeDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVIewEmployeeDepartments.Name = "btnVIewEmployeeDepartments";
            this.btnVIewEmployeeDepartments.Size = new System.Drawing.Size(547, 55);
            this.btnVIewEmployeeDepartments.TabIndex = 13;
            this.btnVIewEmployeeDepartments.Text = "View Employees and departments";
            this.btnVIewEmployeeDepartments.UseVisualStyleBackColor = false;
            this.btnVIewEmployeeDepartments.Click += new System.EventHandler(this.btnVIewEmployeeDepartments_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(18, 77);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(238, 55);
            this.btnRefresh.TabIndex = 12;
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
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(81, 193);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(418, 55);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Departments";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddDepartment.FlatAppearance.BorderSize = 0;
            this.btnAddDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDepartment.Location = new System.Drawing.Point(81, 113);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(418, 55);
            this.btnAddDepartment.TabIndex = 3;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnRemoveaDepartment
            // 
            this.btnRemoveaDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnRemoveaDepartment.FlatAppearance.BorderSize = 0;
            this.btnRemoveaDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemoveaDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveaDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveaDepartment.ForeColor = System.Drawing.Color.White;
            this.btnRemoveaDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveaDepartment.Location = new System.Drawing.Point(81, 269);
            this.btnRemoveaDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveaDepartment.Name = "btnRemoveaDepartment";
            this.btnRemoveaDepartment.Size = new System.Drawing.Size(418, 55);
            this.btnRemoveaDepartment.TabIndex = 4;
            this.btnRemoveaDepartment.Text = "Remove Department";
            this.btnRemoveaDepartment.UseVisualStyleBackColor = false;
            this.btnRemoveaDepartment.Click += new System.EventHandler(this.btnRemoveaDepartment_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.btnRefresh);
            this.panel7.Controls.Add(this.btnVIewEmployeeDepartments);
            this.panel7.Location = new System.Drawing.Point(334, 610);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(600, 162);
            this.panel7.TabIndex = 84;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel8.Controls.Add(this.btnUpdate);
            this.panel8.Controls.Add(this.btnRemoveaDepartment);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.btnAddDepartment);
            this.panel8.Controls.Add(this.tbDepartmentName);
            this.panel8.Location = new System.Drawing.Point(334, 205);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(565, 366);
            this.panel8.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 32);
            this.label4.TabIndex = 63;
            this.label4.Text = "Department Name:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(334, 100);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1140, 66);
            this.panel6.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Department Management";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Location = new System.Drawing.Point(0, 698);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 74);
            this.panel4.TabIndex = 82;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 66);
            this.panel3.TabIndex = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1502, 63);
            this.panel2.TabIndex = 79;
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
            this.panel5.Controls.Add(this.btnMenuStockManagement);
            this.panel5.Controls.Add(this.btnMenuEmployeeManagement);
            this.panel5.Controls.Add(this.btnMenuRoleManagement);
            this.panel5.Controls.Add(this.btnMenuStock);
            this.panel5.Controls.Add(this.btnMenuAdminLogs);
            this.panel5.Controls.Add(this.btnMenuDepartmentManagement);
            this.panel5.Controls.Add(this.btnMenuScheduling);
            this.panel5.Controls.Add(this.btnMenuPersonalDetails);
            this.panel5.Controls.Add(this.btnMenuSchedule);
            this.panel5.Location = new System.Drawing.Point(0, 166);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 532);
            this.panel5.TabIndex = 78;
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
            this.btnMenuStockManagement.Location = new System.Drawing.Point(0, 473);
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
            // btnMenuEmployeeManagement
            // 
            this.btnMenuEmployeeManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuEmployeeManagement.FlatAppearance.BorderSize = 0;
            this.btnMenuEmployeeManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEmployeeManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.btnMenuEmployeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEmployeeManagement.Location = new System.Drawing.Point(0, 0);
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
            // btnMenuRoleManagement
            // 
            this.btnMenuRoleManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuRoleManagement.FlatAppearance.BorderSize = 0;
            this.btnMenuRoleManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuRoleManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRoleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRoleManagement.ForeColor = System.Drawing.Color.White;
            this.btnMenuRoleManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRoleManagement.Location = new System.Drawing.Point(0, 177);
            this.btnMenuRoleManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuRoleManagement.Name = "btnMenuRoleManagement";
            this.btnMenuRoleManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuRoleManagement.Size = new System.Drawing.Size(295, 59);
            this.btnMenuRoleManagement.TabIndex = 55;
            this.btnMenuRoleManagement.Text = "Role Management";
            this.btnMenuRoleManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRoleManagement.UseVisualStyleBackColor = true;
            this.btnMenuRoleManagement.Click += new System.EventHandler(this.btnMenuRoleManagement_Click);
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
            this.btnMenuStock.Location = new System.Drawing.Point(0, 295);
            this.btnMenuStock.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuStock.Name = "btnMenuStock";
            this.btnMenuStock.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuStock.Size = new System.Drawing.Size(295, 59);
            this.btnMenuStock.TabIndex = 49;
            this.btnMenuStock.Text = "Shop Personnel Stock View";
            this.btnMenuStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuStock.UseVisualStyleBackColor = true;
            this.btnMenuStock.Click += new System.EventHandler(this.btnMenuStock_Click);
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
            this.btnMenuAdminLogs.Location = new System.Drawing.Point(0, 236);
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
            this.btnMenuDepartmentManagement.Location = new System.Drawing.Point(0, 118);
            this.btnMenuDepartmentManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuDepartmentManagement.Name = "btnMenuDepartmentManagement";
            this.btnMenuDepartmentManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuDepartmentManagement.Size = new System.Drawing.Size(295, 59);
            this.btnMenuDepartmentManagement.TabIndex = 56;
            this.btnMenuDepartmentManagement.Text = "Department Management";
            this.btnMenuDepartmentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDepartmentManagement.UseVisualStyleBackColor = true;
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
            this.btnMenuScheduling.Location = new System.Drawing.Point(0, 59);
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
            // btnMenuPersonalDetails
            // 
            this.btnMenuPersonalDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPersonalDetails.FlatAppearance.BorderSize = 0;
            this.btnMenuPersonalDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuPersonalDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPersonalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPersonalDetails.ForeColor = System.Drawing.Color.White;
            this.btnMenuPersonalDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPersonalDetails.Location = new System.Drawing.Point(0, 413);
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
            this.btnMenuSchedule.Location = new System.Drawing.Point(0, 354);
            this.btnMenuSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuSchedule.Name = "btnMenuSchedule";
            this.btnMenuSchedule.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuSchedule.Size = new System.Drawing.Size(295, 59);
            this.btnMenuSchedule.TabIndex = 50;
            this.btnMenuSchedule.Text = "Shop Personnel Schedule";
            this.btnMenuSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSchedule.UseVisualStyleBackColor = true;
            this.btnMenuSchedule.Click += new System.EventHandler(this.btnMenuSchedule_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(327, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepartmentManagement
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
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.dgvDepartments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DepartmentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnRemoveaDepartment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnVIewEmployeeDepartments;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button button1;
    }
}
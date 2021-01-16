namespace Project
{
    partial class EmployeeScheduling
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.numEmployeesAShift = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuRoleManagement = new System.Windows.Forms.Button();
            this.btnMenuStock = new System.Windows.Forms.Button();
            this.btnMenuAdminLogs = new System.Windows.Forms.Button();
            this.btnMenuDepartmentManagement = new System.Windows.Forms.Button();
            this.btnMenuScheduling = new System.Windows.Forms.Button();
            this.btnMenuEmployeeManagement = new System.Windows.Forms.Button();
            this.btnMenuStockManagement = new System.Windows.Forms.Button();
            this.btnMenuPersonalDetails = new System.Windows.Forms.Button();
            this.btnMenuSchedule = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbShifts = new System.Windows.Forms.ComboBox();
            this.btnRemoveSchedule = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtAddRemove = new System.Windows.Forms.DateTimePicker();
            this.dataViewSchedules = new System.Windows.Forms.DataGridView();
            this.dataViewEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numEmployeesAShift)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewEmployees)).BeginInit();
            this.SuspendLayout();
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
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // numEmployeesAShift
            // 
            this.numEmployeesAShift.Location = new System.Drawing.Point(155, 125);
            this.numEmployeesAShift.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numEmployeesAShift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEmployeesAShift.Name = "numEmployeesAShift";
            this.numEmployeesAShift.Size = new System.Drawing.Size(184, 22);
            this.numEmployeesAShift.TabIndex = 65;
            this.numEmployeesAShift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEmployeesAShift.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 62;
            this.label4.Text = "From:";
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGenerateSchedule.FlatAppearance.BorderSize = 0;
            this.btnGenerateSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenerateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGenerateSchedule.ForeColor = System.Drawing.Color.White;
            this.btnGenerateSchedule.Location = new System.Drawing.Point(36, 172);
            this.btnGenerateSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(303, 55);
            this.btnGenerateSchedule.TabIndex = 61;
            this.btnGenerateSchedule.Text = "Generate Schedule";
            this.btnGenerateSchedule.UseVisualStyleBackColor = false;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd-MM-yyyy";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(155, 79);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEnd.MinDate = new System.DateTime(2021, 1, 15, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtEnd.Size = new System.Drawing.Size(184, 22);
            this.dtEnd.TabIndex = 59;
            // 
            // dtBegin
            // 
            this.dtBegin.CalendarForeColor = System.Drawing.Color.White;
            this.dtBegin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dtBegin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dtBegin.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtBegin.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dtBegin.CustomFormat = "dd-MM-yyyy";
            this.dtBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBegin.Location = new System.Drawing.Point(155, 37);
            this.dtBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtBegin.MinDate = new System.DateTime(2021, 1, 15, 0, 0, 0, 0);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(184, 22);
            this.dtBegin.TabIndex = 60;
            this.dtBegin.Value = new System.DateTime(2021, 1, 15, 15, 37, 14, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnMenuSchedule);
            this.panel1.Controls.Add(this.btnMenuRoleManagement);
            this.panel1.Controls.Add(this.btnMenuStock);
            this.panel1.Controls.Add(this.btnMenuAdminLogs);
            this.panel1.Controls.Add(this.btnMenuDepartmentManagement);
            this.panel1.Controls.Add(this.btnMenuScheduling);
            this.panel1.Controls.Add(this.btnMenuEmployeeManagement);
            this.panel1.Controls.Add(this.btnMenuStockManagement);
            this.panel1.Controls.Add(this.btnMenuPersonalDetails);
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 532);
            this.panel1.TabIndex = 66;
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
            this.btnMenuRoleManagement.Location = new System.Drawing.Point(0, 334);
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
            this.btnMenuStock.Location = new System.Drawing.Point(0, 223);
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
            this.btnMenuAdminLogs.Location = new System.Drawing.Point(0, 452);
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
            this.btnMenuDepartmentManagement.Location = new System.Drawing.Point(0, 393);
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
            // btnMenuScheduling
            // 
            this.btnMenuScheduling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuScheduling.FlatAppearance.BorderSize = 0;
            this.btnMenuScheduling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuScheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuScheduling.ForeColor = System.Drawing.Color.White;
            this.btnMenuScheduling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuScheduling.Location = new System.Drawing.Point(0, 164);
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
            this.btnMenuEmployeeManagement.Location = new System.Drawing.Point(0, 110);
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
            this.btnMenuStockManagement.Location = new System.Drawing.Point(0, 57);
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
            this.btnMenuPersonalDetails.Location = new System.Drawing.Point(0, 0);
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
            this.btnMenuSchedule.Location = new System.Drawing.Point(0, 282);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1502, 63);
            this.panel2.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 66);
            this.panel3.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Location = new System.Drawing.Point(0, 698);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 74);
            this.panel4.TabIndex = 70;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(334, 100);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1140, 66);
            this.panel6.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scheduling";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.dtBegin);
            this.panel5.Controls.Add(this.dtEnd);
            this.panel5.Controls.Add(this.numEmployeesAShift);
            this.panel5.Controls.Add(this.btnGenerateSchedule);
            this.panel5.Location = new System.Drawing.Point(334, 205);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 256);
            this.panel5.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 66;
            this.label3.Text = "People:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 63;
            this.label2.Text = "Until:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel8.Controls.Add(this.cbShifts);
            this.panel8.Controls.Add(this.btnRemoveSchedule);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.btnAddSchedule);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.dtAddRemove);
            this.panel8.Location = new System.Drawing.Point(334, 500);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(373, 272);
            this.panel8.TabIndex = 71;
            // 
            // cbShifts
            // 
            this.cbShifts.FormattingEnabled = true;
            this.cbShifts.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbShifts.Location = new System.Drawing.Point(155, 76);
            this.cbShifts.Name = "cbShifts";
            this.cbShifts.Size = new System.Drawing.Size(184, 24);
            this.cbShifts.TabIndex = 73;
            // 
            // btnRemoveSchedule
            // 
            this.btnRemoveSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnRemoveSchedule.FlatAppearance.BorderSize = 0;
            this.btnRemoveSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemoveSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemoveSchedule.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSchedule.Location = new System.Drawing.Point(36, 186);
            this.btnRemoveSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveSchedule.Name = "btnRemoveSchedule";
            this.btnRemoveSchedule.Size = new System.Drawing.Size(303, 55);
            this.btnRemoveSchedule.TabIndex = 72;
            this.btnRemoveSchedule.Text = "Remove Schedule";
            this.btnRemoveSchedule.UseVisualStyleBackColor = false;
            this.btnRemoveSchedule.Click += new System.EventHandler(this.btnRemoveSchedule_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 71;
            this.label5.Text = "Shift:";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddSchedule.FlatAppearance.BorderSize = 0;
            this.btnAddSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
            this.btnAddSchedule.Location = new System.Drawing.Point(36, 126);
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(303, 55);
            this.btnAddSchedule.TabIndex = 68;
            this.btnAddSchedule.Text = "Add Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = false;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 32);
            this.label6.TabIndex = 69;
            this.label6.Text = "Date:";
            // 
            // dtAddRemove
            // 
            this.dtAddRemove.CustomFormat = "dd-MM-yyyy";
            this.dtAddRemove.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAddRemove.Location = new System.Drawing.Point(155, 33);
            this.dtAddRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtAddRemove.MinDate = new System.DateTime(2021, 1, 15, 0, 0, 0, 0);
            this.dtAddRemove.Name = "dtAddRemove";
            this.dtAddRemove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtAddRemove.Size = new System.Drawing.Size(184, 22);
            this.dtAddRemove.TabIndex = 67;
            // 
            // dataViewSchedules
            // 
            this.dataViewSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewSchedules.Location = new System.Drawing.Point(737, 205);
            this.dataViewSchedules.Margin = new System.Windows.Forms.Padding(0);
            this.dataViewSchedules.Name = "dataViewSchedules";
            this.dataViewSchedules.RowHeadersWidth = 51;
            this.dataViewSchedules.RowTemplate.Height = 24;
            this.dataViewSchedules.Size = new System.Drawing.Size(737, 256);
            this.dataViewSchedules.TabIndex = 67;
            // 
            // dataViewEmployees
            // 
            this.dataViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewEmployees.Location = new System.Drawing.Point(737, 500);
            this.dataViewEmployees.Name = "dataViewEmployees";
            this.dataViewEmployees.ReadOnly = true;
            this.dataViewEmployees.RowHeadersWidth = 51;
            this.dataViewEmployees.RowTemplate.Height = 24;
            this.dataViewEmployees.Size = new System.Drawing.Size(737, 272);
            this.dataViewEmployees.TabIndex = 72;
            this.dataViewEmployees.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataViewEmployees_CellMouseClick);
            // 
            // EmployeeScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.dataViewEmployees);
            this.Controls.Add(this.dataViewSchedules);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeScheduling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numEmployeesAShift)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.NumericUpDown numEmployeesAShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateSchedule;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuStockManagement;
        private System.Windows.Forms.Button btnMenuPersonalDetails;
        private System.Windows.Forms.Button btnMenuSchedule;
        private System.Windows.Forms.Button btnMenuStock;
        private System.Windows.Forms.Button btnMenuEmployeeManagement;
        private System.Windows.Forms.Button btnMenuScheduling;
        private System.Windows.Forms.Button btnMenuRoleManagement;
        private System.Windows.Forms.Button btnMenuDepartmentManagement;
        private System.Windows.Forms.Button btnMenuAdminLogs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataViewSchedules;
        private System.Windows.Forms.DataGridView dataViewEmployees;
        private System.Windows.Forms.ComboBox cbShifts;
        private System.Windows.Forms.Button btnRemoveSchedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtAddRemove;
    }
}
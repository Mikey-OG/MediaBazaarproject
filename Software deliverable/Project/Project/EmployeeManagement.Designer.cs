namespace Project
{
    partial class Employee_Management
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnSearchForEmployee = new System.Windows.Forms.Button();
            this.tbUserFirstName = new System.Windows.Forms.TextBox();
            this.cmbRoleName = new System.Windows.Forms.ComboBox();
            this.dtDismissalDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.dtDateOfHire = new System.Windows.Forms.DateTimePicker();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewDismissedEmployees = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDismissEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMenuStockManagement = new System.Windows.Forms.Button();
            this.btnMenuPersonalDetails = new System.Windows.Forms.Button();
            this.btnMenuAdminLogs = new System.Windows.Forms.Button();
            this.btnMenuDepartmentManagement = new System.Windows.Forms.Button();
            this.btnMenuStock = new System.Windows.Forms.Button();
            this.btnMenuRoleManagement = new System.Windows.Forms.Button();
            this.btnMenuSchedule = new System.Windows.Forms.Button();
            this.btnMenuScheduling = new System.Windows.Forms.Button();
            this.btnMenuEmployeeManagement = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(675, 207);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.ShowEditingIcon = false;
            this.dgvEmployees.Size = new System.Drawing.Size(1027, 355);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridEmployees_CellMouseClick);
            // 
            // btnSearchForEmployee
            // 
            this.btnSearchForEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSearchForEmployee.FlatAppearance.BorderSize = 0;
            this.btnSearchForEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearchForEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchForEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSearchForEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchForEmployee.Location = new System.Drawing.Point(19, 52);
            this.btnSearchForEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchForEmployee.Name = "btnSearchForEmployee";
            this.btnSearchForEmployee.Size = new System.Drawing.Size(257, 40);
            this.btnSearchForEmployee.TabIndex = 8;
            this.btnSearchForEmployee.Text = "Search Employee";
            this.btnSearchForEmployee.UseVisualStyleBackColor = false;
            this.btnSearchForEmployee.Click += new System.EventHandler(this.btnSearchForEmployee_Click);
            // 
            // tbUserFirstName
            // 
            this.tbUserFirstName.Location = new System.Drawing.Point(137, 16);
            this.tbUserFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserFirstName.Multiline = true;
            this.tbUserFirstName.Name = "tbUserFirstName";
            this.tbUserFirstName.Size = new System.Drawing.Size(161, 25);
            this.tbUserFirstName.TabIndex = 47;
            // 
            // cmbRoleName
            // 
            this.cmbRoleName.FormattingEnabled = true;
            this.cmbRoleName.Location = new System.Drawing.Point(755, 43);
            this.cmbRoleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoleName.Name = "cmbRoleName";
            this.cmbRoleName.Size = new System.Drawing.Size(236, 24);
            this.cmbRoleName.TabIndex = 46;
            // 
            // dtDismissalDate
            // 
            this.dtDismissalDate.CustomFormat = "dd-MM-yyyy";
            this.dtDismissalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDismissalDate.Location = new System.Drawing.Point(755, 98);
            this.dtDismissalDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDismissalDate.Name = "dtDismissalDate";
            this.dtDismissalDate.Size = new System.Drawing.Size(236, 22);
            this.dtDismissalDate.TabIndex = 44;
            // 
            // cmbDepartmentName
            // 
            this.cmbDepartmentName.FormattingEnabled = true;
            this.cmbDepartmentName.Location = new System.Drawing.Point(755, 15);
            this.cmbDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartmentName.Name = "cmbDepartmentName";
            this.cmbDepartmentName.Size = new System.Drawing.Size(236, 24);
            this.cmbDepartmentName.TabIndex = 40;
            // 
            // dtDateOfHire
            // 
            this.dtDateOfHire.CustomFormat = "dd-MM-yyyy";
            this.dtDateOfHire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateOfHire.Location = new System.Drawing.Point(755, 72);
            this.dtDateOfHire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDateOfHire.Name = "dtDateOfHire";
            this.dtDateOfHire.Size = new System.Drawing.Size(236, 22);
            this.dtDateOfHire.TabIndex = 38;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(705, 173);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdress.Multiline = true;
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(286, 70);
            this.tbAdress.TabIndex = 31;
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "dd-MM-yyyy";
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(179, 145);
            this.dtDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(225, 22);
            this.dtDOB.TabIndex = 36;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(755, 147);
            this.tbZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbZipCode.Multiline = true;
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(236, 22);
            this.tbZipCode.TabIndex = 29;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(755, 123);
            this.tbCity.Margin = new System.Windows.Forms.Padding(5);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(236, 22);
            this.tbCity.TabIndex = 23;
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(179, 197);
            this.tbNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(225, 22);
            this.tbNationality.TabIndex = 21;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(179, 171);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(225, 22);
            this.tbPhoneNumber.TabIndex = 19;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(179, 223);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSalary.Multiline = true;
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(225, 25);
            this.tbSalary.TabIndex = 29;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(179, 119);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(225, 22);
            this.tbLastName.TabIndex = 15;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(179, 93);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(225, 22);
            this.tbFirstName.TabIndex = 13;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(179, 67);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(225, 22);
            this.tbPassword.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(179, 41);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(225, 22);
            this.tbEmail.TabIndex = 9;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(179, 15);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(225, 22);
            this.tbUserName.TabIndex = 7;
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
            this.btnRefresh.Location = new System.Drawing.Point(19, 145);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(257, 63);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewDismissedEmployees
            // 
            this.btnViewDismissedEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnViewDismissedEmployees.FlatAppearance.BorderSize = 0;
            this.btnViewDismissedEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewDismissedEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDismissedEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDismissedEmployees.ForeColor = System.Drawing.Color.White;
            this.btnViewDismissedEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDismissedEmployees.Location = new System.Drawing.Point(19, 80);
            this.btnViewDismissedEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDismissedEmployees.Name = "btnViewDismissedEmployees";
            this.btnViewDismissedEmployees.Size = new System.Drawing.Size(257, 61);
            this.btnViewDismissedEmployees.TabIndex = 6;
            this.btnViewDismissedEmployees.Text = "Show Dismissed Employees";
            this.btnViewDismissedEmployees.UseVisualStyleBackColor = false;
            this.btnViewDismissedEmployees.Click += new System.EventHandler(this.btnViewDismissedEmployees_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnClearFields.FlatAppearance.BorderSize = 0;
            this.btnClearFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.Location = new System.Drawing.Point(19, 19);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(257, 57);
            this.btnClearFields.TabIndex = 3;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDismissEmployee
            // 
            this.btnDismissEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnDismissEmployee.FlatAppearance.BorderSize = 0;
            this.btnDismissEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDismissEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDismissEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDismissEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDismissEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDismissEmployee.Location = new System.Drawing.Point(19, 162);
            this.btnDismissEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDismissEmployee.Name = "btnDismissEmployee";
            this.btnDismissEmployee.Size = new System.Drawing.Size(257, 74);
            this.btnDismissEmployee.TabIndex = 2;
            this.btnDismissEmployee.Text = "Dismiss Employee";
            this.btnDismissEmployee.UseVisualStyleBackColor = false;
            this.btnDismissEmployee.Click += new System.EventHandler(this.btnDismissEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnUpdateEmployee.FlatAppearance.BorderSize = 0;
            this.btnUpdateEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(19, 87);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(257, 71);
            this.btnUpdateEmployee.TabIndex = 1;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(19, 15);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(257, 68);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1702, 63);
            this.panel2.TabIndex = 68;
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
            this.btnLogOut.Location = new System.Drawing.Point(1554, 0);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(148, 63);
            this.btnLogOut.TabIndex = 48;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Location = new System.Drawing.Point(0, 771);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 72);
            this.panel4.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 66);
            this.panel1.TabIndex = 72;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.btnMenuStockManagement);
            this.panel5.Controls.Add(this.btnMenuPersonalDetails);
            this.panel5.Controls.Add(this.btnMenuAdminLogs);
            this.panel5.Controls.Add(this.btnMenuDepartmentManagement);
            this.panel5.Controls.Add(this.btnMenuStock);
            this.panel5.Controls.Add(this.btnMenuRoleManagement);
            this.panel5.Controls.Add(this.btnMenuSchedule);
            this.panel5.Controls.Add(this.btnMenuScheduling);
            this.panel5.Controls.Add(this.btnMenuEmployeeManagement);
            this.panel5.Location = new System.Drawing.Point(0, 168);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 603);
            this.panel5.TabIndex = 71;
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
            this.btnMenuStockManagement.Location = new System.Drawing.Point(0, 544);
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
            this.btnMenuPersonalDetails.Location = new System.Drawing.Point(0, 474);
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
            // btnMenuAdminLogs
            // 
            this.btnMenuAdminLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuAdminLogs.FlatAppearance.BorderSize = 0;
            this.btnMenuAdminLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuAdminLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAdminLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAdminLogs.ForeColor = System.Drawing.Color.White;
            this.btnMenuAdminLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAdminLogs.Location = new System.Drawing.Point(0, 262);
            this.btnMenuAdminLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuAdminLogs.Name = "btnMenuAdminLogs";
            this.btnMenuAdminLogs.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuAdminLogs.Size = new System.Drawing.Size(295, 43);
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
            this.btnMenuDepartmentManagement.Click += new System.EventHandler(this.btnMenuDepartmentManagement_Click);
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
            this.btnMenuStock.Location = new System.Drawing.Point(0, 324);
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
            // btnMenuRoleManagement
            // 
            this.btnMenuRoleManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuRoleManagement.FlatAppearance.BorderSize = 0;
            this.btnMenuRoleManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuRoleManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRoleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRoleManagement.ForeColor = System.Drawing.Color.White;
            this.btnMenuRoleManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRoleManagement.Location = new System.Drawing.Point(0, 183);
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
            // btnMenuSchedule
            // 
            this.btnMenuSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSchedule.FlatAppearance.BorderSize = 0;
            this.btnMenuSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMenuSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSchedule.ForeColor = System.Drawing.Color.White;
            this.btnMenuSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSchedule.Location = new System.Drawing.Point(0, 398);
            this.btnMenuSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuSchedule.Name = "btnMenuSchedule";
            this.btnMenuSchedule.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuSchedule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenuSchedule.Size = new System.Drawing.Size(295, 59);
            this.btnMenuSchedule.TabIndex = 50;
            this.btnMenuSchedule.Text = "Shop Personnel Schedule";
            this.btnMenuSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSchedule.UseVisualStyleBackColor = true;
            this.btnMenuSchedule.Click += new System.EventHandler(this.btnMenuSchedule_Click);
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
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(334, 102);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1368, 66);
            this.panel6.TabIndex = 74;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(446, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(552, 55);
            this.label14.TabIndex = 0;
            this.label14.Text = "Employee Management";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel7.Controls.Add(this.btnAddEmployee);
            this.panel7.Controls.Add(this.btnDismissEmployee);
            this.panel7.Controls.Add(this.btnUpdateEmployee);
            this.panel7.Location = new System.Drawing.Point(334, 586);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(297, 257);
            this.panel7.TabIndex = 75;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.btnClearFields);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnViewDismissedEmployees);
            this.panel3.Location = new System.Drawing.Point(334, 332);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 230);
            this.panel3.TabIndex = 76;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.tbUserFirstName);
            this.panel8.Controls.Add(this.btnSearchForEmployee);
            this.panel8.Location = new System.Drawing.Point(334, 207);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(321, 105);
            this.panel8.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(14, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 24);
            this.label18.TabIndex = 78;
            this.label18.Text = "First Name:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel10.Controls.Add(this.label34);
            this.panel10.Controls.Add(this.label33);
            this.panel10.Controls.Add(this.label32);
            this.panel10.Controls.Add(this.cmbRoleName);
            this.panel10.Controls.Add(this.label31);
            this.panel10.Controls.Add(this.dtDismissalDate);
            this.panel10.Controls.Add(this.label30);
            this.panel10.Controls.Add(this.label29);
            this.panel10.Controls.Add(this.label28);
            this.panel10.Controls.Add(this.label27);
            this.panel10.Controls.Add(this.label26);
            this.panel10.Controls.Add(this.label25);
            this.panel10.Controls.Add(this.dtDateOfHire);
            this.panel10.Controls.Add(this.label24);
            this.panel10.Controls.Add(this.label23);
            this.panel10.Controls.Add(this.label22);
            this.panel10.Controls.Add(this.label21);
            this.panel10.Controls.Add(this.cmbDepartmentName);
            this.panel10.Controls.Add(this.tbLastName);
            this.panel10.Controls.Add(this.label20);
            this.panel10.Controls.Add(this.tbSalary);
            this.panel10.Controls.Add(this.label19);
            this.panel10.Controls.Add(this.tbUserName);
            this.panel10.Controls.Add(this.tbEmail);
            this.panel10.Controls.Add(this.tbPassword);
            this.panel10.Controls.Add(this.tbFirstName);
            this.panel10.Controls.Add(this.dtDOB);
            this.panel10.Controls.Add(this.tbAdress);
            this.panel10.Controls.Add(this.tbPhoneNumber);
            this.panel10.Controls.Add(this.tbNationality);
            this.panel10.Controls.Add(this.tbCity);
            this.panel10.Controls.Add(this.tbZipCode);
            this.panel10.Location = new System.Drawing.Point(675, 586);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1027, 257);
            this.panel10.TabIndex = 79;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(583, 95);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(145, 20);
            this.label34.TabIndex = 93;
            this.label34.Text = "Dismissal Date:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(583, 69);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(97, 20);
            this.label33.TabIndex = 92;
            this.label33.Text = "Hire Date:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(583, 43);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 20);
            this.label32.TabIndex = 91;
            this.label32.Text = "Role:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(583, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(113, 20);
            this.label31.TabIndex = 90;
            this.label31.Text = "Department:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(21, 228);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 20);
            this.label30.TabIndex = 89;
            this.label30.Text = "Salary:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(583, 185);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 20);
            this.label29.TabIndex = 88;
            this.label29.Text = "Adress:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(583, 147);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(89, 20);
            this.label28.TabIndex = 87;
            this.label28.Text = "Zip Code:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(583, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 20);
            this.label27.TabIndex = 86;
            this.label27.Text = "City:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(21, 197);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 20);
            this.label26.TabIndex = 85;
            this.label26.Text = "Nationality:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(21, 171);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(141, 20);
            this.label25.TabIndex = 84;
            this.label25.Text = "Mobile Number:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(21, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 20);
            this.label24.TabIndex = 83;
            this.label24.Text = "Birth Date:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(21, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 20);
            this.label23.TabIndex = 82;
            this.label23.Text = "Last Name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(21, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 20);
            this.label22.TabIndex = 81;
            this.label22.Text = "First Name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(21, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 20);
            this.label21.TabIndex = 80;
            this.label21.Text = "Password:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(21, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 20);
            this.label20.TabIndex = 79;
            this.label20.Text = "Email:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(21, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 20);
            this.label19.TabIndex = 78;
            this.label19.Text = "User Name:";
            // 
            // Employee_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1718, 858);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employee_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.DateTimePicker dtDateOfHire;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDismissEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cmbDepartmentName;
        private System.Windows.Forms.DateTimePicker dtDismissalDate;
        private System.Windows.Forms.Button btnViewDismissedEmployees;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.ComboBox cmbRoleName;
        private System.Windows.Forms.Button btnSearchForEmployee;
        private System.Windows.Forms.TextBox tbUserFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}
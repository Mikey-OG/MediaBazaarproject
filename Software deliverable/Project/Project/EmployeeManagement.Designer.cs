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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Management));
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchForEmployee = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tbUserFirstName = new System.Windows.Forms.TextBox();
            this.cmbRoleName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtDismissalDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.dtDateOfHire = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenAdminLog = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewDismissedEmployees = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDismissEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.RowResetbtn = new System.Windows.Forms.Button();
            this.Seemorebtn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbSecureText = new System.Windows.Forms.Label();
            this.lbAccountSecurity = new System.Windows.Forms.Label();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 52);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.ShowEditingIcon = false;
            this.dgvEmployees.Size = new System.Drawing.Size(1117, 466);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridEmployees_CellMouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchForEmployee);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.tbUserFirstName);
            this.groupBox3.Controls.Add(this.cmbRoleName);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.dtDismissalDate);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmbDepartmentName);
            this.groupBox3.Controls.Add(this.dtDateOfHire);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbAdress);
            this.groupBox3.Controls.Add(this.dtDOB);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbZipCode);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbCity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbNationality);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbPhoneNumber);
            this.groupBox3.Controls.Add(this.tbSalary);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbLastName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbFirstName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbPassword);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbUserName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1147, 50);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(499, 660);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Information";
            // 
            // btnSearchForEmployee
            // 
            this.btnSearchForEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearchForEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchForEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchForEmployee.Image")));
            this.btnSearchForEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchForEmployee.Location = new System.Drawing.Point(267, 593);
            this.btnSearchForEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchForEmployee.Name = "btnSearchForEmployee";
            this.btnSearchForEmployee.Size = new System.Drawing.Size(216, 39);
            this.btnSearchForEmployee.TabIndex = 8;
            this.btnSearchForEmployee.Text = "Search for Employee";
            this.btnSearchForEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchForEmployee.UseVisualStyleBackColor = true;
            this.btnSearchForEmployee.Click += new System.EventHandler(this.btnSearchForEmployee_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(253, 539);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 20);
            this.label18.TabIndex = 48;
            this.label18.Text = "Search for FirstName:";
            // 
            // tbUserFirstName
            // 
            this.tbUserFirstName.Location = new System.Drawing.Point(258, 560);
            this.tbUserFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserFirstName.Multiline = true;
            this.tbUserFirstName.Name = "tbUserFirstName";
            this.tbUserFirstName.Size = new System.Drawing.Size(224, 25);
            this.tbUserFirstName.TabIndex = 47;
            // 
            // cmbRoleName
            // 
            this.cmbRoleName.FormattingEnabled = true;
            this.cmbRoleName.Location = new System.Drawing.Point(257, 370);
            this.cmbRoleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoleName.Name = "cmbRoleName";
            this.cmbRoleName.Size = new System.Drawing.Size(224, 24);
            this.cmbRoleName.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(253, 348);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 20);
            this.label17.TabIndex = 45;
            this.label17.Text = "RoleName";
            // 
            // dtDismissalDate
            // 
            this.dtDismissalDate.CustomFormat = "dd-MM-yyyy";
            this.dtDismissalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDismissalDate.Location = new System.Drawing.Point(259, 495);
            this.dtDismissalDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDismissalDate.Name = "dtDismissalDate";
            this.dtDismissalDate.Size = new System.Drawing.Size(223, 22);
            this.dtDismissalDate.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(255, 475);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Dismissal Date";
            // 
            // cmbDepartmentName
            // 
            this.cmbDepartmentName.FormattingEnabled = true;
            this.cmbDepartmentName.Location = new System.Drawing.Point(257, 306);
            this.cmbDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartmentName.Name = "cmbDepartmentName";
            this.cmbDepartmentName.Size = new System.Drawing.Size(224, 24);
            this.cmbDepartmentName.TabIndex = 40;
            // 
            // dtDateOfHire
            // 
            this.dtDateOfHire.CustomFormat = "dd-MM-yyyy";
            this.dtDateOfHire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateOfHire.Location = new System.Drawing.Point(259, 431);
            this.dtDateOfHire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDateOfHire.Name = "dtDateOfHire";
            this.dtDateOfHire.Size = new System.Drawing.Size(223, 22);
            this.dtDateOfHire.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(253, 414);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "Date of Hire";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(257, 172);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(224, 22);
            this.tbAdress.TabIndex = 31;
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "dd-MM-yyyy";
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(11, 368);
            this.dtDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(224, 22);
            this.dtDOB.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(253, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Adress:";
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(257, 112);
            this.tbZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(224, 22);
            this.tbZipCode.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Zip Code:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(257, 50);
            this.tbCity.Margin = new System.Windows.Forms.Padding(5);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(224, 22);
            this.tbCity.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "City:";
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(11, 498);
            this.tbNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(224, 22);
            this.tbNationality.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nationality:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Department Name:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(11, 431);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(224, 22);
            this.tbPhoneNumber.TabIndex = 19;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(259, 234);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(224, 22);
            this.tbSalary.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phone Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(253, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date Of Birth:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(11, 306);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(224, 22);
            this.tbLastName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(11, 234);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(224, 22);
            this.tbFirstName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "First Name:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(11, 172);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(224, 22);
            this.tbPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(11, 112);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(224, 22);
            this.tbEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(11, 50);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(224, 22);
            this.tbUserName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportToPDF);
            this.groupBox1.Controls.Add(this.btnOpenAdminLog);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnViewDismissedEmployees);
            this.groupBox1.Controls.Add(this.btnReturnMenu);
            this.groupBox1.Controls.Add(this.btnClearFields);
            this.groupBox1.Controls.Add(this.btnDismissEmployee);
            this.groupBox1.Controls.Add(this.btnUpdateEmployee);
            this.groupBox1.Controls.Add(this.btnAddEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 526);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1072, 146);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // btnOpenAdminLog
            // 
            this.btnOpenAdminLog.Location = new System.Drawing.Point(1153, 106);
            this.btnOpenAdminLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenAdminLog.Name = "btnOpenAdminLog";
            this.btnOpenAdminLog.Size = new System.Drawing.Size(253, 57);
            this.btnOpenAdminLog.TabIndex = 8;
            this.btnOpenAdminLog.Text = "Open Admin Log";
            this.btnOpenAdminLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenAdminLog.UseVisualStyleBackColor = true;
            this.btnOpenAdminLog.Click += new System.EventHandler(this.btnOpenAdminLog_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(304, 82);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 50);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewDismissedEmployees
            // 
            this.btnViewDismissedEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDismissedEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewDismissedEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDismissedEmployees.Image")));
            this.btnViewDismissedEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDismissedEmployees.Location = new System.Drawing.Point(5, 82);
            this.btnViewDismissedEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDismissedEmployees.Name = "btnViewDismissedEmployees";
            this.btnViewDismissedEmployees.Size = new System.Drawing.Size(293, 50);
            this.btnViewDismissedEmployees.TabIndex = 6;
            this.btnViewDismissedEmployees.Text = "View Dismissed Employees";
            this.btnViewDismissedEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewDismissedEmployees.UseVisualStyleBackColor = true;
            this.btnViewDismissedEmployees.Click += new System.EventHandler(this.btnViewDismissedEmployees_Click);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMenu.Image")));
            this.btnReturnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnMenu.Location = new System.Drawing.Point(883, 22);
            this.btnReturnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(172, 50);
            this.btnReturnMenu.TabIndex = 4;
            this.btnReturnMenu.Text = "Return Menu";
            this.btnReturnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFields.Image")));
            this.btnClearFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.Location = new System.Drawing.Point(683, 21);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(195, 50);
            this.btnClearFields.TabIndex = 3;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDismissEmployee
            // 
            this.btnDismissEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDismissEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDismissEmployee.Image")));
            this.btnDismissEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDismissEmployee.Location = new System.Drawing.Point(453, 22);
            this.btnDismissEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDismissEmployee.Name = "btnDismissEmployee";
            this.btnDismissEmployee.Size = new System.Drawing.Size(223, 50);
            this.btnDismissEmployee.TabIndex = 2;
            this.btnDismissEmployee.Text = "Dismiss Employee";
            this.btnDismissEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDismissEmployee.UseVisualStyleBackColor = true;
            this.btnDismissEmployee.Click += new System.EventHandler(this.btnDismissEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateEmployee.Image")));
            this.btnUpdateEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(223, 21);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(224, 50);
            this.btnUpdateEmployee.TabIndex = 1;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(5, 22);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(211, 50);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(1529, 11);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 37);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // RowResetbtn
            // 
            this.RowResetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RowResetbtn.Location = new System.Drawing.Point(145, 678);
            this.RowResetbtn.Margin = new System.Windows.Forms.Padding(5);
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
            this.Seemorebtn.Location = new System.Drawing.Point(8, 677);
            this.Seemorebtn.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnLogOut.Location = new System.Drawing.Point(1529, 714);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(117, 38);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbSecureText
            // 
            this.lbSecureText.AutoSize = true;
            this.lbSecureText.Location = new System.Drawing.Point(9, 23);
            this.lbSecureText.Name = "lbSecureText";
            this.lbSecureText.Size = new System.Drawing.Size(108, 17);
            this.lbSecureText.TabIndex = 48;
            this.lbSecureText.Text = "Account Secure";
            // 
            // lbAccountSecurity
            // 
            this.lbAccountSecurity.AutoSize = true;
            this.lbAccountSecurity.Location = new System.Drawing.Point(115, 23);
            this.lbAccountSecurity.Name = "lbAccountSecurity";
            this.lbAccountSecurity.Size = new System.Drawing.Size(20, 17);
            this.lbAccountSecurity.TabIndex = 49;
            this.lbAccountSecurity.Text = "...";
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportToPDF.Location = new System.Drawing.Point(453, 82);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExportToPDF.Size = new System.Drawing.Size(177, 50);
            this.btnExportToPDF.TabIndex = 9;
            this.btnExportToPDF.Text = "Export To PDF";
            this.btnExportToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // Employee_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 756);
            this.Controls.Add(this.lbAccountSecurity);
            this.Controls.Add(this.lbSecureText);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.RowResetbtn);
            this.Controls.Add(this.Seemorebtn);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvEmployees);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employee_Management";
            this.Text = "Employee_Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtDateOfHire;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDismissEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cmbDepartmentName;
        private System.Windows.Forms.DateTimePicker dtDismissalDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnViewDismissedEmployees;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHelp;
        public System.Windows.Forms.ComboBox cmbRoleName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSearchForEmployee;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbUserFirstName;
        private System.Windows.Forms.Button RowResetbtn;
        private System.Windows.Forms.Button Seemorebtn;

        private System.Windows.Forms.Button btnOpenAdminLog;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbSecureText;
        private System.Windows.Forms.Label lbAccountSecurity;
        private System.Windows.Forms.Button btnExportToPDF;
    }
}
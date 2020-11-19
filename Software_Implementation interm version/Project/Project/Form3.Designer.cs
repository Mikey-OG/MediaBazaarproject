namespace Project
{
    partial class EmployeeManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.tbUntil = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.tbRoleID = new System.Windows.Forms.TextBox();
            this.tbDepartmentID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmployeeScheduleGridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllEmployeeGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeScheduleGridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(375, 331);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(95, 32);
            this.btnClearFields.TabIndex = 16;
            this.btnClearFields.Text = "Clear All Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtDate);
            this.groupBox4.Controls.Add(this.tbUntil);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.tbFrom);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnAddSchedule);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(639, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(158, 158);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Schedule";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dd-MM-yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(4, 29);
            this.dtDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtDate.MinDate = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(151, 20);
            this.dtDate.TabIndex = 37;
            this.dtDate.Value = new System.DateTime(2020, 9, 25, 0, 0, 0, 0);
            // 
            // tbUntil
            // 
            this.tbUntil.Location = new System.Drawing.Point(4, 104);
            this.tbUntil.Margin = new System.Windows.Forms.Padding(2);
            this.tbUntil.Name = "tbUntil";
            this.tbUntil.Size = new System.Drawing.Size(151, 20);
            this.tbUntil.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 88);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Until:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(4, 67);
            this.tbFrom.Margin = new System.Windows.Forms.Padding(2);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(151, 20);
            this.tbFrom.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 51);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "From:";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(4, 127);
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(150, 29);
            this.btnAddSchedule.TabIndex = 8;
            this.btnAddSchedule.Text = "Add Schedule To Employee";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Date:";
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(375, 368);
            this.AddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(95, 54);
            this.AddEmployee.TabIndex = 14;
            this.AddEmployee.Text = "Add Employee\r\n";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtDOB);
            this.groupBox3.Controls.Add(this.tbRoleID);
            this.groupBox3.Controls.Add(this.tbDepartmentID);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbSalary);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbAdress);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbZipCode);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbCity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbNationality);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbPhoneNumber);
            this.groupBox3.Controls.Add(this.label7);
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
            this.groupBox3.Location = new System.Drawing.Point(475, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(159, 536);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add / Update Employee";
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "dd-MM-yyyy";
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(4, 214);
            this.dtDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(151, 20);
            this.dtDOB.TabIndex = 36;
            // 
            // tbRoleID
            // 
            this.tbRoleID.Location = new System.Drawing.Point(4, 508);
            this.tbRoleID.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoleID.Name = "tbRoleID";
            this.tbRoleID.Size = new System.Drawing.Size(151, 20);
            this.tbRoleID.TabIndex = 35;
            // 
            // tbDepartmentID
            // 
            this.tbDepartmentID.Location = new System.Drawing.Point(4, 470);
            this.tbDepartmentID.Margin = new System.Windows.Forms.Padding(2);
            this.tbDepartmentID.Name = "tbDepartmentID";
            this.tbDepartmentID.Size = new System.Drawing.Size(151, 20);
            this.tbDepartmentID.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 492);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "RoleID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 453);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Department ID:";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(4, 433);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(2);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(151, 20);
            this.tbSalary.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 417);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Salary:";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(4, 396);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(151, 20);
            this.tbAdress.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 380);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Adress:";
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(4, 360);
            this.tbZipCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(151, 20);
            this.tbZipCode.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 344);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Zip Code:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(4, 323);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(151, 20);
            this.tbCity.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 307);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "City:";
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(4, 287);
            this.tbNationality.Margin = new System.Windows.Forms.Padding(2);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(151, 20);
            this.tbNationality.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nationality:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(4, 250);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(151, 20);
            this.tbPhoneNumber.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date Of Birth:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(4, 177);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(151, 20);
            this.tbLastName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(4, 141);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(151, 20);
            this.tbFirstName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "First Name:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(4, 104);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(151, 20);
            this.tbPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(4, 67);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(151, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(4, 31);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(151, 20);
            this.tbUserName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 486);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "Dismissal Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(375, 428);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 54);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Employee Information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmployeeScheduleGridview);
            this.groupBox2.Location = new System.Drawing.Point(8, 331);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(363, 216);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule Employee";
            // 
            // EmployeeScheduleGridview
            // 
            this.EmployeeScheduleGridview.AllowUserToAddRows = false;
            this.EmployeeScheduleGridview.AllowUserToDeleteRows = false;
            this.EmployeeScheduleGridview.AllowUserToResizeColumns = false;
            this.EmployeeScheduleGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeScheduleGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.EmployeeScheduleGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeScheduleGridview.DefaultCellStyle = dataGridViewCellStyle7;
            this.EmployeeScheduleGridview.Location = new System.Drawing.Point(4, 17);
            this.EmployeeScheduleGridview.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeScheduleGridview.Name = "EmployeeScheduleGridview";
            this.EmployeeScheduleGridview.ReadOnly = true;
            this.EmployeeScheduleGridview.RowHeadersWidth = 51;
            this.EmployeeScheduleGridview.RowTemplate.Height = 24;
            this.EmployeeScheduleGridview.Size = new System.Drawing.Size(354, 190);
            this.EmployeeScheduleGridview.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllEmployeeGridView);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(463, 315);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Employees";
            // 
            // AllEmployeeGridView
            // 
            this.AllEmployeeGridView.AllowUserToAddRows = false;
            this.AllEmployeeGridView.AllowUserToDeleteRows = false;
            this.AllEmployeeGridView.AllowUserToResizeColumns = false;
            this.AllEmployeeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllEmployeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.AllEmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllEmployeeGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.AllEmployeeGridView.Location = new System.Drawing.Point(4, 17);
            this.AllEmployeeGridView.Margin = new System.Windows.Forms.Padding(2);
            this.AllEmployeeGridView.Name = "AllEmployeeGridView";
            this.AllEmployeeGridView.ReadOnly = true;
            this.AllEmployeeGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AllEmployeeGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.AllEmployeeGridView.RowTemplate.Height = 24;
            this.AllEmployeeGridView.Size = new System.Drawing.Size(454, 293);
            this.AllEmployeeGridView.TabIndex = 0;
            this.AllEmployeeGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllEmployeeGridView_CellMouseClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeManagementForm";
            this.Text = "Form3";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeScheduleGridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox tbUntil;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TextBox tbRoleID;
        private System.Windows.Forms.TextBox tbDepartmentID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView EmployeeScheduleGridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView AllEmployeeGridView;
        private System.Windows.Forms.Button button1;
    }
}
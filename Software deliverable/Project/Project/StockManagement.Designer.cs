namespace Project
{
    partial class StockManagement
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
            this.DecreaseBtn = new System.Windows.Forms.Button();
            this.IncreaseBtn = new System.Windows.Forms.Button();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeletRowBtn = new System.Windows.Forms.Button();
            this.NewRowBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnLowStock = new System.Windows.Forms.Button();
            this.Seemorebtn = new System.Windows.Forms.Button();
            this.RowResetbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuStockManagement = new System.Windows.Forms.Button();
            this.btnMenuPersonalDetails = new System.Windows.Forms.Button();
            this.btnMenuRoleManagement = new System.Windows.Forms.Button();
            this.btnMenuStock = new System.Windows.Forms.Button();
            this.btnMenuAdminLogs = new System.Windows.Forms.Button();
            this.btnMenuDepartmentManagement = new System.Windows.Forms.Button();
            this.btnMenuScheduling = new System.Windows.Forms.Button();
            this.btnMenuEmployeeManagement = new System.Windows.Forms.Button();
            this.btnMenuSchedule = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProductDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbProductMinQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.DecreaseBtn.FlatAppearance.BorderSize = 0;
            this.DecreaseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DecreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DecreaseBtn.ForeColor = System.Drawing.Color.White;
            this.DecreaseBtn.Location = new System.Drawing.Point(20, 71);
            this.DecreaseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(147, 29);
            this.DecreaseBtn.TabIndex = 36;
            this.DecreaseBtn.Text = "Decrease";
            this.DecreaseBtn.UseVisualStyleBackColor = false;
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click_1);
            // 
            // IncreaseBtn
            // 
            this.IncreaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.IncreaseBtn.FlatAppearance.BorderSize = 0;
            this.IncreaseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IncreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IncreaseBtn.ForeColor = System.Drawing.Color.White;
            this.IncreaseBtn.Location = new System.Drawing.Point(20, 38);
            this.IncreaseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.IncreaseBtn.Name = "IncreaseBtn";
            this.IncreaseBtn.Size = new System.Drawing.Size(147, 29);
            this.IncreaseBtn.TabIndex = 34;
            this.IncreaseBtn.Text = "Increase";
            this.IncreaseBtn.UseVisualStyleBackColor = false;
            this.IncreaseBtn.Click += new System.EventHandler(this.IncreaseBtn_Click_2);
            // 
            // ValueBox
            // 
            this.ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ValueBox.Location = new System.Drawing.Point(20, 11);
            this.ValueBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(148, 26);
            this.ValueBox.TabIndex = 33;
            this.ValueBox.TextChanged += new System.EventHandler(this.ValueBox_TextChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshBtn.Location = new System.Drawing.Point(20, 110);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(147, 29);
            this.RefreshBtn.TabIndex = 32;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click_1);
            // 
            // DeletRowBtn
            // 
            this.DeletRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.DeletRowBtn.FlatAppearance.BorderSize = 0;
            this.DeletRowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeletRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletRowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeletRowBtn.ForeColor = System.Drawing.Color.White;
            this.DeletRowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletRowBtn.Location = new System.Drawing.Point(20, 96);
            this.DeletRowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeletRowBtn.Name = "DeletRowBtn";
            this.DeletRowBtn.Size = new System.Drawing.Size(147, 29);
            this.DeletRowBtn.TabIndex = 31;
            this.DeletRowBtn.Text = "Delete Row";
            this.DeletRowBtn.UseVisualStyleBackColor = false;
            this.DeletRowBtn.Click += new System.EventHandler(this.DeletRowBtn_Click_2);
            // 
            // NewRowBtn
            // 
            this.NewRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.NewRowBtn.FlatAppearance.BorderSize = 0;
            this.NewRowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NewRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NewRowBtn.ForeColor = System.Drawing.Color.White;
            this.NewRowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewRowBtn.Location = new System.Drawing.Point(20, 63);
            this.NewRowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NewRowBtn.Name = "NewRowBtn";
            this.NewRowBtn.Size = new System.Drawing.Size(146, 29);
            this.NewRowBtn.TabIndex = 30;
            this.NewRowBtn.Text = "New Row";
            this.NewRowBtn.UseVisualStyleBackColor = false;
            this.NewRowBtn.Click += new System.EventHandler(this.NewRowBtn_Click_1);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Location = new System.Drawing.Point(20, 31);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(146, 29);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search Name";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(20, 10);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(148, 20);
            this.SearchBox.TabIndex = 28;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(20, 103);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(147, 29);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.Text = "Save changes";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(464, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(642, 292);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(20, 46);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(147, 29);
            this.btnEmployees.TabIndex = 39;
            this.btnEmployees.Text = "Show Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnLowStock
            // 
            this.btnLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnLowStock.FlatAppearance.BorderSize = 0;
            this.btnLowStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLowStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLowStock.ForeColor = System.Drawing.Color.White;
            this.btnLowStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLowStock.Location = new System.Drawing.Point(20, 13);
            this.btnLowStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnLowStock.Name = "btnLowStock";
            this.btnLowStock.Size = new System.Drawing.Size(147, 29);
            this.btnLowStock.TabIndex = 40;
            this.btnLowStock.Text = "Show Low Stock";
            this.btnLowStock.UseVisualStyleBackColor = false;
            this.btnLowStock.Click += new System.EventHandler(this.btnLowStock_Click);
            // 
            // Seemorebtn
            // 
            this.Seemorebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.Seemorebtn.FlatAppearance.BorderSize = 0;
            this.Seemorebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Seemorebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seemorebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Seemorebtn.ForeColor = System.Drawing.Color.White;
            this.Seemorebtn.Location = new System.Drawing.Point(464, 460);
            this.Seemorebtn.Margin = new System.Windows.Forms.Padding(0);
            this.Seemorebtn.Name = "Seemorebtn";
            this.Seemorebtn.Size = new System.Drawing.Size(328, 30);
            this.Seemorebtn.TabIndex = 44;
            this.Seemorebtn.Text = "See more";
            this.Seemorebtn.UseVisualStyleBackColor = false;
            this.Seemorebtn.Click += new System.EventHandler(this.Seemorebtn_Click);
            // 
            // RowResetbtn
            // 
            this.RowResetbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.RowResetbtn.FlatAppearance.BorderSize = 0;
            this.RowResetbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RowResetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RowResetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RowResetbtn.ForeColor = System.Drawing.Color.White;
            this.RowResetbtn.Location = new System.Drawing.Point(791, 460);
            this.RowResetbtn.Margin = new System.Windows.Forms.Padding(0);
            this.RowResetbtn.Name = "RowResetbtn";
            this.RowResetbtn.Size = new System.Drawing.Size(314, 29);
            this.RowResetbtn.TabIndex = 45;
            this.RowResetbtn.Text = "Reset";
            this.RowResetbtn.UseVisualStyleBackColor = false;
            this.RowResetbtn.Click += new System.EventHandler(this.RowResetbtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(20, 78);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 29);
            this.button3.TabIndex = 54;
            this.button3.Text = "Stock to PDF";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(250, 81);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(855, 54);
            this.panel6.TabIndex = 74;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stock Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Location = new System.Drawing.Point(0, 567);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 60);
            this.panel4.TabIndex = 75;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 54);
            this.panel3.TabIndex = 73;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 51);
            this.panel2.TabIndex = 72;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.btnLogOut.Location = new System.Drawing.Point(1016, 0);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(111, 51);
            this.btnLogOut.TabIndex = 48;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnMenuStockManagement);
            this.panel1.Controls.Add(this.btnMenuPersonalDetails);
            this.panel1.Controls.Add(this.btnMenuRoleManagement);
            this.panel1.Controls.Add(this.btnMenuStock);
            this.panel1.Controls.Add(this.btnMenuAdminLogs);
            this.panel1.Controls.Add(this.btnMenuDepartmentManagement);
            this.panel1.Controls.Add(this.btnMenuScheduling);
            this.panel1.Controls.Add(this.btnMenuEmployeeManagement);
            this.panel1.Controls.Add(this.btnMenuSchedule);
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 432);
            this.panel1.TabIndex = 71;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnMenuStockManagement.Location = new System.Drawing.Point(0, 384);
            this.btnMenuStockManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuStockManagement.Name = "btnMenuStockManagement";
            this.btnMenuStockManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuStockManagement.Size = new System.Drawing.Size(221, 48);
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
            this.btnMenuPersonalDetails.Location = new System.Drawing.Point(0, 340);
            this.btnMenuPersonalDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuPersonalDetails.Name = "btnMenuPersonalDetails";
            this.btnMenuPersonalDetails.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuPersonalDetails.Size = new System.Drawing.Size(221, 48);
            this.btnMenuPersonalDetails.TabIndex = 51;
            this.btnMenuPersonalDetails.Text = "Personal Details";
            this.btnMenuPersonalDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPersonalDetails.UseVisualStyleBackColor = true;
            this.btnMenuPersonalDetails.Click += new System.EventHandler(this.btnMenuPersonalDetails_Click);
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
            this.btnMenuRoleManagement.Location = new System.Drawing.Point(0, 142);
            this.btnMenuRoleManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuRoleManagement.Name = "btnMenuRoleManagement";
            this.btnMenuRoleManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuRoleManagement.Size = new System.Drawing.Size(221, 48);
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
            this.btnMenuStock.Location = new System.Drawing.Point(0, 235);
            this.btnMenuStock.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuStock.Name = "btnMenuStock";
            this.btnMenuStock.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuStock.Size = new System.Drawing.Size(221, 48);
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
            this.btnMenuAdminLogs.Location = new System.Drawing.Point(0, 187);
            this.btnMenuAdminLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuAdminLogs.Name = "btnMenuAdminLogs";
            this.btnMenuAdminLogs.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuAdminLogs.Size = new System.Drawing.Size(221, 48);
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
            this.btnMenuDepartmentManagement.Location = new System.Drawing.Point(0, 94);
            this.btnMenuDepartmentManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuDepartmentManagement.Name = "btnMenuDepartmentManagement";
            this.btnMenuDepartmentManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuDepartmentManagement.Size = new System.Drawing.Size(221, 48);
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
            this.btnMenuScheduling.Location = new System.Drawing.Point(0, 48);
            this.btnMenuScheduling.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuScheduling.Name = "btnMenuScheduling";
            this.btnMenuScheduling.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuScheduling.Size = new System.Drawing.Size(221, 48);
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
            this.btnMenuEmployeeManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuEmployeeManagement.Size = new System.Drawing.Size(221, 48);
            this.btnMenuEmployeeManagement.TabIndex = 53;
            this.btnMenuEmployeeManagement.Text = "Employee Management";
            this.btnMenuEmployeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnMenuEmployeeManagement.Click += new System.EventHandler(this.btnMenuEmployeeManagement_Click);
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
            this.btnMenuSchedule.Location = new System.Drawing.Point(0, 288);
            this.btnMenuSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuSchedule.Name = "btnMenuSchedule";
            this.btnMenuSchedule.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuSchedule.Size = new System.Drawing.Size(221, 48);
            this.btnMenuSchedule.TabIndex = 50;
            this.btnMenuSchedule.Text = "Shop Personnel Schedule";
            this.btnMenuSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSchedule.UseVisualStyleBackColor = true;
            this.btnMenuSchedule.Click += new System.EventHandler(this.btnMenuSchedule_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.ValueBox);
            this.panel5.Controls.Add(this.IncreaseBtn);
            this.panel5.Controls.Add(this.DecreaseBtn);
            this.panel5.Controls.Add(this.SaveBtn);
            this.panel5.Location = new System.Drawing.Point(250, 167);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 145);
            this.panel5.TabIndex = 74;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel7.Controls.Add(this.SearchBox);
            this.panel7.Controls.Add(this.SearchBtn);
            this.panel7.Controls.Add(this.NewRowBtn);
            this.panel7.Controls.Add(this.DeletRowBtn);
            this.panel7.Location = new System.Drawing.Point(250, 325);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(184, 135);
            this.panel7.TabIndex = 75;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel8.Controls.Add(this.btnLowStock);
            this.panel8.Controls.Add(this.btnEmployees);
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.RefreshBtn);
            this.panel8.Location = new System.Drawing.Point(250, 470);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(184, 157);
            this.panel8.TabIndex = 76;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel9.Controls.Add(this.tbProductMinQuantity);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.comboBox1);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.tbProductQuantity);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.tbProductDescription);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.tbProductPrice);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.tbProductName);
            this.panel9.Controls.Add(this.btnAddProduct);
            this.panel9.Location = new System.Drawing.Point(464, 507);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(642, 120);
            this.panel9.TabIndex = 77;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(311, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 26);
            this.label7.TabIndex = 73;
            this.label7.Text = "Category:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 28);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(291, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 22);
            this.label6.TabIndex = 71;
            this.label6.Text = "Min Quantity:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(311, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 69;
            this.label5.Text = "Quantity:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbProductQuantity.Location = new System.Drawing.Point(421, 14);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(110, 26);
            this.tbProductQuantity.TabIndex = 68;
            this.tbProductQuantity.TextChanged += new System.EventHandler(this.tbProductQuantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 67;
            this.label3.Text = "Description:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbProductDescription.Location = new System.Drawing.Point(162, 82);
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.Size = new System.Drawing.Size(110, 26);
            this.tbProductDescription.TabIndex = 66;
            this.tbProductDescription.TextChanged += new System.EventHandler(this.tbProductDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "Price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbProductPrice.Location = new System.Drawing.Point(162, 47);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(110, 26);
            this.tbProductPrice.TabIndex = 64;
            this.tbProductPrice.TextChanged += new System.EventHandler(this.tbProductPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 63;
            this.label4.Text = "Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbProductName.Location = new System.Drawing.Point(162, 11);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(110, 26);
            this.tbProductName.TabIndex = 33;
            this.tbProductName.TextChanged += new System.EventHandler(this.tbProductName_TextChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(542, 11);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(88, 100);
            this.btnAddProduct.TabIndex = 32;
            this.btnAddProduct.Text = "Add\r\nProduct\r\n";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbProductMinQuantity
            // 
            this.tbProductMinQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbProductMinQuantity.Location = new System.Drawing.Point(421, 48);
            this.tbProductMinQuantity.Name = "tbProductMinQuantity";
            this.tbProductMinQuantity.Size = new System.Drawing.Size(110, 26);
            this.tbProductMinQuantity.TabIndex = 74;
            this.tbProductMinQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 650);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RowResetbtn);
            this.Controls.Add(this.Seemorebtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DecreaseBtn;
        private System.Windows.Forms.Button IncreaseBtn;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DeletRowBtn;
        private System.Windows.Forms.Button NewRowBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnLowStock;
        private System.Windows.Forms.Button Seemorebtn;
        private System.Windows.Forms.Button RowResetbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuAdminLogs;
        private System.Windows.Forms.Button btnMenuDepartmentManagement;
        private System.Windows.Forms.Button btnMenuRoleManagement;
        private System.Windows.Forms.Button btnMenuScheduling;
        private System.Windows.Forms.Button btnMenuEmployeeManagement;
        private System.Windows.Forms.Button btnMenuStockManagement;
        private System.Windows.Forms.Button btnMenuPersonalDetails;
        private System.Windows.Forms.Button btnMenuSchedule;
        private System.Windows.Forms.Button btnMenuStock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProductDescription;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProductMinQuantity;
    }
}
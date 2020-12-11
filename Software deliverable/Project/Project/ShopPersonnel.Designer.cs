namespace Project
{
    partial class ShopPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopPersonnel));
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmptyStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuantityChange = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rbSHowStocFunctions = new System.Windows.Forms.RadioButton();
            this.rbSHowPeronalFunctions = new System.Windows.Forms.RadioButton();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.RowResetbtn = new System.Windows.Forms.Button();
            this.Seemorebtn = new System.Windows.Forms.Button();
            this.attendancebtn = new System.Windows.Forms.Button();
            this.gbStock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.groupBox1);
            this.gbStock.Controls.Add(this.groupBox3);
            this.gbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbStock.Location = new System.Drawing.Point(602, 69);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(230, 397);
            this.gbStock.TabIndex = 12;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "Update Item";
            this.gbStock.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmptyStock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(36, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnEmptyStock
            // 
            this.btnEmptyStock.Image = ((System.Drawing.Image)(resources.GetObject("btnEmptyStock.Image")));
            this.btnEmptyStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmptyStock.Location = new System.Drawing.Point(6, 116);
            this.btnEmptyStock.Name = "btnEmptyStock";
            this.btnEmptyStock.Size = new System.Drawing.Size(156, 32);
            this.btnEmptyStock.TabIndex = 11;
            this.btnEmptyStock.Text = "Show Low Stock";
            this.btnEmptyStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmptyStock.UseVisualStyleBackColor = true;
            this.btnEmptyStock.Click += new System.EventHandler(this.btnEmptyStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item name: ";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(6, 44);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(156, 26);
            this.tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(32, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbQuantityChange);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnDecrease);
            this.groupBox3.Controls.Add(this.btnIncrease);
            this.groupBox3.Location = new System.Drawing.Point(36, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 202);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Increase / Decrease ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change quantity:";
            // 
            // tbQuantityChange
            // 
            this.tbQuantityChange.Location = new System.Drawing.Point(6, 47);
            this.tbQuantityChange.Multiline = true;
            this.tbQuantityChange.Name = "tbQuantityChange";
            this.tbQuantityChange.Size = new System.Drawing.Size(156, 26);
            this.tbQuantityChange.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(32, 156);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(6, 118);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(156, 32);
            this.btnDecrease.TabIndex = 1;
            this.btnDecrease.Text = "Decrease";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(6, 79);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(156, 32);
            this.btnIncrease.TabIndex = 0;
            this.btnIncrease.Text = "Increase";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(28, 35);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(184, 32);
            this.btnDetails.TabIndex = 41;
            this.btnDetails.Text = "Personal Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(28, 128);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(184, 26);
            this.tbPassword.TabIndex = 40;
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMenu.Image")));
            this.btnReturnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnMenu.Location = new System.Drawing.Point(864, 471);
            this.btnReturnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(129, 32);
            this.btnReturnMenu.TabIndex = 10;
            this.btnReturnMenu.Text = "Return Menu";
            this.btnReturnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(28, 159);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(184, 32);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(28, 73);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(184, 32);
            this.btnSchedule.TabIndex = 9;
            this.btnSchedule.Text = "Open my Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(583, 455);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(998, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "Log Out";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(998, 9);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 30);
            this.btnHelp.TabIndex = 40;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rbSHowStocFunctions
            // 
            this.rbSHowStocFunctions.AutoSize = true;
            this.rbSHowStocFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSHowStocFunctions.Location = new System.Drawing.Point(602, 44);
            this.rbSHowStocFunctions.Margin = new System.Windows.Forms.Padding(2);
            this.rbSHowStocFunctions.Name = "rbSHowStocFunctions";
            this.rbSHowStocFunctions.Size = new System.Drawing.Size(185, 21);
            this.rbSHowStocFunctions.TabIndex = 44;
            this.rbSHowStocFunctions.TabStop = true;
            this.rbSHowStocFunctions.Text = "Show Stock functions ";
            this.rbSHowStocFunctions.UseVisualStyleBackColor = true;
            this.rbSHowStocFunctions.CheckedChanged += new System.EventHandler(this.rbSHowStocFunctions_CheckedChanged);
            // 
            // rbSHowPeronalFunctions
            // 
            this.rbSHowPeronalFunctions.AutoSize = true;
            this.rbSHowPeronalFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSHowPeronalFunctions.Location = new System.Drawing.Point(840, 44);
            this.rbSHowPeronalFunctions.Margin = new System.Windows.Forms.Padding(2);
            this.rbSHowPeronalFunctions.Name = "rbSHowPeronalFunctions";
            this.rbSHowPeronalFunctions.Size = new System.Drawing.Size(289, 21);
            this.rbSHowPeronalFunctions.TabIndex = 45;
            this.rbSHowPeronalFunctions.TabStop = true;
            this.rbSHowPeronalFunctions.Text = "Show personal information functions";
            this.rbSHowPeronalFunctions.UseVisualStyleBackColor = true;
            this.rbSHowPeronalFunctions.CheckedChanged += new System.EventHandler(this.rbSHowPeronalFunctions_CheckedChanged);
            // 
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.btnSchedule);
            this.gbEmployee.Controls.Add(this.btnChangePassword);
            this.gbEmployee.Controls.Add(this.label3);
            this.gbEmployee.Controls.Add(this.btnDetails);
            this.gbEmployee.Controls.Add(this.tbPassword);
            this.gbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployee.Location = new System.Drawing.Point(840, 83);
            this.gbEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.gbEmployee.Size = new System.Drawing.Size(230, 201);
            this.gbEmployee.TabIndex = 46;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "Employee Information";
            this.gbEmployee.Visible = false;
            // 
            // RowResetbtn
            // 
            this.RowResetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RowResetbtn.Location = new System.Drawing.Point(106, 474);
            this.RowResetbtn.Name = "RowResetbtn";
            this.RowResetbtn.Size = new System.Drawing.Size(75, 29);
            this.RowResetbtn.TabIndex = 48;
            this.RowResetbtn.Text = "Resest";
            this.RowResetbtn.UseVisualStyleBackColor = true;
            this.RowResetbtn.Click += new System.EventHandler(this.RowResetbtn_Click);
            // 
            // Seemorebtn
            // 
            this.Seemorebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Seemorebtn.Location = new System.Drawing.Point(3, 473);
            this.Seemorebtn.Name = "Seemorebtn";
            this.Seemorebtn.Size = new System.Drawing.Size(97, 30);
            this.Seemorebtn.TabIndex = 47;
            this.Seemorebtn.Text = "See more";
            this.Seemorebtn.UseVisualStyleBackColor = true;
            this.Seemorebtn.Click += new System.EventHandler(this.Seemorebtn_Click);
            // 
            // attendancebtn
            // 
            this.attendancebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.attendancebtn.Location = new System.Drawing.Point(465, 474);
            this.attendancebtn.Name = "attendancebtn";
            this.attendancebtn.Size = new System.Drawing.Size(121, 30);
            this.attendancebtn.TabIndex = 49;
            this.attendancebtn.Text = "Mark Present";
            this.attendancebtn.UseVisualStyleBackColor = true;
            this.attendancebtn.Click += new System.EventHandler(this.attendancebtn_Click);
            // 
            // ShopPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 513);
            this.Controls.Add(this.attendancebtn);
            this.Controls.Add(this.RowResetbtn);
            this.Controls.Add(this.Seemorebtn);
            this.Controls.Add(this.gbEmployee);
            this.Controls.Add(this.rbSHowPeronalFunctions);
            this.Controls.Add(this.rbSHowStocFunctions);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShopPersonnel";
            this.Text = "ShopPersonnel";
            this.gbStock.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmptyStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuantityChange;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.RadioButton rbSHowStocFunctions;
        private System.Windows.Forms.RadioButton rbSHowPeronalFunctions;
        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.Button RowResetbtn;
        private System.Windows.Forms.Button Seemorebtn;
        private System.Windows.Forms.Button attendancebtn;
    }
}
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rbSHowStocFunctions = new System.Windows.Forms.RadioButton();
            this.rbSHowPeronalFunctions = new System.Windows.Forms.RadioButton();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.RowResetbtn = new System.Windows.Forms.Button();
            this.Seemorebtn = new System.Windows.Forms.Button();
            this.lbAccountSecurity = new System.Windows.Forms.Label();
            this.lbSecureText = new System.Windows.Forms.Label();
            this.btnattendance = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.gbStock.Location = new System.Drawing.Point(812, 101);
            this.gbStock.Margin = new System.Windows.Forms.Padding(4);
            this.gbStock.Name = "gbStock";
            this.gbStock.Padding = new System.Windows.Forms.Padding(4);
            this.gbStock.Size = new System.Drawing.Size(307, 489);
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
            this.groupBox1.Location = new System.Drawing.Point(48, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(225, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnEmptyStock
            // 
            this.btnEmptyStock.Image = ((System.Drawing.Image)(resources.GetObject("btnEmptyStock.Image")));
            this.btnEmptyStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmptyStock.Location = new System.Drawing.Point(8, 143);
            this.btnEmptyStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmptyStock.Name = "btnEmptyStock";
            this.btnEmptyStock.Size = new System.Drawing.Size(208, 39);
            this.btnEmptyStock.TabIndex = 11;
            this.btnEmptyStock.Text = "Show Low Stock";
            this.btnEmptyStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmptyStock.UseVisualStyleBackColor = true;
            this.btnEmptyStock.Click += new System.EventHandler(this.btnEmptyStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item name: ";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(8, 54);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(207, 30);
            this.tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(43, 96);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 39);
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
            this.groupBox3.Location = new System.Drawing.Point(48, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(225, 249);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Increase / Decrease ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change quantity:";
            // 
            // tbQuantityChange
            // 
            this.tbQuantityChange.Location = new System.Drawing.Point(8, 58);
            this.tbQuantityChange.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuantityChange.Multiline = true;
            this.tbQuantityChange.Name = "tbQuantityChange";
            this.tbQuantityChange.Size = new System.Drawing.Size(207, 31);
            this.tbQuantityChange.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(43, 192);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 39);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(8, 145);
            this.btnDecrease.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(208, 39);
            this.btnDecrease.TabIndex = 1;
            this.btnDecrease.Text = "Decrease";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(8, 97);
            this.btnIncrease.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(208, 39);
            this.btnIncrease.TabIndex = 0;
            this.btnIncrease.Text = "Increase";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(37, 43);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(245, 39);
            this.btnDetails.TabIndex = 41;
            this.btnDetails.Text = "Personal Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(37, 158);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(244, 30);
            this.tbPassword.TabIndex = 40;
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMenu.Image")));
            this.btnReturnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnMenu.Location = new System.Drawing.Point(1161, 596);
            this.btnReturnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(172, 39);
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
            this.label3.Location = new System.Drawing.Point(32, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(37, 196);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(245, 39);
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
            this.btnSchedule.Location = new System.Drawing.Point(37, 90);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(245, 39);
            this.btnSchedule.TabIndex = 9;
            this.btnSchedule.Text = "Open my Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(777, 560);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1340, 597);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(117, 34);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(1340, 27);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 37);
            this.btnHelp.TabIndex = 40;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rbSHowStocFunctions
            // 
            this.rbSHowStocFunctions.AutoSize = true;
            this.rbSHowStocFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSHowStocFunctions.Location = new System.Drawing.Point(812, 70);
            this.rbSHowStocFunctions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSHowStocFunctions.Name = "rbSHowStocFunctions";
            this.rbSHowStocFunctions.Size = new System.Drawing.Size(217, 24);
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
            this.rbSHowPeronalFunctions.Location = new System.Drawing.Point(1129, 70);
            this.rbSHowPeronalFunctions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSHowPeronalFunctions.Name = "rbSHowPeronalFunctions";
            this.rbSHowPeronalFunctions.Size = new System.Drawing.Size(336, 24);
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
            this.gbEmployee.Location = new System.Drawing.Point(1129, 118);
            this.gbEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmployee.Size = new System.Drawing.Size(307, 247);
            this.gbEmployee.TabIndex = 46;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "Employee Information";
            this.gbEmployee.Visible = false;
            // 
            // RowResetbtn
            // 
            this.RowResetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RowResetbtn.Location = new System.Drawing.Point(150, 599);
            this.RowResetbtn.Margin = new System.Windows.Forms.Padding(4);
            this.RowResetbtn.Name = "RowResetbtn";
            this.RowResetbtn.Size = new System.Drawing.Size(100, 36);
            this.RowResetbtn.TabIndex = 48;
            this.RowResetbtn.Text = "Resest";
            this.RowResetbtn.UseVisualStyleBackColor = true;
            this.RowResetbtn.Click += new System.EventHandler(this.RowResetbtn_Click);
            // 
            // Seemorebtn
            // 
            this.Seemorebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Seemorebtn.Location = new System.Drawing.Point(13, 598);
            this.Seemorebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Seemorebtn.Name = "Seemorebtn";
            this.Seemorebtn.Size = new System.Drawing.Size(129, 37);
            this.Seemorebtn.TabIndex = 47;
            this.Seemorebtn.Text = "See more";
            this.Seemorebtn.UseVisualStyleBackColor = true;
            this.Seemorebtn.Click += new System.EventHandler(this.Seemorebtn_Click);
            // 
            // lbAccountSecurity
            // 
            this.lbAccountSecurity.AutoSize = true;
            this.lbAccountSecurity.Location = new System.Drawing.Point(118, 9);
            this.lbAccountSecurity.Name = "lbAccountSecurity";
            this.lbAccountSecurity.Size = new System.Drawing.Size(20, 17);
            this.lbAccountSecurity.TabIndex = 51;
            this.lbAccountSecurity.Text = "...";
            // 
            // lbSecureText
            // 
            this.lbSecureText.AutoSize = true;
            this.lbSecureText.Location = new System.Drawing.Point(12, 9);
            this.lbSecureText.Name = "lbSecureText";
            this.lbSecureText.Size = new System.Drawing.Size(108, 17);
            this.lbSecureText.TabIndex = 50;
            this.lbSecureText.Text = "Account Secure";
            // 
            // btnattendance
            // 
            this.btnattendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnattendance.Location = new System.Drawing.Point(629, 599);
            this.btnattendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnattendance.Name = "btnattendance";
            this.btnattendance.Size = new System.Drawing.Size(161, 37);
            this.btnattendance.TabIndex = 52;
            this.btnattendance.Text = "Mark Present";
            this.btnattendance.UseVisualStyleBackColor = true;
            this.btnattendance.Click += new System.EventHandler(this.btnattendance_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(272, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 41);
            this.button2.TabIndex = 53;
            this.button2.Text = "Personal Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShopPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnattendance);
            this.Controls.Add(this.lbAccountSecurity);
            this.Controls.Add(this.lbSecureText);
            this.Controls.Add(this.RowResetbtn);
            this.Controls.Add(this.Seemorebtn);
            this.Controls.Add(this.gbEmployee);
            this.Controls.Add(this.rbSHowPeronalFunctions);
            this.Controls.Add(this.rbSHowStocFunctions);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnLogout;
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
        private System.Windows.Forms.Label lbAccountSecurity;
        private System.Windows.Forms.Label lbSecureText;
        private System.Windows.Forms.Button btnattendance;
        private System.Windows.Forms.Button button2;
    }
}
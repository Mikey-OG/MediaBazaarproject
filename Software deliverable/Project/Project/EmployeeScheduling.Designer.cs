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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeScheduling));
            this.DataGridSchedule = new System.Windows.Forms.DataGridView();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchSchedule = new System.Windows.Forms.Button();
            this.btnRemoveSchedule = new System.Windows.Forms.Button();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTimeShift = new System.Windows.Forms.ComboBox();
            this.dtWorkDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridEmployees = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSearchShiftTime = new System.Windows.Forms.ComboBox();
            this.dtSearchWorkDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSchedule)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridSchedule
            // 
            this.DataGridSchedule.AllowUserToAddRows = false;
            this.DataGridSchedule.AllowUserToDeleteRows = false;
            this.DataGridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSchedule.Location = new System.Drawing.Point(12, 256);
            this.DataGridSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridSchedule.Name = "DataGridSchedule";
            this.DataGridSchedule.ReadOnly = true;
            this.DataGridSchedule.RowHeadersWidth = 51;
            this.DataGridSchedule.RowTemplate.Height = 24;
            this.DataGridSchedule.ShowEditingIcon = false;
            this.DataGridSchedule.Size = new System.Drawing.Size(608, 229);
            this.DataGridSchedule.TabIndex = 24;
            this.DataGridSchedule.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridSchedule_CellMouseClick);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMenu.Image")));
            this.btnReturnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnMenu.Location = new System.Drawing.Point(24, 80);
            this.btnReturnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(184, 46);
            this.btnReturnMenu.TabIndex = 20;
            this.btnReturnMenu.Text = "Return Menu";
            this.btnReturnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchSchedule);
            this.groupBox1.Controls.Add(this.btnRemoveSchedule);
            this.groupBox1.Controls.Add(this.btnReturnMenu);
            this.groupBox1.Controls.Add(this.btnAddSchedule);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(626, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(718, 134);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // btnSearchSchedule
            // 
            this.btnSearchSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSchedule.Location = new System.Drawing.Point(463, 30);
            this.btnSearchSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSchedule.Name = "btnSearchSchedule";
            this.btnSearchSchedule.Size = new System.Drawing.Size(248, 46);
            this.btnSearchSchedule.TabIndex = 21;
            this.btnSearchSchedule.Text = "Search Schedule";
            this.btnSearchSchedule.UseVisualStyleBackColor = true;
            this.btnSearchSchedule.Click += new System.EventHandler(this.btnSearchSchedule_Click);
            // 
            // btnRemoveSchedule
            // 
            this.btnRemoveSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSchedule.Image")));
            this.btnRemoveSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveSchedule.Location = new System.Drawing.Point(227, 30);
            this.btnRemoveSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveSchedule.Name = "btnRemoveSchedule";
            this.btnRemoveSchedule.Size = new System.Drawing.Size(229, 46);
            this.btnRemoveSchedule.TabIndex = 5;
            this.btnRemoveSchedule.Text = "Remove Schedule";
            this.btnRemoveSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveSchedule.UseVisualStyleBackColor = true;
            this.btnRemoveSchedule.Click += new System.EventHandler(this.btnRemoveSchedule_Click);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSchedule.Image")));
            this.btnAddSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSchedule.Location = new System.Drawing.Point(24, 30);
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(197, 46);
            this.btnAddSchedule.TabIndex = 0;
            this.btnAddSchedule.Text = "Add Schedule";
            this.btnAddSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTimeShift);
            this.groupBox3.Controls.Add(this.dtWorkDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(626, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(295, 183);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adding Schedule";
            // 
            // cmbTimeShift
            // 
            this.cmbTimeShift.FormattingEnabled = true;
            this.cmbTimeShift.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cmbTimeShift.Location = new System.Drawing.Point(24, 135);
            this.cmbTimeShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTimeShift.Name = "cmbTimeShift";
            this.cmbTimeShift.Size = new System.Drawing.Size(249, 28);
            this.cmbTimeShift.TabIndex = 37;
            // 
            // dtWorkDate
            // 
            this.dtWorkDate.CustomFormat = "dd-MM-yyyy";
            this.dtWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWorkDate.Location = new System.Drawing.Point(24, 59);
            this.dtWorkDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtWorkDate.Name = "dtWorkDate";
            this.dtWorkDate.Size = new System.Drawing.Size(249, 27);
            this.dtWorkDate.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Work Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shift Time:";
            // 
            // DataGridEmployees
            // 
            this.DataGridEmployees.AllowUserToAddRows = false;
            this.DataGridEmployees.AllowUserToDeleteRows = false;
            this.DataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEmployees.Location = new System.Drawing.Point(12, 12);
            this.DataGridEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridEmployees.Name = "DataGridEmployees";
            this.DataGridEmployees.ReadOnly = true;
            this.DataGridEmployees.RowHeadersWidth = 51;
            this.DataGridEmployees.RowTemplate.Height = 24;
            this.DataGridEmployees.ShowEditingIcon = false;
            this.DataGridEmployees.Size = new System.Drawing.Size(608, 238);
            this.DataGridEmployees.TabIndex = 21;
            this.DataGridEmployees.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridEmployees_CellMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(927, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSearchShiftTime);
            this.groupBox2.Controls.Add(this.dtSearchWorkDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(626, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(295, 154);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Searching Schedule";
            // 
            // cmbSearchShiftTime
            // 
            this.cmbSearchShiftTime.FormattingEnabled = true;
            this.cmbSearchShiftTime.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cmbSearchShiftTime.Location = new System.Drawing.Point(24, 110);
            this.cmbSearchShiftTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearchShiftTime.Name = "cmbSearchShiftTime";
            this.cmbSearchShiftTime.Size = new System.Drawing.Size(249, 28);
            this.cmbSearchShiftTime.TabIndex = 37;
            // 
            // dtSearchWorkDate
            // 
            this.dtSearchWorkDate.CustomFormat = "dd-MM-yyyy";
            this.dtSearchWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSearchWorkDate.Location = new System.Drawing.Point(24, 53);
            this.dtSearchWorkDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSearchWorkDate.Name = "dtSearchWorkDate";
            this.dtSearchWorkDate.Size = new System.Drawing.Size(249, 27);
            this.dtSearchWorkDate.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Work Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shift Time:";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(1199, 22);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 37);
            this.btnHelp.TabIndex = 39;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // EmployeeScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 496);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGridSchedule);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DataGridEmployees);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeScheduling";
            this.Text = "EmployeeScheduling";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSchedule)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridSchedule;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtWorkDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbTimeShift;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSearchShiftTime;
        private System.Windows.Forms.DateTimePicker dtSearchWorkDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchSchedule;
        private System.Windows.Forms.Button btnHelp;
    }
}
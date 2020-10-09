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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagement));
            this.DecreaseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IncreaseBtn = new System.Windows.Forms.Button();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeletRowBtn = new System.Windows.Forms.Button();
            this.NewRowBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnLowStock = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DecreaseBtn.Location = new System.Drawing.Point(664, 293);
            this.DecreaseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(147, 29);
            this.DecreaseBtn.TabIndex = 36;
            this.DecreaseBtn.Text = "Decrease";
            this.DecreaseBtn.UseVisualStyleBackColor = true;
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(665, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Change value by:";
            // 
            // IncreaseBtn
            // 
            this.IncreaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IncreaseBtn.Location = new System.Drawing.Point(664, 260);
            this.IncreaseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IncreaseBtn.Name = "IncreaseBtn";
            this.IncreaseBtn.Size = new System.Drawing.Size(147, 29);
            this.IncreaseBtn.TabIndex = 34;
            this.IncreaseBtn.Text = "Increase";
            this.IncreaseBtn.UseVisualStyleBackColor = true;
            this.IncreaseBtn.Click += new System.EventHandler(this.IncreaseBtn_Click_2);
            // 
            // ValueBox
            // 
            this.ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ValueBox.Location = new System.Drawing.Point(664, 230);
            this.ValueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(147, 26);
            this.ValueBox.TabIndex = 33;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshBtn.Location = new System.Drawing.Point(664, 361);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(147, 29);
            this.RefreshBtn.TabIndex = 32;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click_1);
            // 
            // DeletRowBtn
            // 
            this.DeletRowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeletRowBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeletRowBtn.Image")));
            this.DeletRowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletRowBtn.Location = new System.Drawing.Point(664, 171);
            this.DeletRowBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeletRowBtn.Name = "DeletRowBtn";
            this.DeletRowBtn.Size = new System.Drawing.Size(147, 29);
            this.DeletRowBtn.TabIndex = 31;
            this.DeletRowBtn.Text = "Delete Row";
            this.DeletRowBtn.UseVisualStyleBackColor = true;
            this.DeletRowBtn.Click += new System.EventHandler(this.DeletRowBtn_Click_2);
            // 
            // NewRowBtn
            // 
            this.NewRowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NewRowBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewRowBtn.Image")));
            this.NewRowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewRowBtn.Location = new System.Drawing.Point(664, 103);
            this.NewRowBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewRowBtn.Name = "NewRowBtn";
            this.NewRowBtn.Size = new System.Drawing.Size(147, 29);
            this.NewRowBtn.TabIndex = 30;
            this.NewRowBtn.Text = "New Row";
            this.NewRowBtn.UseVisualStyleBackColor = true;
            this.NewRowBtn.Click += new System.EventHandler(this.NewRowBtn_Click_1);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Location = new System.Drawing.Point(664, 69);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(147, 29);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search Name";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(664, 43);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(147, 20);
            this.SearchBox.TabIndex = 28;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(664, 327);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(147, 29);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.Text = "Save changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(642, 506);
            this.dataGridView1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(664, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 37;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(664, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 29);
            this.button2.TabIndex = 38;
            this.button2.Text = "Input Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(664, 430);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(147, 29);
            this.btnEmployees.TabIndex = 39;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnLowStock
            // 
            this.btnLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLowStock.Image = ((System.Drawing.Image)(resources.GetObject("btnLowStock.Image")));
            this.btnLowStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLowStock.Location = new System.Drawing.Point(664, 395);
            this.btnLowStock.Name = "btnLowStock";
            this.btnLowStock.Size = new System.Drawing.Size(147, 29);
            this.btnLowStock.TabIndex = 40;
            this.btnLowStock.Text = "Show Low Stock";
            this.btnLowStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLowStock.UseVisualStyleBackColor = true;
            this.btnLowStock.Click += new System.EventHandler(this.btnLowStock_Click);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMenu.Image")));
            this.btnReturnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnMenu.Location = new System.Drawing.Point(664, 465);
            this.btnReturnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(146, 31);
            this.btnReturnMenu.TabIndex = 41;
            this.btnReturnMenu.Text = "Return Menu";
            this.btnReturnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(722, 8);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 30);
            this.btnHelp.TabIndex = 43;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 543);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.btnLowStock);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DecreaseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncreaseBtn);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeletRowBtn);
            this.Controls.Add(this.NewRowBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockManagement";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DecreaseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IncreaseBtn;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DeletRowBtn;
        private System.Windows.Forms.Button NewRowBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnLowStock;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnHelp;
    }
}
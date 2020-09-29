namespace Project
{
    partial class Form2
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.Location = new System.Drawing.Point(726, 206);
            this.DecreaseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(63, 24);
            this.DecreaseBtn.TabIndex = 36;
            this.DecreaseBtn.Text = "Decrease";
            this.DecreaseBtn.UseVisualStyleBackColor = true;
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Change value by:";
            // 
            // IncreaseBtn
            // 
            this.IncreaseBtn.Location = new System.Drawing.Point(663, 206);
            this.IncreaseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.IncreaseBtn.Name = "IncreaseBtn";
            this.IncreaseBtn.Size = new System.Drawing.Size(59, 24);
            this.IncreaseBtn.TabIndex = 34;
            this.IncreaseBtn.Text = "Increase";
            this.IncreaseBtn.UseVisualStyleBackColor = true;
            this.IncreaseBtn.Click += new System.EventHandler(this.IncreaseBtn_Click_2);
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(662, 182);
            this.ValueBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(126, 20);
            this.ValueBox.TabIndex = 33;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(663, 234);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(126, 20);
            this.RefreshBtn.TabIndex = 32;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click_1);
            // 
            // DeletRowBtn
            // 
            this.DeletRowBtn.Location = new System.Drawing.Point(663, 137);
            this.DeletRowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeletRowBtn.Name = "DeletRowBtn";
            this.DeletRowBtn.Size = new System.Drawing.Size(126, 24);
            this.DeletRowBtn.TabIndex = 31;
            this.DeletRowBtn.Text = "Delete Row";
            this.DeletRowBtn.UseVisualStyleBackColor = true;
            this.DeletRowBtn.Click += new System.EventHandler(this.DeletRowBtn_Click_2);
            // 
            // NewRowBtn
            // 
            this.NewRowBtn.Location = new System.Drawing.Point(662, 80);
            this.NewRowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NewRowBtn.Name = "NewRowBtn";
            this.NewRowBtn.Size = new System.Drawing.Size(126, 22);
            this.NewRowBtn.TabIndex = 30;
            this.NewRowBtn.Text = "New Row";
            this.NewRowBtn.UseVisualStyleBackColor = true;
            this.NewRowBtn.Click += new System.EventHandler(this.NewRowBtn_Click_1);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(662, 52);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(126, 23);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search Name";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(662, 26);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(126, 20);
            this.SearchBox.TabIndex = 28;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(663, 259);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(126, 23);
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
            this.dataGridView1.Size = new System.Drawing.Size(642, 399);
            this.dataGridView1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Input Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form2";
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
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class StockManagement : Form
    {
        string UserValidation;
        private StockManager stock = new StockManager();
        GeneralManagement generalManagement = new GeneralManagement();
        public StockManagement(string validation)
        {
            InitializeComponent();
            stock.FillTable(dataGridView1);
            if(validation == "Admin")
            {
                UserValidation = "Admin";
            }
            else
            {
                btnReturnMenu.Visible = false;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            stock.Search(dataGridView1, SearchBox);
        }

        private void NewRowBtn_Click_1(object sender, EventArgs e)
        {
            stock.NewRow(dataGridView1);
        }

        private void DeletRowBtn_Click_2(object sender, EventArgs e)
        {
            stock.DeleteRow(dataGridView1);
        }

        private void IncreaseBtn_Click_2(object sender, EventArgs e)
        {
            stock.Increase(dataGridView1, ValueBox);
        }

        private void DecreaseBtn_Click_1(object sender, EventArgs e)
        {
            stock.Decrease(dataGridView1, ValueBox);
        }

        private void RefreshBtn_Click_1(object sender, EventArgs e)
        {
            stock.Refresh(dataGridView1);
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            stock.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StockInput InputForm = new StockInput();
            InputForm.Show();
        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            stock.EmptyStock(dataGridView1);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            stock.ShowEmployees(dataGridView1);
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            GeneralEmployeeForm generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
            generalEmployeeForm.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1)You can create a new row and fill data manually or press input data. " +
                "2)To delete a row choose the most left column. " +
                "3)Click on the value you want to increase/decrease and press a button. " +
                "4)Refresh to see the original table. ", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

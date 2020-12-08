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
            this.dataGridView1.DataError += this.DataGridView1_DataError;
            stock.FillTable(dataGridView1);
            if(validation == "Admin")
            {
                UserValidation = "Admin";
            }
            else
            {
                btnReturnMenu.Visible = false;
            }
            generalManagement.AccountSecurity(generalManagement.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
        }
       
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error\n" + "Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Seemorebtn_Click(object sender, EventArgs e)
        {
            stock.SeeMore(dataGridView1, stock.LastSQL,10);
        }

        private void RowResetbtn_Click(object sender, EventArgs e)
        {
            generalManagement.AccountSecurity(generalManagement.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
            stock.MaxRows = 0;
            stock.SeeMore(dataGridView1, stock.LastSQL,10);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (lbAccountSecurity.Text == "False")
            {
                test testform = new test();
                testform.Show();
            }
            else
            {
                generalManagement.LogOut(this);
            }
        }
    }
}

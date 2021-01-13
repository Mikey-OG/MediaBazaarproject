using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Project.DAL;

namespace Project
{
    public partial class ShopPersonnel : Form
    {
        string UserValidation;
        private StockManager stock = new StockManager();
        private Encryption Cry = new Encryption();
        private EmployeeManagementDAL generalManagement = new EmployeeManagementDAL();
        public ShopPersonnel(string validation)
        {
            InitializeComponent();
            stock.FillTable(dataGridView1);
            if (validation == "Admin")
            {
                UserValidation = "Admin";
            }
            else
            {
                btnReturnMenu.Visible = false;
            }
            generalManagement.AccountSecurity(generalManagement.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            stock.Search(dataGridView1, tbSearch);
        }

        private void btnEmptyStock_Click(object sender, EventArgs e)
        {
            stock.EmptyStock(dataGridView1);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            stock.Increase(dataGridView1, tbQuantityChange);
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            stock.Decrease(dataGridView1, tbQuantityChange);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            stock.Save();
            stock.Refresh(dataGridView1);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            stock.ShowSchedule(dataGridView1);
        }


        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            GeneralEmployeeForm generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
            generalEmployeeForm.Show();
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbPassword.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$"))
            {
                if (generalManagement.ChangePasswordMessageBoxYesNo() == true)
                {
                    generalManagement.ChangePassword(Convert.ToString(Variables.User), tbPassword.Text);
                    tbPassword.Text = "";
                    MessageBox.Show("Password changed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please ensure your password" +
                " possesses at least one lowercase character " +
                " at least one uppercase charater " +
                " at least one numeric character between 0-9 " +
                " and is at least 8-15 characters long " +
                " e.g (Mikoko02, Kirill02, lucM2002) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The user can basically search,increase,decrease items in the store inventory" +
                "1) The search button allows the user to search for a particular product in the inventory" +
                "2) The show low stock button allows the user to see product that are low in stock" +
                "3) The increase button allows the user the increase the quantity of a product" +
                "Make sure to input the product name and the value by which you want to increase the quantity of the product in the necessary textboxes" +
                "4) The decrease  button allows the user the decrease the quantity of a product" +
                "5) The update button saves the data and updates the record with reference to the data which the user inputted" +
                "6) The schedule button gives the user information about his/her timetable" +
                "7) The return menu button takes the user back to the home page/main menu" +
                "8) The logout button signs the user out of the system", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            stock.ShowDetails(dataGridView1);
        }

        private void rbSHowStocFunctions_CheckedChanged(object sender, EventArgs e)
        {
            gbStock.Visible = true;
            gbEmployee.Visible = false;
        }

        private void rbSHowPeronalFunctions_CheckedChanged(object sender, EventArgs e)
        {
            gbStock.Visible = false;
            gbEmployee.Visible = true;
        }

        private void Seemorebtn_Click(object sender, EventArgs e)
        {
            stock.SeeMore(dataGridView1, stock.LastSQL, 10);
        }

        private void RowResetbtn_Click(object sender, EventArgs e)
        {
            generalManagement.AccountSecurity(generalManagement.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
            stock.MaxRows = 0;
            stock.SeeMore(dataGridView1, stock.LastSQL, 10);
        }

<<<<<<< HEAD
        private void btnLogout_Click(object sender, EventArgs e)
        {
            generalManagement.LogOut(this);
        }

        private void btnattendance_Click(object sender, EventArgs e)
=======
        private void button2_Click(object sender, EventArgs e)
>>>>>>> a7aae29b865f182903ef8db676b12eb8721c006a
        {

            UpdateDetailsForm update = new UpdateDetailsForm(2);
            update.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDetailsForm update = new UpdateDetailsForm(2);
            update.Show();
        }
    }
}

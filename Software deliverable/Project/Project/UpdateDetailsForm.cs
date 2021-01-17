using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project.LGC;
using Project.DAL;


namespace Project
{
    public partial class UpdateDetailsForm : Form
    {
        UpdateDetailsDAL update = new UpdateDetailsDAL();
        Employee employee;
        Account account = new Account();
        //MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        MySqlDataAdapter adpt;
        MySqlCommand cmd;
        MySqlDataReader dr;

        private Encryption Cry = new Encryption();
        private string userValidation;

        public void DeactivateShopPersonnelbtn()
        {
            btnMenuStock.Visible = false;
            btnMenuSchedule.Visible = false;
        }
        public void DeactivateAdminBtn()
        {
            btnMenuAdminLogs.Visible = false;
            btnMenuDepartmentManagement.Visible = false;
            btnMenuRoleManagement.Visible = false;
        }

        public void DeactivateEmployeeManagementBtn()
        {
            btnMenuScheduling.Visible = false;
            btnMenuEmployeeManagement.Visible = false;
        }
        public UpdateDetailsForm(string validation)
        {
            InitializeComponent();
            if(validation == "Admin")
            {
                DeactivateShopPersonnelbtn();
                userValidation = validation;
            }
            else
            {
                if(validation == "EmployeeManager")
                {
                    DeactivateShopPersonnelbtn();
                    DeactivateAdminBtn();
                    btnMenuStockManagement.Visible = false;
                    userValidation = validation;

                }
                else
                {
                    if(validation == "StockManager")
                    {
                        DeactivateAdminBtn();
                        DeactivateShopPersonnelbtn();
                        DeactivateEmployeeManagementBtn();
                        userValidation = validation;
                    }
                }
            }
            if (validation == "ShopPersonnel")
            {
                DeactivateAdminBtn();
                DeactivateEmployeeManagementBtn();        
                btnMenuStockManagement.Visible = false;
                userValidation = validation;
            }
            employee = new Employee("bjnkmnb", "bjnkmnb",
                       "bjnkmnb", "bjnkmnb", "bjnkmnb", "bjnkmnb",
                       "bjnkmnb", "bjnkmnb", "bjnkmnb",
                       Convert.ToInt32(2000));
            //int val = 1;
            //this.tbID.Text = Convert.ToString(id);
            update.Insert(tbUpUsername.Text, tbUpEmail.Text, tbUpPassword.Text, tbUpFirstname.Text, tbUpLastname.Text, dtUpDOB.Value, tbUpPhone.Text, tbUpNationality.Text, tbUpAddress.Text, tbUpCity.Text, tbUpZipcode.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (employee.SetPassword(tbUpPassword.Text) == false)
            {
                MessageBox.Show("Please ensure your password" +
                           " possesses at least one lowercase character " +
                           " at least one uppercase charater " +
                           " at least one numeric character between 0-9 " +
                           " and is at least 8-15 characters long " +
                           " e.g (Mikoko02, Kirill02, lucM2002) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.update.UpdateDetails(tbUpUsername.Text, tbUpEmail.Text, tbUpPassword.Text, tbUpFirstname.Text, tbUpLastname.Text, dtUpDOB.Value, tbUpPhone.Text, tbUpNationality.Text, tbUpAddress.Text, tbUpCity.Text, tbUpZipcode.Text);
                MessageBox.Show("Your details have been updated");

                /*if (DialogResult.OK == )
                {
                    this.Hide();
                }*/
            }
        }

        /*private void tbID_TextChanged(object sender, EventArgs e)
        {
            Account account;
            account = new Account();
            try
            {
                conn.Open();
                //if (tbID.Text != "")
                {
                    string sql = "SELECT UserName,Email,FirstName,LastName,DateOfBirth,PhoneNumber,Nationality,Adress,City,ZipCode FROM employee WHERE UserID = @userID";
                    cmd = new MySqlCommand(sql, conn);
                    //LastSQL = sql;
                    adpt = new MySqlDataAdapter(cmd);
                    // dt = new DataTable();
                    //cmd.Parameters.AddWithValue("@userID", int.Parse(tbID.Text));
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tbUpUsername.Text = dr.GetValue(0).ToString();
                        tbUpEmail.Text = dr.GetValue(1).ToString();
                        tbUpFirstname.Text = dr.GetValue(2).ToString();
                        tbUpLastname.Text = dr.GetValue(3).ToString();
                        dtUpDOB.Value = Convert.ToDateTime(dr.GetValue(4));
                        tbUpPhone.Text = dr.GetValue(5).ToString();
                        tbUpNationality.Text = dr.GetValue(6).ToString();
                        tbUpAddress.Text = dr.GetValue(7).ToString();
                        tbUpCity.Text = dr.GetValue(8).ToString();
                        tbUpZipcode.Text = dr.GetValue(9).ToString();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }*/

        private void cbShowPassword_TextChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbUpPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbUpPassword.UseSystemPasswordChar = false;
            }
        }

        private void cbShowOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (cbShowOldPassword.Checked)
            {
                tbUpOldPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbUpOldPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnMenuAdminLogs_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminLog admin = new AdminLog(userValidation);
            admin.Show();
        }

        private void btnMenuScheduling_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeeScheduling scheduling = new EmployeeScheduling(userValidation);
            scheduling.Show();
        }

        private void btnMenuDepartmentManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            DepartmentManagement department = new DepartmentManagement(userValidation);
            department.Show();
        }

        private void btnMenuRoleManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            RoleManagement role = new RoleManagement(userValidation);
            role.Show();
        }

        private void btnMenuEmployeeManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee_Management employee = new Employee_Management(userValidation);
            employee.Show();
        }

        private void btnMenuStockManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            StockManagement stock = new StockManagement(userValidation);
            stock.Show();
        }

        private void btnMenuSchedule_Click(object sender, EventArgs e)
        {
            this.Close();
            ShoppersonalSchedule shoppersonal = new ShoppersonalSchedule(userValidation);
            shoppersonal.Show();
        }

        private void btnMenuStock_Click(object sender, EventArgs e)
        {
            this.Close();
            ShopPersonnel shop = new ShopPersonnel(userValidation);
            shop.Show();
        }
    }
}

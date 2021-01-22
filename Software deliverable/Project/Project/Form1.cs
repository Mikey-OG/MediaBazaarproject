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
using MySql.Data.X.XDevAPI.Common;
using Project.LGC;

namespace Project
{
    public partial class Form1 : Form
    {
        LogInClass lc;
        bool access = true;
        bool success = false;
        string UserValidation;
        public Form1()
        {
            InitializeComponent();
            lc = new LogInClass();
        }

        public bool LogInUser()
        {
            string employeeUsername = tbUserName.Text;
            string employeePassword = tbPassword.Text;
            success = false;
            try
            {
                if (access == true)
                {

                    UserValidation = lc.PrepareLogIn(employeePassword, employeeUsername);
                    if (UserValidation == "Admin")
                    {
                        Employee_Management em = new Employee_Management(UserValidation);
                        em.Show();
                        success = true;

                    }
                    else
                    {
                        if (UserValidation == "EmployeeManager")
                        {
                            Employee_Management generalEmployeeForm = new Employee_Management(UserValidation);
                            generalEmployeeForm.Show();
                            success = true;
                        }
                        else
                        {
                            if (UserValidation == "StockManager")
                            {
                                StockManagement stockmanager = new StockManagement(UserValidation);
                                stockmanager.Show();
                                success = true;
                            }
                            else
                            {
                                if (UserValidation == "ShopPersonnel")
                                {
                                    ShopPersonnel shopPersonnel = new ShopPersonnel(UserValidation);
                                    shopPersonnel.Show();
                                    success = true;
                                }
                                else
                                {
                                    lc.AddFailedLogInUser(employeePassword, employeeUsername);

                                    if (lc.SuspendAccount() == false)
                                    {
                                        success = false;
                                        MessageBox.Show("Error please check your credentials\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        success = false;
                                        tSuspend.Start();
                                        access = false;
                                        MessageBox.Show("You have exceeded the limit for loginning in please wait for 30seconds before you try again," +
                                        " you will be notified when the timer is over\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                            }
                        }
                    }
                }
                else
                {
                    success = false;
                    MessageBox.Show("You have exceeded the limit for loginning in please wait for 30seconds before you try again," +
                    " you will be notified when the timer is over\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string employeeUsername = tbUserName.Text;
            if (lc.AccountSecurity(employeeUsername) != null)
            {
                ChangePwdForm changePwdForm = new ChangePwdForm(employeeUsername);
                changePwdForm.Show();
                this.Hide();
            }
            else
            {
                if (LogInUser() == true && success == true)
                {
                    Variables.User = tbUserName.Text;
                    this.Hide();
                }
            }

        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void tSuspend_Tick(object sender, EventArgs e)
        {
            tSuspend.Stop();
            access = true;
            lc.RemoveAllFailedAttempts();
            MessageBox.Show("You can now Log in\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserValidation = "Admin";
            if (UserValidation == "Admin")
            {
                Employee_Management em = new Employee_Management(UserValidation);
                em.Show();

            }
            else
            {
                if (UserValidation == "EmployeeManager")
                {
                    Employee_Management em = new Employee_Management(UserValidation);
                    em.Show();
                }
                else
                {
                    if (UserValidation == "StockManager")
                    {
                        StockManagement stockmanager = new StockManagement(UserValidation);
                        stockmanager.Show();
                    }
                    else
                    {
                        if (UserValidation == "ShopPersonnel")
                        {
                            ShopPersonnel shopPersonnel = new ShopPersonnel(UserValidation);
                            shopPersonnel.Show();
                        }
                    }
                }
            }
            //EmployeeScheduling employee = new EmployeeScheduling();
            //employee.Show();
        }

        private void btnEndProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

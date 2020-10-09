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

namespace Project
{
    public partial class Form1 : Form
    {
        string connStr = "server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;";
        MySqlDataAdapter adpt;
        DataTable dt;
        bool success = false;
        GeneralManagement gm;
        string UserValidation;
        public Form1()
        {
            InitializeComponent();
            gm = new GeneralManagement();
        }

        public bool AdminPriviledge()
        {
            success = false;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    string sql = "SELECT * FROM employees WHERE Username = '" + tbUserName.Text.Trim() + "' and Password = '" + tbPassword.Text.Trim() + "' and FormAccess = 'AdminForm';";
                    adpt = new MySqlDataAdapter(sql, conn);
                    dt = new DataTable();
                    adpt.Fill(dt);

                    //this check if the number of rows is equal to 1 then the user exists
                    if (dt.Rows.Count == 1)
                    {
                        UserValidation = "Admin";
                        GeneralEmployeeForm generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
                        this.Hide();
                        generalEmployeeForm.Show();
                        success = true;
                    }
                    else
                    {
                        string sql2 = "SELECT * FROM employees WHERE Username = '" + tbUserName.Text.Trim() + "' and Password = '" + tbPassword.Text.Trim() + "' and FormAccess = 'EmployeeForm';";
                        adpt = new MySqlDataAdapter(sql2, conn);
                        dt = new DataTable();
                        adpt.Fill(dt);

                        //this check if the number of rows is equal to 1 then the user exists
                        if (dt.Rows.Count == 1)
                        {
                            UserValidation = "EmployeeManager";
                            GeneralEmployeeForm generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
                            this.Hide();
                            generalEmployeeForm.Show();
                            success = true;
                        }
                        else
                        {
                            string sql3 = "SELECT * FROM employees WHERE Username = '" + tbUserName.Text.Trim() + "' and Password = '" + tbPassword.Text.Trim() + "' and FormAccess = 'StockManagerForm';";
                            adpt = new MySqlDataAdapter(sql3, conn);
                            dt = new DataTable();
                            adpt.Fill(dt);

                            //this check if the number of rows is equal to 1 then the user exists
                            if (dt.Rows.Count == 1)
                            {
                                UserValidation = "StockManager";
                                StockManagement stockmanager = new StockManagement(UserValidation);
                                this.Hide();
                                stockmanager.Show();
                                success = true;
                            }
                            else
                            {
                                string sql4 = "SELECT * FROM employees WHERE Username = '" + tbUserName.Text.Trim() + "' and Password = '" + tbPassword.Text.Trim() + "' and FormAccess = 'ShopPersonnelForm';";
                                adpt = new MySqlDataAdapter(sql4, conn);
                                dt = new DataTable();
                                adpt.Fill(dt);
                                if (dt.Rows.Count == 1)
                                {
                                    UserValidation = "ShopPersonnel";
                                    ShopPersonnel shopPersonnel = new ShopPersonnel(UserValidation);
                                    this.Hide();
                                    shopPersonnel.Show();
                                    success = true;
                                }
                                else
                                {
                                    success = false;
                                    MessageBox.Show("Error please check your credentials\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (AdminPriviledge() == true && success == true)
            {
                Variables.User = tbUserName.Text;
                this.Hide();
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = false;
            }
        }

    }
}

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
    public partial class Form1 : Form
    {
        string connStr = "server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;";
        MySqlDataAdapter adpt;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        public void AdminPriviledge()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    string sql = "SELECT * FROM employees WHERE Username = '" + tbUserName.Text.Trim() + "' and Password = '" + tbPassword.Text.Trim() + "' and RoleID = 1;";
                    adpt = new MySqlDataAdapter(sql, conn);
                    dt = new DataTable();
                    adpt.Fill(dt);

                    //;this check if the number of rows is equal to 1 then the user exists
                    if (dt.Rows.Count == 1)
                    {
                        Admin adminForm = new Admin();
                        this.Hide();
                        adminForm.Show();
                    }
                    else
                    {
                        string sql2 = "SELECT * FROM employees WHERE Username = '" + tbUserName.Text.Trim() + "' and Password = '" + tbPassword.Text.Trim() + "' and RoleID = 2;";
                        adpt = new MySqlDataAdapter(sql2, conn);
                        dt = new DataTable();
                        adpt.Fill(dt);

                        //;this check if the number of rows is equal to 1 then the user exists
                        if (dt.Rows.Count == 1)
                        {
                            Form2 testForm1 = new Form2();
                            this.Hide();
                            testForm1.Show();
                        }
                        else
                        {
                            string sql3 = "SELECT * FROM employees WHERE Username = '" + tbUserName.Text.Trim() + "' and Password = '" + tbPassword.Text.Trim() + "' and RoleID = 3;";
                            adpt = new MySqlDataAdapter(sql3, conn);
                            dt = new DataTable();
                            adpt.Fill(dt);

                            //;this check if the number of rows is equal to 1 then the user exists
                            if (dt.Rows.Count == 1)
                            {
                                EmployeeManagementForm testForm2 = new EmployeeManagementForm();
                                this.Hide();
                                testForm2.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error please check your credentials\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }





        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminPriviledge();
        }
    }
}

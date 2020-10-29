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
    public partial class GeneralEmployeeForm : Form
    {
        string UserValidation;
        Employee_Management employee_Management;
        public GeneralEmployeeForm(string validation)
        {
            InitializeComponent();
            if(validation == "Admin")
            {
                UserValidation = "Admin";
            }
            else
            {
                if(validation == "EmployeeManager")
                {
                    btnDepartmentManagement.Visible = false;
                    btnRoleManagement.Visible = false;
                    btnViewStock.Visible = false;
                    btnViewShopPersonnel.Visible = false;
                    UserValidation = "EmployeeManager";
                }
            }
        }

        private void btnDepartmentManagement_Click(object sender, EventArgs e)
        {
            DepartmentManagement departmentManagement = new DepartmentManagement(UserValidation);
            departmentManagement.Show();
            this.Hide();
        }

        private void btnRoleManagement_Click(object sender, EventArgs e)
        {
            RoleManagement roleManagement = new RoleManagement(UserValidation);
            roleManagement.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            Employee_Management employee_Management = new Employee_Management(UserValidation);
            employee_Management.Show();
            this.Hide();
        }

        private void btnSchedulingEmployees_Click(object sender, EventArgs e)
        {
            EmployeeScheduling employeeScheduling = new EmployeeScheduling(UserValidation);
            employeeScheduling.Show();
            this.Hide();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            StockManagement stockManagement = new StockManagement(UserValidation);
            stockManagement.Show();
            this.Hide();
        }

        private void GeneralEmployeeForm_Load(object sender, EventArgs e)
        {
            //using (MySqlConnection conn = new MySqlConnection(connStr))
            //{
            //    string sql2 = "SELECT * FROM employees WHERE FormAccess = 'EmployeeForm';";
            //    adpt = new MySqlDataAdapter(sql2, conn);
            //    dt = new DataTable();
            //    adpt.Fill(dt);

            //    if (dt.Rows.Count == 1)
            //    {
            //        btnDepartmentManagement.Visible = false;
            //        btnRoleManagement.Visible = false;
            //        btnViewStock.Visible = false;
            //    }
            //}

            //it checks the username and checks the formpermission it was given
        }

        private void btnViewShopPersonnel_Click(object sender, EventArgs e)
        {
            ShopPersonnel shopPersonnel = new ShopPersonnel(UserValidation);
            shopPersonnel.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can access specified forms by clicking on their corresponding button", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnAdminLog_Click(object sender, EventArgs e)
        {
            AdminLog adminlog = new AdminLog();
            adminlog.Show();
        }
    }
}

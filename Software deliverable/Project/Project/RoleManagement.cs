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
using MySql.Data;
using Project.LGC;
using Project.DAL;

namespace Project
{
    public partial class RoleManagement : Form
    {
        private string userValidation;
        Role role;
        StockManager stock;
        EmployeeManagementDAL gm;
        RoleManagementClass rmc;
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        int roleID;
        public void DeactivateShopPersonnelbtn()
        {
            btnMenuStock.Visible = false;
            btnMenuSchedule.Visible = false;
        }
        public RoleManagement(string validation)
        {
            InitializeComponent();
            if(validation == "Admin")
            {
                DeactivateShopPersonnelbtn();
                userValidation = validation;
            }
            stock = new StockManager();
            gm = new EmployeeManagementDAL();
            rmc = new RoleManagementClass();

            GetAllFormAcess();
            rmc.InitializeListOfClasses();
            dgvRoles.DataSource = rmc.GetAllRoles();
        }

        public void GetAllFormAcess()
        {
            rmc.AddAllFormAccess();
            foreach (var item in rmc.GetAllFormAccess())
            {
                cmbFormAccess.Items.Add(item);
            }
        }

        public void LoadNewData()
        {
            //the code here is to empty the dat grid view and then load in the new data in the list  
            dgvRoles.DataSource = null;
            dgvRoles.Rows.Clear();
            dgvRoles.DataSource = rmc.GetAllRoles();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvRoles.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells[0].Value);
                tbRole.Text = dgvRoles.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmbFormAccess.Text = dgvRoles.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            role = new Role();
            role.RoleName = tbRole.Text;
            role.FormAccess = cmbFormAccess.Text;
            if (rmc.AddRole(role) == true)
            {
                //rm.NewRolesLog(role);
                MessageBox.Show("Information Added", "Role Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNewData();
            }
        }

        public bool RoleRemoveMessageBoxYesNo()
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to remomve this role",
             "Remove role", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                if (dialog == DialogResult.No)
                {
                    return false;
                }
            }
            return false;
        }

        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoleRemoveMessageBoxYesNo() == true)
                {
                    if (rmc.RemoveRole(roleID) == true)
                    {
                        //dm.DepartmentRemovelLog(tbDepartmentName.Text);
                        MessageBox.Show("Information Removed", "Role Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNewData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                role = new Role();
                role.RoleName = tbRole.Text;
                role.FormAccess = cmbFormAccess.Text;
                role.RoleID = roleID;

                if (rmc.UpdateRole(role) == true)
                {
                    //dm.DepartmentUpdateLog(department);
                    MessageBox.Show("Information Updated", "Role Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNewData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //create a yes or no message box here
        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            //GeneralEmployeeForm generalEmployeeForm;
            //try
            //{
            //    generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
            //    generalEmployeeForm.Show();
            //    this.Hide();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this form you can edit and add roles into the system. " +
                " To add you input the name of the role via the textbox and click the add button" +
                " To remove a role you select the role and click remove, " +
                " Note(when a role is selected the entire row will be highlighted blue) " +
                " To update a role you select the role, " +
                "input the new role name via the textbox and finally click update ", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadNewData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVIewEmployeeandRoles_Click(object sender, EventArgs e)
        {
            try
            {
                gm.FIllWithEmployeeAndRole(dgvRoles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Seemorebtn_Click(object sender, EventArgs e)
        {
            stock.SeeMore(dgvRoles, gm.LastSQL, 10);
        }

        private void RowResetbtn_Click(object sender, EventArgs e)
        {
            //stock.MaxRows = 0;
            //stock.SeeMore(dataGridView1, gm.LastSQL,10);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            gm.LogOut(this);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
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

        private void btnMenuPersonalDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateDetailsForm update = new UpdateDetailsForm(userValidation);
            update.Show();
        }

        private void btnMenuStock_Click(object sender, EventArgs e)
        {
            this.Close();
            ShopPersonnel shop = new ShopPersonnel(userValidation);
            shop.Show();
        }
    }
}

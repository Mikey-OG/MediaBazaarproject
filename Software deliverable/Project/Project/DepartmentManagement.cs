using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.LGC;
using Project.DAL;

namespace Project
{
    public partial class DepartmentManagement : Form
    {
        int departmentID = 0;
        string UserValidation;
        StockManager stock;
        EmployeeManagementDAL gm;      
        Department department;
        DepartmentManagementClass dmc;
        public DepartmentManagement()
        {
            InitializeComponent();

            stock = new StockManager();
            gm = new EmployeeManagementDAL();
            dmc = new DepartmentManagementClass();

            dmc.InitializeListOfClasses();
            dgvDepartments.DataSource = dmc.GetAllDepartments();
        }

        public void LoadNewData()
        {
            //the code here is to empty the dat grid view and then load in the new data in the list  
            dgvDepartments.DataSource = null;
            dgvDepartments.Rows.Clear();         
            dgvDepartments.DataSource = dmc.GetAllDepartments();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row;
            try
            {
                row = dgvDepartments.Rows[e.RowIndex];
                departmentID = Convert.ToInt32(row.Cells[0].Value);
                tbDepartmentName.Text = dgvDepartments.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                department = new Department();
                department.DepartmentName = tbDepartmentName.Text;
                if (dmc.AddDepartment(department) == true)
                {
                    //dm.NewDepartmentLog(department);
                    MessageBox.Show("Information Added", "Department Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNewData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool DepartmentRemoveMessageBoxYesNo()
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to remomve this department",
             "Remove department", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void btnRemoveaDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartmentRemoveMessageBoxYesNo() == true)
                {
                    if (dmc.RemoveDepartment(departmentID) == true)
                    {
                        //dm.DepartmentRemovelLog(tbDepartmentName.Text);
                        MessageBox.Show("Information Removed", "Department Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                department = new Department();
                department.DepartmentName = tbDepartmentName.Text;
                department.ID = departmentID;
                if (dmc.UpdateDepartment(department) == true)
                {
                    //dm.DepartmentUpdateLog(department);
                    MessageBox.Show("Information Updated", "Department Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNewData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            GeneralEmployeeForm generalEmployeeForm;
            try
            {
                generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
                generalEmployeeForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this form you can edit and add departments into the system. " +
                " To add you input the name of the department via the textbox and click the add button" +
                " To remove a department you select the department and click remove, " +
                " Note(when a department is selected the entire row will be highlighted blue) " +
                " To update a department you select the department, " +
                "input the new department name via the textbox and finally click update ", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnVIewEmployeeDepartments_Click(object sender, EventArgs e)
        {
            try
            {
                gm.FIllWithEmployeeAndDepartment(dgvDepartments);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RowResetbtn_Click(object sender, EventArgs e)
        {
            //stock.MaxRows = 0;
            //stock.SeeMore(dataGridView1, gm.LastSQL,10);
        }

        private void Seemorebtn_Click(object sender, EventArgs e)
        {
            stock.SeeMore(dgvDepartments, gm.LastSQL,10);
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
            AdminLog admin = new AdminLog();
            admin.Show();
        }

        private void btnMenuScheduling_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeeScheduling scheduling = new EmployeeScheduling();
            scheduling.Show();
        }

        private void btnMenuRoleManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            RoleManagement role = new RoleManagement();
            role.Show();
        }

        private void btnMenuEmployeeManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee_Management employee = new Employee_Management(UserValidation);
            employee.Show();
        }

        private void btnMenuStockManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            StockManagement stock = new StockManagement();
            stock.Show();
        }

        private void btnMenuSchedule_Click(object sender, EventArgs e)
        {
            this.Close();
            ShoppersonalSchedule shoppersonal = new ShoppersonalSchedule();
            shoppersonal.Show();
        }

        private void btnMenuPersonalDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateDetailsForm update = new UpdateDetailsForm();
            update.Show();
        }

        private void btnMenuStock_Click(object sender, EventArgs e)
        {
            this.Close();
            ShopPersonnel shop = new ShopPersonnel();
            shop.Show();
        }
    }
}

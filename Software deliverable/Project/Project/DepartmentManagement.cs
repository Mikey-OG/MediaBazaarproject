using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DepartmentManagement : Form
    {
        string UserValidation;
        GeneralManagement gm;
        private StockManager stock = new StockManager();
        Department department;
        DepartmentManager dm;
        int departmentID = 0;
        public DepartmentManagement(string validation)
        {
            InitializeComponent();
            gm = new GeneralManagement();
            dm = new DepartmentManager();
            dgvDepartments.DataSource = dm.GetAllDepartments();
            if (validation == "Admin")
            {
                UserValidation = "Admin";
            }
            gm.AccountSecurity(gm.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
        }

        public void LoadNewData()
        {
            //the code here is to empty the dat grid view and then load in the new data in the list 
            dgvDepartments.DataSource = null;
            dgvDepartments.Rows.Clear();
            dgvDepartments.DataSource = dm.GetAllDepartments();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row;
            try
            {
                row = dgvDepartments.Rows[e.RowIndex];
                departmentID = Convert.ToInt32(row.Cells[0].Value);
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
                department = new Department(tbDepartmentName.Text);
                if (dm.AddDepartment(department) == true)
                {
                    dm.NewDepartmentLog(department);
                    MessageBox.Show("Information Added", "Department Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNewData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveaDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dm.DepartmentRemoveMessageBoxYesNo() == true)
                {
                    if (dm.RemoveDepartment(departmentID) == true)
                    {
                        dm.DepartmentRemovelLog(tbDepartmentName.Text);
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
                department = new Department(tbDepartmentName.Text);
                department.ID = departmentID;
                if (dm.UpdateDepartment(department) == true)
                {
                    dm.DepartmentUpdateLog(department);
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
            gm.AccountSecurity(gm.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
            //stock.MaxRows = 0;
            //stock.SeeMore(dataGridView1, gm.LastSQL,10);
        }

        private void Seemorebtn_Click(object sender, EventArgs e)
        {
            stock.SeeMore(dgvDepartments, gm.LastSQL,10);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (lbAccountSecurity.Text == "False")
            {
                test testform = new test();
                testform.Show();
            }
            else
            {
                gm.LogOut(this);
            }
        }
    }
}

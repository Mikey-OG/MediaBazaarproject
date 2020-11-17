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
        int departmentID;
        public DepartmentManagement(string validation)
        {
            InitializeComponent();
            gm = new GeneralManagement();
            gm.FillWithDepartments(dataGridView1);
            if(validation == "Admin")
            {
                UserValidation = "Admin";
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                department = new Department(tbDepartmentName.Text);
                if (gm.AddDepartment(department) == true)
                {
                    gm.NewDepartmentLog(department);
                    MessageBox.Show("Information Added", "Department Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                gm.FillWithDepartments(dataGridView1);
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
                if (gm.DepartmentRemoveMessageBoxYesNo() == true)
                {
                    if (gm.RemoveDepartment(departmentID) == true)
                    {
                        gm.DepartmentRemovelLog(tbDepartmentName.Text);
                        MessageBox.Show("Information Removed", "Department Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    gm.FillWithDepartments(dataGridView1);
                }
                else
                {
                    gm.FillWithDepartments(dataGridView1);
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
                if (gm.UpdateDepartment(department, departmentID) == true)
                {
                    gm.DepartmentUpdateLog(department);
                    MessageBox.Show("Information Updated", "Department Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gm.FillWithDepartments(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row;
            try
            {
                row = dataGridView1.Rows[e.RowIndex];
                departmentID = Convert.ToInt32(row.Cells[0].Value);
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
                gm.FillWithDepartments(dataGridView1);
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
                gm.FIllWithEmployeeAndDepartment(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RowResetbtn_Click(object sender, EventArgs e)
        {
            stock.MaxRows = 0;
            stock.SeeMore(dataGridView1, gm.LastSQL,10);
        }

        private void Seemorebtn_Click(object sender, EventArgs e)
        {
            stock.SeeMore(dataGridView1, gm.LastSQL,10);
        }
    }
}

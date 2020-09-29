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

namespace Project
{
    public partial class EmployeeManagementForm : Form
    {
        private EmployeeManagement EmployeeManagement = new EmployeeManagement();
        private int UserID;

        public EmployeeManagementForm()
        {
            InitializeComponent();
            EmployeeManagement.FilltableAllEmployees(AllEmployeeGridView);
            AllEmployeeGridView.Columns[1].HeaderCell.Value = "First Name";
            AllEmployeeGridView.Columns[2].HeaderCell.Value = "Last Name";
            AllEmployeeGridView.Columns[3].HeaderCell.Value = "Department";
            AllEmployeeGridView.Columns[4].HeaderCell.Value = "Role";
            AllEmployeeGridView.Columns[0].Visible = false;
            AllEmployeeGridView.Columns[5].Visible = false;
            AllEmployeeGridView.Columns[6].Visible = false;
            AllEmployeeGridView.Columns[7].Visible = false;
            AllEmployeeGridView.Columns[8].Visible = false;
            AllEmployeeGridView.Columns[9].Visible = false;
            AllEmployeeGridView.Columns[10].Visible = false;
            AllEmployeeGridView.Columns[11].Visible = false;
            AllEmployeeGridView.Columns[12].Visible = false;
            AllEmployeeGridView.Columns[13].Visible = false;
            AllEmployeeGridView.Columns[14].Visible = false;
            AllEmployeeGridView.Columns[15].Visible = false;
            AllEmployeeGridView.Columns[16].Visible = false;
        }

        private void ClearFields()
        {
            tbUserName.Clear();
            tbEmail.Clear();
            tbPassword.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbPhoneNumber.Clear();
            tbNationality.Clear();
            tbCity.Clear();
            tbZipCode.Clear();
            tbAdress.Clear();
            tbSalary.Clear();
            tbDepartmentID.Clear();
            tbRoleID.Clear();
            tbFrom.Clear();
            tbUntil.Clear();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            EmployeeManagement.AddSchedule(UserID, dtDate.Value.ToString(), tbFrom.Text, tbUntil.Text);
            EmployeeManagement.FilltableEmployeeSchedule(EmployeeScheduleGridview, UserID);
            ClearFields();
        }

        private void btnClearFields_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeManagement.AddEmployee(tbUserName.Text, tbEmail.Text, tbPassword.Text, tbFirstName.Text, tbLastName.Text, dtDOB.Value.ToString(), tbPhoneNumber.Text, tbNationality.Text, tbCity.Text, tbZipCode.Text, tbAdress.Text, Convert.ToDouble(tbSalary.Text), Convert.ToInt32(tbDepartmentID.Text), Convert.ToInt32(tbRoleID.Text));
            EmployeeManagement.FilltableAllEmployees(AllEmployeeGridView);
            ClearFields();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            EmployeeManagement.UpdateEmployee(UserID, tbUserName.Text, tbEmail.Text, tbPassword.Text, tbFirstName.Text, tbLastName.Text, dtDOB.Value.ToString(), tbPhoneNumber.Text, tbNationality.Text, tbCity.Text, tbZipCode.Text, tbAdress.Text, Convert.ToDouble(tbSalary.Text), Convert.ToInt32(tbDepartmentID.Text), Convert.ToInt32(tbRoleID.Text));
            EmployeeManagement.FilltableAllEmployees(AllEmployeeGridView);
            ClearFields();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EmployeeManagement.Delete(AllEmployeeGridView, UserID);
            ClearFields();
        }

        private void AllEmployeeGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = AllEmployeeGridView.Rows[e.RowIndex];
            UserID = Convert.ToInt32(row.Cells[0].Value);
            tbUserName.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbEmail.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbPassword.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbFirstName.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbLastName.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtDOB.Value = Convert.ToDateTime(AllEmployeeGridView.Rows[e.RowIndex].Cells[8].Value);
            tbPhoneNumber.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbNationality.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
            tbCity.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            tbZipCode.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
            tbAdress.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[13].Value.ToString();
            tbSalary.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[14].Value.ToString();
            tbDepartmentID.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[15].Value.ToString();
            tbRoleID.Text = AllEmployeeGridView.Rows[e.RowIndex].Cells[16].Value.ToString();
            EmployeeManagement.FilltableEmployeeSchedule(EmployeeScheduleGridview, UserID);
            EmployeeScheduleGridview.Columns[0].Visible = false;
            EmployeeScheduleGridview.Columns[1].HeaderCell.Value = "Date";
            EmployeeScheduleGridview.Columns[2].HeaderCell.Value = "From";
            EmployeeScheduleGridview.Columns[3].HeaderCell.Value = "Until";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}

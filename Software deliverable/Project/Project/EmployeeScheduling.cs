using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAL;
using Project.LGC;

namespace Project
{
    public partial class EmployeeScheduling : Form
    {
        SchedulingManagement scheduling;
        int UserID;

        string userValidation;
        public EmployeeScheduling()
        {
            InitializeComponent();
            scheduling = new SchedulingManagement();
            dtBegin.MinDate = DateTime.Now.Date;
            dtEnd.MinDate = DateTime.Now.Date;
            LoadEmployeeView();
        }

        public void LoadEmployeeView()
        {
            dataViewEmployees.DataSource = scheduling.GetShoppersonal();
            dataViewEmployees.Columns["UserID"].Visible = false;
            dataViewEmployees.Columns["UserName"].Visible = false;
            dataViewEmployees.Columns["AccountSecurity"].Visible = false;
            dataViewEmployees.Columns["DismissDate"].Visible = false;
            dataViewEmployees.Columns["Salary"].Visible = false;
            dataViewEmployees.Columns["HireDate"].Visible = false;
            dataViewEmployees.Columns["DateOfBirth"].Visible = false;
            dataViewEmployees.Columns["Zipcode"].Visible = false;
            dataViewEmployees.Columns["City"].Visible = false;
            dataViewEmployees.Columns["Nationality"].Visible = false;
            dataViewEmployees.Columns["DepartmentID"].Visible = false;
            dataViewEmployees.Columns["RoleID"].Visible = false;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            scheduling.GenerateSchedule(dtBegin.Value.Date, dtEnd.Value.Date, Convert.ToInt32(numEmployeesAShift.Value));
            dtBegin.Value = DateTime.Now.Date;
            dtEnd.Value = DateTime.Now.Date;
            numEmployeesAShift.Value = 1;
        }

        private void btnMenuAdminLogs_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminLog admin = new AdminLog();
            admin.Show();
        }

        private void btnMenuDepartmentManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            DepartmentManagement department = new DepartmentManagement();
            department.Show();
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
            Employee_Management employee = new Employee_Management(userValidation);
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

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            scheduling.AddSchedule(UserID,dtAddRemove.Value.Date.ToString("dd-MM-yyyy"), cbShifts.Text);
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
            scheduling.RemoveSchedule(UserID, dtAddRemove.Value.Date.ToString("dd-MM-yyyy"), cbShifts.Text);
        }

        private void dataViewEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataViewEmployees.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells[14].Value);
            }
        }
    }
}

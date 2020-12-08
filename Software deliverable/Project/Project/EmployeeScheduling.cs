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
    public partial class EmployeeScheduling : Form
    {
        string UserValidation;
        GeneralManagement GeneralManagement;
        private StockManager stock = new StockManager();
        private int UserID, ScheduleID;
        public EmployeeScheduling(string validation)
        {
            InitializeComponent();
            GeneralManagement = new GeneralManagement();
            GeneralManagement.FillWithEmployeeSchedule(DataGridEmployees);
            dtWorkDate.MinDate = DateTime.Today;

            if(validation == "Admin")
            {
                UserValidation = "Admin";
            }
            else
            {
                if(validation == "EmployeeManager")
                {
                    UserValidation = "EmployeeManager";
                }
            }
            GeneralManagement.AccountSecurity(GeneralManagement.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
        }

        private void DataGridEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = DataGridEmployees.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells[0].Value);
                GeneralManagement.FillWithSchedule(DataGridSchedule, UserID);
            }
            catch
            {
                MessageBox.Show("You can't select this row.");
            }
        }

        private void DataGridSchedule_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = DataGridSchedule.Rows[e.RowIndex];
                ScheduleID = Convert.ToInt32(row.Cells[0].Value);
            }
            catch
            {
                MessageBox.Show("You can't select this row.");
            }
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
            if (GeneralManagement.RemoveScheduleMessageBoxYesNo() == true)
            {
                GeneralManagement.RemoveSchedule(ScheduleID);
                GeneralManagement.FillWithSchedule(DataGridSchedule, UserID);
            }
            else
            {
                MessageBox.Show("Schedule not removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            GeneralEmployeeForm generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
            generalEmployeeForm.Show();
            this.Hide();
        }

        private void btnSearchSchedule_Click(object sender, EventArgs e)
        {
            GeneralManagement.FillWithScheduleSearch(DataGridSchedule, cmbSearchShiftTime.Text, dtSearchWorkDate.Value.ToString());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can look up schedules and create/ remove schedules " +
                " 1) The add button requires user to input the required data in the combobox and calender " +
                " 2) The remove button requires user to select the schedule row he wants to delete" +
                " 3) The search button requeres user ti input the required data in the combobox and calender" +
                " 4) Return menu button takes user back to the meu button where he can slect a new form to access", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Seemorebtn_Click(object sender, EventArgs e)
        {
            stock.SeeMore(DataGridEmployees, GeneralManagement.LastSQL,10);
        }

        private void RowResetbtn_Click(object sender, EventArgs e)
        {
            stock.MaxRows = 0;
            GeneralManagement.AccountSecurity(GeneralManagement.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
            stock.SeeMore(DataGridEmployees, GeneralManagement.LastSQL,10);
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
                GeneralManagement.LogOut(this);
            }
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if(GeneralManagement.AddSchedule(UserID, dtWorkDate.Value.ToString(), cmbTimeShift.Text)==true)
            {
                MessageBox.Show("Information Added", "Schedule Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GeneralManagement.FillWithSchedule(DataGridSchedule, UserID);
            }
        }
    }
}

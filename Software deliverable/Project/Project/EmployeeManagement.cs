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
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using Project.LGC;
using Project.DAL;

namespace Project
{
    public partial class Employee_Management : Form
    {
        static string to;
        static Employee_Management em;
        Employee employee;
        //EmployeeManagementDAL emd;
        EmployeeManagementClass emc;
        LogsClass lc;
        private StockManager stock = new StockManager();
        private int UserID;
        private int roleID;
        private int departmentID;
        private string currentEmail;
        private string userValidation;
        public void DeactivateShopPersonnelbtn()
        {
            btnMenuStock.Visible = false;
            btnMenuSchedule.Visible = false;
        }
        public void DeactivateAdminBtn()
        {
            btnMenuAdminLogs.Visible = false;
            btnMenuDepartmentManagement.Visible = false;
            btnMenuRoleManagement.Visible = false;
        }
        public Employee_Management(string validation)
        {
            InitializeComponent();
            em = this;
            //emd = new EmployeeManagementDAL();
            emc = new EmployeeManagementClass();
            lc = new LogsClass();
            if (validation == "EmployeeManager")
            {
                DeactivateAdminBtn();
                DeactivateShopPersonnelbtn();
                btnMenuStockManagement.Visible = false;
                userValidation = validation;
            }
            else
            {
                if (validation == "Admin")
                {
                    DeactivateShopPersonnelbtn();
                    userValidation = validation;
                }
            }
            //to get all the employees
            emc.InitializeListOfClasses();
            GetAllRolesForCmb();
            GetAllDepartmentsForCmb();
            dgvEmployees.DataSource = emc.GetAllEmployees();
            emc.AddAllDismissedEmployees();
        }

        //email
        public void Email()
        {
            string from, pass;
            MailMessage message;
            SmtpClient smtp;

            try
            {
                message = new MailMessage();
                to = tbEmail.Text;
                message.Subject = "Log in Deatils from Group3 Melior";
                message.Body = $"Welcome to Media Baazar, Your username is {tbUserName.Text} and your password is {tbPassword.Text} " +
                    $"please ensure you change your password after your first log in Thank you " +
                    $"Signed Management";
                from = "mediabazzar0fontys@gmail.com";
                pass = "groupMelior3";
                message.To.Add(to);
                message.From = new MailAddress(from);
                smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.Send(message);
            }
            catch (SmtpException se)
            {
                MessageBox.Show("Error\n" + se.Message, "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }

        public void LoadNewData()
        {
            //the code here is to empty the dat grid view and then load in the new data in the list  
            dgvEmployees.DataSource = null;
            dgvEmployees.Rows.Clear();
            dgvEmployees.DataSource = emc.GetAllEmployees();
        }

        private void DataGridEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row;

            try
            {
                row = dgvEmployees.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells[14].Value);
                tbUserName.Text = dgvEmployees.Rows[e.RowIndex].Cells[15].Value.ToString();
                tbEmail.Text = dgvEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
                currentEmail = tbEmail.Text;
                tbFirstName.Text = dgvEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbLastName.Text = dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtDOB.Value = Convert.ToDateTime(dgvEmployees.Rows[e.RowIndex].Cells[9].Value);
                tbPhoneNumber.Text = dgvEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbNationality.Text = dgvEmployees.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbCity.Text = dgvEmployees.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbZipCode.Text = dgvEmployees.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbAdress.Text = dgvEmployees.Rows[e.RowIndex].Cells[11].Value.ToString();
                tbSalary.Text = dgvEmployees.Rows[e.RowIndex].Cells[12].Value.ToString();
                dtDateOfHire.Value = Convert.ToDateTime(dgvEmployees.Rows[e.RowIndex].Cells[10].Value);
                //dtDismissalDate.Value = Convert.ToDateTime(dgvEmployees.Rows[e.RowIndex].Cells[13].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmbDepartmentName.Text = dgvEmployees.Rows[e.RowIndex].Cells[5].Value.ToString();
                //departmentID = ((Role)cmbDepartmentName.SelectedItem).RoleID
                //= Convert.ToInt32(cmbDepartmentName.Text);
                //cmbFormAccess.Text = dgvEmployees.Rows[e.RowIndex].Cells[16].Value.ToString();
                cmbRoleName.Text = dgvEmployees.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

        }

        public void GetAllRolesForCmb()
        {
            emc.AddAllRoles();
            foreach (var item in emc.GetAllRoles())
            {
                cmbRoleName.Items.Add(item);
            }
        }

        public void GetAllDepartmentsForCmb()
        {
            emc.AddAllDepartments();
            foreach (var item in emc.GetAllDepartments())
            {
                cmbDepartmentName.Items.Add(item);
            }
        }
        public void ClassIntializer()
        {
            try
            {
                employee = new Employee(tbUserName.Text, tbFirstName.Text,
        tbLastName.Text, tbNationality.Text, tbCity.Text, tbZipCode.Text,
        dtDOB.Text, dtDateOfHire.Text, tbAdress.Text,
        Convert.ToInt32(tbSalary.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //All button functions
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            //GeneralEmployeeForm generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
            //generalEmployeeForm.Show();
            //this.Hide();
        }

        public bool DissmissMessageBoxYesNo()
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to dismiss this employee",
             "Dismiss", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void btnDismissEmployee_Click(object sender, EventArgs e)
        {
            ClassIntializer();
            try
            {
                employee.DismissDate = dtDismissalDate.Text;
                if (DissmissMessageBoxYesNo() == true)
                {
                    if (emc.DismissEmployee(employee, UserID))
                    {
                        //GeneralManagement.EmployeeDismissalLog(dismissedEmployee);
                        //GeneralManagement.FillWithEmployee(DataGridEmployees);
                        MessageBox.Show("Employee dissmissal date has been added", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNewData();
                        emc.AddAllDismissedEmployees();
                        lc.AddNewEmployeeDismmisalLog(employee);
                    }
                }
                else
                {
                    MessageBox.Show("Employee dissmissal date not added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNewData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int RoleID()
        {
            if (((Role)cmbRoleName.SelectedItem) != null)
            {
                roleID = ((Role)cmbRoleName.SelectedItem).RoleID;
                return roleID;
            }
            return 0;
        }

        public int DepartmentID()
        {
            if (((Department)cmbDepartmentName.SelectedItem) != null)
            {
                departmentID = ((Department)cmbDepartmentName.SelectedItem).ID;
                return departmentID;
            }
            return 0;
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                ClassIntializer();
                if (employee.SetPassword(tbPassword.Text) == false)
                {
                    MessageBox.Show("Please ensure your password" +
                               " possesses at least one lowercase character " +
                               " at least one uppercase character " +
                               " at least one numeric character between 0-9 " +
                               " and is at least 8-15 characters long " +
                               " e.g Mikoko02, Kirill02, lucM2002 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (employee.SetPhoneNO(tbPhoneNumber.Text) == false)
                    {
                        MessageBox.Show("Please ensure your phone number" +
                               " is between 5-15 characters long and" +
                               " has your country code with the symbol" +
                               " + in front e.g +31123456789", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (employee.SetEmail(tbEmail.Text) == false)
                        {
                            MessageBox.Show("Please ensure your email" +
                              " is between 5-10 characters long, contains the symbol @" +
                              " contains an email type(eg gmail, yahoo etc) which is 3-7 long" +
                              " and contains either of the following(.com, .org, .nl)" +
                              " e.g mikel@gmail.com, kirill@yahoo.org, lucMoonen@hotmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (employee.SetRoleID(RoleID()) == false)
                            {
                                MessageBox.Show("Please ensure this employee is given a role before adding",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (employee.SetDepartmentID(DepartmentID()) == false)
                                {
                                    MessageBox.Show("Please ensure this employee is given a department before adding",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if (emc.AddEmployee(employee) == true)
                                    {
                                        Email();
                                        //GeneralManagement.NewEmployeeLog(employee);
                                        //GeneralManagement.FillWithEmployee(DataGridEmployees);
                                        LoadNewData();
                                        lc.AddNewEmployeeLog(employee);
                                        MessageBox.Show("Information Added", "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure all feilds inputted in the textboxes are of the right format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EmployeeUpdate()
        {
            if (emc.UpdateEmployee(employee, UserID) == true)
            {
                //GeneralManagement.EmployeeUpdateLog(employee);
                //GeneralManagement.FillWithEmployee(DataGridEmployees);
                //ClearFields();
                MessageBox.Show("Information Updated", "Employee Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNewData();
            }
        }

        public void AllChecks()
        {
            if (RoleID() != 0)
            {
                if (employee.SetRoleID(RoleID()) == false)
                {
                    MessageBox.Show("Please ensure this employee is given a role before adding",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (DepartmentID() != 0)
                    {

                        if (employee.SetDepartmentID(DepartmentID()) == false)
                        {
                            MessageBox.Show("Please ensure this employee is given a department before adding",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            EmployeeUpdate();
                        }
                    }
                }
            }
            else
            {
                employee.SetRoleID(Convert.ToInt32(cmbRoleName.Text));
                if (DepartmentID() != 0)
                {

                    if (employee.SetDepartmentID(DepartmentID()) == false)
                    {
                        MessageBox.Show("Please ensure this employee is given a department before adding",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EmployeeUpdate();
                    }
                }
                else
                {
                    employee.SetDepartmentID(Convert.ToInt32(cmbDepartmentName.Text));
                    EmployeeUpdate();
                }
            }
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                ClassIntializer();
                if (employee.SetPhoneNO(tbPhoneNumber.Text) == false)
                {
                    MessageBox.Show("Please ensure your phone number" +
                           "is 11 characters long and" +
                           "has the country code +31", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (employee.SetEmail(tbEmail.Text) == false)
                    {
                        MessageBox.Show("Please ensure your email" +
                          " is between 5-20 characters long, contains the symbol @" +
                          " contains an email type(eg gmail, yahoo etc) which is 3-7 long" +
                          " and contains either of the following(.com, .org, .nl)" +
                          " eg(mikel@gmail.com, kirill@yahoo.org, lucMoonen@hotmail.com)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        AllChecks();
                        lc.AddNewEmployeeUpdateLog(employee);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure all feilds inputted in the textboxes are of the right format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewDismissedEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEmployees.DataSource = null;
                dgvEmployees.Rows.Clear();
                dgvEmployees.DataSource = emc.GetAllDismissedEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNewData();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here user can edit or add employees " +
                " 1) The add button requires user to input the required data in textboxes and calender " +
                "(Note: when adding an employee please do not pick a date of dismissal but all other fields should be inputed/picked) " +
                " 2) The update employee button requires user to select the employee row he wants to update and " +
                "change the information he wants via the textboxes, when the employee row is selected " +
                " all information about that employee will be displayed in their corresponding textboxes" +
                " (Note when the row of an employee is selected the row will be highlighted blue" +
                " 3) The dismiss button requires the user to select the employee to be dismissed and " +
                " input a dismiss date, finally click on the dismiss button and the employee will have " +
                " a dismiss date " +
                " 4) The clear fields button removes all the existing data in the textboxes " +
                " 5) Return menu button takes user back to the meu button where he can slect a new form to access", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSearchForEmployee_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    emd.Search(dgvEmployees, tbUserFirstName.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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

        private void btnMenuRoleManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            RoleManagement role = new RoleManagement(userValidation);
            role.Show();
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

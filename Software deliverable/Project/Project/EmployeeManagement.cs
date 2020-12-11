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

namespace Project
{
    public partial class Employee_Management : Form
    {
        static string to;
        static Employee_Management em;
        string UserValidation;
        Employee employee;
        Department department;
        Roles role;
        private StockManager stock = new StockManager();
        GeneralManagement GeneralManagement;
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        private int UserID;
        public Employee_Management(string validation)
        {
            InitializeComponent();
            em = this;
            GeneralManagement = new GeneralManagement();
            GeneralManagement.FillWithEmployee(DataGridEmployees);
            FillDepartmentComboBox();
            FillFormAccessComboBox();
            FillRoleNameComboBox();
            if (validation == "Admin")
            {
                UserValidation = "Admin";
            }
            else
            {
                if (validation == "EmployeeManager")
                {
                    UserValidation = "EmployeeManager";
                }
            }
            GeneralManagement.AccountSecurity(GeneralManagement.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
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

        //Form load functions
        public void FillDepartmentComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM departments;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sDepartmentName = dr.GetString("DepartmentName");
                    cmbDepartmentName.Items.Add(sDepartmentName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void FillFormAccessComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM roles GROUP BY FormAccess;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sFormName = dr.GetString("FormAccess");
                    cmbFormAccess.Items.Add(sFormName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void FillRoleNameComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM roles GROUP BY RoleName;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sRoleName = dr.GetString("RoleName");
                    cmbRoleName.Items.Add(sRoleName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
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

        private void DataGridEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row;

            try
            {
                row = DataGridEmployees.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells[0].Value);
                tbUserName.Text = DataGridEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbEmail.Text = DataGridEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbPassword.Text = DataGridEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbFirstName.Text = DataGridEmployees.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbLastName.Text = DataGridEmployees.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtDOB.Value = Convert.ToDateTime(DataGridEmployees.Rows[e.RowIndex].Cells[6].Value);
                tbPhoneNumber.Text = DataGridEmployees.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbNationality.Text = DataGridEmployees.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbCity.Text = DataGridEmployees.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbZipCode.Text = DataGridEmployees.Rows[e.RowIndex].Cells[10].Value.ToString();
                tbAdress.Text = DataGridEmployees.Rows[e.RowIndex].Cells[11].Value.ToString();
                tbSalary.Text = DataGridEmployees.Rows[e.RowIndex].Cells[12].Value.ToString();
                dtDateOfHire.Value = Convert.ToDateTime(DataGridEmployees.Rows[e.RowIndex].Cells[13].Value);
                dtDismissalDate.Value = Convert.ToDateTime(DataGridEmployees.Rows[e.RowIndex].Cells[14].Value);

            }
            catch (InvalidCastException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmbDepartmentName.Text = DataGridEmployees.Rows[e.RowIndex].Cells[15].Value.ToString();
                cmbFormAccess.Text = DataGridEmployees.Rows[e.RowIndex].Cells[16].Value.ToString();
                cmbRoleName.Text = DataGridEmployees.Rows[e.RowIndex].Cells[17].Value.ToString();
            }

        }

        public void ClassIntializer()
        {

            employee = new Employee(tbUserName.Text, tbFirstName.Text,
            tbLastName.Text, tbNationality.Text, tbCity.Text, tbZipCode.Text,
            dtDOB.Text, dtDateOfHire.Text, tbAdress.Text,
            cmbFormAccess.Text, Convert.ToInt32(tbSalary.Text));

            department = new Department(cmbDepartmentName.Text);
            role = new Roles(cmbRoleName.Text);
        }



        //All button functions
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            GeneralEmployeeForm generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
            generalEmployeeForm.Show();
            this.Hide();
        }

        private void btnDismissEmployee_Click(object sender, EventArgs e)
        {
            Employee dismissedEmployee;
            try
            {
                dismissedEmployee = new Employee(tbUserName.Text, tbFirstName.Text,
                      tbLastName.Text, tbNationality.Text, tbCity.Text, tbZipCode.Text,
                       dtDOB.Text, dtDateOfHire.Text, tbAdress.Text,
                       cmbFormAccess.Text, Convert.ToInt32(tbSalary.Text), dtDismissalDate.Text);
                if (GeneralManagement.DissmissMessageBoxYesNo() == true)
                {
                    if (GeneralManagement.RemoveEmployee(dismissedEmployee, UserID))
                    {
                        GeneralManagement.EmployeeDismissalLog(dismissedEmployee);
                        GeneralManagement.FillWithEmployee(DataGridEmployees);
                        MessageBox.Show("Employee dissmissal date has been added", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    GeneralManagement.FillWithEmployee(DataGridEmployees);
                    MessageBox.Show("Employee dissmissal date not added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            if (GeneralManagement.AddEmployee(employee, department, role) == true)
                            {
                                Email();
                                GeneralManagement.NewEmployeeLog(employee);
                                GeneralManagement.FillWithEmployee(DataGridEmployees);
                                ClearFields();
                                MessageBox.Show("Information Added", "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("please ensure your phone number is in numeric format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                ClassIntializer();

                if (employee.SetPassword(tbPassword.Text) == false)
                {
                    MessageBox.Show("Please ensure your password" +
                               " possesses at least one lowercase character " +
                               " at least one uppercase charater " +
                               " at least one numeric character between 0-9 " +
                               " and is at least 8-15 characters long " +
                               " e.g (Mikoko02, Kirill02, lucM2002) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
                            if (GeneralManagement.UpdateEMployee(employee, department, role, UserID) == true)
                            {
                                GeneralManagement.EmployeeUpdateLog(employee);
                                GeneralManagement.FillWithEmployee(DataGridEmployees);
                                ClearFields();
                                MessageBox.Show("Information Added", "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("please ensure your phone number is in numeric format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                GeneralManagement.FillWithDIsmissedEmployee(DataGridEmployees);
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
                GeneralManagement.FillWithEmployee(DataGridEmployees);
                GeneralManagement.AccountSecurity(GeneralManagement.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                GeneralManagement.Search(DataGridEmployees, tbUserFirstName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Seemorebtn_Click(object sender, EventArgs e)
        {
            stock.SeeMore(DataGridEmployees,GeneralManagement.LastSQL,10);
        }

        private void RowResetbtn_Click(object sender, EventArgs e)
        {
            stock.MaxRows = 0;
            stock.SeeMore(DataGridEmployees, GeneralManagement.LastSQL,10);
            GeneralManagement.AccountSecurity(GeneralManagement.GetUsername(Convert.ToString(Variables.User)), lbAccountSecurity);
        }


        private void btnOpenAdminLog_Click(object sender, EventArgs e)
        {
            //works
            AdminLog adminlog = new AdminLog();
            adminlog.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(lbAccountSecurity.Text == "False")
            {
                test testform = new test();
                testform.Show();
            }
            else
            {
                GeneralManagement.LogOut(this);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    label19.Text = GeneralManagement.LastSQL;
        //}
    }
}

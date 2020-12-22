using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Project
{
    public class GeneralManagement : IEmployeeManage, IStockManage, IScheduleManage
    {
        private string log;
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        private Encryption Cry = new Encryption();
        MySqlDataAdapter adpt;
        public string LastSQL = $"";
        DataTable dt;
        MySqlDataReader dr;
        DataSet ds = new DataSet();
        MySqlCommand cmd;
        Stack<Logs> deletedLogs;

        public GeneralManagement()
        {
            deletedLogs = new Stack<Logs>();
        }

        public bool EmployeeDoesNotExist(Employee employee)
        {
            conn.Open();
            string sql = "SELECT * FROM employees WHERE Password = '" + employee.GetPassword() + "'";
            cmd = new MySqlCommand(sql, conn);
            LastSQL = sql;
            adpt = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adpt.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Password already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool AddEmployee(Employee employee, Department department, Roles role)
        {
            try
            {
                if(EmployeeDoesNotExist(employee) == true)
                {
                    string sql = "INSERT INTO employees (UserName, Email, Password, FirstName, LastName, DateOfBirth, PhoneNumber, Nationality, City, ZipCode, Adress, " +
                        "Salary, DateOfHire, DepartmentName, FormAccess, RoleName, AccountSecure)" +
                        " VALUES(@UserName, @Email, @Password, @FirstName, @LastName, @DateOfBirth, @PhoneNumber, @Nationality, @City, @ZipCode, @Adress, @Salary," +
                        " @DateOfHire, @DepartmentName, @FormAccess, @RoleName, FALSE)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserName", employee.UserName);
                    cmd.Parameters.AddWithValue("@Email", employee.GetEmail());
                    string pass = Cry.Encrypt(employee.GetPassword());
                    cmd.Parameters.AddWithValue("@Password", pass);
                    cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                    cmd.Parameters.AddWithValue("@PhoneNumber", employee.GetPhoneNo());
                    cmd.Parameters.AddWithValue("@Nationality", employee.Nationality);
                    cmd.Parameters.AddWithValue("@City", employee.City);
                    cmd.Parameters.AddWithValue("@ZipCode", employee.Zipcode);
                    cmd.Parameters.AddWithValue("@Adress", employee.Address);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@DateOfHire", employee.HireDate);
                    cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                    cmd.Parameters.AddWithValue("@FormAccess", employee.FormAccess);
                    cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }


        public bool AddSchedule(int UserID, string Date, string TimeShift)
        {
            try
            {
                conn.Open();
                int space1 = Date.IndexOf(' ');
                string DateSubstring = Date.Substring(0, space1);
                cmd = new MySqlCommand($"INSERT INTO schedules (UserID, WorkDate, TimeShift) VALUES (@UserID, @WorkDate, @TimeShift)", conn);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@WorkDate", DateSubstring);
                cmd.Parameters.AddWithValue("@TimeShift", TimeShift);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool UpdateEMployee(Employee employee, Department department, Roles role, int UserID)
        {
            try
            {
                if(EmployeeDoesNotExist(employee) == true)
                {
                    cmd = new MySqlCommand("UPDATE employees SET UserName= @UserName, Email= @Email, Password= @Password, FirstName= @FirstName, LastName= @LastName, " +
                        "DateOfBirth= @DateOfBirth, PhoneNumber= @PhoneNumber, Nationality= @Nationality, City= @City, ZipCode= @ZipCode, Adress= @Adress, Salary= @Salary," +
                        " DateOfHire= @DateOfHire, DepartmentName= @DepartmentName, FormAccess= @FormAccess, RoleName= @RoleName WHERE UserID =@UserID;", conn);
                    cmd.Parameters.AddWithValue("@UserName", employee.UserName);
                    cmd.Parameters.AddWithValue("@Email", employee.GetEmail());
                    cmd.Parameters.AddWithValue("@Password", Cry.Encrypt(employee.GetPassword()));
                    cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                    cmd.Parameters.AddWithValue("@PhoneNumber", employee.GetPhoneNo());
                    cmd.Parameters.AddWithValue("@Nationality", employee.Nationality);
                    cmd.Parameters.AddWithValue("@City", employee.City);
                    cmd.Parameters.AddWithValue("@ZipCode", employee.Zipcode);
                    cmd.Parameters.AddWithValue("@Adress", employee.Address);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@DateOfHire", employee.HireDate);
                    cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                    cmd.Parameters.AddWithValue("@FormAccess", employee.FormAccess);
                    cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                    cmd.Parameters.AddWithValue("@UserID", UserID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
            return false;
        }


        public void FillDataGridTable(string sql, DataGridView dataGrid)
        {
            conn.Open();
            LastSQL = sql;
            adpt = new MySqlDataAdapter(sql, conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGrid.DataSource = dt;
        }


        public void FillWithEmployee(DataGridView dataGrid)
        {
            try
            {
                string sql = "SELECT * FROM employees LIMIT 10";
                FillDataGridTable(sql, dataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }



        public void FillWithSchedule(DataGridView dataGrid, int UserID)
        {
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM schedules WHERE (UserID='{UserID}')";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void FillWithStock(DataGridView dataGrid)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM stockinventory";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void FillWithScheduleSearch(DataGridView dataGrid, string ShiftTime, string WorkDate)
        {
            try
            {
                int index = WorkDate.IndexOf(" ");
                string Workdate = WorkDate.Substring(0, index);
                conn.Open();
                string sql = $"SELECT * FROM schedules WHERE WorkDate='{Workdate}' AND TimeShift='{ShiftTime}'";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void FillWithEmployeeSchedule(DataGridView dataGrid)
        {
            try
            {
                conn.Open();
                string sql = "SELECT UserID, FirstName, LastName, DepartmentName, RoleName FROM employees WHERE DismissalDate IS NULL";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void FillWithDIsmissedEmployee(DataGridView dataGrid)
        {
            try
            {
                string sql = "SELECT * FROM employees WHERE DismissalDate IS NOT NULL";
                FillDataGridTable(sql, dataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void FIllWithEmployeeAndDepartment(DataGridView dataGrid)
        {
            try
            {
                string sql = "SELECT E.UserName, D.DepartmentName FROM employees AS E INNER JOIN departments D ON E.DepartmentName = D.DepartmentName";
                FillDataGridTable(sql, dataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void FIllWithEmployeeAndRole(DataGridView dataGrid)
        {
            try
            {
                string sql = "SELECT E.Username, R.RoleName, R.FormAccess FROM employees As E INNER JOIN roles As R ON E.RoleName = R.RoleName";
                FillDataGridTable(sql, dataGrid);           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void FillWithLogs(ListBox listbox)
        {
            conn.Open();
            string sql = "SELECT * FROM logs";
            cmd = new MySqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listbox.Items.Add(dr["Logs"].ToString());
            }

        }
        public bool RemoveEmployee(Employee employee, int UserID)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand($"UPDATE employees SET  DismissalDate= @DismissalDate WHERE UserID = @userID", conn);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@DismissalDate", employee.DismissDate);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
            return false;
        }



        public void RemoveSchedule(int ScheduleID)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand($"DELETE FROM schedules WHERE ScheduleID= @ScheduleID", conn);
                cmd.Parameters.AddWithValue("@ScheduleID", ScheduleID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public bool RemoveScheduleMessageBoxYesNo()
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to remove this schedule",
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


        public void ChangePassword(string UserName, string Password)
        {
            try
            {
                if (Regex.IsMatch(Password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$"))
                {
                    conn.Open();
                    cmd = new MySqlCommand($"UPDATE employees SET Password= @Password, AccountSecure = True WHERE UserName = @UserName", conn);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Cry.Encrypt(Password));
                    cmd.ExecuteNonQuery();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public bool ChangePasswordMessageBoxYesNo()
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to change your password",
             "Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        public void Search(DataGridView dataGrid, string name)
        {
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM employees WHERE FirstName LIKE '%{name}%';";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        //TRANSACTION LOGS
        //Admin page logs
        public void NewEmployeeLog(Employee employee)
        {
            try
            {
                conn.Open();
                log = $"New employee {employee.FirstName} {employee.LastName} has been added, Time of addition";
                Logs logs = new Logs(log, DateTime.Now);           
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", logs.ToString());
                cmd.ExecuteNonQuery();    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void EmployeeUpdateLog(Employee employee)
        {
            try
            {
                conn.Open();
                log = $"Employee {employee.FirstName} {employee.LastName} records were updated, Time of update";
                Logs logs = new Logs(log, DateTime.Now);
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", logs.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void EmployeeDismissalLog(Employee employee)
        {
            try
            {
                conn.Open();
                log = $"Employee {employee.FirstName} {employee.LastName} was Dismissed, Time of dismissal";
                Logs logs = new Logs(log, DateTime.Now);
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", logs.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public string GetUsername(string UserName)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand($"SELECT LastName FROM employees WHERE UserName = @UserName", conn);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.ExecuteNonQuery();
                return UserName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
            return UserName;
        }

        public void AccountSecurity(string AcctUsername, Label label)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand($"SELECT AccountSecure FROM employees WHERE UserName = @UserName", conn);
                cmd.Parameters.AddWithValue("@UserName", AcctUsername);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label.Text = dr["AccountSecure"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void RemoveLog(Logs logs)
        {
            conn.Open();
            cmd = new MySqlCommand("DELETE FROM logs WHERE Logs=@LogName", conn);
            cmd.Parameters.AddWithValue("@LogName", logs.NameOfLog);
            cmd.ExecuteNonQuery();
            deletedLogs.Push(logs);
        }
        public void LogOut(Form form)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            form.Hide();
        }
    }
}

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
    public class GeneralManagement : IEmployeeManage, IStockManage
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

        public bool AddEmployee(Employee employee, Department department, Roles role)
        {
            try
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
                }
                else
                {
                    cmd = new MySqlCommand("INSERT INTO employees (UserName, Email, Password, FirstName, LastName, DateOfBirth, PhoneNumber, Nationality, City, ZipCode, Adress, Salary, DateOfHire, DepartmentName, FormAccess, RoleName) VALUES(@UserName, @Email, @Password, @FirstName, @LastName, @DateOfBirth, @PhoneNumber, @Nationality, @City, @ZipCode, @Adress, @Salary, @DateOfHire, @DepartmentName, @FormAccess, @RoleName)", conn);
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
        public bool AddRole(Roles role, string fileAccess)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM roles WHERE RoleName = '" + role.RoleName + "'";
                LastSQL = sql;
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Role Already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.Clear();
                }
                else
                {
                    cmd = new MySqlCommand("INSERT INTO roles (RoleName, FormAccess, LogTime_Date) VALUES(@RoleName, @FormAccess, CURRENT_TIMESTAMP)", conn);
                    cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                    cmd.Parameters.AddWithValue("@FormAccess", fileAccess);
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

        public bool AddDepartment(Department department)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM departments WHERE DepartMentName = '" + department.DepartmentName + "'";
                LastSQL = sql;
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Department Already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.Clear();
                }
                else
                {
                    cmd = new MySqlCommand("INSERT INTO departments (DepartmentName) VALUES( @DepartmentName)", conn);
                    cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
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
                conn.Open();
                string sql = "SELECT * FROM employees WHERE Password = '" + employee.GetPassword() + "'";
                LastSQL = sql;
                cmd = new MySqlCommand(sql,conn);
                adpt = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Please User Already exists with this FormAccess and Username please change one  of them ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.Clear();
                }
                else
                {
                    cmd = new MySqlCommand("UPDATE employees SET UserName= '" + employee.UserName + "', Email= '" + employee.GetEmail() + "', Password= '" + employee.GetPassword() + "', FirstName= '" + employee.FirstName + "', LastName= '" + employee.LastName + "', DateOfBirth= '" + employee.DateOfBirth + "', PhoneNumber= '" + employee.GetPhoneNo() + "', Nationality= '" + employee.Nationality + "', City= '" + employee.City + "', ZipCode= '" + employee.Zipcode + "', Adress= '" + employee.Address + "', Salary= '" + employee.Salary + "', DateOfHire= '" + employee.HireDate + "', DepartmentName= '" + department.DepartmentName + "', FormAccess= '" + employee.FormAccess + "', RoleName= '" + role.RoleName + "' WHERE UserID ='" + UserID + "';", conn);
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

        public bool UpdateRole(Roles role, string fileAccess, int roleID)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM roles WHERE RoleName = '" + role.RoleName + "'";
                LastSQL = sql;
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Role Already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.Clear();
                }
                else
                {
                    cmd = new MySqlCommand($"UPDATE roles SET RoleName= @RoleName, FormAccess= @FormAccess WHERE RoleID = @roleID", conn);
                    cmd.Parameters.AddWithValue("@roleID", roleID);
                    cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                    cmd.Parameters.AddWithValue("@FormAccess", fileAccess);
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

        public bool UpdateDepartment(Department department, int departmentID)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM departments WHERE DepartMentName = '" + department.DepartmentName + "'";
                LastSQL = sql;
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Department Already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.Clear();
                }
                else
                {
                    cmd = new MySqlCommand($"UPDATE departments SET DepartmentName= @DepartmentName WHERE DepartmentID = @departmentID", conn);
                    cmd.Parameters.AddWithValue("@DepartmentID", departmentID);
                    cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
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

        public void FillWithEmployee(DataGridView dataGrid)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM employees";
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
        public void FillWithRoles(DataGridView dataGrid)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM roles";
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


        public void FillWithDepartments(DataGridView dataGrid)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM departments";
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
                conn.Open();
                string sql = "SELECT * FROM employeeS WHERE DismissalDate IS NOT NULL";
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

        public void FIllWithEmployeeAndDepartment(DataGridView dataGrid)
        {
            try
            {
                conn.Open();
                string sql = "SELECT E.UserName, D.DepartmentName FROM employees AS E INNER JOIN departments D ON E.DepartmentName = D.DepartmentName";
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

        public void FIllWithEmployeeAndRole(DataGridView dataGrid)
        {
            try
            {
                conn.Open();
                string sql = "SELECT E.Username, R.RoleName, R.FormAccess FROM employees As E INNER JOIN roles As R ON E.RoleName = R.RoleName";
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

        public bool RemoveRole(int roleID)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("DELETE FROM roles WHERE RoleID=@RoleID", conn);
                cmd.Parameters.AddWithValue("@RoleID", roleID);
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

        public bool RemoveDepartment(int departmentID)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("DELETE FROM departments WHERE DepartmentID=@DepartmentID", conn);
                cmd.Parameters.AddWithValue("@DepartmentID", departmentID);
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

        public void ChangePassword(string UserName, string Password)
        {
            try
            {
                if (Regex.IsMatch(Password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$"))
                {
                    conn.Open();
                    cmd = new MySqlCommand($"UPDATE employees SET Password= @Password WHERE UserName = @UserName", conn);
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
                log = $"New employee {employee.FirstName} {employee.LastName} has been added, Time of addition {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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
                log = $"Employee {employee.FirstName} {employee.LastName} records were updated, Time of update {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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
                log = $"Employee {employee.FirstName} {employee.LastName} was Dismissed, Time of dismissal {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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

        //Role page logs
        public void NewRolesLog(Roles role)
        {
            try
            {
                conn.Open();
                log = $"New role {role.RoleName} has been added, Time of addition {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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

        public void RoleUpdateLog(Roles role)
        {
            try
            {
                conn.Open();
                log = $"Role {role.RoleName} was updated, Time of update {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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

        public void RoleRemovelLog(string roleName)
        {
            try
            {
                conn.Open();
                log = $"Role {roleName} was removed, Time of removal {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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

        //Department Logs
        public void NewDepartmentLog(Department department)
        {
            try
            {
                conn.Open();
                log = $"New Department {department.DepartmentName} has been added, Time of addition {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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

        public void DepartmentUpdateLog(Department department)
        {
            try
            {
                conn.Open();
                log = $"Department {department.DepartmentName} was updated, Time of update {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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

        public void DepartmentRemovelLog(string departmentName)
        {
            try
            {
                conn.Open();
                log = $"Department {departmentName} was removed, Time of removal {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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
    }
}

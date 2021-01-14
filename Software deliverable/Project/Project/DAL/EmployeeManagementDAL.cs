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
using Project.LGC;


namespace Project.DAL
{
    public class EmployeeManagementDAL : BaseDAL, IStockManage, IScheduleManage
    {
        private string log;
        DataTable dt;
        Stack<Logs> deletedLogs;
        public string LastSQL = $"";
        private Encryption Cry;
        private List<Employee> allEmployeesInDatabase;
        private List<Role> allRoles;
        private List<Department> allDepartments;
        public EmployeeManagementDAL()
        {
            base.CreateConnection();
            Cry = new Encryption();
            deletedLogs = new Stack<Logs>();
            allEmployeesInDatabase = new List<Employee>();
            allRoles = new List<Role>();
            allDepartments = new List<Department>();
        }

        public void AccountSecurity(string AcctUsername, Label label)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand($"SELECT AccountSecure FROM employee WHERE UserName = @UserName", conn);
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

        public int ReturnRow(string sql)
        {
            LastSQL = sql;
            adpt = new MySqlDataAdapter(cmd);
            adpt.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            return i;
        }
        public bool EmployeeDoesNotExist(Employee employee)
        {
            string sql = "SELECT * FROM employee WHERE UserName = @Username";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", employee.UserName);
            if (ReturnRow(sql) > 0)
            {
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UniqueEmail(Employee employee)
        {
            string sql = "SELECT * FROM employee WHERE Email = @Email";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            if (ReturnRow(sql) > 0)
            {
                MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool EmailUpdateIsUnique(Employee employee, int userID)
        {
            string sql = "SELECT * FROM employee WHERE NOT UserID = @UserID AND Email = @Email";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            if (ReturnRow(sql) > 0)
            {
                MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UsernameUpdateIsUnique(Employee employee, int userID)
        {
            string sql = "SELECT * FROM employee WHERE NOT UserID = @UserID AND UserName = @UserName";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.AddWithValue("@UserName", employee.UserName);
            if (ReturnRow(sql) > 0)
            {
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }



        //this is to add an employee
        public bool AddEmployeeToDatabase(Employee employee)
        {
            try
            {
                conn.Open();
                if (EmployeeDoesNotExist(employee) == true)
                {
                    if (UniqueEmail(employee) == true)
                    {
                        string sql = "INSERT INTO employee (UserName, Email, Password, FirstName, LastName, DateOfBirth, PhoneNumber, Nationality, City, ZipCode, Adress, " +
                            "Salary, DateOfHire, DepartmentID, RoleID, AccountSecure)" +
                            " VALUES(@UserName, @Email, @Password, @FirstName, @LastName, @DateOfBirth, @PhoneNumber, @Nationality, @City, @ZipCode, @Adress, @Salary," +
                            " @DateOfHire, @DepartmentID, @RoleID, @AccountSecure)";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@UserName", employee.UserName);
                        cmd.Parameters.AddWithValue("@Email", employee.Email);
                        string pass = Cry.Encrypt(employee.GetPassword());
                        cmd.Parameters.AddWithValue("@Password", pass);
                        cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                        cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNo);
                        cmd.Parameters.AddWithValue("@Nationality", employee.Nationality);
                        cmd.Parameters.AddWithValue("@City", employee.City);
                        cmd.Parameters.AddWithValue("@ZipCode", employee.Zipcode);
                        cmd.Parameters.AddWithValue("@Adress", employee.Address);
                        cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@DateOfHire", employee.HireDate);
                        cmd.Parameters.AddWithValue("@DepartmentID", employee.DepartmentID);
                        cmd.Parameters.AddWithValue("@RoleID", employee.RoleID);
                        cmd.Parameters.AddWithValue("@AccountSecure", employee.AccountSecurity);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
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

        public bool DismissEmployeeInDatabase(Employee employee, int UserID)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE employees SET  DismissalDate = @DismissalDate WHERE UserID = @UserID";
                cmd = new MySqlCommand(sql, conn);
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

        public bool UpdateEmployeeInDatabase(Employee employee, int UserID)
        {
            try
            {
                conn.Open();
                if (UsernameUpdateIsUnique(employee, UserID) == true)
                {
                    if (EmailUpdateIsUnique(employee, UserID) == true)
                    {

                        string sql = "UPDATE employee SET UserName = @UserName, Email = @Email, FirstName = @FirstName, LastName = @LastName, " +
                        "DateOfBirth = @DateOfBirth, PhoneNumber = @PhoneNumber, Nationality = @Nationality, City = @City, " +
                        "ZipCode = @ZipCode, Adress = @Address, Salary = @Salary, DateOfHire = @HireDate, DepartmentID = @DepartmentID," +
                        "RoleID = @RoleID WHERE UserID = @UserID";

                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@UserName", employee.UserName);
                        cmd.Parameters.AddWithValue("@Email", employee.Email);
                        cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                        cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNo);
                        cmd.Parameters.AddWithValue("@Nationality", employee.Nationality);
                        cmd.Parameters.AddWithValue("@City", employee.City);
                        cmd.Parameters.AddWithValue("@ZipCode", employee.Zipcode);
                        cmd.Parameters.AddWithValue("@Address", employee.Address);
                        cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
                        cmd.Parameters.AddWithValue("@DepartmentID", employee.DepartmentID);
                        cmd.Parameters.AddWithValue("@RoleID", employee.RoleID);
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.ExecuteNonQuery();

                        //error doesnt go tot the return value meanign it failed to wron the sql query 
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
            return false;
        }

        //this is to prevent a employee from being added to the list
        //if that employee already exists
        public bool EmployeeDoesNotExistInDtbList(Employee employee)
        {
            if (allEmployeesInDatabase.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (var item in allEmployeesInDatabase)
                {
                    if (item.Email == employee.Email)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        //Database list logic
        //this is to add the data gotten from the database into a list 
        public void AddToDtbListOfEmployees()
        {
            try
            {
                conn.Open();
                //sql code for selecting all th data from the table 
                string sql = "SELECT * FROM employee";
                cmd = new MySqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                //this is to loop through the results 
                while (dr.Read())
                {
                    bool addToDtbList = true;
                    //here we are changing all results into objects employee
                    Employee employee = new Employee(dr[1].ToString(), dr[4].ToString(), dr[5].ToString(), dr[8].ToString(),
                        dr[9].ToString(), dr[10].ToString(), dr[6].ToString(), dr[13].ToString(), dr[11].ToString(),
                        Convert.ToInt32(dr[12]));
                    employee.UserID = Convert.ToInt32(dr[0]);
                    if (employee.SetDepartmentID(Convert.ToInt32(dr[15])) != true)
                    {
                        addToDtbList = false;
                    }
                    if (employee.SetRoleID(Convert.ToInt32(dr[16])) != true)
                    {
                        addToDtbList = false;
                    }
                    if (employee.SetPhoneNO(dr[7].ToString()) == false)
                    {
                        addToDtbList = false;
                    }
                    if (employee.SetEmail(dr[2].ToString()) == false)
                    {
                        addToDtbList = false;
                    }

                    if (addToDtbList == true)
                    {
                        if (EmployeeDoesNotExistInDtbList(employee) == true)
                        {
                            //once changed into object department we add into a list
                            allEmployeesInDatabase.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public bool UpdateInDtbListOfEmployees(Employee employee, int userID)
        {
            //go through the list of database departments
            foreach (var item in allEmployeesInDatabase)
            {
                //if any item of the list of database roles has the same id of the role the user has inputted
                if (item.UserID == userID)
                {
                    //change that role name to the new role name inputted by the user
                    item.UserName = employee.UserName;
                    item.SetEmail(employee.Email);
                    item.FirstName = employee.FirstName;
                    item.LastName = employee.LastName;
                    item.DateOfBirth = employee.DateOfBirth;
                    item.SetPhoneNO(employee.PhoneNo);
                    item.Nationality = employee.Nationality;
                    item.City = employee.City;
                    item.Zipcode = employee.Zipcode;
                    item.Address = employee.Address;
                    item.Salary = employee.Salary;
                    item.HireDate = employee.HireDate;
                    item.DismissDate = employee.DismissDate;
                    item.SetDepartmentID(employee.DepartmentID);
                    item.SetRoleID(employee.RoleID);
                    //once this is done and gotten end the operation by returning true;
                    return true;
                }
            }
            return false;
        }

        public bool DismissInDtbListOfEmployees(Employee employee, int userID)
        {
            //go through the list of database departments
            foreach (var item in allEmployeesInDatabase)
            {
                //if any item of the list of database roles has the same id of the role the user has inputted
                if (item.UserID == userID)
                {
                    //change that role name to the new role name inputted by the user
                    item.DismissDate = employee.DismissDate;
                    //once this is done and gotten end the operation by returning true;
                    return true;
                }
            }
            return false;
        }

        public List<Employee> GetListOfAllEmployeesFromDatabase()
        {
            return allEmployeesInDatabase;
        }


        public void AddAllRolesFromDtb()
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
                    Role role = new Role();
                    role.RoleID = Convert.ToInt32(dr[0]);
                    role.RoleName = dr[1].ToString();
                    role.FormAccess = dr[2].ToString();
                    allRoles.Add(role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void AddAllDepartmentsFromDTB()
        {
            try
            {
                conn.Open();
                //sql code for selecting all th data from the table 
                string sql = "SELECT * FROM departments";
                cmd = new MySqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                //this is to loop through the results 
                while (dr.Read())
                {
                    //here we are changing all results into objects department
                    Department department = new Department();
                    department.DepartmentName = dr[1].ToString();
                    department.ID = Convert.ToInt32(dr[0]);
                    allDepartments.Add(department);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public List<Role> GetAllRolesFromDtb()
        {
            return this.allRoles;
        }

        public List<Department> GetAllDepartmentsFromDtb()
        {
            return this.allDepartments;
        }

        public bool AddSchedule(int UserID, string Date, string TimeShift)
        {
            try
            {
                conn.Open();
                int space1 = Date.IndexOf(' ');
                string DateSubstring = Date.Substring(0, space1);
                string sql = "INSERT INTO schedules (UserID, WorkDate, TimeShift) VALUES (@UserID, @WorkDate, @TimeShift)";
                cmd = new MySqlCommand(sql, conn);
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


        public void FillDataGridTable(string sql, DataGridView dataGrid)
        {
            conn.Open();
            LastSQL = sql;
            adpt = new MySqlDataAdapter(sql, conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGrid.DataSource = dt;
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
                string sql = "SELECT employee.UserID, employee.FirstName, employee.LastName, departments.DepartmentName, roles.RoleName FROM employee " +
                    "INNER JOIN roles ON employee.RoleID = roles.RoleID INNER JOIN departments ON employee.DepartmentID = departments.DepartmentID " +
                    "WHERE employee.DismissalDate IS NULL";
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
                string sql = "SELECT E.UserName, D.DepartmentName FROM employee AS E INNER JOIN departments D ON E.DepartmentID = D.DepartmentID";
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
                string sql = "SELECT E.Username, R.RoleName, R.FormAccess FROM employee As E INNER JOIN roles As R ON E.RoleID = R.RoleID";
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

        public void ChangePassword(string UserName, string Password)
        {
            try
            {
                if (Regex.IsMatch(Password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$"))
                {
                    conn.Open();
                    cmd = new MySqlCommand($"UPDATE employee SET Password= @Password, AccountSecure = True WHERE UserName = @UserName", conn);
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

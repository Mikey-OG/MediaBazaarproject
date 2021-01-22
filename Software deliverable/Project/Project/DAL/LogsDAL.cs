using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project.DAL
{
    public class LogsDAL : BaseDAL
    {
        private string log;
        private List<Logs> allLogs;

        public LogsDAL()
        {
            base.CreateConnection();
            allLogs = new List<Logs>();
        }

        public bool LogDoesNotExistInDtbList(Logs log)
        {
            if (allLogs.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (var item in allLogs)
                {
                    if (item.NameOfLog == log.NameOfLog)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        //this is to get all logs
        public void AddToDtbListOfLogs()
        {
            try
            {
                conn.Open();
                //sql code for selecting all th data from the table 
                string sql = "SELECT * FROM logs";
                cmd = new MySqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                //this is to loop through the results 
                while (dr.Read())
                {
                    bool addToDtbList = true;
                    //here we are changing all results into objects employee
                    Logs logs = new Logs(dr[0].ToString(), dr[1].ToString());

                    if (addToDtbList == true)
                    {
                        if (LogDoesNotExistInDtbList(logs) == true)
                        {
                            //once changed into object department we add into a list
                            allLogs.Add(logs);
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

        //TRANSACTION LOGS
        //Admin page logs
        public bool NewEmployeeLog(Employee employee)
        {
            try
            {
                conn.Open();
                log = $"New employee {employee.FirstName} {employee.LastName} has been added, Time of addition";
                Logs logs = new Logs(log, DateTime.Now.ToString());
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", logs.ToString());
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

        public bool EmployeeUpdateLog(Employee employee)
        {
            try
            {
                conn.Open();
                log = $"Employee {employee.FirstName} {employee.LastName} records were updated, Time of update";
                Logs logs = new Logs(log, DateTime.Now.ToString());
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", logs.ToString());
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

        public bool EmployeeDismissalLog(Employee employee)
        {
            try
            {
                conn.Open();
                log = $"Employee {employee.FirstName} {employee.LastName} was Dismissed, Time of dismissal ";
                Logs logs = new Logs(log, DateTime.Now.ToString());
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", logs.ToString());
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


        //Role page logs
        public bool NewRolesLog(Role role)
        {
            try
            {
                conn.Open();
                log = $"New role {role.RoleName} has been added, Time of addition ";
                Logs logs = new Logs(log, DateTime.Now.ToString());
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", logs.ToString());
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


        public bool RoleUpdateLog(Role role)
        {
            try
            {
                conn.Open();
                log = $"Role {role.RoleName} was updated, Time of update ";
                Logs logs = new Logs(log, DateTime.Now.ToString());
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", logs.ToString());
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

        public bool RoleRemovelLog(string roleName)
        {
            try
            {
                conn.Open();
                log = $"Role {roleName} was removed, Time of removal ";
                Logs logs = new Logs(log, DateTime.Now.ToString());
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", logs.ToString());
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

        //Department Logs
        public bool NewDepartmentLog(Department department)
        {
            try
            {
                conn.Open();
                log = $"New Department {department.DepartmentName} has been added, Time of addition {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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

        public bool DepartmentUpdateLog(Department department)
        {
            try
            {
                conn.Open();
                log = $"Department {department.DepartmentName} was updated, Time of update {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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

        public bool DepartmentRemovelLog(string departmentName)
        {
            try
            {
                conn.Open();
                log = $"Department {departmentName} was removed, Time of removal {DateTime.Now}";
                cmd = new MySqlCommand("INSERT INTO logs(Logs) VALUE(@Logs)", conn);
                cmd.Parameters.AddWithValue("@Logs", log);
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


        public bool RemoveLog(Logs logs)
        {
            conn.Open();
            cmd = new MySqlCommand("DELETE FROM logs WHERE Logs=@LogName", conn);
            cmd.Parameters.AddWithValue("@LogName", logs.NameOfLog);
            cmd.ExecuteNonQuery();
            return true;
        }

        public List<Logs> GetAllLogsFromDtb()
        {
            return allLogs;
        }


    }
}

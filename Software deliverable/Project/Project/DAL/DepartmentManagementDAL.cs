using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows.Forms;

namespace Project.DAL
{
    public class DepartmentManagementDAL: BaseDAL
    {
        private string log;
        public string LastSQL = $"";
        private List<Department> allDepartmentsInDatabse;

        public DepartmentManagementDAL()
        {
            base.CreateConnection();
            allDepartmentsInDatabse = new List<Department>();
        }

        //Database Logic
        public bool DepartmentDoesNotExists(Department department)
        {
            conn.Open();
            string sql = "SELECT * FROM departments WHERE DepartMentName = @Department";
            LastSQL = sql;
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Department", department.DepartmentName);
            adpt = new MySqlDataAdapter(cmd);
            adpt.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Department Already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }

        //this is to add a department into the database
        public bool AddDepartmentToDatabase(Department department)
        {
            try
            {
                if (DepartmentDoesNotExists(department) == true)
                {
                    string sql = "INSERT INTO departments (DepartmentName) VALUES( @DepartmentName)";
                    cmd = new MySqlCommand(sql, conn);
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

        public bool RemoveDepartmentFromDatabase(int departmentID)
        {
            try
            {
                conn.Open();
                string sql = "DELETE FROM departments WHERE DepartmentID=@DepartmentID";
                cmd = new MySqlCommand(sql, conn);
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

        public bool UpdateDepartmentInDatabase(Department department)
        {
            try
            {
                if (DepartmentDoesNotExists(department) == true)
                {
                    string sql = $"UPDATE departments SET DepartmentName= @DepartmentName WHERE DepartmentID = @departmentID";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DepartmentID", department.ID);
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

        //this is to prevent a department from being added to the list
        //if that department already exists
        public bool DepartmentDoesNotExistInDtbList(Department department)
        {
            if (allDepartmentsInDatabse.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (var item in allDepartmentsInDatabse)
                {
                    if (item.DepartmentName == department.DepartmentName)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public Department FindDepartmentByID(int departmentID)
        {
            foreach (var item in allDepartmentsInDatabse)
            {
                if (item.ID == departmentID)
                {
                    return item;
                }
            }
            return null;
        }


        //Database list logic
        //this is to add the data gotten from the database into a list 
        public void AddToDtbListOfDepartments()
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

                    if (DepartmentDoesNotExistInDtbList(department) == true)
                    {
                        //once changed into object department we add into a list
                        allDepartmentsInDatabse.Add(department);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        //this is to remove data removed from the database 
        public void RemoveFromDtbListOfDepartments(int departmentID)
        {
            allDepartmentsInDatabse.Remove(FindDepartmentByID(departmentID));
        }

        //find the solution to the problem in the Note paper
        //this works the 
        public bool UpdateInDtbListOfDepartments(Department department)
        {
            //go through the list of database departments
            foreach (var item in allDepartmentsInDatabse)
            {
                //if any item of the list of database departments has the same id of the department the user has inputted
                if (item.ID == department.ID)
                {
                    //change that department name to the new department name inputted by the user
                    item.DepartmentName = department.DepartmentName;
                    //once this is done and gotten end the operation by returning true;
                    return true;
                }
            }
            return false;
        }

        ////this is to update the data updated in the database
        //public void UpdateDataInDatabaseList(Department department)
        //{
        //    //the method Find the department is called 
        //    FindDepartment(department);
        //}

     
        public List<Department> GetListOfAllDepartmentsFromDatabase()
        {
            return allDepartmentsInDatabse;
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

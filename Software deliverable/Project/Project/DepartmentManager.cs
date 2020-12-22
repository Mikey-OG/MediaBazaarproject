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

namespace Project
{
    public class DepartmentManager
    {
        private string log;
        public string LastSQL = $"";
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        DataSet ds = new DataSet();
        MySqlDataAdapter adpt;
        MySqlCommand cmd;
        MySqlDataReader dr;
        DataTable dt;
        List<Department> departments;

        public DepartmentManager()
        {
          departments = new List<Department>();
        }
        public bool DepartmentDoesNotExists(Department department)
        {
            conn.Open();
            string sql = "SELECT * FROM departments WHERE DepartMentName = @Department";
            LastSQL = sql;
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Department", department.DepartmentName);
            adpt = new MySqlDataAdapter(cmd);
            dt = new DataTable();
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

        //this is to add the data gottn from the database into a list 
        public void AddToListOFDepartments()
        {
            try
            {
                string sql = "SELECT * FROM departments";
                cmd = new MySqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Department department = new Department(dr[1].ToString());
                    department.ID = Convert.ToInt32(dr[0]);
                    departments.Add(department);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        //this is to add a department into the database
        public bool AddDepartment(Department department)
        {
            try
            {
                if(DepartmentDoesNotExists(department) == true)
                {
                    string sql = "INSERT INTO departments (DepartmentName) VALUES( @DepartmentName)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                    cmd.ExecuteNonQuery();
                    departments.Clear();
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

        //test
        //public Department FinDepartment(Department department)
        //{
        //    foreach (var item in departments)
        //    {
        //        if(item.ID == department.ID)
        //        {
        //            return department;
        //        }
        //    }
        //    return null;
        //}
        public bool UpdateDepartment(Department department)
        {
            try
            {
                if(DepartmentDoesNotExists(department) == true)
                {
                    string sql = $"UPDATE departments SET DepartmentName= @DepartmentName WHERE DepartmentID = @departmentID";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DepartmentID", department.ID);
                    cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                    departments.Clear();
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


        public bool RemoveDepartment(int departmentID)
        {
            try
            {
                conn.Open();
                string sql = "DELETE FROM departments WHERE DepartmentID=@DepartmentID";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DepartmentID", departmentID);
                departments.Clear();
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



        public List<Department> GetAllDepartments()
        {
            conn.Open();
            AddToListOFDepartments();
            return departments;
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
    }
}

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
    public class DepartmentManager: IDepartmentManage
    {
        private string log;
        public string LastSQL = $"";
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        DataSet ds = new DataSet();
        MySqlDataAdapter adpt;
        MySqlCommand cmd;
        DataTable dt;


        public bool AddDepartment(Department department)
        {
            try
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


        public bool UpdateDepartment(Department department, int departmentID)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM departments WHERE DepartMentName = @DepartmentName";
                LastSQL = sql;
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
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

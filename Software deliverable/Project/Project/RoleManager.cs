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
    public class RoleManager: IRoleManage
    {
        private string log;
        public string LastSQL = $"";
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        DataSet ds = new DataSet();
        MySqlDataAdapter adpt;
        MySqlCommand cmd;
        DataTable dt;
        public bool AddRole(Roles role, string fileAccess)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM roles WHERE RoleName = @RoleName";
                LastSQL = sql;
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
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



        public bool UpdateRole(Roles role, string fileAccess, int roleID)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM roles WHERE RoleName = @RoleName";
                LastSQL = sql;
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
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

    }
}

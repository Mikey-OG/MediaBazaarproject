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
    public class RoleManagementDAL: BaseDAL
    {
        private string log;
        public string LastSQL = $"";
        private List<Role> allRolesInDatabase;
        private List<string> allFormAccess;

        public RoleManagementDAL()
        {
            base.CreateConnection();      
            allFormAccess = new List<string>();
            allRolesInDatabase = new List<Role>();
        }

        //Database Logic
        public bool RoleDoesNotExists(Role role)
        {
            conn.Open();
            string sql = "SELECT * FROM roles WHERE RoleName = @Role";
            LastSQL = sql;
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Role", role.RoleName);
            adpt = new MySqlDataAdapter(cmd);
            adpt.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Role Already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }



        //this is to add a department into the database
        public bool AddRoleToDatabase(Role role)
        {
            try
            {
                if (RoleDoesNotExists(role) == true)
                {
                    string sql = "INSERT INTO roles (RoleName, FormAccess) VALUES( @RoleName, @FormAccess)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                    cmd.Parameters.AddWithValue("@FormAccess", role.FormAccess);
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

        public bool RemoveRoleFromDatabase(int roleID)
        {
            try
            {
                conn.Open();
                string sql = "DELETE FROM roles WHERE RoleID=@RoleID";
                cmd = new MySqlCommand(sql, conn);
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

        public bool UpdateRoleInDatabase(Role role)
        {
            try
            {
                if (RoleDoesNotExists(role) == true)
                {
                    string sql = $"UPDATE departments SET DepartmentName= @DepartmentName WHERE DepartmentID = @departmentID";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DepartmentID", role.RoleID);
                    cmd.Parameters.AddWithValue("@DepartmentName", role.RoleName);
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
        public bool RoleDoesNotExistInDtbList(Role role)
        {
            if (allRolesInDatabase.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (var item in allRolesInDatabase)
                {
                    if (item.RoleName == role.RoleName)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public Role FinRoleByID(int roleID)
        {
            foreach (var item in allRolesInDatabase)
            {
                if (item.RoleID == roleID)
                {
                    return item;
                }
            }
            return null;
        }


        //Database list logic
        //this is to add the data gotten from the database into a list 
        public void AddToDtbListOfRoles()
        {
            try
            {
                conn.Open();
                //sql code for selecting all th data from the table 
                string sql = "SELECT * FROM roles";
                cmd = new MySqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                //this is to loop through the results 
                while (dr.Read())
                {
                    //here we are changing all results into objects role
                    Role role = new Role();
                    role.RoleName = dr[1].ToString();
                    role.FormAccess = dr[2].ToString();
                    role.RoleID = Convert.ToInt32(dr[0]);

                    if (RoleDoesNotExistInDtbList(role) == true)
                    {
                        //once changed into object role we add into a list
                        allRolesInDatabase.Add(role);
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
        public void RemoveFromDtbListOfRoles(int roleID)
        {
            allRolesInDatabase.Remove(FinRoleByID(roleID));
        }

        //find the solution to the problem in the Note paper
        //this works the 
        public bool UpdateInDtbListOfRoles(Role role)
        {
            //go through the list of database departments
            foreach (var item in allRolesInDatabase)
            {
                //if any item of the list of database roles has the same id of the role the user has inputted
                if (item.RoleID == role.RoleID)
                {
                    //change that role name to the new role name inputted by the user
                    item.RoleName = role.RoleName;
                    item.FormAccess = role.FormAccess;
                    //once this is done and gotten end the operation by returning true;
                    return true;
                }
            }
            return false;
        }

        public void AddAllFormAccessFromDtb()
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
                    allFormAccess.Add(sFormName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }
        public List<Role> GetListOfAllRolesFromDatabase()
        {
            return allRolesInDatabase;
        }

        public List<string> GetAllFormAccessInDtb()
        {
            return allFormAccess;
        }

        //Role page logs
        public void NewRolesLog(Role role)
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


        public void RoleUpdateLog(Role role)
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

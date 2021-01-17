using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project.DAL
{
    public class LoginDAL : BaseDAL
    {
        private Encryption Cry;
        private string employeePriviledge;

        public LoginDAL()
        {
            Cry = new Encryption();
            base.CreateConnection();
        }

        public int CheckForEmployee(string sql, string formAccess, string password, string userName)
        {
            string pass = Cry.Encrypt(password);
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Password", pass);
            cmd.Parameters.AddWithValue("@FormAccess", formAccess);
            cmd.Parameters.AddWithValue("@Username", userName);
            adpt = new MySqlDataAdapter(cmd);
            adpt.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            return i;
        }

        public bool CheckAccountSecurity(string userName)
        {
            try
            {
                conn.Open();
                ds.Clear();
                string sql = "SELECT * FROM employee WHERE UserName = @UserName AND AccountSecure = @accountSecure";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", userName);
                cmd.Parameters.AddWithValue("@accountSecure", true);
                adpt = new MySqlDataAdapter(cmd);
                adpt.Fill(ds);
                int tableCOunt = ds.Tables[0].Rows.Count;
                if (tableCOunt != 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public string EmployeePriviledge(string password, string userName)
        {
            try
            {
                conn.Open();
                //this is here to ensure we are workign with a new data 
                ds.Clear();
                string sql = "SELECT employee.* FROM (roles INNER JOIN employee ON roles.RoleID = employee.RoleID)" +
                "WHERE employee.UserName = @Username and employee.Password = @Password and roles.FormAccess = @FormAccess and employee.DismissalDate IS NULL;";
                if (CheckForEmployee(sql, "AdminForm", password, userName) == 1)
                {
                    employeePriviledge = "Admin";
                }
                else
                {
                    if (CheckForEmployee(sql, "EmployeeForm", password, userName) == 1)
                    {
                        employeePriviledge = "EmployeeManager";
                    }
                    else
                    {
                        if (CheckForEmployee(sql, "StockManagerForm", password, userName) == 1)
                        {
                            employeePriviledge = "StockManager";
                        }
                        else
                        {
                            if (CheckForEmployee(sql, "ShopPersonnelForm", password, userName) == 1)
                            {
                                employeePriviledge = "ShopPersonnel";
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
                return employeePriviledge;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool ChangePassword(string UserName, string Password)
        {
            try
            {
                if (Regex.IsMatch(Password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$"))
                {
                    conn.Open();
                    string sql = "UPDATE employee SET Password= @Password, AccountSecure = True WHERE UserName = @UserName";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Cry.Encrypt(Password));
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { conn.Close(); }
        }


    }
}

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

namespace Project
{
    public class GeneralManagement : IEmployeeManage, IStockManage
    {
        string connStr = "server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;";
        MySqlDataAdapter adpt;
        MySqlCommandBuilder cmbld;
        DataTable dt;
        DataSet ds = new DataSet();
        MySqlCommand cmd;
        MySqlDataReader dr;

        public bool AddRole(Roles role)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    cmd = new MySqlCommand("INSERT INTO roles (RoleID, RoleName) VALUES(@RoleID, @RoleName)", conn);
                    cmd.Parameters.AddWithValue("@RoleID", role.RoleID);
                    cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;

        }
        public bool AddEmployee(Employee employee)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * FROM employees WHERE UserID = '" + employee.UserID + "'", conn);
                    adpt = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    adpt.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                        MessageBox.Show("UserID already exist");
                        ds.Clear();
                    }
                    else
                    {
                        cmd = new MySqlCommand("INSERT INTO employees (UserID, UserName, Email, Password, FirstName, LastName, DateOfBirth, PhoneNumber, Nationality, City, ZipCode, Adress, Salary, DateOfHire, DepartmentId, RoleID) VALUES(@UserID, @UserName, @Email, @Password, @FirstName, @LastName, @DateOfBirth, @PhoneNumber, @Nationality, @City, @ZipCode, @Adress, @Salary, @DateOfHire, @DepartmentId, @RoleID)", conn);
                        cmd.Parameters.AddWithValue("@UserID", employee.UserID);
                        cmd.Parameters.AddWithValue("@UserName", employee.UserName);
                        cmd.Parameters.AddWithValue("@Email", employee.Email);
                        cmd.Parameters.AddWithValue("@Password", employee.Password);
                        cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                        cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNO);
                        cmd.Parameters.AddWithValue("@Nationality", employee.Nationality);
                        cmd.Parameters.AddWithValue("@City", employee.City);
                        cmd.Parameters.AddWithValue("@ZipCode", employee.Zipcode);
                        cmd.Parameters.AddWithValue("@Adress", employee.Address);
                        cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@DateOfHire", employee.HireDate);
                        cmd.Parameters.AddWithValue("@DepartmentID", employee.EmployeeDepartment);
                        cmd.Parameters.AddWithValue("@RoleID", employee.RoleID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            return false;
        }

        public void UpdateEMployee(Employee employee)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE employees SET UserID ='" + employee.UserID + "', UserName='" + employee.UserName + "', Email='" + employee.Email + "', Password='" + employee.Password + "', FirstName='" + employee.FirstName + "', LastName='" + employee.LastName + "', DateOfBirth ='" + employee.DateOfBirth + "', PhoneNumber='" + employee.PhoneNO + "', Nationality='" + employee.Nationality + "', City='" + employee.City + "', ZipCode='" + employee.Zipcode + "', Adress='" + employee.Address + "', Salary='" + employee.Salary + "', DateOfHire='" + employee.DateOfBirth + "', DepartmentId='" + employee.EmployeeDepartment + "', RoleID='" + employee.RoleID + "' WHERE UserID ='" + employee.UserID + "';";
                    cmd = new MySqlCommand(query, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void UpdateDepartment(Department department)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE departments SET DepartmentID =  '" + department.DepartmentID + "', DepartmentName='" + department.DepartmentName + "';";
                    cmd = new MySqlCommand(query, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void FillWithDepartments(DataGridView dataGrid)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM departments";
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

            }
        }

        public void FillWithRoles(DataGridView dataGrid)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM roles";
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

            }
        }

        public void RemoveEmployee(int UserID)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM employees  WHERE UserID='" + UserID + "'";
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void FillWithEmployee(DataGridView dataGrid)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM employees";
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

            }
        }

        public void FillWithStock(DataGridView dataGrid)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM stockinventory";
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

            }
        }
    }
}

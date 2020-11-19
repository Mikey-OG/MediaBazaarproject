using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project
{
    public class EmployeeManagement
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        MySqlDataAdapter adpt;
        MySqlCommand cmd;
        DataTable dt;
        MySqlDataReader reader;


        public void FilltableAllEmployees(DataGridView datagrid)
        {
            conn.Open();
            try
            {
                adpt = new MySqlDataAdapter("SELECT employees.UserID, employees.FirstName, employees.LastName, departments.DepartmentName, roles.RoleName, employees.UserName, employees.Email, employees.Password, employees.DateOfBirth, employees.PhoneNumber, employees.Nationality, employees.City, employees.ZipCode, employees.Adress, employees.Salary, employees.DepartmentID, employees.RoleID FROM employees JOIN departments ON employees.DepartmentID = departments.DepartmentID JOIN roles ON employees.RoleID = roles.RoleID", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
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

        public void FilltableEmployeeSchedule(DataGridView datagrid, int UserID)
        {
            conn.Open();
            try
            {
                adpt = new MySqlDataAdapter($"SELECT * FROM schedules WHERE UserID={UserID}", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
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

        public void Delete(DataGridView datagrid, int UserID)
        {
            conn.Open();
            try
            {
                foreach (DataGridViewRow item in datagrid.SelectedRows)
                {
                    datagrid.Rows.RemoveAt(item.Index);
                }
                cmd = new MySqlCommand($"DELETE FROM employees WHERE UserID={UserID}", conn);
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

        public void AddSchedule(int UserID, string Date, string From, string Until)
        {
            Regex CheckTime = new Regex(@"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            if (CheckTime.IsMatch(From) && CheckTime.IsMatch(Until))
            {
                try
                {
                    conn.Open();
                    int space1 = Date.IndexOf(' ');
                    string DateSubstring = Date.Substring(0, space1);
                    cmd = new MySqlCommand($"INSERT INTO schedules (UserID, WorkDate, TimeFrom, TimeUntil) VALUES ('{UserID}', '{DateSubstring}', '{From}', '{Until}')", conn);
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
            else
            {
                MessageBox.Show("Some value(s) are not valid.");
            }
        }

        public void AddEmployee(string UserName, string Email, string Password, string FirstName, string LastName, string DOB, string PhoneNumber, string Nationality, string City, string ZipCode, string Adress, double Salary, int DepartmentID, int RoleID)
        {
            Regex EmailChecker = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (EmailChecker.IsMatch(Email))
            {
                try
                {
                    conn.Open();
                    DateTime HireDate = DateTime.Today;
                    cmd = new MySqlCommand($"INSERT INTO employees (UserName, Email, Password, FirstName, LastName, DateOfBirth, PhoneNumber, Nationality, City, ZipCode,Adress, Salary, DateOfHire, DepartmentID, RoleID) VALUES ('{UserName}', '{Email}', '{Password}', '{FirstName}', '{LastName}', '{DOB}', '{PhoneNumber}', '{Nationality}', '{City}', '{ZipCode}', '{Adress}', '{Salary}', '{HireDate.ToString()}', '{DepartmentID}', '{RoleID}')", conn);
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
            else
            {
                MessageBox.Show("Some value(s) are not valid.");
            }
        }

        public void UpdateEmployee(int UserID, string UserName, string Email, string Password, string FirstName, string LastName, string DOB, string PhoneNumber, string Nationality, string City, string ZipCode, string Adress, double Salary, int DepartmentID, int RoleID)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand($"UPDATE employees SET UserName='{UserName}', Email='{Email}', Password='{Password}', FirstName='{FirstName}', LastName='{LastName}', DateOfBirth='{DOB}', PhoneNumber='{PhoneNumber}', Nationality='{Nationality}', City='{City}', ZipCode='{ZipCode}',Adress='{Adress}', Salary='{Salary}', DepartmentID='{DepartmentID}', RoleID='{RoleID}' WHERE UserID='{UserID}'", conn);
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

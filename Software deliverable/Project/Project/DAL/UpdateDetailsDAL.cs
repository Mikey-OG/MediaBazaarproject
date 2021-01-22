using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using Project.LGC;

namespace Project.DAL
{
    public class UpdateDetailsDAL : BaseDAL
    {

        MySqlDataAdapter adpt;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public string LastSQL = $"";
        private Encryption Cry;
        List<Employee> foundEmployee;

        public UpdateDetailsDAL()
        {
            base.CreateConnection();
            Cry = new Encryption();
            foundEmployee = new List<Employee>();
        }

        public List<Employee> Insert()
        {
            Account account;
            account = new Account();

            try
            {
                conn.Open();


                string test = "";
                string sql1 = $"SELECT UserID FROM employee WHERE UserName = '{Variables.User}'";
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                Object result = cmd.ExecuteScalar();
                int userID = Convert.ToInt32(result);
                string sql = $"SELECT UserName,Email,Password,FirstName,LastName,DateOfBirth,PhoneNumber,Nationality,City,ZipCode,Adress FROM employee WHERE UserID= '" + userID + "'";
                LastSQL = sql;
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                // dt = new DataTable();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee employee = new Employee(dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[7].ToString(),
                    dr[8].ToString(), dr[9].ToString(), dr[5].ToString(), "", dr[10].ToString(), 0);
                    foundEmployee.Add(employee);
                    employee.SetEmail(dr[1].ToString());
                    employee.SetPhoneNO(dr[6].ToString());
                    employee.SetPassword(Cry.Decrypt(dr[2].ToString()));
                }
                return foundEmployee;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public void UpdateDetails(string username, string email, string password, string firstname, string lastname, DateTime dob, string phone, string nationality, string address, string city, string zipcode)
        {
            Account account = new Account();
            try
            {
                conn.Open();
                string sql1 = $"SELECT UserID FROM employee WHERE UserName = '{Variables.User}'";
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                Object result = cmd.ExecuteScalar();
                int userID = Convert.ToInt32(result);
                string sql = "UPDATE employee SET Username='" + username + "',Email='" + email + "',Password='" + Cry.Encrypt(password) + "',FirstName='" + firstname + "',LastName='" + lastname + "',DateOfBirth='" + dob.ToString("dd-MM-yyyy") + "',PhoneNumber='" + phone + "',Nationality='" + nationality + "',Adress='" + address + "',City='" + city + "',ZipCode='" + zipcode + "' WHERE UserID= '" + userID + "'";
                LastSQL = sql;
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

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
        }




    }
}

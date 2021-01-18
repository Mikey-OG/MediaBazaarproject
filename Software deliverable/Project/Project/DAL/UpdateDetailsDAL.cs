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

        public UpdateDetailsDAL()
        {
            base.CreateConnection();
            Cry = new Encryption();
        }

        public void Insert(string username, string email, string password, string firstname, string lastname, DateTime dob, string phone, string nationality, string city, string zipcode, string address)
        {
            Account account;
            account = new Account();

            try
            {
                conn.Open();
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
                    username = dr.GetValue(0).ToString();
                    email = dr.GetValue(1).ToString();
                    password = Cry.Decrypt(dr.GetValue(2).ToString());
                    firstname = dr.GetValue(3).ToString();
                    lastname = dr.GetValue(4).ToString();
                    dob = Convert.ToDateTime(dr.GetValue(5));
                    phone = dr.GetValue(6).ToString();
                    nationality = dr.GetValue(7).ToString();
                    city = dr.GetValue(8).ToString();
                    zipcode = dr.GetValue(9).ToString();
                    address = dr.GetValue(10).ToString();



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

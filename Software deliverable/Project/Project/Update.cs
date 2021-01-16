using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Project
{
    public class Update
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        MySqlDataAdapter adpt;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public string LastSQL = $"";
        private Encryption Cry = new Encryption();

        public void Insert(string username, string email, string password, string firstname, string lastname, DateTime dob, string phone, string nationality, string address, string city, string zipcode)
        {
            Account account;
            account = new Account();
            try
            {
                conn.Open();
                string sql = "SELECT UserName,Email,Password,FirstName,LastName,DateOfBirth,PhoneNumber,Nationality,Adress,City,ZipCode FROM employees WHERE UserID = 1";
                cmd = new MySqlCommand(sql, conn);
                //LastSQL = sql;
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
                    address = dr.GetValue(8).ToString();
                    city = dr.GetValue(9).ToString();
                    zipcode = dr.GetValue(10).ToString();

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

        public void UpdateDetails(int userID, string username, string email, string password, string firstname, string lastname, DateTime dob, string phone, string nationality, string address, string city, string zipcode)
        {
            Account account = new Account();
            try
            {
                conn.Open();
                string sql = "UPDATE employee SET Username='" + username + "',Email='" + email + "',Password='" + Cry.Encrypt(password) + "',FirstName='" + firstname + "',LastName='" + lastname + "',DateOfBirth='" + dob.ToString("dd-MM-yyyy") + "',PhoneNumber='" + phone + "',Nationality='" + nationality + "',Adress='" + address + "',City='" + city + "',ZipCode='" + zipcode + "' WHERE UserID= '" + userID + "'";
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

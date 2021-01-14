using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class UpdateDetailsForm : Form
    {
        Update update = new Update();
        Employee employee;
        Account account = new Account();
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        MySqlDataAdapter adpt;
        MySqlCommand cmd;
        MySqlDataReader dr;

        private Encryption Cry = new Encryption();
        public UpdateDetailsForm(int id)
        {
            InitializeComponent();
            employee = new Employee("bjnkmnb", "bjnkmnb",
                       "bjnkmnb", "bjnkmnb", "bjnkmnb", "bjnkmnb",
                       "bjnkmnb", "bjnkmnb", "bjnkmnb",
                       Convert.ToInt32(2000));
            //int val = 1;
            this.tbID.Text = Convert.ToString(id);
            update.Insert(tbUpUsername.Text, tbUpEmail.Text, tbUpPassword.Text, tbUpFirstname.Text, tbUpLastname.Text, dtUpDOB.Value, tbUpPhone.Text, tbUpNationality.Text, tbUpAddress.Text, tbUpCity.Text, tbUpZipcode.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (employee.SetPassword(tbUpPassword.Text) == false)
            {
                MessageBox.Show("Please ensure your password" +
                           " possesses at least one lowercase character " +
                           " at least one uppercase charater " +
                           " at least one numeric character between 0-9 " +
                           " and is at least 8-15 characters long " +
                           " e.g (Mikoko02, Kirill02, lucM2002) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.update.UpdateDetails(Convert.ToInt32(tbID.Text), tbUpUsername.Text, tbUpEmail.Text, tbUpPassword.Text, tbUpFirstname.Text, tbUpLastname.Text, dtUpDOB.Value, tbUpPhone.Text, tbUpNationality.Text, tbUpAddress.Text, tbUpCity.Text, tbUpZipcode.Text);

                if (DialogResult.OK == MessageBox.Show("Your details have been updated"))
                {
                    this.Hide();
                }
            }



        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            Account account;
            account = new Account();
            try
            {
                conn.Open();
                if (tbID.Text != "")
                {
                    string sql = "SELECT UserName,Email,FirstName,LastName,DateOfBirth,PhoneNumber,Nationality,Adress,City,ZipCode FROM employee WHERE UserID = @userID";
                    cmd = new MySqlCommand(sql, conn);
                    //LastSQL = sql;
                    adpt = new MySqlDataAdapter(cmd);
                    // dt = new DataTable();
                    cmd.Parameters.AddWithValue("@userID", int.Parse(tbID.Text));
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tbUpUsername.Text = dr.GetValue(0).ToString();
                        tbUpEmail.Text = dr.GetValue(1).ToString();
                        tbUpFirstname.Text = dr.GetValue(2).ToString();
                        tbUpLastname.Text = dr.GetValue(3).ToString();
                        dtUpDOB.Value = Convert.ToDateTime(dr.GetValue(4));
                        tbUpPhone.Text = dr.GetValue(5).ToString();
                        tbUpNationality.Text = dr.GetValue(6).ToString();
                        tbUpAddress.Text = dr.GetValue(7).ToString();
                        tbUpCity.Text = dr.GetValue(8).ToString();
                        tbUpZipcode.Text = dr.GetValue(9).ToString();
                    }

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

        private void cbShowPassword_TextChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbUpPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbUpPassword.UseSystemPasswordChar = false;
            }
        }

        private void cbShowOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (cbShowOldPassword.Checked)
            {
                tbUpOldPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbUpOldPassword.UseSystemPasswordChar = false;
            }
        }
    }
}

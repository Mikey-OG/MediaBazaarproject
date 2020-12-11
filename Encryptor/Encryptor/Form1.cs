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
using System.Security.Cryptography;
using System.IO;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        private Crypt3 Cry = new Crypt3();
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        MySqlDataAdapter adpt;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            string password = "ShpG`6G*(f2";

            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password));

            // Create secret IV
            byte[] iv = new byte[16] { 0x48, 0x75, 0x69, 0x6d, 0x21, 0x5a, 0x55, 0x62, 0x68, 0x72, 0x60, 0x64, 0x78, 0x42, 0x35, 0x16 };

            string encrypted = Cry.EncryptString(message, key, iv);
            string decrypted = Cry.DecryptString(encrypted, key, iv);
            textBox2.Text = encrypted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox2.Text;
            string password = "ShpG`6G*(f2";

            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password));

            // Create secret IV
            byte[] iv = new byte[16] { 0x48, 0x75, 0x69, 0x6d, 0x21, 0x5a, 0x55, 0x62, 0x68, 0x72, 0x60, 0x64, 0x78, 0x42, 0x35, 0x16 };

            string encrypted = Cry.EncryptString(message, key, iv);
            string decrypted = Cry.DecryptString(message, key, iv);
            label1.Text = decrypted;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT UserID, Password FROM employees;";
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}

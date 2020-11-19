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

namespace Encryptor
{
    public partial class Form1 : Form
    {
        private Crypt Cry = new Crypt();
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        MySqlDataAdapter adpt;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Cry.Encrypt(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Cry.Decrypt(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
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

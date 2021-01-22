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
    public partial class StockInput : Form
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        public StockInput()
        {
            InitializeComponent();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                double price = Convert.ToDouble(textBox2.Text);
                string disc = richTextBox1.Text;
                int quan = Convert.ToInt32(textBox4.Text);
                int DepID = Convert.ToInt32(textBox5.Text);
                conn.Open();
                string sql1 = "SELECT MAX(ProductID) FROM stockinventory;";
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                Object result = cmd.ExecuteScalar();
                int maxID = Convert.ToInt32(result);
                string sql2 = $"INSERT INTO `stockinventory`(`ProductID`, `Name`, `Price`, `Description`, `Quantity`, `DepartmentID`) VALUES ({maxID + 1},{name},{price},{disc},{quan},{DepID})";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.ExecuteScalar();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                richTextBox1.Text = "";
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

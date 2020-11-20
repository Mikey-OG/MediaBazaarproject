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
        private StockManager stock = new StockManager();
        public StockInput()
        {
            InitializeComponent();
            FillCombo();
        }
        private void FillCombo()
        {
            stock.FillCombo(comboBox1);
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            stock.StockInput(textBox1, textBox2, textBox4, comboBox1,textBox3, richTextBox1);
        }
    }
}

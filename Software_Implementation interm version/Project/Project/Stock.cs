using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    class StockManager
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        MySqlDataAdapter adpt;
        DataTable dt;
        MySqlCommandBuilder cmdbld;
        public void FillTable(DataGridView datagrid)
        {
            conn.Open();
            try
            {
                adpt = new MySqlDataAdapter("SELECT * FROM stockinventory", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void Search(DataGridView datagrid, TextBox textbox)
        {
            conn.Open();
            string searchresult = textbox.Text;
            string sql = $"SELECT * FROM stockinventory WHERE Name LIKE '%{searchresult}%';";
            try
            {
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void NewRow(DataGridView datagrid)
        {
            conn.Open();
            try
            {
                string sql1 = "SELECT MAX(ProductID) FROM stockinventory;";
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                Object result = cmd.ExecuteScalar();
                int maxID = Convert.ToInt32(result);
                string sql2 = $"INSERT INTO stockinventory(`ProductID`) VALUES ('{maxID + 1}')";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.ExecuteScalar();
                string sql3 = $"SELECT * FROM stockinventory WHERE ProductID = {maxID + 1};";
                adpt = new MySqlDataAdapter(sql3, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void DeleteRow(DataGridView datagrid)
        {
            conn.Open();
            try
            {
                foreach (DataGridViewRow item in datagrid.SelectedRows)
                {
                    datagrid.Rows.RemoveAt(item.Index);
                }
                cmdbld = new MySqlCommandBuilder(adpt);
                adpt.Update(dt);
                MessageBox.Show("Row Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void Increase(DataGridView datagrid, TextBox textbox)
        {
            conn.Open();
            try
            {
                if (datagrid.CurrentCell.ColumnIndex != 0)
                {
                    int stockchange = Convert.ToInt32(textbox.Text);
                    int current_stock = Convert.ToInt32(datagrid.CurrentCell.Value);
                    datagrid.CurrentCell.Value = current_stock + stockchange;
                    datagrid.Select();
                    MessageBox.Show("Value Increased", "Increase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (datagrid.CurrentCell.ColumnIndex == 0)
                {
                    MessageBox.Show("Can't change ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmdbld = new MySqlCommandBuilder(adpt);
                adpt.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void Decrease(DataGridView datagrid, TextBox textbox)
        {
            conn.Open();
            try
            {
                if (datagrid.CurrentCell.ColumnIndex != 0)
                {
                    int stockchange = Convert.ToInt32(textbox.Text);
                    int current_stock = Convert.ToInt32(datagrid.CurrentCell.Value);
                    datagrid.CurrentCell.Value = current_stock - stockchange;
                    datagrid.Select();
                    MessageBox.Show("Value Decreased", "Decrease", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (datagrid.CurrentCell.ColumnIndex == 0)
                {
                    MessageBox.Show("Can't change ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmdbld = new MySqlCommandBuilder(adpt);
                adpt.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void Refresh(DataGridView datagrid)
        {
            conn.Open();
            try
            {
                string sql = "SELECT * FROM stockinventory;";
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void Save()
        {
            try
            {
                conn.Open();
                cmdbld = new MySqlCommandBuilder(adpt);
                adpt.Update(dt);
                MessageBox.Show("Inforamtion Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

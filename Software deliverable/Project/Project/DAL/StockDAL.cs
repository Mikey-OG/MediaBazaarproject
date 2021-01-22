using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Project.DAL
{
    public class StockDAL : BaseDAL
    {
        public int MaxRows = 10;
        public string LastSQL = $"";
        DataTable dt;
        private List<StockItem> allStockItems;
        MySqlCommandBuilder cmdbld;

        public StockDAL()
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            base.CreateConnection();
            allStockItems = new List<StockItem>();
        }
        public void AddToDtbListOfItems()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM stockinventory";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    StockItem item = new StockItem(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToDouble(dr[2]), dr[3].ToString(), Convert.ToInt32(dr[4])
                        , Convert.ToInt32(dr[5]), dr[6].ToString());

                    if (ItemDoesNotExistInDtbList(item) == true)
                    {
                        //once changed into object role we add into a list
                        allStockItems.Add(item);
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
        public bool ItemDoesNotExistInDtbList(StockItem Item)
        {
            if (allStockItems.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (var item in allStockItems)
                {
                    if (item.ItemName == Item.ItemName)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public List<StockItem> GetListOfAllItemsFromDatabase()
        {
            return allStockItems;
        }

        public bool SearchDatabase(DataGridView datagrid, TextBox textbox)
        {
            try
            {
                string searchresult = textbox.Text;
                string sql = $"SELECT * FROM stockinventory WHERE Name LIKE '%{searchresult}%' LIMIT {MaxRows};";
                LastSQL = sql;
                conn.Open();
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool NewDatabaseRow(DataGridView datagrid)
        {
            try
            {
                conn.Open();
                string sql1 = "SELECT MAX(ProductID) FROM stockinventory;";
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                Object result = cmd.ExecuteScalar();
                int maxID = Convert.ToInt32(result);
                string sql2 = $"INSERT INTO stockinventory(`ProductID`) VALUES ('{maxID + 1}')";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.ExecuteScalar();
                string sql3 = $"SELECT * FROM stockinventory WHERE ProductID = {maxID + 1} LIMIT {MaxRows};";
                LastSQL = sql3;
                adpt = new MySqlDataAdapter(sql3, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool DeleteDatabaseRow(DataGridView datagrid)
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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool IncreaseDatabaseValue(DataGridView datagrid, TextBox textbox)
        {
            try
            {
                conn.Open();
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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool DecreaseDatabaseValue(DataGridView datagrid, TextBox textbox)
        {
            try
            {
                conn.Open();
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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public void FillTable(DataGridView datagrid)
        {
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM stockinventory LIMIT {MaxRows};";
                LastSQL = sql;
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
        public bool RefreshDatabase(DataGridView datagrid)
        {
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM stockinventory LIMIT {MaxRows};";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool SaveChanges()
        {
            try
            {
                conn.Open();
                cmdbld = new MySqlCommandBuilder(adpt);
                adpt.Update(dt);
                MessageBox.Show("Inforamtion Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool CheckDatabaseEmptyStock(DataGridView datagrid)
        {
            conn.Open();
            string sql = $"SELECT * FROM stockinventory WHERE Quantity <= 10 OR Quantity IS NULL LIMIT {MaxRows};";
            LastSQL = sql;
            try
            {
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagrid.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool DatabaseStockInput(string a, double b, int c, string d, int e, string f)
        {
            try
            {
                string name = a;
                double price = Convert.ToDouble(b);
                string desc = f;
                int quan = Convert.ToInt32(c);
                int minquan = Convert.ToInt32(e);
                string Category = Convert.ToString(d);
                conn.Open();
                string sql1 = "SELECT MAX(ProductID) FROM stockinventory;";
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                Object result = cmd.ExecuteScalar();
                int maxID = Convert.ToInt32(result);
                string sql2 = $"INSERT INTO `stockinventory`(`ProductID`, `Name`, `Price`, `Description`, `Quantity`, `MinQuantity`, `Category`) VALUES ('{maxID + 1}','{name}','{price}','{desc}','{quan}','{minquan}','{Category}')";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.ExecuteScalar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool DatabaseFillCombo(ComboBox a)
        {
            try
            {
                conn.Open();
                string query = $"SELECT DISTINCT Category FROM stockinventory LIMIT {MaxRows};";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sCategory = dr.GetString("Category");
                    a.Items.Add(sCategory);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
            return false;
        }

        public bool ShowDatabaseSchedule(DataGridView a)
        {
            try
            {
                conn.Open();
                string sql1 = $"SELECT UserID FROM `employee` WHERE `UserName` = '{Variables.User}'";
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                Object result = cmd.ExecuteScalar();
                int ID = Convert.ToInt32(result);
                string sql = $"SELECT * FROM schedules WHERE UserID = {result} LIMIT {MaxRows};";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                a.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool ShowDatabaseEmployees(DataGridView a)
        {
            try
            {

                conn.Open();
                string sql = $"SELECT employee.UserID, employee.FirstName, employee.LastName, employee.Salary FROM employee " +
$"INNER JOIN departments ON employee.DepartmentID = departments.DepartmentID WHERE departments.DepartmentName = 'Sales' LIMIT {MaxRows};";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                a.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool ShowEmployeeDetails(DataGridView a)
        {
            try
            {
                conn.Open();
                string sql = $"SELECT `UserID`,`UserName`,`Email`, `FirstName`, `LastName`,`DateOfBirth`,`PhoneNumber`,`Nationality`,`City`,`ZipCode`,`Adress`,`Salary` FROM `employees` WHERE `UserName` = '{Variables.User}'";
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                a.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool SeeMoreData(DataGridView a, string sql, int increase)
        {
            conn.Open();
            try
            {
                int indexOfSteam = sql.IndexOf("LIMIT");
                if (indexOfSteam >= 0)
                {
                    sql = sql.Remove(indexOfSteam);
                    MaxRows += increase;
                    sql = sql + "LIMIT " + MaxRows + ";";
                }
                else
                {
                    sql = sql + "LIMIT " + MaxRows + ";";
                }
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                a.DataSource = dt;
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Project
{
    class StockManager
    {
        public int MaxRows = 10;
        public string LastSQL = $"";
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        MySqlDataAdapter adpt;
        DataTable dt;
        MySqlCommandBuilder cmdbld;
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
        public void Search(DataGridView datagrid, TextBox textbox)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public void NewRow(DataGridView datagrid)
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
        public void Decrease(DataGridView datagrid, TextBox textbox)
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
        public void Refresh(DataGridView datagrid)
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
            finally
            {
                conn.Close();
            }
        }

        public void Save()
        {
            try
            {
                conn.Open();
                cmdbld = new MySqlCommandBuilder(adpt);
                adpt.Update(dt);
                MessageBox.Show("Inforamtion Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void EmptyStock(DataGridView datagrid)
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
        public void StockInput(TextBox a, TextBox b, TextBox c, ComboBox d, DateTimePicker f, RichTextBox e)
        {
            try
            {
                string name = a.Text;
                double price = Convert.ToDouble(b.Text);
                string desc = e.Text;
                int quan = Convert.ToInt32(c.Text);
                string Date = f.Value.ToString("yyyy-M-d");
                string Category = Convert.ToString(d.Text);
                conn.Open();
                string sql1 = "SELECT MAX(ProductID) FROM stockinventory;";
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                Object result = cmd.ExecuteScalar();
                int maxID = Convert.ToInt32(result);
                string sql2 = $"INSERT INTO `stockinventory`(`ProductID`, `Name`, `Price`, `Description`, `Quantity`, `StockDate`, `Category`) VALUES ('{maxID + 1}','{name}','{price}','{desc}','{quan}','{Date}','{Category}')";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.ExecuteScalar();
                a.Text = "";
                b.Text = "";
                c.Text = "";
                d.Text = "";
                e.Text = "";
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

        public void FillCombo(ComboBox a)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void ShowSchedule(DataGridView a)
        {
            try
            {
                conn.Open();
                string sql1 = $"SELECT UserID FROM `employees` WHERE `UserName` = '{Variables.User}'";
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                Object result = cmd.ExecuteScalar();
                int ID = Convert.ToInt32(result);
                string sql = $"SELECT * FROM schedules WHERE UserID = {result} LIMIT {MaxRows};";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                a.DataSource = dt;
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
        public void ShowEmployees(DataGridView a)
        {
            try
            {
                conn.Open();
                string sql = $"SELECT `UserID`, `FirstName`, `LastName`,  `Salary` FROM `employees` WHERE `FormAccess` = 'ShopPersonnelForm' and `DepartmentName`= 'Sales' LIMIT {MaxRows};";
                LastSQL = sql;
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                a.DataSource = dt;
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

        public void ShowDetails(DataGridView a)
        {
            try
            {
                conn.Open();
                string sql = $"SELECT `UserID`,`UserName`,`Email`, `FirstName`, `LastName`,`DateOfBirth`,`PhoneNumber`,`Nationality`,`City`,`ZipCode`,`Adress`,`Salary` FROM `employees` WHERE `UserName` = '{Variables.User}'";
                adpt = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adpt.Fill(dt);
                a.DataSource = dt;
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
        public void SeeMore(DataGridView a, string sql, int increase)
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

        public void ExportToPdf(DataGridView dgv)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter w = PdfWriter.GetInstance(doc, new FileStream(@"Stock.pdf", FileMode.Create));
            doc.Open();
            //Add border to page
            PdfContentByte content = w.DirectContent;
            iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 30, BaseColor.BLACK);
            iTextSharp.text.Font font2 = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11, BaseColor.BLACK);
            Paragraph prg = new Paragraph();
            prg.Alignment = Element.ALIGN_CENTER; // adjust the alignment of the heading
            prg.Add(new Chunk("Stock", font)); //adding a heading to the PDF
            doc.Add(prg); //add the component we created to the document
            PdfPTable table = new PdfPTable(dgv.Columns.Count);
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                PdfPCell cell = new PdfPCell(); //create object from the pdfpcell class
                cell.BackgroundColor = BaseColor.LIGHT_GRAY; //set color of cells to gray
                cell.AddElement(new Chunk(dgv.Columns[j].HeaderText.ToUpper(), font2));
                table.AddCell(cell);
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                table.WidthPercentage = 100; //set width of the table
                for (int k = 0; k < dgv.Columns.Count; k++)
                {
                    if (dgv[k, i].Value != null)
                        // get the value of   each cell in the dataTable tblemp
                        table.AddCell(new Phrase(dgv[k, i].Value.ToString(), font2));
                }
            }
            //add the table to document
            doc.Add(table);
            doc.Close();
        }
    }

}

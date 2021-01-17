using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Project.LGC;
using Project.DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Project
{
    public partial class StockManagement : Form
    {
        private string userValidation;
        StockManager stock = new StockManager();
        StockDAL sdl = new StockDAL();
        EmployeeManagementDAL generalManagement = new EmployeeManagementDAL();
        public void DeactivateShopPersonnelbtn()
        {
            btnMenuStock.Visible = false;
            btnMenuSchedule.Visible = false;
        }
        public void DeactivateAdminBtn()
        {
            btnMenuAdminLogs.Visible = false;
            btnMenuDepartmentManagement.Visible = false;
            btnMenuRoleManagement.Visible = false;
        }

        public void DeactivateEmployeeManagementBtn()
        {
            btnMenuScheduling.Visible = false;
            btnMenuEmployeeManagement.Visible = false;
        }
        public StockManagement(string validation)
        {
            InitializeComponent();
            if(validation == "StockManager")
            {
                DeactivateAdminBtn();
                DeactivateShopPersonnelbtn();
                DeactivateEmployeeManagementBtn();
                userValidation = validation;
            }
            else
            {
                if(validation == "Admin")
                {
                    DeactivateShopPersonnelbtn();
                    userValidation = validation;
                }
            }
            this.dataGridView1.DataError += this.DataGridView1_DataError;
            sdl.FillTable(dataGridView1);
            stock.FillCombo(comboBox1);
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error\n" + "Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            stock.Search(dataGridView1, SearchBox);
        }

        private void NewRowBtn_Click_1(object sender, EventArgs e)
        {
            stock.NewRow(dataGridView1);
        }

        private void DeletRowBtn_Click_2(object sender, EventArgs e)
        {
            stock.DeleteRow(dataGridView1);
        }

        private void IncreaseBtn_Click_2(object sender, EventArgs e)
        {
            stock.Increase(dataGridView1, ValueBox);
        }

        private void DecreaseBtn_Click_1(object sender, EventArgs e)
        {
            stock.Decrease(dataGridView1, ValueBox);
        }

        private void RefreshBtn_Click_1(object sender, EventArgs e)
        {
            stock.Refresh(dataGridView1);
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            stock.Save();
        }


        private void btnLowStock_Click(object sender, EventArgs e)
        {
            stock.EmptyStock(dataGridView1);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            stock.ShowEmployees(dataGridView1);
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1)You can create a new row and fill data manually or press input data. " +
                "2)To delete a row choose the most left column. " +
                "3)Click on the value you want to increase/decrease and press a button. " +
                "4)Refresh to see the original table. ", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Seemorebtn_Click(object sender, EventArgs e)
        {
            stock.SeeMore(dataGridView1, sdl.LastSQL, 10);
        }

        private void RowResetbtn_Click(object sender, EventArgs e)
        {
            sdl.MaxRows = 0;
            stock.SeeMore(dataGridView1, sdl.LastSQL, 10);
        }

        public string ChooseFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename;
                string extension = ".pdf";
                filename = sfd.FileName + extension;
                return filename;

            }
            return null;
        }

        public void ExportToPdf(DataGridView dgv)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter w = PdfWriter.GetInstance(doc, new FileStream(ChooseFile(), FileMode.Create));
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
            MessageBox.Show("Stock info Exported", "File Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
           ExportToPdf(dataGridView1);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnMenuAdminLogs_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminLog admin = new AdminLog(userValidation);
            admin.Show();
        }

        private void btnMenuScheduling_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeeScheduling scheduling = new EmployeeScheduling(userValidation);
            scheduling.Show();
        }

        private void btnMenuDepartmentManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            DepartmentManagement department = new DepartmentManagement(userValidation);
            department.Show();
        }

        private void btnMenuRoleManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            RoleManagement role = new RoleManagement(userValidation);
            role.Show();
        }

        private void btnMenuEmployeeManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee_Management employee = new Employee_Management(userValidation);
            employee.Show();
        }

        private void btnMenuSchedule_Click(object sender, EventArgs e)
        {
            this.Close();
            ShoppersonalSchedule shoppersonal = new ShoppersonalSchedule(userValidation);
            shoppersonal.Show();
        }

        private void btnMenuPersonalDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateDetailsForm update = new UpdateDetailsForm(userValidation);
            update.Show();
        }

        private void btnMenuStock_Click(object sender, EventArgs e)
        {
            this.Close();
            ShopPersonnel shop = new ShopPersonnel(userValidation);
            shop.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string a = tbProductName.Text;
                double b = Convert.ToDouble(tbProductPrice.Text);
                int c = Convert.ToInt32(tbProductQuantity.Text);
                string d = comboBox1.Text;
                int mq = Convert.ToInt32(tbProductMinQuantity.Text);
                string f = tbProductDescription.Text;
                stock.StockInput(a, b, c, d, mq, f);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

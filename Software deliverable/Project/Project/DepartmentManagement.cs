using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Project.LGC;

namespace Project
{
    public partial class DepartmentManagement : Form
    {
        int departmentID = 0;
        private string userValidation;   
        Department department;
        DepartmentManagementClass dmc;
        LogsClass lc;
        public void DeactivateShopPersonnelbtn()
        {
            btnMenuStock.Visible = false;
            btnMenuSchedule.Visible = false;
        }
        public DepartmentManagement(string validation)
        {
            InitializeComponent();
            if(validation == "Admin")
            {
                DeactivateShopPersonnelbtn();
                userValidation = validation;
            }

            dmc = new DepartmentManagementClass();
            lc = new LogsClass();

            dmc.InitializeListOfClasses();
            dgvDepartments.DataSource = dmc.GetAllDepartments();
        }

        public void LoadNewData()
        {
            //the code here is to empty the dat grid view and then load in the new data in the list  
            dgvDepartments.DataSource = null;
            dgvDepartments.Rows.Clear();         
            dgvDepartments.DataSource = dmc.GetAllDepartments();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row;
            try
            {
                row = dgvDepartments.Rows[e.RowIndex];
                departmentID = Convert.ToInt32(row.Cells[0].Value);
                tbDepartmentName.Text = dgvDepartments.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                department = new Department();
                department.DepartmentName = tbDepartmentName.Text;
                if (dmc.AddDepartment(department) == true)
                {
                    //dm.NewDepartmentLog(department);
                    MessageBox.Show("Information Added", "Department Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNewData();
                    lc.AddNewDepartmentLog(department);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool DepartmentRemoveMessageBoxYesNo()
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to remomve this department",
             "Remove department", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                if (dialog == DialogResult.No)
                {
                    return false;
                }
            }
            return false;
        }

        private void btnRemoveaDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartmentRemoveMessageBoxYesNo() == true)
                {
                    if (dmc.RemoveDepartment(departmentID) == true)
                    {
                        //dm.DepartmentRemovelLog(tbDepartmentName.Text);
                        MessageBox.Show("Information Removed", "Department Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNewData();
                        lc.AddNewDepartmentRemoveLog(department);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                department = new Department();
                department.DepartmentName = tbDepartmentName.Text;
                department.ID = departmentID;
                if (dmc.UpdateDepartment(department) == true)
                {
                    //dm.DepartmentUpdateLog(department);
                    MessageBox.Show("Information Updated", "Department Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNewData();
                    lc.AddNewDepartmentUpdateLog(department);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadNewData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this form you can edit and add departments into the system. " +
                " To add you input the name of the department via the textbox and click the add button" +
                " To remove a department you select the department and click remove, " +
                " Note(when a department is selected the entire row will be highlighted blue) " +
                " To update a department you select the department, " +
                "input the new department name via the textbox and finally click update ", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnVIewEmployeeDepartments_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDepartments.DataSource = dmc.FIllWithEmployeeAndDepartment();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnMenuStockManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            StockManagement stock = new StockManagement(userValidation);
            stock.Show();
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
            prg.Add(new Chunk("Department Info", font)); //adding a heading to the PDF
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
            MessageBox.Show("Department info Exported", "File Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExportToPdf(dgvDepartments);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Project.DAL;
using System.Windows.Forms;

namespace Project.LGC
{
    public class StockManager: IObjectList
    {
        private StockDAL sdl;
        private List<StockItem> stockItems;
        public StockManager()
        {
            stockItems = new List<StockItem>();
            sdl = new StockDAL();
        }
        public List<StockItem> GetAllItems()
        {
            return stockItems;
        }
        public void InitializeListOfClasses()
        {
            AddAllItems();
        }
        public void AddAllItems()
        {
            sdl.AddToDtbListOfItems();
            foreach (var item in sdl.GetListOfAllItemsFromDatabase())
            {
                stockItems.Add(item);
            }
        }

        public bool Search(DataGridView datagrid, TextBox textbox)
        {
            if (sdl.SearchDatabase(datagrid, textbox) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NewRow(DataGridView datagrid)
        {
            if (sdl.NewDatabaseRow(datagrid) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteRow(DataGridView datagrid)
        {
            if (sdl.DeleteDatabaseRow(datagrid) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Increase(DataGridView datagrid, TextBox textbox)
        {
            if (sdl.IncreaseDatabaseValue(datagrid, textbox) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Decrease(DataGridView datagrid, TextBox textbox)
        {
            if (sdl.DecreaseDatabaseValue(datagrid, textbox) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Refresh(DataGridView datagrid)
        {
            if (sdl.RefreshDatabase(datagrid) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Save()
        {
            if (sdl.SaveChanges() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EmptyStock(DataGridView datagrid)
        {
            if (sdl.CheckDatabaseEmptyStock(datagrid) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool StockInput(string a, double b, int c, string d, int e, string f)
        {
            if (sdl.DatabaseStockInput(a, b, c, d, e, f) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FillCombo(ComboBox a)
        {
            if (sdl.DatabaseFillCombo(a) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ShowSchedule(DataGridView datagrid)
        {
            if (sdl.ShowDatabaseSchedule(datagrid) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ShowEmployees(DataGridView datagrid)
        {
            if (sdl.ShowDatabaseEmployees(datagrid) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ShowDetails(DataGridView datagrid)
        {
            if (sdl.ShowEmployeeDetails(datagrid) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SeeMore(DataGridView datagrid, string sql, int increase)
        {
            if (sdl.SeeMoreData(datagrid, sql, increase) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string SaveFile()
        {
            string filename;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
                return filename;
            }
            return null;
        }
        public void ExportToPdf(DataGridView dgv)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog sfd = new SaveFileDialog();
            PdfWriter w = PdfWriter.GetInstance(doc, new FileStream(SaveFile(), FileMode.Create));
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

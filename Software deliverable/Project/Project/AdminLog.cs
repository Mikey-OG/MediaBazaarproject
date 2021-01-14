using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAL;

namespace Project
{
    public partial class AdminLog : Form
    {
        EmployeeManagementDAL gm;

        public AdminLog()
        {
            InitializeComponent();        
            gm = new EmployeeManagementDAL();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            gm.FillWithLogs(ltbAdminLog);
        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            //gm.RemoveLog();
        }
    }
}

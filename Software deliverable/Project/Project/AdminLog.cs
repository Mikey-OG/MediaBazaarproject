using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdminLog : Form
    {
<<<<<<< HEAD
        public AdminLog()
        {
            InitializeComponent();
=======
        GeneralManagement gm;
        public AdminLog()
        {
            InitializeComponent();
            gm = new GeneralManagement();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            gm.FillWithLogs(ltbAdminLog);
>>>>>>> Osuntuyi-Michael
        }
    }
}

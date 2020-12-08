using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class test : Form
    {
         GeneralManagement generalManagement = new GeneralManagement();
        public test()
        {
            InitializeComponent();          
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbPassword.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$"))
            {
                if (generalManagement.ChangePasswordMessageBoxYesNo() == true)
                {
                    generalManagement.ChangePassword(Convert.ToString(Variables.User), tbPassword.Text);
                    tbPassword.Text = "";
                    MessageBox.Show("Password changed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please ensure your password" +
                " possesses at least one lowercase character " +
                " at least one uppercase charater " +
                " at least one numeric character between 0-9 " +
                " and is at least 8-15 characters long " +
                " e.g (Mikoko02, Kirill02, lucM2002) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

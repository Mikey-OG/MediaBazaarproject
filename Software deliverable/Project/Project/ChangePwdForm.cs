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
using Project.LGC;

namespace Project
{
    public partial class ChangePwdForm : Form
    {
        private string userName;
        LogInClass lc;

        public ChangePwdForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            lc = new LogInClass();
        }

        public bool ChangePasswordMessageBoxYesNo()
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to change your password",
             "Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbPassword.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$"))
            {
                if (ChangePasswordMessageBoxYesNo() == true)
                {
                    lc.ChangePassword(userName, tbPassword.Text);
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}

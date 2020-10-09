using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Project
{
    public partial class RoleManagement : Form
    {
        string UserValidation;
        GeneralManagement gm;
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;");
        int roleID;
        public RoleManagement(string validation)
        {
            InitializeComponent();
            gm = new GeneralManagement();
            gm.FillWithRoles(dataGridView1);
            FillFormAccessComboBox();
            if(validation == "Admin")
            {
                UserValidation = "Admin";
            }
        }
        public void FillFormAccessComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM roles GROUP BY FormAccess;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sFormName = dr.GetString("FormAccess");
                    cmbFormAccess.Items.Add(sFormName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            Roles role = new Roles(tbRole.Text);
            if (gm.AddRole(role, cmbFormAccess.Text)==true)
            {
                MessageBox.Show("Information Added", "Role Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            gm.FillWithRoles(dataGridView1);
        }

        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            if(gm.RemoveRole(roleID)==true)
            {
                MessageBox.Show("Information Removed", "Role Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }     
            gm.FillWithRoles(dataGridView1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Roles role = new Roles(tbRole.Text);
            if(gm.UpdateRole(role,cmbFormAccess.Text, roleID) == true)
            {
                MessageBox.Show("Information Updated", "Role Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            gm.FillWithRoles(dataGridView1);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            roleID = Convert.ToInt32(row.Cells[0].Value);
        }

        //create a yes or no message box here
        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            GeneralEmployeeForm generalEmployeeForm;
            try
            {
                generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
                generalEmployeeForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this form you can edit and add roles into the system. " +
                " To add you input the name of the role via the textbox and click the add button" +
                " To remove a role you select the role and click remove, " +
                " Note(when a role is selected the entire row will be highlighted blue) " +
                " To update a role you select the role, " +
                "input the new role name via the textbox and finally click update ", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                gm.FillWithRoles(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVIewEmployeeandRoles_Click(object sender, EventArgs e)
        {
            try
            {
                gm.FIllWithEmployeeAndRole(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

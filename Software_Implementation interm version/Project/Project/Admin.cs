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
    public partial class Admin : Form
    {
        private GeneralManagement gm;
        public Admin()
        {
            InitializeComponent();
            gm = new GeneralManagement();
        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            gm.FillWithEmployee(dataGridView1);
        }


        private void btnAddRole_Click(object sender, EventArgs e)
        {
            //Roles role = new Roles(tbRoleName.Text, Convert.ToInt16(tbRoleID.Text));
            //gm.AddRole(role);
            //MessageBox.Show("Information Added", "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVIewStock_Click_1(object sender, EventArgs e)
        {
            gm.FillWithStock(dataGridView1);
        }

        private void btnViewRoleandDepartment_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdateEmployee_Click_1(object sender, EventArgs e)
        {
            Employee employee = new Employee(Convert.ToInt16(tbUserID.Text), tbPassword.Text, tbUserName.Text, tbFirstName.Text,
                tbLastName.Text, tbEmail.Text, Convert.ToInt32(tbPhoneNumber.Text), tbNationality.Text, tbCity.Text, tbZipCode.Text,
                dtDOB.Text, dtDOH.Text, tbAdress.Text, Convert.ToInt32(tbDepartmentID.Text), Convert.ToInt16(tbRoleID.Text), Convert.ToInt32(tbSalary.Text));
            gm.UpdateEMployee(employee);
            MessageBox.Show("Information Updated", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveEmployee_Click_1(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt16(tbRemoveID.Text);
            gm.RemoveEmployee(employeeID);
        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            Employee employee = new Employee(Convert.ToInt16(tbUserID.Text), tbPassword.Text, tbUserName.Text, tbFirstName.Text,
                tbLastName.Text, tbEmail.Text, Convert.ToInt32(tbPhoneNumber.Text), tbNationality.Text, tbCity.Text, tbZipCode.Text,
                dtDOB.Text, dtDOH.Text, tbAdress.Text, Convert.ToInt32(tbDepartmentID.Text), Convert.ToInt16(tbRoleID.Text), Convert.ToInt32(tbSalary.Text));
            if (gm.AddEmployee(employee) == true)
            {
                this.timer1.Start();
                MessageBox.Show("Information Added", "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void btnViewDepartments_Click_1(object sender, EventArgs e)
        {
            gm.FillWithDepartments(dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gm.FillWithRoles(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}

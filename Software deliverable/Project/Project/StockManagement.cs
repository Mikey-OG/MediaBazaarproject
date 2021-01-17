﻿using System;
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
using Project.DAL;

namespace Project
{
    public partial class StockManagement : Form
    {
        private string userValidation;
        private StockManager stock = new StockManager();
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
            stock.FillTable(dataGridView1);
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



        private void button2_Click(object sender, EventArgs e)
        {
            StockInput InputForm = new StockInput();
            InputForm.Show();
        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            stock.EmptyStock(dataGridView1);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            stock.ShowEmployees(dataGridView1);
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            //GeneralEmployeeForm generalEmployeeForm = new GeneralEmployeeForm(UserValidation);
            //generalEmployeeForm.Show();
            //this.Hide();
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
            stock.SeeMore(dataGridView1, stock.LastSQL, 10);
        }

        private void RowResetbtn_Click(object sender, EventArgs e)
        {
            stock.MaxRows = 0;
            stock.SeeMore(dataGridView1, stock.LastSQL, 10);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            generalManagement.LogOut(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stock.ExportToPdf(dataGridView1);
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
    }
}

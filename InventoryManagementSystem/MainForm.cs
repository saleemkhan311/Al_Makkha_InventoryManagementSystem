﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);

            }
            Form f = Form as Form;

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();

        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            loadForm(new Product());
        }


        private void MinimizeAppButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DashboardButton.Select();
            loadForm(new Dashboard());
        }

        private void SaleButton_Click(object sender, EventArgs e)
        {

            loadForm(new Sale());
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            loadForm(new Customers());
        }

        private void SaleLedgerButton_Click(object sender, EventArgs e)
        {
            loadForm(new SaleLedger());
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            loadForm(new UserPanel());
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            loadForm(new Orders());
        }

        private void abcd_Click(object sender, EventArgs e)
        {

        }
    }
}

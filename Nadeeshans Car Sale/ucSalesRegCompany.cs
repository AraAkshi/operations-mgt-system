﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Nadeeshans_Car_Sale
{
    public partial class ucSalesRegCompany : UserControl
    {
        private static ucSalesRegCompany _instance;

        public static ucSalesRegCompany Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucSalesRegCompany();
                }
                return _instance;
            }
        }

        public ucSalesRegCompany()
        {
            InitializeComponent();
        }

        private void ucSalesRegCompany_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.CharacterCasing = CharacterCasing.Upper;
            //string selectStatement = "SELECT customerName FROM tblcustomer WHERE customerNIC like '%" + txtName.Text + "%'";
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage.Instance.Show();
        }

        private void btnViewMore_Click(object sender, EventArgs e)
        {
            List<MySqlParameter> paramlist = new List<MySqlParameter>();
            paramlist.Clear();
            paramlist.Add(new MySqlParameter("@address", txtAddress.Text));
            paramlist.Add(new MySqlParameter("@customerName", txtName.Text));
            paramlist.Add(new MySqlParameter("@customerTel", txtContactNumber.Text));
            paramlist.Add(new MySqlParameter("@notes", txtSpecialNotes.Text));

            string query = "INSERT INTO tblcustomer VALUES (@customerName, @customerName, @address, 'BUYER', 'REG_COMPANY', @customerTel)";
            int rowsAffedted = DatabaseHandler.insertOrDeleteRow(query, paramlist);

            if (rowsAffedted == 1)
            {
                try
                {
                    
                    if (!frmHomepage.Instance.pnlcontainer.Controls.Contains(ucVehicleDetails.Instance))
                    {
                        frmHomepage.Instance.pnlcontainer.Controls.Add(ucVehicleDetails.Instance);
                        ucVehicleDetails.Instance.Dock = DockStyle.Fill;
                        ucVehicleDetails.Instance.BringToFront();
                        GlobalLoginData.customerId = txtName.Text;
                    }
                    else
                    {
                        ucVehicleDetails.Instance.BringToFront();
                        GlobalLoginData.customerId = txtName.Text;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Operation Unsuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Error Occured!");
            }
        }
    }
}

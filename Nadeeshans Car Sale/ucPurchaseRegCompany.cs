using System;
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
    public partial class ucPurchaseRegCompany : UserControl
    {
        private static ucPurchaseRegCompany _instance;

        public static ucPurchaseRegCompany Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucPurchaseRegCompany();
                }
                return _instance;
            }
        }

        public ucPurchaseRegCompany()
        {
            InitializeComponent();
        }

        private void ucPurchaseRegCompany_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void UppercaseCharacters(TextBox txt)
        {
            txt.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UppercaseCharacters(txtName);
            //string selectStatement = "SELECT customerName FROM tblcustomer WHERE customerNIC like '%" + txtName.Text + "%'";
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            UppercaseCharacters(txtAddress);
        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            UppercaseCharacters(txtContactNumber);
        }

        private void btnViewMore_Click(object sender, EventArgs e)
        {
            List<MySqlParameter> paramlist = new List<MySqlParameter>();
            paramlist.Clear();
            paramlist.Add(new MySqlParameter("@address", txtAddress.Text));
            paramlist.Add(new MySqlParameter("@nic", txtName.Text));
            paramlist.Add(new MySqlParameter("@customerName", txtName.Text));
            paramlist.Add(new MySqlParameter("@customerTel", txtContactNumber.Text));
            paramlist.Add(new MySqlParameter("@notes", txtSpecialNotes.Text));

            string query = "INSERT INTO tblcustomer VALUES (@nic, @customerName, @address, 'SELLER', 'REG_COMPANY', @customerTel)";
            int rowsAffedted = DatabaseHandler.insertOrDeleteRow(query, paramlist);

            if (rowsAffedted == 1)
            {
                try
                {                    
                    ucVehicleDetails temp = new ucVehicleDetails();

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
                MessageBox.Show("Error Occured!" + rowsAffedted);
            }
            //this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage.Instance.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

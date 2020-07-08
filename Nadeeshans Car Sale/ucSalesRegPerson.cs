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
    public partial class ucSalesRegPerson : UserControl
    {
        private static ucSalesRegPerson _instance;

        public static ucSalesRegPerson Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucSalesRegPerson();
                }
                return _instance;
            }
        }

        public ucSalesRegPerson()
        {
            InitializeComponent();
        }

        
        private void ucSalesRegPerson_Load(object sender, EventArgs e)
        {

        }
        
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            txtname.CharacterCasing = CharacterCasing.Upper;
            //string selectStatement = "SELECT customerName FROM tblcustomer WHERE customerNIC like '%" + txtNIC.Text + "%'";
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            txtNIC.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.CharacterCasing = CharacterCasing.Upper;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage.Instance.Show();
        }

        private void btnViewMore_Click(object sender, EventArgs e)
        {
            List<MySqlParameter> paramlist = new List<MySqlParameter>();
            paramlist.Clear();
            paramlist.Add(new MySqlParameter("@nic", txtNIC.Text));
            paramlist.Add(new MySqlParameter("@address", txtAddress.Text));
            paramlist.Add(new MySqlParameter("@customerName", txtname.Text));
            paramlist.Add(new MySqlParameter("@customerTel", txtcontact.Text));
            paramlist.Add(new MySqlParameter("@notes", txtSpecialNotes.Text));

            string query = "INSERT INTO tblcustomer VALUES (@nic, @customerName, @address, 'BUYER', 'REG_PERSON', @customerTel)";
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
                        GlobalLoginData.customerId = txtNIC.Text;
                    }
                    else
                    {
                        ucVehicleDetails.Instance.BringToFront();
                        GlobalLoginData.customerId = txtNIC.Text; 
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

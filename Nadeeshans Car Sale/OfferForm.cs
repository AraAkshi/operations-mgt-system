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

namespace Nadeeshans_Car_Sale
{
    public partial class OfferForm : Form
    {
        public static OfferForm _instance;
        
        public static OfferForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OfferForm();
                return _instance;
            }
        }

        //public string vehicleId;

        /*public void getVehicleId(string id) {
            GlobalLoginData.vehicleId = id;
        }*/

        public OfferForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<MySqlParameter> paramlist = new List<MySqlParameter>();
            paramlist.Clear();
            paramlist.Add(new MySqlParameter("@vehicleId", GlobalLoginData.vehicleId));
            paramlist.Add(new MySqlParameter("@customerName", txtName.Text));
            paramlist.Add(new MySqlParameter("@customerTel", txtContactNo.Text));
            paramlist.Add(new MySqlParameter("@toPurchaseDate", dateToPurchase.Value));
            //paramlist.Add(new MySqlParameter("@email", txtEmail.Text));
            paramlist.Add(new MySqlParameter("@amount", Convert.ToDouble(txtAmount.Text)));

            string query = "INSERT INTO tbloffers (vehicleID, customerFirstName, customerContact, offerDate, offerAmount) VALUES (@vehicleId, @customerName, @customerTel, @toPurchaseDate, @amount)";
            int rowsAffedted = DatabaseHandler.insertOrDeleteRow(query, paramlist);

            if (rowsAffedted == 1)
            {
                try
                {
                    MessageBox.Show("New Inquiry Added Successfully!");
                    //DatabaseHandler.populateGridViewWithBinding(ucSearchCars.queryOffer, ucSearchCars.datagridOffersVehicle);
                }
                catch (Exception)
                {
                    MessageBox.Show("Inquiry Not Added!");
                }
            }
            else
            {
                MessageBox.Show("Error Occured!" );
            }
        }

        private void txtAmountOfferDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void OfferForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using System.IO;

namespace Nadeeshans_Car_Sale
{
    public partial class ucViewSelectedCar : UserControl
    {
        public static ucViewSelectedCar _instance;
        public string vehicleId;

        public static ucViewSelectedCar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucViewSelectedCar();
                }
                return _instance;
            }
        }
        
        public ucViewSelectedCar()
        {
            InitializeComponent();
        }

        private void btnAddOffer_Click(object sender, EventArgs e)
        {
            OfferForm dash = new OfferForm();
            dash.Show();
        }

        private void ucViewSelectedCar_Load(object sender, EventArgs e)
        {
            
            string queryOffer = "SELECT customerFirstName as 'Name', offerAmount as 'Amount', customerContact as 'Contact', offerDate as 'To Purchase Date', offerSpecialNote as 'Notes' from tbloffers where vehicleId = '"+GlobalLoginData.vehicleId+"'";
            DatabaseHandler.populateGridViewWithBinding(queryOffer, datagridOffersVehicle);

            string queryVehicle = "select * from tblvehicle where tblvehicle.vehicleID = vehicleId";

            txtPriceViewVehicle.Text = DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "price");
            txtMakeViewVehicle.Text = DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "vehicleMake");
            txtMadelViewVehicle.SelectedText = DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "vehicleModel");
            txtStatusViewVehicle.SelectedText = DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "vehicleStatus");
            txtYearOfManufactureViewVehicle.Text = DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "vehicleManufacturedDate");

            //byte[] img1 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "vehicleImageOne"));
            //byte[] img2 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "vehicleImageTwo"));
            //byte[] img3 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "vehicleImageThree"));
            //byte[] img4 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "vehicleImageFour"));
            //byte[] img5 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(queryVehicle, "vehicleImageFive"));

            //MemoryStream ms = new MemoryStream(img1);

            //picBoxViewCar01.Image = Image.FromStream(ms);
            //picBoxViewCar02.Image = Image.FromStream(new MemoryStream(img2));
            //picBoxViewCar03.Image = Image.FromStream(new MemoryStream(img3));
            //picBoxViewCar04.Image = Image.FromStream(new MemoryStream(img4));
            //picBoxViewCar05.Image = Image.FromStream(new MemoryStream(img5));
        }

        private void btnViewMore_Click(object sender, EventArgs e)
        {
            
            if (!frmHomepage.Instance.pnlcontainer.Controls.Contains(viewUser.Instance))
            {
                frmHomepage.Instance.pnlcontainer.Controls.Add(viewUser.Instance);
                viewUser.Instance.Dock = DockStyle.Fill;
                viewUser.Instance.BringToFront();
                GlobalLoginData.vehicleId = vehicleId;
                //MessageBox.Show(vehicleId);
            }
            else
            {
                ucVehicleDetails.Instance.BringToFront();
                GlobalLoginData.vehicleId = vehicleId;
                //MessageBox.Show(vehicleId);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!frmHomepage.Instance.pnlcontainer.Controls.Contains(ucSearchCars.Instance))
            {
                frmHomepage.Instance.pnlcontainer.Controls.Add(ucSearchCars.Instance);
                ucSearchCars.Instance.Dock = DockStyle.Fill;
                ucSearchCars.Instance.BringToFront();
            }
            else
                ucSearchCars.Instance.BringToFront();
        }
    }
}

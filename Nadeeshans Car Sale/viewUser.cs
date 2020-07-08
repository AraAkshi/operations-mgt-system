using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nadeeshans_Car_Sale
{
    public partial class viewUser : UserControl
    {
        public static viewUser _instance;
        public static viewUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new viewUser();
                }
                return _instance;
            }
        }
        public viewUser()
        {
            InitializeComponent();
        }

        private void viewUser_Load(object sender, EventArgs e)
        {
            
                string query = "select * from tblvehicle where tblvehicle.vehicleID = '" + GlobalLoginData.vehicleId + "'";
                int rows = DatabaseHandler.returnRowCountWithoutParams(query);

                if (rows == 1)
                {
                                      btnEdit.Show();

                    txtVehicleRegNo.Text = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleRegNo");
                    txtMake.Text = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleMake");
                    cmbModel.SelectedText = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleModel");
                    cmbVehicleStatus.SelectedText = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleStatus");
                    cmbFuelType.SelectedText = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleFuelType");
                    cmbTransmissionGear.SelectedText = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleTransmissionGear");
                    txtChassisNo.Text = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleChasisNo");
                    txtEngineNo.Text = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleEngineNo");
                    txtCylinderCapacity.Text = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleCylinderCapacity");
                    txtColor.Text = DatabaseHandler.returnOneValueWithoutParams(query, "vehicleColor");
                    cmbOriginCountry.SelectedText = DatabaseHandler.returnOneValueWithoutParams(query, "countryOfOrigin");
                    countPreviousOwner.Value = Convert.ToInt16(DatabaseHandler.returnOneValueWithoutParams(query, "previousOwnerCount"));
                    countSeatingCapacity.Value = Convert.ToInt16(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleSeatingCapacity"));
                    countServicesDone.Value = Convert.ToInt16(DatabaseHandler.returnOneValueWithoutParams(query, "noOfServicesDone"));
                    dateFirstRegDate.Value = Convert.ToDateTime(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleRegDate"));
                    dateInsurance.Value = Convert.ToDateTime(DatabaseHandler.returnOneValueWithoutParams(query, "insuranceDate"));
                    yearManufacture.Value = Convert.ToDateTime(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleManufacturedDate"));
                    dateLastService.Value = Convert.ToDateTime(DatabaseHandler.returnOneValueWithoutParams(query, "lastServiceDate"));
                    txtInsuranceType.Text = DatabaseHandler.returnOneValueWithoutParams(query, "insuranceType");
                    txtInsuranceCompany.Text = DatabaseHandler.returnOneValueWithoutParams(query, "insuranceCompany");
                    txtSpecialNotes.Text = DatabaseHandler.returnOneValueWithoutParams(query, "specialNotes");
                    txtVehiclePrice.Text = DatabaseHandler.returnOneValueWithoutParams(query, "price");

                    //byte[] img = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleImageOne"));
                    //byte[] img2 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleImageTwo"));
                    //byte[] img3 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleImageThree"));
                    //byte[] img4 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleImageFour"));
                    //byte[] img5 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleImageFive"));
                    //byte[] img6 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleImageSix"));
                    //byte[] img7 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleImageSeven"));
                    //byte[] img8 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleImageEight"));
                    //byte[] img9 = Encoding.ASCII.GetBytes(DatabaseHandler.returnOneValueWithoutParams(query, "vehicleImageNine"));

                    //picBoxOne.Image = Image.FromStream(new MemoryStream(img));
                    //picBoxTwo.Image = Image.FromStream(new MemoryStream(img2));
                    //picBoxThree.Image = Image.FromStream(new MemoryStream(img3));
                    //picBoxFour.Image = Image.FromStream(new MemoryStream(img4));
                    //picBoxFive.Image = Image.FromStream(new MemoryStream(img5));
                    //picBoxSix.Image = Image.FromStream(new MemoryStream(img6));
                    //picBoxSeven.Image = Image.FromStream(new MemoryStream(img7));
                    //picBoxEight.Image = Image.FromStream(new MemoryStream(img8));
                    //picBoxNine.Image = Image.FromStream(new MemoryStream(img9));

                    txtVehicleRegNo.ReadOnly = true;
                    txtMake.ReadOnly = true;
                    cmbModel.Enabled = false;
                    cmbVehicleStatus.Enabled = false;
                    cmbFuelType.Enabled = false;
                    cmbTransmissionGear.Enabled = false;
                    txtChassisNo.ReadOnly = true;
                    txtCylinderCapacity.ReadOnly = true;
                    txtColor.ReadOnly = true;
                    cmbOriginCountry.Enabled = false;
                    countPreviousOwner.ReadOnly = true;
                    countSeatingCapacity.ReadOnly = true;
                    countServicesDone.ReadOnly = true;
                    dateFirstRegDate.Enabled = false;
                    dateInsurance.Enabled = false;
                    yearManufacture.Enabled = false;
                    dateLastService.Enabled = false;
                    txtInsuranceType.ReadOnly = true;
                    txtInsuranceCompany.ReadOnly = true;
                    txtSpecialNotes.ReadOnly = true;
                    picBoxOne.Enabled = false;
                    picBoxTwo.Enabled = false;
                    picBoxThree.Enabled = false;
                    picBoxFour.Enabled = false;
                    picBoxFive.Enabled = false;
                    picBoxSix.Enabled = false;
                    picBoxSeven.Enabled = false;
                    picBoxEight.Enabled = false;
                    picBoxNine.Enabled = false;
                    txtVehiclePrice.ReadOnly = true;
                }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage.Instance.Show();
        }

        private void txtCylinderCapacity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ucVehicleDetails : UserControl
    {
        public static ucVehicleDetails _instance;
        //public string customerId = null;
        //public string vehicleId = null;

        
        public static ucVehicleDetails Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucVehicleDetails();
                }
                return _instance;
            }
        }

        public ucVehicleDetails()
        {
            InitializeComponent();
        }

        private void ucVehicleDetails_Load(object sender, EventArgs e)
        {
            btnEdit.Hide();
            
        }

        private void txtVehicleRegNo_TextChanged_1(object sender, EventArgs e)
        {
            txtVehicleRegNo.CharacterCasing = CharacterCasing.Upper;
     
    }

        private void txtVehicleMileage_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVehicleMileage.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter Numbers Only!");
                txtVehicleMileage.Text = txtVehicleMileage.Text.Remove(txtVehicleMileage.Text.Length - 1);
            }
        }

        private void txtMake_TextChanged(object sender, EventArgs e)
        {
            txtMake.CharacterCasing = CharacterCasing.Upper;
        }
        
        private void txtChassisNo_TextChanged(object sender, EventArgs e)
        {
            txtChassisNo.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtEngineNo_TextChanged(object sender, EventArgs e)
        {
            txtEngineNo.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCylinderCapacity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCylinderCapacity.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter Numbers Only!");
                txtCylinderCapacity.Text = txtCylinderCapacity.Text.Remove(txtCylinderCapacity.Text.Length - 1);
            }
        }

        private void txtVehiclePrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVehiclePrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter Numbers Only!");
                txtVehiclePrice.Text = txtVehiclePrice.Text.Remove(txtVehiclePrice.Text.Length - 1);
            }
        }

        private void txtInsuranceType_TextChanged(object sender, EventArgs e)
        {
            txtInsuranceType.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtInsuranceCompany_TextChanged(object sender, EventArgs e)
        {
            txtInsuranceCompany.CharacterCasing = CharacterCasing.Upper;
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult reply;
            reply = MessageBox.Show("Do you want to Proceed? You may loose already entered details", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (reply == DialogResult.OK)
                this.Hide();
        }

        private void BrowseImage(PictureBox img)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                img.Image = Image.FromFile(opf.FileName);
            }
        }

        private void picBoxOne_Click(object sender, EventArgs e)
        {
            BrowseImage(picBoxOne);
        }

        private void picBoxTwo_Click(object sender, EventArgs e)
        {
            BrowseImage(picBoxTwo);
        }

        private void picBoxThree_Click(object sender, EventArgs e)
        {
            BrowseImage(picBoxThree);
        }

        private void picBoxFour_Click(object sender, EventArgs e)
        {
            BrowseImage(picBoxFour);
        }

        private void picBoxFive_Click(object sender, EventArgs e)
        {
            BrowseImage(picBoxFive);
        }

        private void picBoxSix_Click(object sender, EventArgs e)
        {
            BrowseImage(picBoxSix);
        }

        private void picBoxSeven_Click(object sender, EventArgs e)
        {
            BrowseImage(picBoxSeven);
        }

        private void picBoxEight_Click(object sender, EventArgs e)
        {
            BrowseImage(picBoxEight);
        }

        private void picBoxNine_Click(object sender, EventArgs e)
        {
            BrowseImage(picBoxNine);
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            txtColor.CharacterCasing = CharacterCasing.Upper;
        }
               
        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void lblservicedate_Click(object sender, EventArgs e)
        {

        }

        private void dateLastService_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage.Instance.Show();
        }

        private void btnViewMore_Click(object sender, EventArgs e)
        {
                MemoryStream ms1 = new MemoryStream();
                MemoryStream ms2 = new MemoryStream();
                MemoryStream ms3 = new MemoryStream();
                MemoryStream ms4 = new MemoryStream();
                MemoryStream ms5 = new MemoryStream();
                MemoryStream ms6 = new MemoryStream();
                MemoryStream ms7 = new MemoryStream();
                MemoryStream ms8 = new MemoryStream();
                MemoryStream ms9 = new MemoryStream();

                //picBoxOne.Image.Save(ms1, picBoxOne.Image.RawFormat);
                //picBoxTwo.Image.Save(ms2, picBoxTwo.Image.RawFormat);
                //picBoxThree.Image.Save(ms3, picBoxThree.Image.RawFormat);
                //picBoxFour.Image.Save(ms4, picBoxFour.Image.RawFormat);
                //picBoxFive.Image.Save(ms5, picBoxFive.Image.RawFormat);
                //picBoxSix.Image.Save(ms6, picBoxSix.Image.RawFormat);
                //picBoxSeven.Image.Save(ms7, picBoxSeven.Image.RawFormat);
                //picBoxEight.Image.Save(ms8, picBoxEight.Image.RawFormat);
                //picBoxNine.Image.Save(ms9, picBoxNine.Image.RawFormat);

                byte[] img1 = ms1.ToArray();
                byte[] img2 = ms2.ToArray();
                byte[] img3 = ms3.ToArray();
                byte[] img4 = ms4.ToArray();
                byte[] img5 = ms5.ToArray();
                byte[] img6 = ms6.ToArray();
                byte[] img7 = ms7.ToArray();
                byte[] img8 = ms8.ToArray();
                byte[] img9 = ms9.ToArray();

                List<MySqlParameter> paramlist = new List<MySqlParameter>();
                
                string query = "INSERT INTO tblvehicle VALUES " +
                    "(@RegNo, @customerNIC, @firstRegDate, @status, @chassisNo, @engineNo, @manufactureYear, @cc, @color, @mileage, @fuelType, @Make, @Model, @origin,@TransmissionGear, " +
                    "@seatingCapacity, @ownerCount, @insuType, @insuCompanny, @insuDate, @lastservice, @serviceCount, @img1, @img2, @img3, @img4, @img5, @img6, @img7, @img8, @img9, @notes, @price)";

            paramlist.Clear();
            paramlist.Add(new MySqlParameter("@RegNo", txtVehicleRegNo.Text));
            paramlist.Add(new MySqlParameter("@customerNIC", GlobalLoginData.customerId));
            paramlist.Add(new MySqlParameter("@Make", txtMake.Text));
            paramlist.Add(new MySqlParameter("@Model", cmbModel.SelectedText));
            paramlist.Add(new MySqlParameter("@status", cmbVehicleStatus.SelectedText));
            paramlist.Add(new MySqlParameter("@fuelType", cmbFuelType.SelectedText));
            paramlist.Add(new MySqlParameter("@TransmissionGear", cmbTransmissionGear.SelectedText));
            paramlist.Add(new MySqlParameter("@mileage", txtVehicleMileage.Text));
            paramlist.Add(new MySqlParameter("@chassisNo", txtChassisNo.Text));
            paramlist.Add(new MySqlParameter("@engineNo", txtEngineNo.Text));
            paramlist.Add(new MySqlParameter("@cc", txtCylinderCapacity.Text));
            paramlist.Add(new MySqlParameter("@color", txtColor.Text));
            paramlist.Add(new MySqlParameter("@origin", cmbOriginCountry.SelectedText));
            paramlist.Add(new MySqlParameter("@ownerCount", countPreviousOwner.Value));
            paramlist.Add(new MySqlParameter("@seatingCapacity", countSeatingCapacity.Value));
            paramlist.Add(new MySqlParameter("@serviceCount", countServicesDone.Value));
            paramlist.Add(new MySqlParameter("@firstRegDate", dateFirstRegDate.Value));
            paramlist.Add(new MySqlParameter("@insuType", txtInsuranceType.Text));
            paramlist.Add(new MySqlParameter("@insuCompanny", txtInsuranceCompany.Text));
            paramlist.Add(new MySqlParameter("@insuDate", dateInsurance.Value));
            paramlist.Add(new MySqlParameter("@manufactureYear", yearManufacture.Value));
            paramlist.Add(new MySqlParameter("@lastservice", dateLastService.Value));
            paramlist.Add(new MySqlParameter("@notes", txtSpecialNotes.Text));
            paramlist.Add(new MySqlParameter("@img1", null));
            paramlist.Add(new MySqlParameter("@img2", null));
            paramlist.Add(new MySqlParameter("@img3", null));
            paramlist.Add(new MySqlParameter("@img4", null));
            paramlist.Add(new MySqlParameter("@img5", null));
            paramlist.Add(new MySqlParameter("@img6", null));
            paramlist.Add(new MySqlParameter("@img7", null));
            paramlist.Add(new MySqlParameter("@img8", null));
            paramlist.Add(new MySqlParameter("@img9", null));
            paramlist.Add(new MySqlParameter("@price", txtVehiclePrice.Text));

            int rowsAffedted = DatabaseHandler.insertOrDeleteRow(query, paramlist);
            

                if (rowsAffedted >= 0)
                {
                    try
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grpboxVehicleImages_Enter(object sender, EventArgs e)
        {

        }

        private void lblyearofmanufacture_Click(object sender, EventArgs e)
        {

        }

        private void dateInsurance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void countSeatingCapacity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblinsurancedate_Click(object sender, EventArgs e)
        {

        }

        private void lblpreviousowners_Click(object sender, EventArgs e)
        {

        }

        private void countServicesDone_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblnoofservicesdone_Click(object sender, EventArgs e)
        {

        }

        private void lblfirstregistrationdate_Click(object sender, EventArgs e)
        {

        }

        private void cmbOriginCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblcountryoforigin_Click(object sender, EventArgs e)
        {

        }

        private void countPreviousOwner_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblseatingcapacity_Click(object sender, EventArgs e)
        {

        }

        private void lbltransmissiongear_Click(object sender, EventArgs e)
        {

        }

        private void lblfueltype_Click(object sender, EventArgs e)
        {

        }

        private void lblcylindercapacity_Click(object sender, EventArgs e)
        {

        }

        private void lblengineno_Click(object sender, EventArgs e)
        {

        }

        private void lblchassisno_Click(object sender, EventArgs e)
        {

        }

        private void lblmileage_Click(object sender, EventArgs e)
        {

        }

        private void lblmodels_Click(object sender, EventArgs e)
        {

        }

        private void lblVehicleMake_Click(object sender, EventArgs e)
        {

        }

        private void lblVehicleDetails_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistrationNo_Click(object sender, EventArgs e)
        {

        }

        private void yearManufacture_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateFirstRegDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTransmissionGear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblkm_Click(object sender, EventArgs e)
        {

        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbVehicleStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbllkr_Click(object sender, EventArgs e)
        {

        }

        private void txtSpecialNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblspecialnotes_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void lblvechile_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nadeeshans_Car_Sale
{
    public partial class ucSearchCars : UserControl
    {
        private static ucSearchCars _instance;

        public static ucSearchCars Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucSearchCars();
                }
                return _instance;
            }
        }

        public ucSearchCars()
        {
            InitializeComponent();
        }

        private void ucSearchCars_Load(object sender, EventArgs e)
        {
            string query = "SELECT vehicleID as 'ID', vehicleStatus as 'Status', vehicleRegNo as 'Registartion No', vehicleModel as 'Model', vehicleMake as 'Make', vehicleMileage as 'Mileage', vehicleManufacturedDate as 'Maufactured Year' from tblvehicle";
            DatabaseHandler.populateGridViewWithBinding(query, dgridCarsAllCarDetails);
        }

        
        private void dataGridViewCarsAllCarDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {                
                DataGridViewRow row = this.dgridCarsAllCarDetails.Rows[e.RowIndex];

                if (!frmHomepage.Instance.pnlcontainer.Controls.Contains(ucViewSelectedCar.Instance))
                {
                    frmHomepage.Instance.pnlcontainer.Controls.Add(ucViewSelectedCar.Instance);
                    ucViewSelectedCar.Instance.Dock = DockStyle.Fill;
                    ucViewSelectedCar.Instance.BringToFront();
                    GlobalLoginData.vehicleId = (row.Cells["ID"].Value.ToString());
                    Console.WriteLine("Assign Data: " + row.Cells["ID"].Value.ToString());
                }
                else
                {
                    ucViewSelectedCar.Instance.BringToFront();
                    GlobalLoginData.vehicleId = (row.Cells["ID"].Value.ToString());
                }
            }
        }

        private void txtSearchAllCarDetails_TextChanged(object sender, EventArgs e)
        {
            txtSearchAllCarDetails.CharacterCasing = CharacterCasing.Upper;
            string query = "SELECT vehicleStatus as 'Status', vehicleRegNo as 'Registartion No', vehicleModel as 'Model', vehicleMake as 'Make', vehicleMileage as 'Mileage', vehicleManufacturedDate as 'Maufactured Year' from tblvehicle WHERE tblvehicle.vehicleRegNo like '%" + txtSearchAllCarDetails.Text + "%' OR tblvehicle.vehicleModel like '%" + txtSearchAllCarDetails.Text + "%' OR tblvehicle.vehicleMake like '%" + txtSearchAllCarDetails.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(query, dgridCarsAllCarDetails);
        }

        private void dateTimePickerYearofManufactureAllCarDetails_ValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT vehicleStatus as 'Status', vehicleRegNo as 'Registartion No', vehicleModel as 'Model', vehicleMake as 'Make', vehicleMileage as 'Mileage', vehicleManufacturedDate as 'Maufactured Year' from tblvehicle WHERE tblvehicle.vehicleManufacturedDate like '%" + dateManufactured.Value + "%'";
            DatabaseHandler.populateGridViewWithBinding(query, dgridCarsAllCarDetails);
        }

        private void cmbModeAllCarDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT vehicleStatus as 'Status', vehicleRegNo as 'Registartion No', vehicleModel as 'Model', vehicleMake as 'Make', vehicleMileage as 'Mileage', vehicleManufacturedDate as 'Maufactured Year' from tblvehicle WHERE tblvehicle.vehicleMake like '%" + cmbMake.SelectedText + "%'";
            DatabaseHandler.populateGridViewWithBinding(query, dgridCarsAllCarDetails);
        }

        private void cmbMakeAllCarDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT vehicleStatus as 'Status', vehicleRegNo as 'Registartion No', vehicleModel as 'Model', vehicleMake as 'Make', vehicleMileage as 'Mileage', vehicleManufacturedDate as 'Maufactured Year' from tblvehicle WHERE tblvehicle.vehicleModel like '%" + cmbModel.SelectedText + "%'";
            DatabaseHandler.populateGridViewWithBinding(query, dgridCarsAllCarDetails);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}

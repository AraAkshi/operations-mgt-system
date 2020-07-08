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
    public partial class ucInquiriesForm : UserControl
    {
        private static ucInquiriesForm _instance;


        public static ucInquiriesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucInquiriesForm();
                }
                return _instance;
            }
        }
        public ucInquiriesForm()
        {
            InitializeComponent();
        }

        private void ucInquiriesForm_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            
        }

        private void populateDataGrid()
        {
            string query = "SELECT customerName as 'Customer Name', customerAddress as 'Address', customerContact as 'Contact', vehicleModel as 'Model', vehicleMake as 'Make', specialNotes as 'Notes' from tblinquiries";
            DatabaseHandler.populateGridViewWithBinding(query, dgridAllInquiries);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string vehicleModel = txtModel.Text;
            string vehicleMake = cmbMake.SelectedText;
            string inquirySpecialNotes = txtSpecialNotes.Text;
            string customerName = txtName.Text;
            string customerTel = txtPhoneNumber.Text;
            string customerAdd = txtEmail.Text;


            List<MySqlParameter> paramlist = new List<MySqlParameter>();
            paramlist.Clear();
            paramlist.Add(new MySqlParameter("@vehicleModel", vehicleModel));
            paramlist.Add(new MySqlParameter("@vehicleMake", vehicleMake));
            paramlist.Add(new MySqlParameter("@customerName", customerName));
            paramlist.Add(new MySqlParameter("@specialNotes", inquirySpecialNotes));
            paramlist.Add(new MySqlParameter("@customerContact", customerTel));
            paramlist.Add(new MySqlParameter("@customerAddress", customerAdd));

            string query = "INSERT INTO tblinquiries (customerName, customerContact, customerAddress, vehicleModel, vehicleMake, specialNotes) VALUES (@customerName, @customerContact, @customerAddress, @vehicleModel, @vehicleMake, @specialNotes)";
            int rowsAffedted = DatabaseHandler.insertOrDeleteRow(query, paramlist);

            if (rowsAffedted == 1)
            {
                try
                {
                    MessageBox.Show("New Inquiry Added Successfully!");
                    populateDataGrid();

                }
                catch (Exception)
                {
                    MessageBox.Show("Inquiry Not Added!");
                }
            }
            else
            {
                MessageBox.Show("Error Occured!" + rowsAffedted);
            }
            
        }

        private void cmbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectStatement = "SELECT customerName as 'Customer Name', customerAddress as 'Address', customerContact as 'Contact', vehicleModel as 'Model', vehicleMake as 'Make', specialNotes as 'Notes' FROM tblinquiries WHERE vehicleMake like '%" + cmbMake.SelectedText + "%'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement, dgridAllInquiries);
        }

        private void txtSpecialNotes_TextChanged(object sender, EventArgs e)
        {
            string selectStatement = "SELECT customerName as 'Customer Name', customerAddress as 'Address', customerContact as 'Contact', vehicleModel as 'Model', vehicleMake as 'Make', specialNotes as 'Notes' FROM tblinquiries WHERE specialNotes like '%" + txtSpecialNotes.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement, dgridAllInquiries);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UppercaseCharacters(txtName);
            string selectStatement = "SELECT customerName as 'Customer Name', customerAddress as 'Address', customerContact as 'Contact', vehicleModel as 'Model', vehicleMake as 'Make', specialNotes as 'Notes' FROM tblinquiries WHERE customerName like '%" + txtName.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement, dgridAllInquiries);
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            UppercaseCharacters(txtPhoneNumber);
            string selectStatement = "SELECT customerName as 'Customer Name', customerAddress as 'Address', customerContact as 'Contact', vehicleModel as 'Model', vehicleMake as 'Make', specialNotes as 'Notes' FROM tblinquiries WHERE customerContact like '%" + txtSpecialNotes.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement, dgridAllInquiries);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string selectStatement = "SELECT customerName as 'Customer Name', customerAddress as 'Address', customerContact as 'Contact', vehicleModel as 'Model', vehicleMake as 'Make', specialNotes as 'Notes' FROM tblinquiries WHERE customerAddress like '%" + txtEmail.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement, dgridAllInquiries);
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            UppercaseCharacters(txtModel);
            string selectStatement = "SELECT customerName as 'Customer Name', customerAddress as 'Address', customerContact as 'Contact', vehicleModel as 'Model', vehicleMake as 'Make', specialNotes as 'Notes' FROM tblinquiries WHERE vehicleModel like '%" + txtModel.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement, dgridAllInquiries);
        }

        private void lblClass_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtModel.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtSpecialNotes.Clear();
            cmbMake.SelectedIndex = 0;
        }

        private void UppercaseCharacters(TextBox txt)
        {
            txt.CharacterCasing = CharacterCasing.Upper;
        }
    }
}

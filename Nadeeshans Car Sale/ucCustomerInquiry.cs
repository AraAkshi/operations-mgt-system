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
    public partial class ucCustomerInquiry : UserControl
    {
        private static ucCustomerInquiry _instance;

        public static ucCustomerInquiry Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucCustomerInquiry();
                }
                return _instance;
            }
        }

        public ucCustomerInquiry()
        {
            InitializeComponent();
        }

        private void dgridNotifications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ucCustomerInquiry_Load(object sender, EventArgs e)
        {
            string query = "SELECT customerName as 'Customer Name', vehicleModel as 'Model', vehicleMake as 'Make' from tblinquiries";
            DatabaseHandler.populateGridViewWithBinding(query, dgridNotifications);

        }

        private void dgridNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

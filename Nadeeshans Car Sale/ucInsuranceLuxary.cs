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
    public partial class ucInsuranceLuxary : UserControl
    {
        private static ucInsuranceLuxary _instance;

        public static ucInsuranceLuxary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucInsuranceLuxary();
                }
                return _instance;
            }
        }

        public ucInsuranceLuxary()
        {
            InitializeComponent();
        }

        private void ucInsuranceLuxary_Load(object sender, EventArgs e)
        {
            string query = "SELECT customerName as 'Customer Name', vehicleModel as 'Model', vehicleMake as 'Make' from tblinquiries";
            DatabaseHandler.populateGridViewWithBinding(query, dgridNotifications);
        }

        private void dgridNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

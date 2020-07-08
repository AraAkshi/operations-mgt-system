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
    public partial class ucVehicleTransfer : UserControl
    {
        private static ucVehicleTransfer _instance;

        public static ucVehicleTransfer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucVehicleTransfer();
                }
                return _instance;
            }
        }

        public ucVehicleTransfer()
        {
            InitializeComponent();
        }

        private void ucVehicleTransfer_Load(object sender, EventArgs e)
        {

        }
    }
}

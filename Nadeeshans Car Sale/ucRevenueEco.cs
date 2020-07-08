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
    public partial class ucRevenueEco : UserControl
    {
        private static ucRevenueEco _instance;

        public static ucRevenueEco Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucRevenueEco();
                }
                return _instance;
            }
        }

        public ucRevenueEco()
        {
            InitializeComponent();
        }

        private void ucRevenueEco_Load(object sender, EventArgs e)
        {

        }
    }
}

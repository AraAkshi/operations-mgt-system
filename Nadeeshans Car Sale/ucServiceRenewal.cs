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
    public partial class ucServiceRenewal : UserControl
    {
        private static ucServiceRenewal _instance;

        public static ucServiceRenewal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucServiceRenewal();
                }
                return _instance;
            }
        }

        public ucServiceRenewal()
        {
            InitializeComponent();
        }

        private void ucServiceRenewal_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ucPendingPayments : UserControl
    {
        private static ucPendingPayments _instance;

        public static ucPendingPayments Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucPendingPayments();
                }
                return _instance;
            }
        }

        public ucPendingPayments()
        {
            InitializeComponent();
        }

        private void ucPendingPayments_Load(object sender, EventArgs e)
        {

        }
    }
}

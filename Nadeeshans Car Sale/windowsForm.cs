using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Nadeeshans_Car_Sale
{
    public partial class frmHomepage : Form
    {
        bool isSalesPanelOpen = false;
        bool isPurchasePanelOpen = false;

        static frmHomepage _formObject;
        public static frmHomepage Instance
        {
            get
            {
                if (_formObject == null)
                    _formObject = new frmHomepage();
                return _formObject;
            }
        }

        public Panel pnlcontainer
        {
            get { return panelDashboard; }
            set { panelDashboard = value; }
        }

        public frmHomepage()
        {
            InitializeComponent();
        }

        private void frmHomepage_Load(object sender, EventArgs e)
        {
            _formObject = this;
            
        }

    
        private void btnCustomerInquiry_Click(object sender, EventArgs e)
        {

            if (!panelViewDetails.Controls.Contains(ucCustomerInquiry.Instance))
            {
                panelViewDetails.Controls.Add(ucCustomerInquiry.Instance);
                ucCustomerInquiry.Instance.Dock = DockStyle.Fill;
                ucCustomerInquiry.Instance.BringToFront();
            }
            else
                ucCustomerInquiry.Instance.BringToFront();
        }

        private void btnPendingPayments_Click(object sender, EventArgs e)
        {
            if (!panelViewDetails.Controls.Contains(ucPendingPayments.Instance))
            {
                panelViewDetails.Controls.Add(ucPendingPayments.Instance);
                ucPendingPayments.Instance.Dock = DockStyle.Fill;
                ucPendingPayments.Instance.BringToFront();
            }
            else
                ucPendingPayments.Instance.BringToFront();
        }

        private void btnServiceRenewal_Click(object sender, EventArgs e)
        {

            if (!panelViewDetails.Controls.Contains(ucServiceRenewal.Instance))
            {
                panelViewDetails.Controls.Add(ucServiceRenewal.Instance);
                ucServiceRenewal.Instance.Dock = DockStyle.Fill;
                ucServiceRenewal.Instance.BringToFront();
            }
            else
                ucServiceRenewal.Instance.BringToFront();
        }

        private void btnInsuranceLuxary_Click(object sender, EventArgs e)
        {

            if (!panelViewDetails.Controls.Contains(ucInsuranceLuxary.Instance))
            {
                panelViewDetails.Controls.Add(ucInsuranceLuxary.Instance);
                ucInsuranceLuxary.Instance.Dock = DockStyle.Fill;
                ucInsuranceLuxary.Instance.BringToFront();
            }
            else
                ucInsuranceLuxary.Instance.BringToFront();
        }

        private void btnRevenueEco_Click(object sender, EventArgs e)
        {

            if (!panelViewDetails.Controls.Contains(ucRevenueEco.Instance))
            {
                panelViewDetails.Controls.Add(ucRevenueEco.Instance);
                ucRevenueEco.Instance.Dock = DockStyle.Fill;
                ucRevenueEco.Instance.BringToFront();
            }
            else
                ucRevenueEco.Instance.BringToFront();
        }

        private void btnVehicleTransfers_Click(object sender, EventArgs e)
        {

            if (!panelViewDetails.Controls.Contains(ucVehicleTransfer.Instance))
            {
                panelViewDetails.Controls.Add(ucVehicleTransfer.Instance);
                ucVehicleTransfer.Instance.Dock = DockStyle.Fill;
                ucVehicleTransfer.Instance.BringToFront();
            }
            else
                ucVehicleTransfer.Instance.BringToFront();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            if (!panelDashboard.Controls.Contains(ucSearchCars.Instance))
            {
                panelDashboard.Controls.Add(ucSearchCars.Instance);
                ucSearchCars.Instance.Dock = DockStyle.Fill;
                ucSearchCars.Instance.BringToFront();
            }
            else
                ucSearchCars.Instance.BringToFront();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnInquiries_Click(object sender, EventArgs e)
        {
            if (!panelDashboard.Controls.Contains(ucInquiriesForm.Instance))
            {
                panelDashboard.Controls.Add(ucInquiriesForm.Instance);
                ucInquiriesForm.Instance.Dock = DockStyle.Fill;
                ucInquiriesForm.Instance.BringToFront();
            }
            else
                ucInquiriesForm.Instance.BringToFront();
        }

        public void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            //this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!isSalesPanelOpen)
            {
                panel1.Height += 20;
                if(panel1.Height == 100)
                {
                    timer1.Stop();
                    isSalesPanelOpen = true;
                }
            }else if(isSalesPanelOpen)
            {
                panel1.Height -= 20;
                if (panel1.Height == 0)
                {
                    timer1.Stop();
                    isSalesPanelOpen = false;
                }
            }

        }

        private void btnSalesRegPerson_Click(object sender, EventArgs e)
        {
            if (!panelDashboard.Controls.Contains(ucSalesRegPerson.Instance))
            {
                panelDashboard.Controls.Add(ucSalesRegPerson.Instance);
                ucSalesRegPerson.Instance.Dock = DockStyle.Fill;
                ucSalesRegPerson.Instance.BringToFront();
            }
            else
                ucSalesRegPerson.Instance.BringToFront();
        }

        private void btnSalesRegCom_Click(object sender, EventArgs e)
        {
            if (!panelDashboard.Controls.Contains(ucSalesRegCompany.Instance))
            {
                panelDashboard.Controls.Add(ucSalesRegCompany.Instance);
                ucSalesRegCompany.Instance.Dock = DockStyle.Fill;
                ucSalesRegCompany.Instance.BringToFront();
            }
            else
                ucSalesRegCompany.Instance.BringToFront();
        }

        private void btnSalesUnegPerson_Click(object sender, EventArgs e)
        {
            if (!panelDashboard.Controls.Contains(ucSalesUnregPerson.Instance))
            {
                panelDashboard.Controls.Add(ucSalesUnregPerson.Instance);
                ucSalesUnregPerson.Instance.Dock = DockStyle.Fill;
                ucSalesUnregPerson.Instance.BringToFront();
            }
            else
                ucSalesUnregPerson.Instance.BringToFront();
        }

        private void btnSalesUnregCom_Click(object sender, EventArgs e)
        {
            if (!panelDashboard.Controls.Contains(ucSalesUnregCompany.Instance))
            {
                panelDashboard.Controls.Add(ucSalesUnregCompany.Instance);
                ucSalesUnregCompany.Instance.Dock = DockStyle.Fill;
                ucSalesUnregCompany.Instance.BringToFront();
            }
            else
                ucSalesUnregCompany.Instance.BringToFront();
        }

        private void btnPurRegPerson_Click(object sender, EventArgs e)
        {
            if (!panelDashboard.Controls.Contains(UcPurchaseRegPerson.Instance))
            {
                panelDashboard.Controls.Add(UcPurchaseRegPerson.Instance);
                UcPurchaseRegPerson.Instance.Dock = DockStyle.Fill;
                UcPurchaseRegPerson.Instance.BringToFront();
            }
            else
                UcPurchaseRegPerson.Instance.BringToFront();
        }

        private void btnPurRegCom_Click(object sender, EventArgs e)
        {
            if (!panelDashboard.Controls.Contains(ucPurchaseRegCompany.Instance))
            {
                panelDashboard.Controls.Add(ucPurchaseRegCompany.Instance);
                ucPurchaseRegCompany.Instance.Dock = DockStyle.Fill;
                ucPurchaseRegCompany.Instance.BringToFront();
            }
            else
                ucPurchaseRegCompany.Instance.BringToFront();
        }

        private void btnPurUnreg_Click(object sender, EventArgs e)
        {
            if (!panelDashboard.Controls.Contains(UcPurchaseUnreg.Instance))
            {
                panelDashboard.Controls.Add(UcPurchaseUnreg.Instance);
                UcPurchaseUnreg.Instance.Dock = DockStyle.Fill;
                UcPurchaseUnreg.Instance.BringToFront();
            }
            else
                UcPurchaseUnreg.Instance.BringToFront();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (!isPurchasePanelOpen)
            {
                panel2.Height += 19;
                if (panel2.Height == 76)
                {
                    timer2.Stop();
                    isPurchasePanelOpen = true;
                }
            }
            else if(isPurchasePanelOpen)
            {
                panel2.Height -= 19;
                if (panel2.Height == 0)
                {
                    timer2.Stop();
                    isPurchasePanelOpen = false;
                }
            }
        }
        
    }
}

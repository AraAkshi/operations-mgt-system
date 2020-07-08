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

namespace Nadeeshans_Car_Sale
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginFor_Load(object sender, EventArgs e)
        {

        }
        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@userName", txtLoginUsername.Text));
            paramList.Add(new MySqlParameter("@password", txtLoginPw.Text));
            int returnedRowCount = DatabaseHandler.returnRowCount("SELECT * FROM tbladmin WHERE userName=@userName and password=@password", paramList);

            if (returnedRowCount != 1)
            {
                GlobalLoginData.userName = txtLoginUsername.Text;
                paramList.Clear();
                //paramList.Add(new MySqlParameter("@username", txtLoginUsername.Text));
                //GlobalLoginData.userRole = DatabaseHandler.returnOneValue("SELECT userRole FROM tbladmin WHERE userName = @userName", paramList, "userName");

                this.Hide();
                frmHomepage dash = new frmHomepage();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Invalid Data! Please Try Again!");
                txtLoginPw.Clear();
                txtLoginUsername.Clear();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLoginUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

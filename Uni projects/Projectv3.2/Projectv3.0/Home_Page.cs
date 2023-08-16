using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectv3._0
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            string acd = User.Id.ToString();
             User_id_lbl.Text =acd;
            User_id_lbl.Show();
            
        }

        private void Check_Balancebx_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Account Balance Is :"+User.AccountBal);
        }

        private void Fund_transferbx_Click(object sender, EventArgs e)
        {
            Fund_Transfer fundt = new Fund_Transfer();
            fundt.Show();
        }

        private void Pay_Billbx_Click(object sender, EventArgs e)
        {
            Online_Paybill paybil = new Online_Paybill();
            paybil.Show();
        }

        private void Online_Paymentbx_Click(object sender, EventArgs e)
        {
            Online_Payment onlpay = new Online_Payment();
            onlpay.Show();
        }

        private void Online_investmentbx_Click(object sender, EventArgs e)
        {
            Online_Investment onl = new Online_Investment();
            onl.Show();
        }

        private void Cash_Depositbx_Click(object sender, EventArgs e)
        {
            Cash_Deposit cshdp = new Cash_Deposit();
            cshdp.Show();
        }

        public void User_id_lbl_Click(object sender, EventArgs e)
        { 
        }
    }
}

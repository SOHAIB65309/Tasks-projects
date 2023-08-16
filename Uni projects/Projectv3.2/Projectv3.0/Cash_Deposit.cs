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
    public partial class Cash_Deposit : Form
    {
        public Cash_Deposit()
        {
            InitializeComponent();
        }
        private void Cash_Deposit_Load(object sender, EventArgs e)
        {
        }
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            int amount =int.Parse( Cash_Deposit_bx.Text);
                string query = string.Format("update account set AccountBalance={0} where Name='{1}' and password='{2}'", User.AccountBal = User.AccountBal + amount, User.Name, User.password);
                SqlCommand cmd = new SqlCommand(query, Database.opendb());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Depost have been done successfully\n" + "Your New Account Balance is :" + User.AccountBal);
                Cash_Deposit_bx.Clear();
        }
        private void Cash_Deposit_bx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cash_Deposit_bx.MaxLength = 5;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}

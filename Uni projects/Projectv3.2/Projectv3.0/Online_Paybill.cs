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
    public partial class Online_Paybill : Form
    {
        public Online_Paybill()
        {
            InitializeComponent();
        }

        private void Online_Paybill_Load(object sender, EventArgs e)
        {

        }
        private void Submit_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(Bill_Amount_bx.Text);
                if (User.AccountBal > amount)
                {
                    string query = string.Format("update account set AccountBalance={0} where Name='{1}' and password='{2}'", User.AccountBal = User.AccountBal - amount, User.Name, User.password);
                    SqlCommand cmd = new SqlCommand(query, Database.opendb());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Bill Has been Paid successfully" + "Your New Account Balance is :" + User.AccountBal);
                    Bill_Amount_bx.Clear();
                }
                else
                {
                    MessageBox.Show("Insuficient Balance to Pay bill You Can Max pay" + User.AccountBal);
                    Bill_Amount_bx.Clear();
                }
        }
        private void Bill_Amount_bx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bill_Amount_bx.MaxLength =5;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}

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
    public partial class Online_Payment : Form
    {
        public Online_Payment()
        {
            InitializeComponent();
        }

        private void Online_Payment_Load(object sender, EventArgs e)
        {

        }

        private void Payment_btn_Click(object sender, EventArgs e)
        {

            string Name = Name_Payment_bx.Text;
            int amount = int.Parse(Payment_bx.Text);
                if (User.AccountBal > amount)
                {
                    string query = string.Format("update account set AccountBalance={0} where Name='{1}' and password='{2}'", User.AccountBal = User.AccountBal - amount, User.Name, User.password);
                    SqlCommand cmd = new SqlCommand(query, Database.opendb());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Online Payment  Has been Paid successfully /n Payment Name Is :" + Name + "\n Your New Account Balance is :" + User.AccountBal);
                }
                else
                {
                    MessageBox.Show("Insuficient Balance to Generate Online Payment You Can Max pay" + User.AccountBal);
                }
            }
        private void Payment_bx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Payment_bx.MaxLength = 6;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void Name_Payment_bx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Name_Payment_bx.MaxLength = 20;
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 8  ) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}

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
    public partial class Online_Investment : Form
    {
        public Online_Investment()
        {
            InitializeComponent();
        }

        private void Online_Investment_Load(object sender, EventArgs e)
        {

        }

        private void invest_btn_Click(object sender, EventArgs e)
        {
            
            string name = Name_bx.Text;
            int amount = int.Parse(Amount_bx.Text);
                if (User.AccountBal > amount && amount >= 500)
                {
                    string query = string.Format("update account set AccountBalance={0} where Name='{1}' and password='{2}'", User.AccountBal = User.AccountBal - amount, User.Name, User.password);
                    SqlCommand cmd = new SqlCommand(query, Database.opendb());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Online Investment Have been Done successfully In :" + name + "\nYour New Account Balance is :" + User.AccountBal);
                Amount_bx.Clear();
                Name_bx.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid amount amount must be less then your account balance Which is :" + User.AccountBal + "&&" + " Greater Than 500 Unable To make Payment\n");
                Amount_bx.Clear();
                }
        }
        private void Amount_bx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Amount_bx.MaxLength = 6;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Name_bx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Name_bx.MaxLength = 20;
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}

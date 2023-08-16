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
    public partial class Fund_Transfer : Form
    {
        public Fund_Transfer()
        {
            InitializeComponent();
        }
        private void Fund_Transfer_Load(object sender, EventArgs e)
        {

        }
        private void Transfer_btn_Click(object sender, EventArgs e)
        {
            int id, Amount;
            id = int.Parse(Account_id_bx.Text);
            Amount = int.Parse(Amount_bx.Text);
                if (User.AccountBal >= Amount)
                {
                    string query = string.Format("select * from account where ID={0}", id);
                    SqlCommand cmd = new SqlCommand(query, Database.opendb());
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        string q2 = string.Format("update account set AccountBalance={0} where ID={1}", int.Parse(dt.Rows[0][3].ToString()) + Amount, id);
                        SqlCommand cmd2 = new SqlCommand(q2, Database.opendb());
                        cmd2.ExecuteNonQuery();
                        string query2 = string.Format("update account set AccountBalance={0} where Name='{1}' and password='{2}'", User.AccountBal = User.AccountBal - Amount, User.Name, User.password);
                        SqlCommand cmd3 = new SqlCommand(query2, Database.opendb());
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Amount Have Been successfully Transfered TO :" + id + "\n Now Your Current Balance Is : " + User.AccountBal);
                        Account_id_bx.Clear();
                        Amount_bx.Clear();
                    }
                    else
                    {
                        MessageBox.Show("This id doesn't Exist");
                        Account_id_bx.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient Balance");
                    Amount_bx.Clear();
                }  
        }
        private void Account_id_bx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Account_id_bx.MaxLength = 6;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Amount_bx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Amount_bx.MaxLength = 6;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}

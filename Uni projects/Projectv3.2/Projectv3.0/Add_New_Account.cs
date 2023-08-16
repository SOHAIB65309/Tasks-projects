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
    public partial class Add_New_Account : Form
    {
        public Add_New_Account()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string Name = User_Name.Text;
            string Pass = Confirm_password.Text;
            if (First_Password.Text == Confirm_password.Text && Pass.Length <= 10 && User_Name.TextLength>1 && First_Password.TextLength>1)
            {  
                string query = string.Format("insert into account values('{0}','{1}',{2})", Name, Pass, "0");
                SqlCommand cmd = new SqlCommand(query, Database.opendb());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Has Been Genrated Successfully\n User Name :" + Name + "\n User Password :" + Pass + "\n Balance :0");
                string query1 = string.Format("select * from account where Name='{0}' and Password='{1}' ", Name, Pass);
                SqlCommand cmd1 = new SqlCommand(query1, Database.opendb());
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                User.Name = dt1.Rows[0][0].ToString();
                User.password = dt1.Rows[0][2].ToString();
                User.AccountBal = int.Parse(dt1.Rows[0][3].ToString());
                User.Id = int.Parse(dt1.Rows[0][1].ToString());
                Home_Page home = new Home_Page();
                home.Show();
            }
            else
            {
                MessageBox.Show("Fill the input fields clearly \n first and confirm password should be same");
                First_Password.Clear();
                Confirm_password.Clear();
            }
        }
        private void User_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            User_Name.MaxLength = 20;
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar != 32) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void First_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            First_Password.MaxLength =10 ;
        }

        private void Confirm_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Confirm_password.MaxLength = 10;
        }
    }
}

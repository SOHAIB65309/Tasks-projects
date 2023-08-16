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
    public partial class LoginForm : Form
    {
        public string Login_Name;
        public string Login_Pass;
        public string Login_Id;
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string con = @"data source=DESKTOP-6UPONFK; initial catalog=asra; integrated security=true;";
        public static SqlConnection sql = new SqlConnection(con);
        private void Login_btn_Click(object sender, EventArgs e)
        {
            Login_Name = User_Name_txtbx.Text;
            Login_Pass = Paswword_Txt_bx.Text;
            Login_Id = User_id_bx.Text;
            string query = string.Format("select * from account where Name='{0}' and Password='{1}'and ID='{2}' ", Login_Name, Login_Pass,Login_Id);
            SqlCommand cmd = new SqlCommand(query, Database.opendb());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                User.Name = dt.Rows[0][0].ToString();
                User.password = dt.Rows[0][2].ToString();
                User.AccountBal = int.Parse(dt.Rows[0][3].ToString());
                User.Id= int.Parse(dt.Rows[0][1].ToString());
                Home_Page home = new Home_Page();
                home.Show();
            }
            else
            {
                MessageBox.Show("Wrong User Name or ID or Password");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_New_Account ad = new Add_New_Account();
            ad.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIET_LMS
{
    public partial class LoginAsStudent : Form
    {
        public LoginAsStudent()
        {
            InitializeComponent();
        }

        private void AsFaculty_Click(object sender, EventArgs e)
        {
            Form f = new LoginAsFaculty();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new RegisterOrLogin();
                f.Show();
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string query = String.Format("select * from Std where email='{0}' and password='{1}'",
                Email.Text.ToString(),Password.Text.ToString());
            DataTable dt = databaseConnection.getTable(query) ;
          

            if (dt.Rows.Count != 0)
            {
                
                Student.name = dt.Rows[0][1].ToString();
                Student.email = dt.Rows[0][2].ToString();
                Student.age = int.Parse(dt.Rows[0][3].ToString());
                Student.DegreeProgram = dt.Rows[0][4].ToString();
                Student.CNIC = long.Parse(dt.Rows[0][5].ToString());
                Student.cellNo = long.Parse(dt.Rows[0][6].ToString());
                Student.gender = dt.Rows[0][7].ToString();
                Student.Password = dt.Rows[0][8].ToString();
                Student.SID = int.Parse(dt.Rows[0][0].ToString());
                Student.crHourLimit = int.Parse(dt.Rows[0][16].ToString());
                
                Form f = new Student_LMS();
                f.Show();
                this.Close();
            }
            else 
            {
                MyMessageBox.Show("Enter a Valid Email or Password");
            }
        }
    }
}

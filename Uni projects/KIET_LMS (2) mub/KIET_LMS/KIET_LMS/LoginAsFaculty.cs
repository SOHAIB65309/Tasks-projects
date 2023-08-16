using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KIET_LMS.Teachers;
using KIET_LMS.Program_manager;

namespace KIET_LMS
{
    public partial class LoginAsFaculty : Form
    {
        public LoginAsFaculty()
        {
            InitializeComponent();
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
            if (int.Parse(id.Text.ToString()) == 56057 && pass.Text == "Basharat123")
            {
                Form f = new ProgramManagerLMS();
                f.Show();
                this.Close();
            }
            else
            {
                string query = String.Format("select * from Teacher where ID={0} and password='{1}'", id.Text, pass.Text);
                DataTable dt = databaseConnection.getTable(query);
                if (dt.Rows.Count != 0)
                {
                    Teacher.ID = int.Parse(dt.Rows[0][0].ToString());
                    Teacher.name = dt.Rows[0][1].ToString();
                    Teacher.faculty = dt.Rows[0][2].ToString();
                    Teacher.position = dt.Rows[0][3].ToString();
                    Teacher.department = dt.Rows[0][4].ToString();
                    Teacher.email = dt.Rows[0][6].ToString();
                    Teacher.password = dt.Rows[0][7].ToString();

                    Form f = new home_teacher();
                    f.Show();
                    this.Close();
                }
                else
                {
                    MyMessageBox.Show("Invalid ID or Password");
                }
            }

        }

        private void AsStudent_Click(object sender, EventArgs e)
        {
            Form f = new LoginAsStudent();
            f.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

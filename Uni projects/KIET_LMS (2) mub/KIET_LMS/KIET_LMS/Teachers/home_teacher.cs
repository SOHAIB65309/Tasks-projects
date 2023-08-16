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

namespace KIET_LMS
{
    public partial class home_teacher : Form
    {
        public home_teacher()
        {
            InitializeComponent();
        }

        private void home_teacher_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            name.Text = "Name: " + Teacher.name;
            tid.Text = "Teacher ID: " + Teacher.ID.ToString();
            pos.Text = "Position: " + Teacher.position;
            fac.Text = "Faculty: " + Teacher.faculty;
            dept.Text = "Department: " + Teacher.department;



            string querycourses = String.Format("select * from Classes where Faculty='{0}'",
                Teacher.name);
            DataTable dt3 = databaseConnection.getTable(querycourses);
            
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                string queryAbrreviation = String.Format("select * from CoursesNames where Courses='{0}'",
                dt3.Rows[i][1].ToString());
                DataTable dt4 = databaseConnection.getTable(queryAbrreviation);
                User_Controls.Course1 c1 = new User_Controls.Course1();
                c1.course.Text = dt4.Rows[0][3].ToString();
                c1.id.Text = dt3.Rows[i][0].ToString();
                c1.Click += new EventHandler(ShowInfo);
                c1.BackColor = generateColor();
                flowLayoutPanel1.Controls.Add(c1);
            }
        }

        private Color generateColor()
        {
            Color color;
            Random random = new Random();
            int a = random.Next(1, 6);
            if (a == 1)
            {
                color = Color.FromArgb(127, 97, 110);
            }
            else if (a == 2)
            {
                color = Color.FromArgb(90, 108, 114);
            }
            else if (a == 3)
            {
                color = Color.FromArgb(162, 113, 101);
            }
            else if (a == 4)
            {
                color = Color.FromArgb(26, 97, 108);
            }
            else if (a == 5)
            {
                color = Color.FromArgb(80, 47, 64);
            }
            else
            {
                color = Color.FromArgb(85, 91, 91);
            }
            return color;
        }
        private void ShowInfo(object sender, EventArgs e)
        {
            User_Controls.Course1 c1 = (User_Controls.Course1) sender;
            Form f = new TeacherLMS(int.Parse(c1.id.Text.Trim()));
            f.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new LoginAsFaculty();
            f.Show();
            this.Close();
        }
    }
}

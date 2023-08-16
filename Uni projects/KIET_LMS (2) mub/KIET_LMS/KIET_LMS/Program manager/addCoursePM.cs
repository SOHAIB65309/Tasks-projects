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
    public partial class addCoursePM : Form
    {
        int sid;
        public addCoursePM()
        {
            InitializeComponent();
        }
        public addCoursePM(int sid)
        {
            InitializeComponent();
            this.sid = sid;
        }

        private void addCoursePM_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            CourseLoad();
        }

        private void CourseLoad() 
        {
            flowLayoutPanel1.Controls.Clear();
            string q2 = string.Format("select * from Classes");
            DataTable dt2 = databaseConnection.getTable(q2);
            string q = string.Format("select * from Enrolled where Sid={0}", sid);
            DataTable dt = databaseConnection.getTable(q);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt.Rows.Count != 0)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (dt.Rows[j][0].ToString() != dt2.Rows[i][0].ToString())
                        {
                            User_Controls.Course2 c = new User_Controls.Course2();
                            c.id.Text = dt2.Rows[i][0].ToString();
                            string q3 = string.Format("select * from CoursesNames where Courses='{0}'"
                                , dt2.Rows[i][1].ToString());
                            DataTable dt3 = databaseConnection.getTable(q3);
                            c.course.Text = dt3.Rows[0][3].ToString();
                            c.Click += new EventHandler(CourseSelected);
                            flowLayoutPanel1.Controls.Add(c);
                            break;
                        }
                    }
                }
                else
                {
                    User_Controls.Course2 c = new User_Controls.Course2();
                    c.id.Text = dt2.Rows[i][0].ToString();
                    string q3 = string.Format("select * from CoursesNames where Courses='{0}'"
                        , dt2.Rows[i][1].ToString());
                    DataTable dt3 = databaseConnection.getTable(q3);
                    c.course.Text = dt3.Rows[0][3].ToString();
                    c.Click += new EventHandler(CourseSelected);
                    flowLayoutPanel1.Controls.Add(c);
                }

            }
        }

        private void CourseSelected(object sender, EventArgs e)
        {
            User_Controls.Course2 c = (User_Controls.Course2)sender;
            string query = string.Format("select * from Classes where Cld={0}",c.id.Text);
            DataTable dt = databaseConnection.getTable(query);
            string q2 = string.Format("select * from Teacher where name='{0}'", dt.Rows[0][2].ToString());
            DataTable dt2 = databaseConnection.getTable(q2);
            string query2 = string.Format("insert into Enrolled (Cid,Sid,Tid,Present,Absents)values({0},{1},{2},{3},{4})",
            c.id.Text,sid,dt2.Rows[0][0].ToString(),0,0);
            databaseConnection.Execute(query2);
            MyMessageBox.Show("Course ID Registered Successfully");
            CourseLoad();
        }
    }
}

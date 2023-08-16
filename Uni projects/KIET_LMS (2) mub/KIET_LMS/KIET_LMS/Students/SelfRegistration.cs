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
    public partial class SelfRegistration : Form
    {
        private List<Courses> clist = new List<Courses>();
 
        public SelfRegistration()
        {
            InitializeComponent();
        }

        
        private void SelfRegistration_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            clist = new List<Courses>();
            string query = String.Format("select * from CoursesNames");
            DataTable course = databaseConnection.getTable(query);
            string query2 = String.Format("select * from Classes");
            DataTable classes = databaseConnection.getTable(query2);
            for (int i = 0; i < course.Rows.Count; i++)
            {
                bool flag = true;
                for (int j = 0; j < classes.Rows.Count; j++)
                {
                    if (course.Rows[i][0].ToString() == classes.Rows[j][1].ToString())
                    {
                        string q3 = string.Format("select * from Enrolled where Sid={0}",Student.SID);
                        DataTable dt3 = databaseConnection.getTable(q3);
                        
                        for (int k = 0; k < dt3.Rows.Count; k++)
                        {
                            if (classes.Rows[j][0].ToString() == dt3.Rows[k][0].ToString()) 
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag)
                        {
                            User_Controls.Course4 c = new User_Controls.Course4();
                            if (SelfRegistrationCourses.clist != null)
                            {
                                for (int k = 0; k < SelfRegistrationCourses.clist.Count; k++)
                                {
                                    if (SelfRegistrationCourses.clist[k].name == course.Rows[i][0].ToString())
                                    {
                                        c.BackColor = Color.FromArgb(255, 139, 38);
                                        c.panel3.BackColor = Color.FromArgb(62, 67, 88);
                                    }
                                }

                            }
                            c.abb.Text = course.Rows[i][3].ToString();
                            c.course.Text = course.Rows[i][0].ToString();
                            c.crHour.Text = course.Rows[i][1].ToString();
                            c.Click += new EventHandler(this.CourseSelected);

                            flowLayoutPanel1.Controls.Add(c);
                            break;
                        }
                    }
                }
               
            }
            
            updateCRHours();
        }

        private void updateCRHours() 
        {
            label1.Text = "Credit Hours Available: " + Student.crHourLimit.ToString();
        }

   
        private void CourseSelected(object sender, EventArgs e)
        {
            
            User_Controls.Course4 course4 = (User_Controls.Course4) sender;
            Courses courses = new Courses();
            courses.name = course4.course.Text.ToString();
            courses.CrHours = int.Parse(course4.crHour.Text.ToString());
            courses.abr = course4.abb.Text.ToString();
            if (course4.BackColor == Color.FromArgb(255, 139, 38))
            {
                Student.crHourLimit += courses.CrHours;
                clist.Remove(courses);
                course4.BackColor = Color.FromArgb(62, 67, 88);
                
            }
            else
            {
                Student.crHourLimit -= courses.CrHours;
                clist.Add(courses);
                course4.BackColor = Color.FromArgb(255, 139, 38);
                course4.panel3.BackColor = Color.FromArgb(62, 67, 88);
                if (Student.crHourLimit < 0)
                {
                    Student.crHourLimit += courses.CrHours;
                    clist.Remove(courses);
                    course4.BackColor = Color.FromArgb(62, 67, 88);
                    MyMessageBox.Show("Credit Hours Limit Exceeded!");
                }
            }
           
            updateCRHours();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clist.Count != 0)
            {
                SelfRegistrationCourses.clist = clist;
                Form f = new SelfRegistrationIDSelection();
                ((Student_LMS)ParentForm).OpenForm(f);
            }
            else 
            {
                MyMessageBox.Show("Please Select a Course");
            }
            
        }

    }
}

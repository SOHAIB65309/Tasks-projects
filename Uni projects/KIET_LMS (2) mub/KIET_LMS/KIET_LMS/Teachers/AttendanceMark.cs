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
    public partial class AttendanceMark : Form
    {
        private int cid;
        private bool pr ;
        private bool ab;
        private List<int> ids;
        public AttendanceMark()
        {
            InitializeComponent();
        }

        public AttendanceMark(int cid)
        {
            InitializeComponent();
            this.cid = cid;
        }
        private void AttendanceMark_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            string query = string.Format("Select * from Enrolled where Cid = {0}", cid.ToString());
            DataTable dt = databaseConnection.getTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string sid = dt.Rows[i][1].ToString();
                string query1 = string.Format("Select * from Std where ID = {0}",sid);
                DataTable dt1 = databaseConnection.getTable(query1);
                User_Controls.Student1 s1 = new User_Controls.Student1();
                s1.id.Text = sid;
                s1.name.Text = dt1.Rows[0][1].ToString();
                s1.Click += new EventHandler(selectStudent);
                flowLayoutPanel1.Controls.Add(s1);
            }
        }

        private void selectStudent(object sender, EventArgs e)
        {
            User_Controls.Student1 s1 = (User_Controls.Student1)sender;
            if (pr)
            {
                if (s1.BackColor == Color.FromArgb(235, 139, 56))
                {
                    s1.BackColor = Color.FromArgb(79, 175, 79);
                    s1.ForeColor = Color.FromArgb(43, 45, 66);
                    if (ids != null)
                    {
                        ids.Add(int.Parse(s1.id.Text.Trim()));
                    }
                    else 
                    {
                        MyMessageBox.Show("Please Select a Button");
                    }

                }
                else
                {
                    s1.BackColor = Color.FromArgb(235, 139, 56);
                    s1.ForeColor = Color.FromArgb(43, 45, 66);
                    ids.Remove(int.Parse(s1.id.Text.Trim()));
                }
            }
            else 
            {
                if (s1.BackColor == Color.FromArgb(235, 139, 56)) 
                {
                    s1.BackColor = Color.FromArgb(151, 57, 57);
                    s1.ForeColor = Color.FromArgb(144,224,139);
                    if (ids != null)
                    {
                        ids.Add(int.Parse(s1.id.Text.Trim()));
                    }
                    else
                    {
                        MyMessageBox.Show("Please Select a Button");
                    }
                }
                else
                {
                    s1.BackColor = Color.FromArgb(235, 139, 56);
                    s1.ForeColor = Color.FromArgb(43, 45, 66);
                    ids.Remove(int.Parse(s1.id.Text.Trim()));
                }
            }
        }

        private void present_Click(object sender, EventArgs e)
        {
            ids = new List<int>();
            present.BackColor = Color.FromArgb(235, 134, 56);
            absent.BackColor = Color.FromArgb(62, 67, 88);
            pr = true;
            ab = false;
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                User_Controls.Student1 s1 = (User_Controls.Student1)flowLayoutPanel1.Controls[i];
                s1.BackColor = Color.FromArgb(235, 139, 56);
                s1.ForeColor = Color.FromArgb(43, 45, 66);
            }
        }


        private void absent_Click(object sender, EventArgs e)
        {
            ids = new List<int>();
            absent.BackColor = Color.FromArgb(235, 134, 56);
            present.BackColor = Color.FromArgb(62, 67, 88);
            pr = false;
            ab = true;
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                User_Controls.Student1 s1 = (User_Controls.Student1)flowLayoutPanel1.Controls[i];
                s1.BackColor = Color.FromArgb(235, 139, 56);
                s1.ForeColor = Color.FromArgb(43, 45, 66);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = string.Format("Select * from Enrolled where Cid = {0}", cid.ToString());
            DataTable dt = databaseConnection.getTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int prs, abs;
                string sid = dt.Rows[i][1].ToString();
                string q2 = string.Format("select * from Enrolled where Cid = {0} and Sid ={1}"
                    , cid.ToString(),sid);
                DataTable dt2 = databaseConnection.getTable(q2);
                prs = int.Parse(dt2.Rows[0][4].ToString());
                abs = int.Parse(dt2.Rows[0][5].ToString());

                if (pr)
                {
                    bool flag = false;
                    for (int j = 0; j < ids.Count; j++)
                    {
                        if (ids[j] == int.Parse(sid)) 
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        prs++;
                    }
                    else 
                    {
                        abs++;
                    }
                }
                else 
                {
                    bool flag = false;
                    for (int j = 0; j < ids.Count; j++)
                    {
                        if (ids[j] == int.Parse(sid))
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        abs++;
                    }
                    else
                    {
                        prs++;
                    }
                }

                string query2 = String.Format("update Enrolled set Present={0},Absents={1} where Sid = {2} and Cid = {3}"
                       , prs, abs, sid,cid);
                databaseConnection.Execute(query2);
            }

            MyMessageBox.Show("The Attendance has been Marked");
         
        }
    }
}

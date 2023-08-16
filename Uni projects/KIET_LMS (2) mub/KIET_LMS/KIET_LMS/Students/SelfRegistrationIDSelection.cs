using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KIET_LMS
{
    public partial class SelfRegistrationIDSelection : Form
    {
        private List<Courses> clist = SelfRegistrationCourses.clist;
        public SelfRegistrationIDSelection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new SelfRegistration();
            ((Student_LMS)ParentForm).OpenForm(f);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                Panel panel = (Panel) flowLayoutPanel1.Controls[i];
                for (int j = 0; j < panel.Controls.Count; j++)
                {
                    string main = panel.Name.ToString().Remove(0, 2);
                    if (panel.Controls[j].Name != main)
                    {
                        if (panel.Controls[j].BackColor == Color.FromArgb(235, 139, 56))
                        {
                            User_Controls.Id_Creation id = (User_Controls.Id_Creation)panel.Controls[j];
                            string query = String.Format("select * from Teacher where name = '{0}'"
                                ,id.faculty.Text.ToString().Trim());
                            DataTable dt = databaseConnection.getTable(query);
                            int tid = int.Parse(dt.Rows[0][0].ToString());
                            string enrollQuery = String.Format("insert into Enrolled (Cid,Sid,Tid,Present,Absents) values({0},{1},{2},0,0)"
                                , id.cid.Text.Trim(), Student.SID.ToString(), tid.ToString());
                            databaseConnection.Execute(enrollQuery);
                        }
                    }
                }
            }
            MyMessageBox.Show("Registered Successfully");
        }

        private void SelfRegistrationIDSelection_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            for (int i = 0; i < clist.Count; i++)
            {
                int y = 10;
                Panel panel = new Panel();
                User_Controls.Course4 c4 = new User_Controls.Course4();
                c4.Name = clist[i].abr;
                panel.Name = "pc" + c4.Name;
                panel.Size = new Size(817, 296);
                c4.Location = new Point(10, 10);
                c4.course.Text = clist[i].name;
                c4.crHour.Text = clist[i].CrHours.ToString();
                c4.abb.Text = clist[i].abr;
                string query = String.Format("select * from Classes where CourseName = '{0}'"
                    , clist[i].name);
                DataTable dt = databaseConnection.getTable(query);
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    User_Controls.Id_Creation id = new User_Controls.Id_Creation();
                    id.cid.Text = dt.Rows[j][0].ToString();
                    id.faculty.Text = dt.Rows[j][2].ToString();
                    id.time.Text = dt.Rows[j][3].ToString().Trim() + "(" + dt.Rows[j][5].ToString().Trim() +")";
                    id.Location = new Point(328, y);
                    id.Name = c4.Name + j;
                    id.Click += new EventHandler(IdSelected);
                    panel.Controls.Add(id);
                    y += 69;
                    if (panel.Controls.Count >= 4)
                    {
                        panel.Height = y;
                    }
                }
                panel.Controls.Add(c4);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void IdSelected(object sender, EventArgs e)
        {
            User_Controls.Id_Creation id = (User_Controls.Id_Creation)sender;
            if (id.BackColor == Color.FromArgb(235, 139, 56))
            {
                id.BackColor = Color.FromArgb(61, 97, 164); 
            }
            else
            {
                string idname = id.Name.ToString();
                string panelname = "pc" + idname.Remove(idname.Length - 1,1);
                Control[] c = this.flowLayoutPanel1.Controls.Find(panelname,false);
                Panel p = (Panel)c[0];
                for (int i = 0; i < p.Controls.Count; i++)
                {
                    if (p.Controls[i].Name != idname.Remove(idname.Length - 1, 1))
                    {
                        p.Controls[i].BackColor = Color.FromArgb(61, 97, 164);

                    }
                }
                id.BackColor = Color.FromArgb(235, 139, 56);

            }
            MakeOrRemoveClash(id);

        }

        private void MakeOrRemoveClash(User_Controls.Id_Creation panel) 
        {
            string time = panel.time.Text.Trim();
            // For Removing Old Clash
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                Panel p = (Panel) flowLayoutPanel1.Controls[i];
                string main = p.Name.ToString().Remove(0,2);
                for (int j = 0; j < p.Controls.Count; j++)
                {
                    if (p.Controls[j].BackColor == Color.FromArgb(164,61,61))
                    {
                        p.Controls[j].BackColor = Color.FromArgb(61, 97, 164);
                        User_Controls.Id_Creation idc = (User_Controls.Id_Creation)p.Controls[j];
                        for (int k = 0; k < idc.Controls.Count; k++)
                        {
                            idc.Controls[k].ForeColor = Color.FromArgb(237, 242, 244);
                           
                        }
                        idc.Enabled = true;
                    }
                }
            }
            // For Finding New Clash
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                Panel p = (Panel)flowLayoutPanel1.Controls[i];
                string main = p.Name.ToString().Remove(0, 2);
                for (int j = 0; j < p.Controls.Count; j++)
                {
                    if (p.Controls[j].Name != main)
                    {
                        User_Controls.Id_Creation idc = (User_Controls.Id_Creation)p.Controls[j];

                        if ((idc.time.Text.Trim() == time) && (idc.Name != panel.Name))
                        {
                            idc.BackColor = Color.FromArgb(164, 61, 61);
                            for (int k = 0; k < idc.Controls.Count; k++)
                            {
                                idc.Controls[k].ForeColor = Color.FromArgb(186,115,116);
                            }
                            idc.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}

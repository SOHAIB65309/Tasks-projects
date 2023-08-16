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
    public partial class StudentMarksUpload : Form
    {
        private int cid;
        private int y;
        private bool alreadyExists = false;
        public StudentMarksUpload()
        {
            InitializeComponent();
        }

        public StudentMarksUpload(int cid)
        {
            InitializeComponent();
            this.cid = cid;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Size.Height == 57)
            {
                panel2.Height = y;
                panel2.BringToFront();
            }
            else 
            {
                panel2.Height = 57;
            }
        }

        private void StudentMarksUpload_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            List<String> assesments = new List<string>();
            string[] asses = {"Quiz 2","Quiz 3","Assignment 1"
                    ,"Assignment 2","Project","Mid","Final Exam","Presentation"};
            assesments.AddRange(asses);
            y = 57;
            for (int i = 0; i < assesments.Count; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.FromArgb(237, 242, 244);
                btn.ForeColor = Color.FromArgb(43, 45, 66);
                btn.Font = new Font("Montserrat", 14);
                btn.Padding = new Padding(50, 0, 13, 0);
                btn.Text = assesments[i];
                btn.Size = new Size(428, 57);
                btn.Name = "b" + i;
                btn.Location = new Point(0,y);
                btn.Margin = new Padding(0, 0,0, 0);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Click += new EventHandler(OnSelected);
                panel2.Controls.Add(btn);
                y += 57;
            }
            CheckAssesment("Quiz 1");

            //string query = string.Format("select * from Enrolled where Cid ={0}",
            //    cid.ToString());
            //DataTable dt = databaseConnection.getTable(query);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    string student = string.Format("select * from Std where ID={0}",
            //        dt.Rows[i][1].ToString());
            //    DataTable dt2 = databaseConnection.getTable(student);

            //    User_Controls.tableMarks tm = new User_Controls.tableMarks();
            //    tm.Sno.Text = (i + 1) + ".";
            //    tm.name.Text = dt2.Rows[0][1].ToString();
            //    tm.sid.Text = dt2.Rows[0][0].ToString();
            //    flowLayoutPanel1.Controls.Add(tm);
            //}
        }

        private void CheckAssesment(string name) 
        {
            flowLayoutPanel1.Controls.Clear();
            string assesmentTotal = "";
            string query = String.Format("select * from Assesment where CID={0}"
                ,cid);
            DataTable dt = databaseConnection.getTable(query);
            if (dt.Rows.Count != 0)
            {
                alreadyExists = true;
                if (name == "Quiz 1")
                {
                    assesmentTotal = LoadStudents(10,1,dt,assesmentTotal);
                }
                else if (name == "Quiz 2")
                {
                    assesmentTotal = LoadStudents(11, 2, dt, assesmentTotal);
                }
                else if (name == "Quiz 3")
                {
                    assesmentTotal = LoadStudents(12, 5, dt, assesmentTotal);
                }
                else if (name == "Assignment 1")
                {
                    assesmentTotal = LoadStudents(13, 3, dt, assesmentTotal);
                }
                else if (name == "Assignment 2")
                {
                    assesmentTotal = LoadStudents(14, 4, dt, assesmentTotal);
                }
                else if (name == "Project")
                {
                    assesmentTotal = LoadStudents(15, 6, dt, assesmentTotal);
                }
                else if (name == "Mid")
                {
                    assesmentTotal = LoadStudents(16, 7, dt, assesmentTotal);
                }
                else if (name == "Final Exam")
                {
                    assesmentTotal = LoadStudents(17, 8, dt, assesmentTotal);
                }
                else if (name == "Presentation")
                {
                   assesmentTotal = LoadStudents(18, 9, dt, assesmentTotal);
                }
                textBox1.Text = assesmentTotal;
            }
            else 
            {
                alreadyExists = false;
                string query3 = string.Format("select * from Enrolled where Cid ={0}",
               cid.ToString());
                DataTable dt3 = databaseConnection.getTable(query3);
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    string student = string.Format("select * from Std where ID={0}",
                        dt3.Rows[i][1].ToString());
                    DataTable dt2 = databaseConnection.getTable(student);

                    User_Controls.tableMarks tm = new User_Controls.tableMarks();
                    tm.Sno.Text = (i + 1) + ".";
                    tm.name.Text = dt2.Rows[0][1].ToString();
                    tm.sid.Text = dt2.Rows[0][0].ToString();
                    flowLayoutPanel1.Controls.Add(tm);
                }
            }
        }

        private string LoadStudents(int a1, int a2,DataTable dt, string assesmentTotal) 
        {
            assesmentTotal = dt.Rows[0][a1].ToString();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string student = string.Format("select * from Std where ID={0}",
           dt.Rows[i][20].ToString());
                DataTable dt2 = databaseConnection.getTable(student);

                User_Controls.tableMarks tm = new User_Controls.tableMarks();
                tm.Sno.Text = (i + 1) + ".";
                tm.name.Text = dt2.Rows[0][1].ToString();
                tm.sid.Text = dt2.Rows[0][0].ToString();
                tm.marks.Text = dt.Rows[i][a2].ToString();
                flowLayoutPanel1.Controls.Add(tm);
            }
            return assesmentTotal;
        }

        private void OnSelected(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string selected = btn.Text;
            btn.Text = button1.Text;
            button1.Text = selected;
            CheckAssesment(selected);
            panel2.Height = 57;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            string assesment_name = button1.Text;
            string colName = "[" + assesment_name + " Obt]";
            string totalColName = "[" + assesment_name + " Tot]";
            string totalMarks = textBox1.Text.ToString();
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                User_Controls.tableMarks tm = (User_Controls.tableMarks)flowLayoutPanel1.Controls[i];
                int stmarks = int.Parse(tm.marks.Text);
                if (alreadyExists)
                {
                    // Update
                    string query = string.Format("select * from Assesment where CID={0} and SID='{1}'"
                        ,cid,tm.sid.Text);
                    DataTable dt = databaseConnection.getTable(query);
                    string query2 = string.Format("update Assesment set {0}={1},{2}={3} where CID={4} and SID={5}"
                        ,colName,stmarks,totalColName,totalMarks,cid,tm.sid.Text);
                    databaseConnection.Execute(query2);
                }
                else 
                {
                    // Insert
                    string query = string.Format("insert into Assesment ({0},CID,SID,{1}) values({2},{3},{4},{5})",
                        colName,totalColName,stmarks,cid,tm.sid.Text,totalMarks);
                    databaseConnection.Execute(query);
                    string query2 = string.Format("select * from Assesment where CID={0} and SID={1}"
                        , cid, tm.sid.Text);
                    DataTable dt = databaseConnection.getTable(query2);
                    string aid = dt.Rows[0][0].ToString();
                    string query3 = string.Format("update Enrolled set Aid={0} where Cid={1} and Sid={2}",
                        aid,cid,tm.sid.Text);
                    databaseConnection.Execute(query3);
                }
            }
            alreadyExists = true;
            MyMessageBox.Show("Marks Updated Successfully");
        }
    }
}

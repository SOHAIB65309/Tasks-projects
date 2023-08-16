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
    public partial class IdCreation_pm : Form
    {
        public int y = 0;
        public int panelsize;
        bool course=false, faculty=false, room=false, day=false, slot = false;
        public IdCreation_pm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IdCreation_pm_Load(object sender, EventArgs e)
        {
            string query = "select * from CoursesNames";
            DataTable dt = databaseConnection.getTable(query);

            int btns = dt.Rows.Count;
            int x = 0;
            panelsize = CoursePanel1.Size.Height;
            for (int i = 0; i < btns; i++) 
            {
                
               panelsize +=46;
                

                Button b = new Button();
                b.Left = x;
                b.Top = y;
                b.Size = new Size(615, 46);
                b.BackColor = Color.FromArgb(69, 80, 108);
                b.ForeColor = Color.FromArgb(237, 242, 244);
                b.Name = dt.Rows[0][3].ToString();
                b.FlatStyle = FlatStyle.Flat;
                b.Text = "   " + dt.Rows[i][0].ToString();
                b.Font = new Font("Montserrat", 18);
                b.FlatAppearance.BorderSize = 0;
                b.Margin = new Padding(0,0,0,0);
                b.TextAlign = ContentAlignment.MiddleLeft;
                CoursePanel.Controls.Add(b);
                b.Click += new EventHandler(this.GreetingBtn_Click);
                y += 46;

            }
           // For Faculty
            string query1 = "select * from Teacher";
            DataTable dt1 = databaseConnection.getTable(query1);

            int btns1 = dt1.Rows.Count;
            y = 0;
            for (int i = 0; i < btns1; i++)
            {

                panelsize += 46;


                Button b = new Button();
                b.Left = x;
                b.Top = y;
                b.Size = new Size(615, 46);
                b.BackColor = Color.FromArgb(69, 80, 108);
                b.ForeColor = Color.FromArgb(237, 242, 244);
                b.Name = "a" + dt1.Rows[0][0].ToString();
                b.FlatStyle = FlatStyle.Flat;
                b.Text = "   " + dt1.Rows[i][1].ToString();
                b.Font = new Font("Montserrat", 18);
                b.FlatAppearance.BorderSize = 0;
                b.Margin = new Padding(0, 0, 0, 0);
                b.TextAlign = ContentAlignment.MiddleLeft;
                flowLayoutPanel1.Controls.Add(b);
                b.Click += new EventHandler(this.Faculty_Click);
                y += 46;

            }
            List<string> days = new List<string>();
            string[] day = { "Mon","Tues","Wed","Thurs","Sat","Sun" };
            days.AddRange(day);
            List<string> Slots = new List<string>();
            string[] slot = { "1st", "2nd", "3rd", "4rth"};
            Slots.AddRange(slot);
            List<string> Rooms = new List<string>();
            string[] room = {"4B","11B","10A","9B","27A","26A","Audi","Lab1","Lab2","Lab3","Lab4","Lab5","Lab6"};
            Rooms.AddRange(room);
            // For Days
            y = 0;
            for (int i = 0; i < days.Count; i++)
            {

                panelsize += 46;
                Button b = new Button();
                b.Left = x;
                b.Top = y;
                b.Size = new Size(615, 46);
                b.BackColor = Color.FromArgb(69, 80, 108);
                b.ForeColor = Color.FromArgb(237, 242, 244);
                b.Name = "d" + i;
                b.FlatStyle = FlatStyle.Flat;
                b.Text = "   " + days[i];
                b.Font = new Font("Montserrat", 18);
                b.FlatAppearance.BorderSize = 0;
                b.Margin = new Padding(0, 0, 0, 0);
                b.TextAlign = ContentAlignment.MiddleLeft;
                flowLayoutPanel2.Controls.Add(b);
                b.Click += new EventHandler(this.Day_Click);
                y += 46;

            }
            // For Slots
            y = 0;
            for (int i = 0; i < Slots.Count; i++)
            {

                panelsize += 46;
                Button b = new Button();
                b.Left = x;
                b.Top = y;
                b.Size = new Size(615, 46);
                b.BackColor = Color.FromArgb(69, 80, 108);
                b.ForeColor = Color.FromArgb(237, 242, 244);
                b.Name = "s" + i;
                b.FlatStyle = FlatStyle.Flat;
                b.Text = "   " + Slots[i];
                b.Font = new Font("Montserrat", 18);
                b.FlatAppearance.BorderSize = 0;
                b.Margin = new Padding(0, 0, 0, 0);
                b.TextAlign = ContentAlignment.MiddleLeft;
                flowLayoutPanel3.Controls.Add(b);
                b.Click += new EventHandler(this.Slot_Click);
                y += 46;

            }
            // For Rooms
            y = 0;
            for (int i = 0; i < Rooms.Count; i++)
            {

                panelsize += 46;
                Button b = new Button();
                b.Left = x;
                b.Top = y;
                b.Size = new Size(615, 46);
                b.BackColor = Color.FromArgb(69, 80, 108);
                b.ForeColor = Color.FromArgb(237, 242, 244);
                b.Name = "r" + i;
                b.FlatStyle = FlatStyle.Flat;
                b.Text = "   " + Rooms[i];
                b.Font = new Font("Montserrat", 18);
                b.FlatAppearance.BorderSize = 0;
                b.Margin = new Padding(0, 0, 0, 0);
                b.TextAlign = ContentAlignment.MiddleLeft;
                flowLayoutPanel4.Controls.Add(b);
                b.Click += new EventHandler(this.Room_Click);
                y += 46;

            }


        }

        private void Slot_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            MySlot.Text = b.Text;
            panel5.Size = new Size(615, 46);
            flowLayoutPanel3.AutoScroll = false;
            slot = true;
        }

        private void Room_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            MyRoom.Text = b.Text;
            panel6.Size = new Size(615, 46);
            flowLayoutPanel4.AutoScroll = false;
            room = true;
        }

        private void Day_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            MyDay.Text = b.Text;
            panel4.Size = new Size(615, 46);
            flowLayoutPanel2.AutoScroll = false;
            day = true;
        }

        private void Faculty_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            MyFaculty.Text = b.Text;
            panel3.Size = new Size(615, 46);
            flowLayoutPanel1.AutoScroll = false;
            faculty = true;
        }

        private void GreetingBtn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            MyCourse.Text = b.Text;
            CoursePanel1.Size = new Size(615,46);
            CoursePanel.AutoScroll = false;
            course = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (CoursePanel1.Size.Height == 46)
            {
                CoursePanel.AutoScroll = true;
                CoursePanel1.Size = new Size(615, 294);
                CoursePanel1.BringToFront();
            }
            else 
            {
                CoursePanel.AutoScroll = false;
                CoursePanel1.Size = new Size(615, 46);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel3.Size.Height == 46)
            {
                flowLayoutPanel1.AutoScroll = true;
                panel3.Size = new Size(615, 294);
                panel3.BringToFront();
            }
            else
            {
                flowLayoutPanel1.AutoScroll = false;
                panel3.Size = new Size(615, 46);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel4.Size.Height == 46)
            {
                flowLayoutPanel2.AutoScroll = true;
                panel4.Size = new Size(615, 294);
                panel4.BringToFront();
            }
            else
            {
                flowLayoutPanel2.AutoScroll = false;
                panel4.Size = new Size(615, 46);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel5.Size.Height == 46)
            {
                flowLayoutPanel3.AutoScroll = true;
                panel5.Size = new Size(615, 294);
                panel5.BringToFront();
            }
            else
            {
                flowLayoutPanel3.AutoScroll = false;
                panel5.Size = new Size(615, 46);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel6.Size.Height == 46)
            {
                flowLayoutPanel4.AutoScroll = true;
                panel6.Size = new Size(615, 294);
                panel6.BringToFront();
            }
            else
            {
                flowLayoutPanel4.AutoScroll = false;
                panel6.Size = new Size(615, 46);

            }
        }

        private void GenerateID_Click(object sender, EventArgs e)
        {
            if (course && faculty && day && slot && room)
            {
                string query = String.Format("insert into Classes values('{0}','{1}','{2}','{3}','{4}')"
                    , MyCourse.Text.ToString().Trim(), MyFaculty.Text.ToString().Trim(), MyDay.Text.ToString().Trim(),
                    MyRoom.Text.ToString().Trim(), MySlot.Text.ToString().Trim());
                databaseConnection.Execute(query);
                MyMessageBox.Show("ID Created Successfully!");
            }
            else 
            {
                MyMessageBox.Show("Please Select All Fields First");
            }
        }
    }
}

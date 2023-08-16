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
    public partial class StudentsClassSchedule : Form
    {
        public StudentsClassSchedule()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentsClassSchedule_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string query = String.Format("select * from Enrolled where Sid={0}",Student.SID);
            DataTable dt = databaseConnection.getTable(query);
            if (dt.Rows.Count != 0) {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string query2 = String.Format("select * from Classes where ClD ={0}",
                        dt.Rows[i][0].ToString());
                    ShowButtons(query2);
                }
                
            }
        }

        private void ShowButtons(String query)
        {
            DataTable dt = databaseConnection.getTable(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(833, 57);
                panel.Name = "p" + i;
                Label label = new Label();
                label.Text = dt.Rows[i][0].ToString();
                label.Location = new Point(21, 15);
                label.Name = "cid" + i;
                panel.Controls.Add(label);
                label.Font = new Font("Montserrat", 15);
                label.ForeColor = Color.FromArgb(237, 242, 244);
                label.BackColor = Color.Transparent;
                Label label2 = new Label();
                label2.Text = dt.Rows[i][1].ToString();
                label2.Location = new Point(120, 15);
                label2.Name = "c" + i;
                label2.Font = new Font("Montserrat", 15);
                label2.Size = new Size(400, 27);
                label2.ForeColor = Color.FromArgb(237, 242, 244);
                panel.Controls.Add(label2);
                Label label3 = new Label();
                label3.Text = dt.Rows[i][3].ToString();
                label3.Location = new Point(538, 15);
                label3.Name = "day" + i;
                label3.Size = new Size(80,27);
                label3.Font = new Font("Montserrat", 15);
                label3.ForeColor = Color.FromArgb(237, 242, 244);
                panel.Controls.Add(label3);
                Label label4 = new Label();
                string time = "";
                if (dt.Rows[i][5].ToString() == "1st")
                {
                    time = "8:40-11:40";
                }
                else if (dt.Rows[i][5].ToString() == "2nd")
                {
                    time = "12:15-3:15";
                }
                else if (dt.Rows[i][5].ToString() == "3rd")
                {
                    time = "3:00-6:00";
                }
                else
                {
                    time = "6:00-9:00";
                }
                label4.Text = time;
                label4.Location = new Point(627, 15);
                label4.Name = "time" + i;
                label4.Size = new Size(130, 27);
                label4.Font = new Font("Montserrat", 15);
                label4.ForeColor = Color.FromArgb(237, 242, 244);
                panel.Controls.Add(label4);
                Label label5 = new Label();
                label5.Text = dt.Rows[i][4].ToString();
                label5.Location = new Point(756, 15);
                label5.Name = "room" + i;
                label5.BringToFront();
                label5.Font = new Font("Montserrat", 15);
                label5.ForeColor = Color.FromArgb(237, 242, 244);
                panel.Controls.Add(label5);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
    }
}

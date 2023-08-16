using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIET_LMS.Teachers
{
    public partial class TeacherLMS : Form
    {
        private Form activeForm = null;
        public int cid;
        public TeacherLMS()
        {
            InitializeComponent();
        }

        public TeacherLMS(int cid)
        {
            this.cid = cid;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new StudentMarksUpload(cid);
            OpenForm(f);
            ResetAllButtons();
            button2.ForeColor = Color.FromArgb(43, 45, 66);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeacherLMS_Load(object sender, EventArgs e)
        {
           
            Form f = new CourseInformatin_t(cid);
            OpenForm(f);
        }
        private void OpenForm(Form f)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = f;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            this.show.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new StudentInfoTeacher(cid);
            OpenForm(f);
            ResetAllButtons();
            button3.ForeColor = Color.FromArgb(43, 45, 66);
        }

        private void ResetAllButtons()
        {
            button1.ForeColor = Color.FromArgb(237, 242, 244);
            button2.ForeColor = Color.FromArgb(237, 242, 244);
            button3.ForeColor = Color.FromArgb(237, 242, 244);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new AttendanceMark(cid);
            OpenForm(f);
            ResetAllButtons();
            button1.ForeColor = Color.FromArgb(43, 45, 66);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f = new CourseInformatin_t();
            OpenForm(f);
            ResetAllButtons();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new LoginAsFaculty();
            f.Show();
            this.Close();
        }

        private void show_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

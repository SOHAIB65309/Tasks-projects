using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KIET_LMS.Program_manager
{
    public partial class ProgramManagerLMS : Form
    {
        private Form activeForm = null;
        public ProgramManagerLMS()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new IdCreation_pm();
            OpenForm(f);
            ResetAllButtons();
            button3.ForeColor = Color.FromArgb(43, 45, 66);
        }
        public void OpenForm(Form f)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = f;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            this.showpanel.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new stReg_pm();
            OpenForm(f);
            ResetAllButtons();
            button1.ForeColor = Color.FromArgb(43, 45, 66);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new CourseTimingsPM();
            OpenForm(f);
            ResetAllButtons();
            button2.ForeColor = Color.FromArgb(43, 45, 66);
        }

        private void ProgramManagerLMS_Load(object sender, EventArgs e)
        {
            Form f = new IdCreation_pm();
            OpenForm(f);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new LoginAsFaculty();
            f.Show();
            this.Close();
        }

        private void ResetAllButtons()
        {
            button1.ForeColor = Color.FromArgb(237, 242, 244);
            button2.ForeColor = Color.FromArgb(237, 242, 244);
            button3.ForeColor = Color.FromArgb(237, 242, 244);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

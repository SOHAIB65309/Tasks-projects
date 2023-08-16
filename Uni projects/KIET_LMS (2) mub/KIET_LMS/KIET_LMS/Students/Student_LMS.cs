namespace KIET_LMS
{
    public partial class Student_LMS : Form
    {
        private Form activeForm = null;
        private int a = 1;
        public Student_LMS()
        {
            InitializeComponent();
        }

        public Student_LMS(int v)
        {
            a = v;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new TestResults();
            ResetAllButtons();
            OpenForm(f);
            testResults.ForeColor = Color.FromArgb(43, 45, 66);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void currentCourses_Click(object sender, EventArgs e)
        {
            Form f = new S_CurrentCourses();
            OpenForm(f);
            ResetAllButtons();
            currentCourses.ForeColor = Color.FromArgb(43, 45, 66);
        }

        private void Student_LMS_Load(object sender, EventArgs e)
        {
        
         
            Form f;
            if (a == 1)
            {
                f = new home_student();
            }
            else
            {
                f = new SelfRegistrationIDSelection();
            }
            OpenForm(f);
        }

        private void selfRegistration_Click(object sender, EventArgs e)
        {
            Form f = new SelfRegistration();
            OpenForm(f);
            ResetAllButtons();
            selfRegistration.ForeColor = Color.FromArgb(43, 45, 66);
        }

        private void classSchedule_Click(object sender, EventArgs e)
        {
            Form f = new StudentsClassSchedule();
            OpenForm(f);
            ResetAllButtons();
            classSchedule.ForeColor = Color.FromArgb(43, 45, 66);
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
            this.show.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f = new home_student();
            OpenForm(f);
            ResetAllButtons();
        }

        private void ResetAllButtons() 
        {
            currentCourses.ForeColor = Color.FromArgb(237, 242, 244);
            classSchedule.ForeColor = Color.FromArgb(237, 242, 244);
            testResults.ForeColor = Color.FromArgb(237, 242, 244);
            selfRegistration.ForeColor = Color.FromArgb(237, 242, 244);

        }
        private void selfRegistration_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new LoginAsStudent();
            f.Show();
            this.Close();
        }
    }
}
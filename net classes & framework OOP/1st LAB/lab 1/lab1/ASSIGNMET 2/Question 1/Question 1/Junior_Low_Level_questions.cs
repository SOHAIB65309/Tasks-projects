using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_1
{
    public partial class Junior_Low_Level_questions : Form
    {
        public Junior_Low_Level_questions()
        {
            InitializeComponent();
            Juniour_student_data.Q1 = "What is the capital city of France?";
            Juniour_student_data.Q2 = "How many colors are there in a rainbow?";
            Juniour_student_data.Q3 = "Which animal is known for its long trunk?";
            Juniour_student_data.Q4 = "What is the largest ocean on Earth?";
            Juniour_student_data.Q5 = "What is the symbol for the element oxygen in the periodic table?";
            Juniour_student_data.q1o1 = " London"; Juniour_student_data.q1o2 = "Paris"; Juniour_student_data.q1o3 = " Rome";
            Juniour_student_data.q2o1 = "  7"; Juniour_student_data.q2o2 = " 5"; Juniour_student_data.q2o3 = "9";
            Juniour_student_data.q3o1 = "Elephant "; Juniour_student_data.q3o2 = "Giraffe"; Juniour_student_data.q3o3 = "Kangaroo";
            Juniour_student_data.q4o1 = " Indian Ocean"; Juniour_student_data.q4o2 = " Atlantic Ocean"; Juniour_student_data.q4o3 = "Pacific Ocean";
            Juniour_student_data.q5o1 = "O"; Juniour_student_data.q5o2 = "H"; Juniour_student_data.q5o3 = "C";
            Junior_Quiz sn = new Junior_Quiz(
                new string[] { Juniour_student_data.q1o1, Juniour_student_data.q1o2, Juniour_student_data.q1o3 },
                new string[] { Juniour_student_data.q2o1, Juniour_student_data.q2o2, Juniour_student_data.q2o3 },
                new string[] { Juniour_student_data.q3o1, Juniour_student_data.q3o2, Juniour_student_data.q3o3 },
                new string[] { Juniour_student_data.q4o1, Juniour_student_data.q4o2, Juniour_student_data.q4o3 },
                new string[] { Juniour_student_data.q5o1, Juniour_student_data.q5o2, Juniour_student_data.q5o3 });
        }
        public Junior_Low_Level_questions(string[] Q1, string[] Q2, string[] Q3, string[] Q4, string[] Q5)
        {
            for (int i = 0; i < 3; i++)
            {
                Juniour_student_data.O1[i] = Q1[i];
                Juniour_student_data.O2[i] = Q2[i];
                Juniour_student_data.O3[i] = Q3[i];
                Juniour_student_data.O4[i] = Q4[i];
                Juniour_student_data.O5[i] = Q5[i];
            }
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (btnq1r2.Checked == true) { Juniour_student_data.count++; }
            if (btnq2r1.Checked == true) { Juniour_student_data.count++; }
            if (btnq3r1.Checked == true) { Juniour_student_data.count++; }
            if (btnq4r3.Checked == true) { Juniour_student_data.count++; }
            if (btnq5r1.Checked == true) { Juniour_student_data.count++; }
            MessageBox.Show("Your Total Currect answers \n"+Juniour_student_data.count.ToString());
            label1.Text = "Correct Answers";
            btnq1r2.Checked = true;
            btnq2r1.Checked = true;
            btnq3r1.Checked = true;
            btnq4r3.Checked = true;
            btnq5r1.Checked = true;
            btnq1r2.ForeColor = Color.Green;
            btnq2r1.ForeColor = Color.Green;
            btnq3r1.ForeColor = Color.Green;
            btnq4r3.ForeColor = Color.Green;
            btnq5r1.ForeColor = Color.Green;
            btnq1r1.ForeColor = Color.Red;
            btnq1r3.ForeColor = Color.Red;
            btnq2r2.ForeColor = Color.Red;
            btnq2r3.ForeColor = Color.Red;
            btnq3r2.ForeColor = Color.Red;
            btnq3r3.ForeColor = Color.Red;
            btnq4r1.ForeColor = Color.Red;
            btnq4r2.ForeColor = Color.Red;
            btnq5r2.ForeColor = Color.Red;
            btnq5r3.ForeColor = Color.Red;
            btnrefresh.Show();
        }

        private void Junior_Low_Level_questions_Load(object sender, EventArgs e)
        {
            question1.Text = Juniour_student_data.Q1;
            question1.Show();
            question2.Text = Juniour_student_data.Q2; question2.Show();
            question3.Text = Juniour_student_data.Q3; question3.Show();
            question4.Text = Juniour_student_data.Q4; question4.Show();
            question5.Text = Juniour_student_data.Q5; question5.Show();
            btnq1r1.Text = Juniour_student_data.O1[0];
            btnq1r2.Text = Juniour_student_data.O1[1];
            btnq1r3.Text = Juniour_student_data.O1[2];
            btnq2r1.Text = Juniour_student_data.O2[0];
            btnq2r2.Text = Juniour_student_data.O2[1];
            btnq2r3.Text = Juniour_student_data.O2[2];
            btnq3r1.Text = Juniour_student_data.O3[0];
            btnq3r2.Text = Juniour_student_data.O3[1];
            btnq3r3.Text = Juniour_student_data.O3[2];
            btnq4r1.Text = Juniour_student_data.O4[0];
            btnq4r2.Text = Juniour_student_data.O4[1];
            btnq4r3.Text = Juniour_student_data.O4[2];
            btnq5r1.Text = Juniour_student_data.O5[0];
            btnq5r2.Text = Juniour_student_data.O5[1];
            btnq5r3.Text = Juniour_student_data.O5[2];
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            Junior_Low_Level_questions sn = new Junior_Low_Level_questions();
            sn.Show();
        }
    }
}

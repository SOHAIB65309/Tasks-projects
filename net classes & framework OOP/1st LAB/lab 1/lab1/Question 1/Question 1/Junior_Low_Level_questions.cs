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
            Juniour_Data.Q1 = "Which country is famous for the Taj Mahal?";
            Juniour_Data.Q2 = "What is the primary language spoken in Brazil?";
            Juniour_Data.Q3 = "Which animal is known as the King of the Jungle?";
            Juniour_Data.Q4 = "What is the main ingredient in bread?";
            Juniour_Data.Q5 = "Which famous scientist developed the theory of gravity?";
            Junior_Low_Level_questions sn = new Junior_Low_Level_questions(
                    new string[] { "India", "China", " Egypt" },
                    new string[] { "Spanish", "Portuguese ", " English" },
                    new string[] { "Lion", "Tiger", "Elephent" },
                    new string[] { "Flour", "Sugar", "Milk" },
                    new string[] { "Albert Einstein", "Isaac Newton", "Galileo Galilei" }
                                           );
        }
        public Junior_Low_Level_questions(string[] P1, string[] P2, string[] P3, string[] P4, string[] P5)
        {
            for (int i = 0; i < 3; i++)
            {
                Juniour_Data.P1[i] = P1[i];
                Juniour_Data.P2[i] = P2[i];
                Juniour_Data.P3[i] = P3[i];
                Juniour_Data.P4[i] = P4[i];
                Juniour_Data.P5[i] = P5[i];
            }
        }

        private void Junior_Low_Level_questions_Load(object sender, EventArgs e)
        {
            Label_1.Text = Juniour_Data.Q1;
            Label_1.Show();
            Label_2.Text = Juniour_Data.Q2; Label_2.Show();
            Label_3.Text = Juniour_Data.Q3; Label_3.Show();
            Label_4.Text = Juniour_Data.Q4; Label_4.Show();
            Label_5.Text = Juniour_Data.Q5; Label_5.Show();
            q1r1.Text = Juniour_Data.P1[0];
            q1r2.Text = Juniour_Data.P1[1];
            q1r3.Text = Juniour_Data.P1[2];
            q2r1.Text = Juniour_Data.P2[0];
            q2r2.Text = Juniour_Data.P2[1];
            q2r3.Text = Juniour_Data.P2[2];
            q3r1.Text = Juniour_Data.P3[0];
            q3r2.Text = Juniour_Data.P3[1];
            q3r3.Text = Juniour_Data.P3[2];
            q4r1.Text = Juniour_Data.P4[0];
            q4r2.Text = Juniour_Data.P4[1];
            q4r3.Text = Juniour_Data.P4[2];
            q5r1.Text = Juniour_Data.P5[0];
            q5r2.Text = Juniour_Data.P5[1];
            q5r3.Text = Juniour_Data.P5[2];
        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            if (q1r1.Checked == true) { Juniour_Data.count++; }
            if (q2r2.Checked == true) { Juniour_Data.count++; }
            if (q3r1.Checked == true) { Juniour_Data.count++; }
            if (q4r1.Checked == true) { Juniour_Data.count++; }
            if (q5r2.Checked == true) { Juniour_Data.count++; }
            MessageBox.Show("Your Total Currect answers Out of 5 \n" + Juniour_Data.count.ToString());
            label1.Text = "Correct Answers";
            q1r1.Checked = true;
            q2r2.Checked = true;
            q3r1.Checked = true;
            q4r3.Checked = true;
            q5r1.Checked = true;
            q1r2.ForeColor = Color.Red;
            q2r1.ForeColor = Color.Red;
            q3r1.ForeColor = Color.Green;
            q4r3.ForeColor = Color.Red;
            q5r1.ForeColor = Color.Red;
            q1r1.ForeColor = Color.Green;
            q1r3.ForeColor = Color.Red;
            q2r2.ForeColor = Color.Green;
            q2r3.ForeColor = Color.Red;
            q3r2.ForeColor = Color.Red;
            q3r3.ForeColor = Color.Red;
            q4r1.ForeColor = Color.Green;
            q4r2.ForeColor = Color.Red;
            q5r2.ForeColor = Color.Green;
            q5r3.ForeColor = Color.Red;
        }
    }
}

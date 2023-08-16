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
    public partial class RegisterScr : Form
    {
        public RegisterScr()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new RegisterOrLogin();
            f.Show();
            this.Close();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            if (MyName.Text == "" || Email.Text == "" || Age.Text == "" || DegreeProgram.Text == "" ||
                CNIC.Text == "" || Cell.Text == "" || Password.Text == "" || ConPass.Text == "")
            {
                MyMessageBox.Show("Please Fill all the Information");
            }
            else
            {
                if (Password.Text == ConPass.Text)
                {
                    string gender = "";
                    if (Male.Checked)
                    {
                        gender = "Male";
                    }
                    else if (Female.Checked)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        MyMessageBox.Show("Please Select a Gender");
                    }
                    Student.name = MyName.Text;
                    Student.email = Email.Text;
                    Student.DegreeProgram= DegreeProgram.Text;
                    Student.CNIC = long.Parse(CNIC.Text);
                    Student.cellNo = long.Parse(Cell.Text);
                    Student.gender = gender;
                    Student.Password = Password.Text;
                    Student.age = int.Parse(Age.Text);
                    Student.crHourLimit = 15;
             

                    SaveToDb();

                    Form f = new Student_LMS();
                    f.Show();
                    this.Close();
                }

                else
                {
                    MyMessageBox.Show("Password don't match");
                }
            }
        }

        private void SaveToDb() 
        {
            string query1 = String.Format("Select * from Std where email ='{0}'", Student.email);
            DataTable dt1 = databaseConnection.getTable(query1);
            
            if (dt1.Rows.Count == 0)
            {
                string query = String.Format("Insert into Std (Name,email,age,DegreeProgram,CNIC,cellNo,gender,password,crHourLimit) values('{0}','{1}',{2},'{3}',{4},{5},'{6}','{7}',{8})"
                    , Student.name, Student.email, Student.age, Student.DegreeProgram, Student.CNIC, Student.cellNo,
                    Student.gender, Student.Password,Student.crHourLimit);
                databaseConnection.Execute(query);
                MyMessageBox.Show("Welcome to KIET, You're now a Student of KIET");

                string query2 = String.Format("Select * from Std where email ='{0}'", Student.email);
                DataTable dt2 = databaseConnection.getTable(query2);
                
                Student.SID = int.Parse(dt2.Rows[0][0].ToString());
            }
            else 
            {
                MyMessageBox.Show("This Email Already Exists");
            }
        }
    }
}

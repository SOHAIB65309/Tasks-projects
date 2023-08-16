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
    public partial class TestResults : Form
    {
        public TestResults()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                panel3.Visible = true;
                panel4.Visible = true;
                label2.Visible = true;
                string query = string.Format("select * from Enrolled where Sid={0} and Cid={1}"
                    ,Student.SID,textBox1.Text.Trim());
                DataTable dt = databaseConnection.getTable(query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Please Enter a Valid Class ID");
                }
                else 
                {
                    string q2 = string.Format("select * from Assesment where Aid={0}",
                        dt.Rows[0][3].ToString());
                    DataTable dt2 = databaseConnection.getTable(q2);
                    q1obt.Text = nullcheck(dt2.Rows[0][1].ToString());
                    q2obt.Text = nullcheck(dt2.Rows[0][2].ToString()); 
                    q3obt.Text = nullcheck(dt2.Rows[0][5].ToString()); 
                    a1obt.Text = nullcheck(dt2.Rows[0][3].ToString()); 
                    a2obt.Text = nullcheck(dt2.Rows[0][4].ToString()); 
                    pobt.Text = nullcheck(dt2.Rows[0][6].ToString()); 
                    fobt.Text = nullcheck(dt2.Rows[0][8].ToString()); 
                    mobt.Text = nullcheck(dt2.Rows[0][7].ToString()); 
                    q1tot.Text = nullcheck(dt2.Rows[0][10].ToString()); 
                    q2tot.Text = nullcheck(dt2.Rows[0][11].ToString()); 
                    q3tot.Text = nullcheck(dt2.Rows[0][12].ToString()); 
                    a1tot.Text = nullcheck(dt2.Rows[0][13].ToString()); 
                    a2tot.Text = nullcheck(dt2.Rows[0][14].ToString()); 
                    ptot.Text = nullcheck(dt2.Rows[0][15].ToString()); 
                    ftot.Text = nullcheck(dt2.Rows[0][17].ToString()); 
                    mtot.Text = nullcheck(dt2.Rows[0][16].ToString());
                    //Summary
                    attot.Text = (int.Parse(a1tot.Text) + int.Parse(a2tot.Text)).ToString();
                    qttot.Text = (int.Parse(q1tot.Text) + int.Parse(q2tot.Text) + int.Parse(q3tot.Text)).ToString();
                    mttot.Text = mtot.Text;
                    pttot.Text = pttot.Text;
                    fttot.Text = fttot.Text;
                    atobt.Text = (int.Parse(a1obt.Text) + int.Parse(a2obt.Text)).ToString();
                    qtobt.Text = (int.Parse(q1obt.Text) + int.Parse(q2obt.Text) + int.Parse(q3obt.Text)).ToString();
                    mtobt.Text = mobt.Text;
                    ptobt.Text = pobt.Text;
                    ftobt.Text = fobt.Text;

                    // total Marks
                    total.Text = (int.Parse(atobt.Text) + int.Parse(qtobt.Text) + int.Parse(ptobt.Text)
                        + int.Parse(mtobt.Text) + int.Parse(ftobt.Text)).ToString() + "/100";
                }
                textBox1.Text = "";
            }
            
            
        }

        private string nullcheck(string val) 
        {
            if (val == "")
            {
                val = "0";
            }
            return val;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TestResults_Load(object sender, EventArgs e)
        {

        }
    }
}

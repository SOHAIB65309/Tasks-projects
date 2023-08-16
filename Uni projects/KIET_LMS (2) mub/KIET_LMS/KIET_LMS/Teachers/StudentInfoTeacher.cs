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
    public partial class StudentInfoTeacher : Form
    {
        private int cid;
        public StudentInfoTeacher()
        {
            InitializeComponent();
        }
        public StudentInfoTeacher(int cid)
        {
            InitializeComponent();
            this.cid = cid;
        }


        private void StudentInfoTeacher_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            string query = string.Format("Select * from Enrolled where Cid = {0}",cid.ToString());
            DataTable dt = databaseConnection.getTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string sid = dt.Rows[i][1].ToString();
                string query1 = string.Format("Select * from Std where ID = {0} ",sid);
                DataTable dt1 = databaseConnection.getTable(query1);
                User_Controls.Table1 t1 = new User_Controls.Table1();
                t1.Sno.Text = (i+1) + ".";
                t1.name.Text = dt1.Rows[0][1].ToString();
                t1.sid.Text = sid;
                flowLayoutPanel1.Controls.Add(t1);

            }
        }
    }
}

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
    public partial class CoursePageStudent : Form
    {
        private string cid;
        private string name;
        public CoursePageStudent()
        {
            InitializeComponent();
        }
        public CoursePageStudent(string cid, string name)
        {
            this.cid = cid;
            InitializeComponent();
            this.name = name;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CoursePageStudent_Load(object sender, EventArgs e)
        {
            string query = String.Format("select * from Classes where Cld='{0}'"
                ,cid);
            DataTable dt = databaseConnection.getTable(query);
            day.Text = dt.Rows[0][3].ToString();
            room.Text = dt.Rows[0][4].ToString();
            slot.Text = dt.Rows[0][5].ToString();
            tname.Text = dt.Rows[0][2].ToString();
            string q2 = string.Format("select * from Teacher where name='{0}'",
                dt.Rows[0][2].ToString());
            DataTable dt2 = databaseConnection.getTable(q2);
            tmail.Text = dt2.Rows[0][6].ToString();
            tpost.Text =dt2.Rows[0][3].ToString();
            courseAbr.Text = name;

        }
    }
}

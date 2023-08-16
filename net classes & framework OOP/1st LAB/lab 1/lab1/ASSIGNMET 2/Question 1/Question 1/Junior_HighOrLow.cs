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
    public partial class Junior_HighOrLow : Form
    {
        public Junior_HighOrLow()
        {
            InitializeComponent();
        }

        private void High_Level_Click(object sender, EventArgs e)
        {
            Junior_Quiz jn = new Junior_Quiz();
            this.Close();
            jn.Show();
        }

        private void Low_level_Click(object sender, EventArgs e)
        {
            Junior_Low_Level_questions jn = new Junior_Low_Level_questions();
            this.Close();
            jn.Show();
        }
    }
}

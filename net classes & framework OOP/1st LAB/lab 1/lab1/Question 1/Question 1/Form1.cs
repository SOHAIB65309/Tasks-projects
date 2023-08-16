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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSenior_Click(object sender, EventArgs e)
        {
            Seniour_high_or_low sn = new Seniour_high_or_low();
            sn.Show();
        }

        private void btnjunior_Click(object sender, EventArgs e)
        {
            Junior_HighOrLow j = new Junior_HighOrLow();
            j.Show();
        }
    }
}

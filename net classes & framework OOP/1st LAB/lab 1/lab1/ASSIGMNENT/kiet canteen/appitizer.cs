using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiet_canteen
{
    public partial class appitizer : Form
    {
        public static string apptizerdish;
        public static int apptizerquantity;
        public static int total;
        public appitizer()
        {
            InitializeComponent();
        }

        private void bgr_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            apptizerdish = dishtxt.Text;
            apptizerquantity = Convert.ToInt32(quantitytxt.Text);
            switch (apptizerdish)
            {
                case "FRIES":
                    total = apptizerquantity * 150;
                    break;
                case "soup":
                    total = apptizerquantity * 400;
                    break;
               
                case "fries":
                    total = apptizerquantity * 150;
                    break;
                case "SOUP":
                    total = apptizerquantity * 400;
                    break;
               
            }
            this.Close();
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appitizer_Load(object sender, EventArgs e)
        {

        }
    }
        
    
}

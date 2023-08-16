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
    public partial class desert : Form
    {
        public static string desertd;
        public static int desertquan, deserttotal;
        public desert()
        {
            InitializeComponent();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desert_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            desertd = desertdish.Text;
            desertquan = Convert.ToInt32(desertquantity.Text);
            switch (desertd)
            {
                case "ice cream":
                   deserttotal = desertquan * 250;
                    break;
               
                case "ICE CREAM":
                    deserttotal = desertquan * 250;
                    break;
               

            }
            

            this.Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void apptizerbtn_Click(object sender, EventArgs e)
        {
            appitizer apitizerobj = new appitizer();
            apitizerobj.Show();
            
        }

        private void makereceiptbtn_Click(object sender, EventArgs e)
        {
            int aptquan = appitizer.apptizerquantity;
            string apptdish = appitizer.apptizerdish;
            int appttotal = appitizer.total;

            int mainquan = maincourse.mainquan;
            string maindish = maincourse.maincoursedish;
            int totalmain = maincourse.total;

            string desertdish = desert.desertd;
            int deserttotal = desert.deserttotal;


            int overalltotal = deserttotal + totalmain + appttotal;
            MessageBox.Show("Dish: " + maindish + "\n " + apptdish + "\n " + desertdish + "total bill:= " + overalltotal.ToString());
        }

        private void maincoursebtn_Click(object sender, EventArgs e)
        {
            maincourse maincour = new maincourse();
            maincour.Show();
        }

        private void desertbtn_Click(object sender, EventArgs e)
        {
            desert desert1 = new desert();
            desert1.Show();
        }
    }
}

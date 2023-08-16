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
    public partial class maincourse : Form
    {
        public static string maincoursedish;
        public static int total;
        public static int mainquan;
        public maincourse()
        {
            InitializeComponent();
        }



        private void submitbtn_Click(object sender, EventArgs e)
        {
            maincoursedish = maindish.Text;
            mainquan = Convert.ToInt32(mainquantity.Text);

            switch (maincoursedish)
            {
                case "biryani":
                    total = mainquan * 275;
                    break;

                case "pizza":
                    total = mainquan * 800;
                    break;

                case "burger":
                    total = mainquan * 300;
                    break;

                case "BIRYANI":
                    total = mainquan * 275;
                    break;

                case "PIZZA":
                    total = mainquan * 800;
                    break;
                case "BURGER":
                    total = mainquan * 300;
                    break;

            }

            this.Close();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterdish_Click(object sender, EventArgs e)
        {

        }
    }
    }

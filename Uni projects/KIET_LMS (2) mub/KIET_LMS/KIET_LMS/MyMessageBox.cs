using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIET_LMS
{
    public static class MyMessageBox
    {
        public static DialogResult Show(string message) 
        {
            DialogResult dresult = DialogResult.None;
            using (MBox m = new MBox()) 
            {
                m.message.Text = message;
                dresult = m.ShowDialog();
            }
                return dresult;
        }
    }
}

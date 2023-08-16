using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIET_LMS
{
    internal class TouchScrollVertical
    {
        private Point mousePoint;
        private FlowLayoutPanel parentPanel;

        public TouchScrollVertical(FlowLayoutPanel panel) 
        {
            parentPanel = panel;
            AssignEvent(panel);
        }

        private void AssignEvent(Control control) 
        {
            control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;
            foreach (Control child in control.Controls)
            {
                
            }
        }

        private void MouseMove(object sender, MouseEventArgs e) 
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            Point pointDifference = new Point(Cursor.Position.X + mousePoint.X, Cursor.Position.Y - mousePoint.Y);

            if ((mousePoint.X == Cursor.Position.X) && (mousePoint.Y == Cursor.Position.Y))
            {
                return;
            }

            Point cursorAutos = parentPanel.AutoScrollPosition;
            parentPanel.AutoScrollPosition = new Point(Math.Abs(cursorAutos.X) - pointDifference.X, Math.Abs(cursorAutos.Y) - pointDifference.Y);
            mousePoint = Cursor.Position;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.mousePoint = Cursor.Position;
            }
          
        }
    }
}

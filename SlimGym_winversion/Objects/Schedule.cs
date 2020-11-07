using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimGym_winversion.Objects
{
    class Schedule : panelEllip
    {
        

        protected override void OnPaint(PaintEventArgs e)
        {
            buttonEllip buttonEllip = new buttonEllip();
            buttonEllip.Size = new Size(100, 50);
            buttonEllip.BackColor = Color.Red;
            buttonEllip.Location = new Point(30, 30);
            buttonEllip.Show();
            buttonEllip.BringToFront();
            this.Controls.Add(buttonEllip);
            base.OnPaint(e);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using Bunifu.Framework.UI;
using System.Windows.Forms;

namespace SlimGym_winversion.Objects
{
    class datePickerEllip : BunifuDatepicker
    {
        public int _roundness = 3;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath grPath = Methods.CreateRoundedRectangle(_roundness, Width, Height - 2);
            this.Region = new Region(grPath);
        }

        public int Roundness
        {
            get { return _roundness; }
            set
            {
                _roundness = value;
                Invalidate();
            }
        }
    }
}

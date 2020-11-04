using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SlimGym_winversion.Objects
{
    public class panelEllip : Panel
    {
        private int _panelRoundness = 3;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Graphics g = e.Graphics;
            GraphicsPath grPath = Methods.CreateRoundedRectangle(_panelRoundness, Width, Height);
            //g.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            //g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            //g.CompositingQuality = CompositingQuality.HighQuality;
            //g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //g.SmoothingMode = SmoothingMode.AntiAlias;
            //Pen pen = new Pen(_borderColor, _borderThickness);

            this.Region = new Region(grPath);
            //g.DrawPath(pen, grPath);
        }
    }
}

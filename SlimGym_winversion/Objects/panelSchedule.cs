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
    public class panelSchedule : Panel
    {
        private Color _borderColor = Color.Transparent;
        private int _borderThickness = 0;
        private int _panelRoundness = 3;
        private Pen penline = new Pen(Color.Black);

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            Graphics g = e.Graphics;
            GraphicsPath grPath = Methods.CreateRoundedRectangle(_panelRoundness, Width, Height);
            g.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(_borderColor, _borderThickness);
            for (int i = 0; i < 16; i++)
            {
                g.DrawLine(penline, (i + 1) * 58, 20, (i + 1) * 58, 575);
            }


            this.Region = new Region(grPath);
            g.DrawPath(pen, grPath);

        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
            base.OnResize(e);
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public int BorderThickness
        {
            get => _borderThickness;
            set
            {
                _borderThickness = value;
                Invalidate();
            }
        }

        public int PanelRoundness
        {
            get => _panelRoundness;
            set
            {
                _panelRoundness = value;
                Invalidate();
            }
        }
    }
}

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
    public class panelEllipSchedule : Panel
    {
        private Color _borderColor = Color.Transparent;
        private int _borderThickness = 0;
        private int _panelRoundness = 3;
        private Pen penline = new Pen(Color.Black);
        private int _numberOfVerticalSegments = 1;
        private int _lineLocationYTop = 0;
        private int _numberOfHorizontalSegments = 1;
        private int _lineLocationXLeft = 0;

        protected override void OnPaint(PaintEventArgs e)
        {
            int _segmentWidth = this.Width;
            if (_numberOfVerticalSegments > 0)
            {
                _segmentWidth /= _numberOfVerticalSegments;
            }
            int _lineLocationYBottom = this.Height - _lineLocationYTop;

            int _segmentHeight = this.Height;
            if(_numberOfHorizontalSegments > 0)
            {
                _segmentHeight /= _numberOfHorizontalSegments;
            }
            int _lineLocationXRight = this.Width - _lineLocationXLeft;

            base.OnPaint(e);
            Graphics g = e.Graphics;
            GraphicsPath grPath = Methods.CreateRoundedRectangle(_panelRoundness, Width, Height);
            g.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(_borderColor, _borderThickness);
            for (int i = 0; i < _numberOfVerticalSegments - 1; i++)
            {
                g.DrawLine(penline, (i + 1) * _segmentWidth, _lineLocationYTop, (i + 1) * _segmentWidth, _lineLocationYBottom);
            }

            for(int i = 0; i < _numberOfHorizontalSegments - 1; i++)
            {
                g.DrawLine(penline, _lineLocationXLeft, (i + 1) * _segmentHeight, _lineLocationXRight, (i + 1) * _segmentHeight);
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

        public int NumberOfVerticalSegments
        {
            get => _numberOfVerticalSegments;
            set
            {
                _numberOfVerticalSegments = value;
                Invalidate();
            }
        }

        public int VerticalLineLocationYAxis
        {
            get => _lineLocationYTop;
            set
            {
                _lineLocationYTop = value;
                Invalidate();
            }
        }

        public int NumberOfHorizontalSegments
        {
            get => _numberOfHorizontalSegments;
            set
            {
                _numberOfHorizontalSegments = value;
                Invalidate();
            }
        }

        public int HorizontalLineLocationXAxis
        {
            get => _lineLocationXLeft;
            set
            {
                _lineLocationXLeft = value;
                Invalidate();
            }
        }
    }
}

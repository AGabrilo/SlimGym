using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SlimGym_winversion.Objects
{
    class buttonEllip : Button
    {
        private Color _onHoverTextColor = Color.Transparent;
        private Color _offHoverTextColor = Color.Transparent;
        private Color _onClickTextColor = Color.Transparent;
        private Color _offClickTextColor = Color.Transparent;
        private Color _borderColor = Color.Transparent;
        private int _borderThickness = 0;
        private int _buttonRoundness = 3;

        protected override void OnMouseEnter(EventArgs e)
        {
            _offHoverTextColor = ForeColor;
            ForeColor = _onHoverTextColor;
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            ForeColor = _offHoverTextColor;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            _offClickTextColor = ForeColor;
            ForeColor = _onClickTextColor;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            ForeColor = _offClickTextColor;
            base.OnMouseUp(mevent);
        }

        public Color OnHoverTextColor
        {
            get { return _onHoverTextColor; }
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }

        public Color OnClickTextColor
        {
            get { return _onClickTextColor; }
            set
            {
                _onClickTextColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            Graphics g = e.Graphics;
            GraphicsPath grPath = CreateRoundedRectangle(_buttonRoundness);
            g.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(_borderColor, _borderThickness);

            this.Region = new Region(grPath);
            g.DrawPath(pen, grPath);
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
            get { return _borderThickness; }
            set
            {
                _borderThickness = value;
                Invalidate();
            }
        }

        public int ButtonRoundness
        {
            get { return _buttonRoundness; }
            set
            {
                _buttonRoundness = value;
                Invalidate();
            }
        }

        public GraphicsPath CreateRoundedRectangle(int roundness)
        {
            GraphicsPath grPath = new GraphicsPath();

            Rectangle rtgLU = new Rectangle(0, 0, Height / _buttonRoundness, Height / _buttonRoundness);
            Rectangle rtgLD = new Rectangle(0, Height * (_buttonRoundness - 1) / _buttonRoundness, Height / _buttonRoundness, Height / _buttonRoundness);
            Rectangle rtgRU = new Rectangle(Width - Height / _buttonRoundness, 0, Height / _buttonRoundness, Height / _buttonRoundness);
            Rectangle rtgRD = new Rectangle(Width - Height / _buttonRoundness, Height * (_buttonRoundness - 1) / _buttonRoundness, Height / _buttonRoundness, Height / _buttonRoundness);

            grPath.StartFigure();
            grPath.AddArc(rtgLU, 180, 90);
            grPath.AddArc(rtgRU, -90, 90);
            grPath.AddArc(rtgRD, 0, 90);
            grPath.AddArc(rtgLD, 90, 90);
            grPath.CloseFigure();

            return grPath;
        }
    }
}


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
    class Elliptic_Button : Button
    {
        private static Color _borderColor = Color.Transparent;
        private static int _borderThickness = 0;
        private static int _buttonRoundness = 3;
        Pen pen = new Pen(_borderColor, _borderThickness);
        
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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

            this.Region = new Region(grPath);
            pevent.Graphics.DrawPath(pen, grPath);
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                pen = new Pen(_borderColor, _borderThickness);
                Invalidate();
            }
        }

        public int BorderThickness
        {
            get { return _borderThickness; }
            set
            {
                _borderThickness = value;
                pen.Dispose();
                pen = new Pen(_borderColor, _borderThickness);
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}


using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using SlimGym_winversion.UserControls;

namespace SlimGym_winversion.Objects
{
    internal class Methods
    {
        //==================================
        //
        // Used to make regular rectangle
        //
        //==================================
        public static GraphicsPath CreateRectangle(int width, int height)
        {
            GraphicsPath grPath = new GraphicsPath();

            Rectangle rtg = new Rectangle(0, 0, width, height);


            grPath.StartFigure();
            grPath.AddRectangle(rtg);
            grPath.CloseFigure();

            return grPath;
        }

        //==================================
        //
        // Used to make rounded rectangle
        //
        //==================================
        public static GraphicsPath CreateRoundedRectangle(int roundness, int Width, int Height)
        {
            GraphicsPath grPath = new GraphicsPath();

            Rectangle rtgLU = new Rectangle(0, 0, Height / roundness, Height / roundness);
            Rectangle rtgLD = new Rectangle(0, Height * (roundness - 1)  / roundness, Height / roundness, Height / roundness);
            Rectangle rtgRU = new Rectangle(Width - Height / roundness, 0, Height / roundness, Height / roundness);
            Rectangle rtgRD = new Rectangle(Width - Height / roundness, Height * (roundness - 1) / roundness, Height / roundness, Height / roundness);

            grPath.StartFigure();
            grPath.AddArc(rtgLU, 180, 90);
            grPath.AddArc(rtgRU, -90, 90);
            grPath.AddArc(rtgRD, 0, 90);
            grPath.AddArc(rtgLD, 90, 90);
            grPath.CloseFigure();

            return grPath;
        }

        //==================================
        //
        // Used to return graphics path
        //
        //==================================
        public static Region ReturnRegion(GraphicsPath grPath)
        {
            return new Region(grPath);                   // Applying corners
        }

        //==================================
        //
        // Used to change all parameters to maximize
        //
        //==================================
        public static void ChangeParametersToMaximize()
        {
            SlimGym.Instance.Region = Methods.ReturnRegion(Methods.CreateRectangle(SlimGym.Instance.Width,SlimGym.Instance.Height));
        }

        //==================================
        //
        // Used to change location of an object
        //n
        //==================================
        public static void ChangeObjectLocation(Control control, int x, int y)
        {
            control.Location = new Point(x,y);
        }

        public static void ChangeObjectSize(Control control, int x, int y)
        {
            control.Size = new Size(x, y);
        }
        public static void ChangeObjectFontSize(Control control, int x, int y)
        {
            control.Size = new Size(x, y);
        }

        public static void AddButton(panelEllip panel)
        {
            buttonEllip buttonEllip = new buttonEllip();
            buttonEllip.Size = new Size(100, 50);
            buttonEllip.BackColor = Color.Red;
            buttonEllip.Location = new Point(30,30);
            buttonEllip.Show();
            buttonEllip.BringToFront();
            panel.Controls.Add(buttonEllip);
        }

    }
}

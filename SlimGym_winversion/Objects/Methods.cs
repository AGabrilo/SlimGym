﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using SlimGym_winversion.UserControls;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace SlimGym_winversion.Objects
{
    internal class Methods
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================

        static List<buttonEllip> buttonlist = new List<buttonEllip>();

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

        public static void AddButton(panelSchedule panel, DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            int hoursStart, hoursEnd;
            buttonEllip buttonEllip = new buttonEllip();
            //MessageBox.Show(int.Parse(dateTimeStart.TimeOfDay.TotalHours.ToString().Substring(0, 2)).ToString());
            hoursStart = int.Parse(dateTimeStart.TimeOfDay.TotalHours.ToString().Substring(0, 2));

            hoursEnd = int.Parse(dateTimeStart.TimeOfDay.TotalHours.ToString().Substring(0, 2));
            buttonEllip.Size = new Size(56 * (hoursEnd + 1 - hoursStart), 100);
            buttonEllip.BackColor = Color.FromArgb(70,180,30);
            buttonEllip.Location = new Point((((hoursStart - 6) * 60) + 1), 30);
            buttonEllip.BringToFront();
            buttonEllip.FlatStyle = FlatStyle.Flat;
            buttonEllip.FlatAppearance.BorderSize = 0;
            buttonEllip.BorderColor = Color.Transparent;
            buttonEllip.BorderThickness = 0;
            buttonEllip.ButtonRoundness = 5;
            buttonlist.Add(buttonEllip);

            panel.Controls.Add(buttonEllip);
            
        }

        //public static DataTable 

    }
}

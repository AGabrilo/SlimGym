using System;
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

        static List<buttonEllip> buttonList = new List<buttonEllip>();
        static List<panellGroup> panelList = new List<panellGroup>();

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
        //
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

        //==================================
        //
        // Used to add buttons
        //
        //==================================
        public static void AddButtons(panelEllipSchedule panel /*DataTable dataTable*/)
        {
            buttonEllip button;
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                button = createButton(panel, "06:00", "07:00", 0); //dataTable.Rows[i][0].ToString(), dataTable.Rows[i][1].ToString(), int.Parse(dataTable.Rows[i][2].ToString()));
                //DODAT FUNKCIJU ZA DODAVANJE TEKSTA U BOTUN(TRENERA, VRIME, BROJ LJUDI ...)
                setStyle(button);
                buttonList.Add(button);
                panel.Controls.Add(button);
            }
        }

        public static int getMinutesInIntFromString(string timeString)
        {
            string[] subStrings;
            subStrings = timeString.Split(':');

            return int.Parse(subStrings[0]) * 60 + int.Parse(subStrings[1]);
        }

        public static void setStyle(buttonEllip button)
        { 
            button.BackColor = Color.FromArgb(75, 180, 30);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BorderColor = Color.Transparent;
            button.BorderThickness = 0;
            //button.Anchor = AnchorStyles.Left;
        }

        public static buttonEllip createButton(panelEllipSchedule panel, string timeStartString, string timeEndString, int room)
        {
            buttonEllip button = new buttonEllip();
            int timeStartInt = getMinutesInIntFromString(timeStartString);
            int timeEndInt = getMinutesInIntFromString(timeEndString);
            int duration = timeEndInt - timeStartInt;
            int segmentHeight = panel.Height / panel.NumberOfHorizontalSegments;
            int quarterHourSegment = segmentHeight / 4;
            int segmentWidth = panel.Width / panel.NumberOfVerticalSegments;
            int timeStartFromStart = timeStartInt - 360;


            //MessageBox.Show(duration.ToString());

            button.Size = new Size(segmentWidth - 6, (duration / 15) * quarterHourSegment - 6);
            
            button.Location = new Point(segmentWidth * room + 3, (timeStartFromStart / 15) * quarterHourSegment + 3);

            return button;
        }

        //==================================
        //
        // Used to add panels
        //
        //==================================

        public static void addPanels(panelEllip panelParent, int index)
        {
            for (int i = 0; i < 9; i++)
            {
                panellGroup panel = new panellGroup(panelParent.Width, i);
                panelList.Add(panel);
                panelParent.Controls.Add(panel);
            }
        }
    }
}

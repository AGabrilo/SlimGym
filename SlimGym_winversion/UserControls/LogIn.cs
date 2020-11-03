using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SlimGym_winversion
{
    public partial class LogIn : UserControl
    {

        //==================================
        //
        // Loading LogIn user control
        //
        //==================================
        public LogIn()
        {
            InitializeComponent();
            this.panelLogIn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelLogIn.Width, panelLogIn.Height, 20, 20));                // Make login panel rounded
        }

        //==================================
        //
        // Button LogIn
        //
        //==================================

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //
            // Validates data from textboxses
            // If data is authenticated do followin
            //
            if (!SlimGym.Instance.panelBodyControl.Controls.ContainsKey("Base"))    // Checks for exitsting user control
            {                                                                       // Does not exist
                Base baseUserControl = new Base();                                  // Creates an instance
                baseUserControl.Dock = DockStyle.Fill;                              //
                SlimGym.Instance.panelBodyControl.Controls.Add(baseUserControl);    // Adds it to control
            }

            SlimGym.Instance.panelBodyControl.Controls["Base"].BringToFront();      // Showing Base

            textBoxPassword.Text = "";                                              // Deleting data from textboxes
            textboxUsername.Text = "";                                              // Deleting data from textboxes

            //
            // If not show message
            //
        }

        //=======================================================//
        //                                                       //
        // ------------------CUSTOM FUNCTIONS------------------- //
        //                                                       //
        //=======================================================//

        //==================================
        //
        // Make form rounded function
        //
        //==================================
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using SlimGym_winversion.Objects;

namespace SlimGym_winversion
{
    public partial class LogIn : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================
        private int roundness = 18;
        //==================================
        //
        // Loading LogIn user control
        //
        //==================================
        public LogIn()
        {
            InitializeComponent();
            panelLogIn.Region =  Methods.ReturnRegion(Methods.CreateRoundedRectangle(roundness, panelLogIn.Width, panelLogIn.Height));                // Make login panel rounded
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
        // Get and set functions
        //
        //==================================
    }
}

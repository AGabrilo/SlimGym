using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimGym_winversion.UserControls
{
    public partial class AddRecord : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================

        //==================================
        //
        // Loading ListGroups usercontrol
        //
        //==================================
        public AddRecord()
        {
            InitializeComponent();
        }

        //==================================
        //
        // Button Add Entrance
        //
        //==================================
        private void buttonAddEntrance_Click(object sender, EventArgs e)
        {
            callSearchUsers("buttonAddEntrance");
        }

        //==================================
        //
        // Button Add Exit
        //
        //==================================
        private void buttonAddExit_Click(object sender, EventArgs e)
        {
            callSearchUsers("buttonAddExit");
        }

        //=======================================================//
        //                                                       //
        // ------------------CUSTOM FUNCTIONS------------------- //
        //                                                       //
        //=======================================================//

        private void callSearchUsers(string buttonName)
        {
            if (!Base.Instance.panelWindowControl.Controls.ContainsKey("SearchUsers"))                  // Checks for exitsting user control
            {                                                                                           // Does not exist
                SearchUsers searchUsersUserControl = new SearchUsers(buttonName);                                 // Creates an instance
                searchUsersUserControl.Dock = DockStyle.Fill;                                           //
                Base.Instance.panelWindowControl.Controls.Add(searchUsersUserControl);                  // Adds it to control
            }

            Base.Instance.panelWindowControl.Controls["SearchUsers"].BringToFront();                    // Showing Base
        }
    }
}

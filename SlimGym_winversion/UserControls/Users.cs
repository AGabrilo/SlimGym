using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SlimGym_winversion.UserControls;

namespace SlimGym_winversion.Pictures
{
    public partial class Users : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================
        

        //==================================
        //
        // Loading the form
        //
        //==================================
        public Users()
        {
            InitializeComponent();
        }

        //==================================
        //
        // Loading SearchUser user control on button click
        //
        //==================================
        private void buttonUserInfo_Click(object sender, EventArgs e)
        {
            if (!Base.Instance.panelWindowControl.Controls.ContainsKey("SearchUsers"))                  // Checks for exitsting user control
            {                                                                                           // Does not exist
                SearchUsers searchUsersUserControl = new SearchUsers();                                 // Creates an instance
                searchUsersUserControl.Dock = DockStyle.Fill;                                           //
                Base.Instance.panelWindowControl.Controls.Add(searchUsersUserControl);                  // Adds it to control
            }

            Base.Instance.panelWindowControl.Controls["SearchUsers"].BringToFront();                    // Showing Base
        }
        private void buttonNewUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonInTheGym_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignToGroup_Click(object sender, EventArgs e)
        {

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
    }
}

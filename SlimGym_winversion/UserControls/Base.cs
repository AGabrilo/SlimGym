using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimGym_winversion.Pictures;
using SlimGym_winversion.UserControls;

namespace SlimGym_winversion
{
    public partial class Base : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================
        static Base _base;

        //==================================
        //
        // Loading Base usercontrol
        //
        //==================================
        public Base()
        {
            InitializeComponent();
            _base = this;
        }

        //==================================
        //
        // Buttons in panelButtons
        //
        //==================================
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonUsers);
            panelWindow.Controls.Clear();                                       // Removes all user controls from controls to start fresh

            if (!panelWindow.Controls.ContainsKey("Users"))                     // If it does not exitst in controls add it
            {                
                Users usersUserControl = new Users();                           // Create new insatnce of Users user control
                usersUserControl.Dock = DockStyle.Fill;                         // Dock it so it works in full screen
                panelWindow.Controls.Add(usersUserControl);
            }
            panelWindow.Controls["Users"].BringToFront();                       // Bring Users to front
        }

        private void buttonGroupsScheduel_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonGroupsScheduel);
            panelWindow.Controls.Clear();                                       // Removes all user controls from controls to start fresh
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonRecords);
            panelWindow.Controls.Clear();                                       // Removes all user controls from controls to start fresh
            if (!panelWindow.Controls.ContainsKey("Records"))                   // If it does not exitst in controls add it
            {
                Records recordsUserContol = new Records();                  // Create new insatnce of Records user control
                recordsUserContol.Dock = DockStyle.Fill;                    // Dock it so it works in full screen
                panelWindow.Controls.Add(recordsUserContol);
            }
            panelWindow.Controls["Records"].BringToFront();                 // Bring Records to front
        }

        private void buttonMembership_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonMembership);
            panelWindow.Controls.Clear();                                       // Removes all user controls from controls to start fresh

            if (!panelWindow.Controls.ContainsKey("SearchUsers"))               // If it does not exitst in controls add it
            {
                SearchUsers searchUsersUserContol = new SearchUsers(buttonMembership.Name.ToString());          // Create new insatnce of SearchUsers user control
                searchUsersUserContol.Dock = DockStyle.Fill;                    // Dock it so it works in full screen
                panelWindow.Controls.Add(searchUsersUserContol);
            }
            panelWindow.Controls["SearchUsers"].BringToFront();                 // Bring SearchUsers to front
        }

        private void buttonChanges_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonChanges);
            panelWindow.Controls.Clear();                                       // Removes all user controls from controls to start fresh
        }


        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            SlimGym.Instance.panelBodyControl.Controls.RemoveByKey("Base");
        }


        //=======================================================//
        //                                                       //
        // ------------------CUSTOM FUNCTIONS------------------- //
        //                                                       //
        //=======================================================//

        //==================================
        //
        // Change back color of selcted section
        //
        //==================================
        private void ChangeBackColor(Button thisbutton)
        {
            thisbutton.BackColor = Color.FromArgb(105,105,105);
            foreach (var button in this.panelButtons.Controls.OfType<Button>())             // Checks all buttons and sets color
            {
                if (button != thisbutton)                                                   // If it wasn't pressed button make it gray
                    button.BackColor = Color.Gray;
            }
        }

        //==================================
        //                                  
        // Get and set functions            
        //                                  
        //==================================
        public static Base Instance
        {
            get
            {
                if (_base == null)
                {
                    _base = new Base();     // If _slimGym is null pointer create new instance of form
                }
                return _base;                // Return pointer on form
            }
        }

        public Panel panelWindowControl             // Returns pointer on panel body to be used in user control panel
        {
            get { return panelWindow; }
            set { panelWindow = value; }
        }

        public Color ResetButtonColors
        {
            get
            {
                return Color.Gray;
            }
            set
            {
                foreach(var button in this.panelButtons.Controls.OfType<Button>())          // Go through all buttons
                {
                    button.BackColor = value;                                               // Make them all gray
                }
            }
        }

        public string SelectedButton
        {
            get
            {
                foreach (var button in this.panelButtons.Controls.OfType<Button>())          // Go through all buttons
                {
                    if (button.BackColor == Color.FromArgb(105, 105, 105))
                        return button.Name;
                }
                return buttonUsers.Name;
            }
        }

    }
}

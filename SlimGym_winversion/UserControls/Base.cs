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
        Users usersUserControl = new Users();
        SearchUsers searchUsersUserContol = new SearchUsers();

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
            usersUserControl.Dock = DockStyle.Fill;
            panelWindow.Controls.Clear();
            if (!panelWindow.Controls.ContainsKey("Users"))
                panelWindow.Controls.Add(usersUserControl);
            panelWindow.Controls["Users"].BringToFront();
        }

        private void buttonGroupsScheduel_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonGroupsScheduel);
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonRecords);
        }

        private void buttonMembership_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonMembership);
            searchUsersUserContol.Dock = DockStyle.Fill;
            panelWindow.Controls.Clear();
            if(!panelWindow.Controls.ContainsKey("SearchUsers"))
                panelWindow.Controls.Add(searchUsersUserContol);
            panelWindow.Controls["SearchUsers"].BringToFront();

        }

        private void buttonChanges_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonChanges);
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
            foreach (var button in this.panelButtons.Controls.OfType<Button>())
            {
                if (button != thisbutton)
                    button.BackColor = Color.Gray;
            }
        }

        //==================================
        //
        // Used to change user control in panelWindow
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

        //==================================
        //
        // Used to change user control in panelWindow
        //
        //==================================
        public Color ResetButtonColors
        {
            get
            {
                return Color.Gray;
            }
            set
            {
                foreach(var button in this.panelButtons.Controls.OfType<Button>())
                {
                    button.BackColor = value;
                }
            }
        }
    }
}

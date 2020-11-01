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

namespace SlimGym_winversion
{
    public partial class Base : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================
        Users usersUserControl = new Users();
        List<Button> buttonList = new List<Button>();

        //==================================
        //
        // Loading Base usercontrol
        //
        //==================================
        public Base()
        {
            InitializeComponent();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ChangeBackColor(buttonUsers);
            usersUserControl.Dock = DockStyle.Fill;
            panelWindow.Controls.Add(usersUserControl);
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
    }
}

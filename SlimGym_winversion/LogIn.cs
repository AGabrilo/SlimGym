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

namespace SlimGym_winversion
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
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
            SlimGym.Instance.panelBodyControl.Controls.RemoveByKey("LogIn");        // Removing LogIn from controls

            //
            // If not show message
            //
        }
    }
}

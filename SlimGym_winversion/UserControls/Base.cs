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
            usersUserControl.Dock = DockStyle.Fill;
            panelWindow.Controls.Add(usersUserControl);
        }
    }
}

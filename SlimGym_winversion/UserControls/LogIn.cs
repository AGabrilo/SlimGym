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
using SlimGym_winversion.DB_Connection;
using SlimGym_winversion.LoggedUser;

namespace SlimGym_winversion
{
    public partial class LogIn : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================

        //==================================
        //
        // Loading LogIn user control
        //
        //==================================
        public LogIn()
        {
            InitializeComponent();
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
            DataTable dataTable = DBAcess.get(Queries.getLogin(textBoxPassword.Text, textBoxUsername.Text));
            if (dataTable != null && int.Parse(dataTable.Rows[0][3].ToString()) < 3)
            {
                SlimGym.loggedUser = new LoggedIn(dataTable);
                if (!SlimGym.Instance.panelBodyControl.Controls.ContainsKey("Base"))    // Checks for exitsting user control
                {                                                                       // Does not exist
                    Base baseUserControl = new Base(dataTable.Rows[0][0].ToString());                                  // Creates an instance
                    baseUserControl.Dock = DockStyle.Fill;                              //
                    SlimGym.Instance.panelBodyControl.Controls.Add(baseUserControl);    // Adds it to control
                }

                SlimGym.Instance.panelBodyControl.Controls["Base"].BringToFront();      // Showing Base
            }
            
            else
            {
                MessageBox.Show("Data is invalid!!!");
            }
            textBoxPassword.Text = "";                                              // Deleting data from textboxes
            textBoxUsername.Text = "";                                              // Deleting data from textboxes

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

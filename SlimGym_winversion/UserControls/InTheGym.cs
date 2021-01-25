﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimGym_winversion.DB_Connection;

namespace SlimGym_winversion.UserControls
{
    public partial class InTheGym : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================


        //==================================
        //
        // Loading Base usercontrol
        //
        //==================================
        public InTheGym()
        {
            InitializeComponent();
            dataGridViewSearchUsers.DataSource =  DBAcess.get(Queries.getPeopleInTheGym());
        }

        //==================================
        //
        // Back button
        //
        //==================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("InTheGym");
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
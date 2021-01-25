﻿using SlimGym_winversion.Objects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlimGym_winversion.UserControls
{
    public partial class ListGroups : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================
        static ListGroups listGroups;

        //==================================
        //
        // Loading ListGroups usercontrol
        //
        //==================================
        public ListGroups()
        {
            InitializeComponent();
            listGroups = this;
        }

        //==================================
        //
        // Button Back 
        //
        //==================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("ListGroups");       // Removes user control from controls
            if (Base.Instance.panelWindowControl.Controls.Count == 0)                  // Checks if the ListGroups is only user control in controls
            {
                Base.Instance.ResetButtonColors = Color.Gray;                          // To reset colors of buttons in panelButtons if it is first user control that button opens
            }
        }

        //==================================
        //                                  
        // Get and set functions            
        //                                  
        //==================================
        public static ListGroups Instance
        {
            get
            {
                if (listGroups == null)
                {
                    listGroups = new ListGroups();
                }
                return listGroups;
            }
        }

        public panelEllip PanelGroups
        {
            get => panelGroups;
        }
    }
}
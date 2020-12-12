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
    public partial class AddEntranceOrExit : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================
        static AddEntranceOrExit addEntranceOrExit;

        //==================================
        //
        // Loading AddEntranceOrExit usercontrol
        //
        //==================================
        public AddEntranceOrExit()
        {
            InitializeComponent();
            addEntranceOrExit = this;
        }

        //==================================
        //
        // Button Back
        //
        //==================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("AddEntranceOrExit");       // Removes user control from controls
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

        public static AddEntranceOrExit Instance
        {
            get
            {
                if(addEntranceOrExit == null)
                {
                    addEntranceOrExit = new AddEntranceOrExit();
                }

                return addEntranceOrExit;
            }
        }

        public Label LabelExitTime
        {
            get => labelExitTime;
            set { labelExitTime = value; }
        }

        public Label LabelExitTimeValue
        {
            get => labelExitTimeValue;
            set { labelExitTimeValue = value; }
        }
    }
}

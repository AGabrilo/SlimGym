using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimGym_winversion.Objects;

namespace SlimGym_winversion.UserControls
{
    public partial class AddMembership : UserControl
    {
        static AddMembership addMembership;
        public AddMembership()
        {
            InitializeComponent();
            addMembership = this;
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("AddMembership");       // Removes user control from controls
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
        public static AddMembership Instance
        {
            get
            {
                if (addMembership == null)
                {
                    addMembership = new AddMembership();
                }
                return addMembership;
            }
        }

        public panelEllip PanelMemberships
        {
            get => panelMemberships;
        }
    }
}

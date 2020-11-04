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
    public partial class Records : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================
        public static Records _records;

        //==================================
        //
        // Loading Records usercontrol
        //
        //==================================
        public Records()
        {
            InitializeComponent();

            _records = this;

            panelFilter.Region = Methods.ReturnRegion(Methods.CreateRoundedRectangle(2, panelFilter.Width, panelFilter.Height));
            labelFilter.Region = Methods.ReturnRegion(Methods.CreateRoundedRectangle(1, labelFilter.Width, labelFilter.Height));
            datePickerEntrance.Region = Methods.ReturnRegion(Methods.CreateRoundedRectangle(1, datePickerEntrance.Width, datePickerEntrance.Height - 3));
            datePickerExit.Region = Methods.ReturnRegion(Methods.CreateRoundedRectangle(1, datePickerExit.Width, datePickerExit.Height - 3));
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
        public static Records Instance
        {
            get 
            {   if(_records == null)
                {
                    _records = new Records();
                }
                return _records;
            }
        }

        public panelEllip PanelFilter
        {
            get { return panelFilter; }
            set { panelFilter = value; }
        }
    }
}

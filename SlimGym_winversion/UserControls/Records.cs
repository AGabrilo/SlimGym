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
    }
}

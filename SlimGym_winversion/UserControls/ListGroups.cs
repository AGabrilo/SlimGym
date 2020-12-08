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
    public partial class ListGroups : UserControl
    {
        static ListGroups listGroups;
        public ListGroups()
        {
            InitializeComponent();
            listGroups = this;
        }

        public static ListGroups Instance
        {
            get
            {
                if(listGroups == null)
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

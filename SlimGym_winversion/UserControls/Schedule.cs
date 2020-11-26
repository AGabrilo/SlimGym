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
    public partial class Schedule : UserControl
    {
        static Schedule sch;
        public Schedule()
        {
            InitializeComponent();
            sch = this;
        }
        public static Schedule Instance
        {
            get
            {
                if (sch == null)
                {
                    sch = new Schedule();
                }
                return sch;
            }
        }

        public panelSchedule panelSchedule =>
            panelSchedule1;
            
    }
}

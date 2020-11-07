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
    public partial class UserControl1 : UserControl
    {
        public static UserControl1 uc1;
        public UserControl1()
        {
            InitializeComponent();
            uc1 = this;
        }

        private void base1_Load(object sender, EventArgs e)
        {
        }

        public static UserControl1 Instance
        {
            get 
            {
                if(uc1 == null)
                {
                    uc1 = new UserControl1();
                }
                return uc1;
            }
        }

        public panelEllip PanelEllip => panelEllip1;
        
    }
}

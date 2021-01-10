using System;
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
    public partial class UserInfo : UserControl
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
        public UserInfo(DataTable info)
        {                                                                                               //ovo bi tribalo bit oke,
            InitializeComponent();                                                                      //samo prominit labele u vrijednosti
            string personalid = info.Rows[0][3].ToString();
            DBAcess.get(Queries.getUser(personalid));
        }

        //==================================
        //
        // Back button
        //
        //==================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("UserInfo");
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

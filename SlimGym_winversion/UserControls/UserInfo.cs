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
        public UserInfo(string personal_id)
        {                                                                                               //ovo bi tribalo bit oke,
            InitializeComponent();                                                                    //samo prominit labele u vrijednosti
            insertInfo(personal_id);
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

        //==================================
        //
        // insert info function
        //
        //==================================
        private void insertInfo(string personal_id)
        {
            DataTable userInfoTable = new DataTable();
            userInfoTable = DBAcess.get(Queries.getUser(personal_id));
            labelNameValue.Text = userInfoTable.Rows[0][0].ToString();
            labelSurnameValue.Text = userInfoTable.Rows[0][1].ToString();
            labelUserIDValue.Text = userInfoTable.Rows[0][2].ToString();
            labelPersonalIDValue.Text = userInfoTable.Rows[0][3].ToString();
            labelBirthDateValue.Text = userInfoTable.Rows[0][4].ToString();
            labelGenderValue.Text = userInfoTable.Rows[0][5].ToString();
            labelContactValue.Text = userInfoTable.Rows[0][6].ToString();
            labelPaymentDateValue.Text = userInfoTable.Rows[0][7].ToString();
            labelExpirationDateValue.Text = userInfoTable.Rows[0][8].ToString();
            labelMembeshipValue.Text = userInfoTable.Rows[0][9].ToString();
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

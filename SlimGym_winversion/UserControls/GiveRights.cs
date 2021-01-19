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
    public partial class GiveRights : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================

        private string personal_id;

        //==================================
        //
        // Loading Base usercontrol
        //
        //==================================

        public GiveRights(string name, string surname, string birth_date, string personal_id)
        {
            InitializeComponent();
            labelNameValue.Text = name;
            labelSurnameValue.Text = surname;
            labelPersonalIDValue.Text = personal_id;
            labelBirthDateValue.Text = birth_date;
            this.personal_id = personal_id;
        }

        //==================================
        //
        // Back button
        //
        //==================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("GiveRights");
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (radioButtonAdministrator.Checked == true)
            {
                DBAcess.put(Queries.changeRights(personal_id, 1));
            }
            else if (radioButtonEmployee.Checked == true)
            {
                DBAcess.put(Queries.changeRights(personal_id, 2));
            }

            Base.Instance.panelWindowControl.Controls.RemoveByKey("GiveRights");
        }
    }
}

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
    public partial class NewUser : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================


        //==================================
        //
        // Loading NewUser usercontrol
        //
        //==================================
        public NewUser()
        {
            InitializeComponent();
        }

        //==================================
        //
        // Cancle button
        //
        //==================================
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("NewUser");
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxSurname.Text) && !string.IsNullOrEmpty(textBoxPersonalID.Text) && !string.IsNullOrEmpty(textBoxBithDate.Text) && !string.IsNullOrEmpty(textBoxPhone.Text))
            {
                string username = textBoxName.Text[0] + textBoxSurname.Text;
                string password = textBoxName.Text[0] + textBoxSurname.Text + "123";
                if (radioButtonNewUser.Checked)
                {
                    if (radioButtonMale.Checked)
                    {
                        DBAcess.put(Queries.putUser(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, radioButtonMale.Text, textBoxBithDate.Text, textBoxPhone.Text));
                    }
                    else if (radioButtonFemale.Checked)
                        DBAcess.put(Queries.putUser(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, radioButtonFemale.Text, textBoxBithDate.Text, textBoxPhone.Text));
                    else
                        MessageBox.Show("Gender not selected");
                }

                else if (radioButtonNewEmployee.Checked)
                {
                    if (radioButtonMale.Checked)
                    {
                        DBAcess.put(Queries.putEmployee(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, radioButtonMale.Text, textBoxBithDate.Text, textBoxPhone.Text));
                        DBAcess.put(Queries.MakeAccount(username, password, 2));
                    }
                    else if (radioButtonFemale.Checked)
                    {
                        DBAcess.put(Queries.putEmployee(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, radioButtonFemale.Text, textBoxBithDate.Text, textBoxPhone.Text));
                        DBAcess.put(Queries.MakeAccount(username, password, 2));
                    }
                    else
                        MessageBox.Show("Gender not selected");
                }

                else
                    MessageBox.Show("Action not selected");
            }

            else
                MessageBox.Show("Not all data entered");
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

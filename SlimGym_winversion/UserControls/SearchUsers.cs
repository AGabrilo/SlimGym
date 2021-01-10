using SlimGym_winversion.DB_Connection;
using SlimGym_winversion.Objects;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SlimGym_winversion.UserControls
{
    public partial class SearchUsers : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================
        public string triggerName;

        //==================================
        //
        // Loading Base usercontrol
        //
        //==================================
        public SearchUsers(string triggerName)
        {
            InitializeComponent();
            dataGridViewSearchUsers.DataSource = DBAcess.get(Queries.getUsers(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, textBoxBithDate.Text));
            this.triggerName = triggerName;
            if (Base.Instance.panelWindowControl.Controls.Count == 0)                    // Checks if the searchUsers is onley user control in controls
            {
                buttonBack.Visible = false;                                             // If yes make buttonBack invisible
            }
        }

        //==================================
        //
        // Button Search
        //
        //==================================
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSearchUsers.DataSource = DBAcess.get(Queries.getUsers(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, textBoxBithDate.Text));
        }

        //==================================
        //
        // Button Back 
        //
        //==================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("SearchUsers");       // Removes user control from controls
            if (Base.Instance.panelWindowControl.Controls.Count == 0)                    // Checks if the searchUsers is onley user control in controls
            {
                Base.Instance.ResetButtonColors = Color.Gray;                           // To reset colors of buttons in panelButtons if it is first user control that button opens
            }
        }

        //==================================
        //
        // Button Select
        //
        //==================================
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridViewSearchUsers.SelectedRows.ToString()))
            {
                if (triggerName == "buttonUserInfo")
                {
                    if (!Base.Instance.panelWindowControl.Controls.ContainsKey("UserInfo"))             // Checks for exitsting user control
                    {                                                                                   // Does not exist
                        DataTable selectedUserInfo= new DataTable();
                        /*NE VALJA*/
                        selectedUserInfo.Rows.Add(dataGridViewSearchUsers.SelectedRows.ToString());
                        UserInfo userInfoUserControl = new UserInfo(selectedUserInfo);                  // Creates an instance
                        userInfoUserControl.Dock = DockStyle.Fill;                                     //
                        Base.Instance.panelWindowControl.Controls.Add(userInfoUserControl);           // Adds it to control
                    }

                    Base.Instance.panelWindowControl.Controls["UserInfo"].BringToFront();               // Bring userInfo to front without removing searchUsers from controls (so we can go back to it)
                }

                if (triggerName == "buttonSignToGroup")
                {
                    if (!Base.Instance.panelWindowControl.Controls.ContainsKey("ListGroups"))             // Checks for exitsting user control
                    {                                                                                   // Does not exist
                        ListGroups listGroupsUserControl = new ListGroups();                                  // Creates an instance
                        listGroupsUserControl.Dock = DockStyle.Fill;                                      //
                        Base.Instance.panelWindowControl.Controls.Add(listGroupsUserControl);             // Adds it to control
                    }

                    Base.Instance.panelWindowControl.Controls["ListGroups"].BringToFront();               // Bring userInfo to front without removing searchUsers from controls (so we can go back to it)
                    Methods.addPanels(ListGroups.Instance.PanelGroups, 5);
                }


                if (triggerName == "buttonMembership")
                {

                }

                if (triggerName == "buttonAddEntrance")
                {
                    callAddEntranceOrExitUserControl();
                    AddEntranceOrExit.Instance.LabelExitTime.Visible = false;
                    AddEntranceOrExit.Instance.LabelExitTimeValue.Visible = false;
                }

                if (triggerName == "buttonAddExit")
                {
                    callAddEntranceOrExitUserControl();
                    AddEntranceOrExit.Instance.LabelExitTime.Visible = true;
                    AddEntranceOrExit.Instance.LabelExitTimeValue.Visible = true;
                }
            }
        }

        //=======================================================//
        //                                                       //
        // ------------------CUSTOM FUNCTIONS------------------- //
        //                                                       //
        //=======================================================//

        //==================================
        //                                  
        // Call AddEntranceOrExit user control
        //                                  
        //==================================
        private void callAddEntranceOrExitUserControl()
        {
            if (!Base.Instance.panelWindowControl.Controls.ContainsKey("AddEntranceOrExit"))                // Checks for exitsting user control
            {                                                                                               // Does not exist
                AddEntranceOrExit AddEntranceOrExitUserControl = new AddEntranceOrExit();                   // Creates an instance
                AddEntranceOrExitUserControl.Dock = DockStyle.Fill;                                         //
                Base.Instance.panelWindowControl.Controls.Add(AddEntranceOrExitUserControl);                // Adds it to control

                Base.Instance.panelWindowControl.Controls["AddEntranceOrExit"].BringToFront();              // Bring userInfo to front without removing searchUsers from controls (so we can go back to it)
            }
        }
    }
}

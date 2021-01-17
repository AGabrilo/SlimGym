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
        static SearchUsers _searchUsers;

        //==================================
        //
        // Loading Base usercontrol
        //
        //==================================
        public SearchUsers(string triggerName)
        {
            InitializeComponent();
            this.triggerName = triggerName;
            if (Base.Instance.panelWindowControl.Controls.Count == 0)                    // Checks if the searchUsers is onley user control in controls
            {
                buttonBack.Visible = false;                                             // If yes make buttonBack invisible
            }

            loadDataGridView(triggerName);
        }

        //==================================
        //
        // Button Search
        //
        //==================================
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            loadDataGridView(triggerName);
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
                        string personalId = dataGridViewSearchUsers.CurrentRow.Cells[3].Value.ToString();

                        UserInfo userInfoUserControl = new UserInfo(personalId);                  // Creates an instance
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
                    Methods.addPanelsGroups(ListGroups.Instance.PanelGroups, 5, dataGridViewSearchUsers.CurrentRow.Cells[4].Value.ToString());
                }


                if (triggerName == "buttonMembership")
                {
                    if (!Base.Instance.panelWindowControl.Controls.ContainsKey("AddMembership"))             // Checks for exitsting user control
                    {                                                                                   // Does not exist
                        AddMembership AddMembershipUserControl = new AddMembership();                                  // Creates an instance
                        AddMembershipUserControl.Dock = DockStyle.Fill;                                      //
                        Base.Instance.panelWindowControl.Controls.Add(AddMembershipUserControl);             // Adds it to control
                    }

                    Base.Instance.panelWindowControl.Controls["AddMembership"].BringToFront();               // Bring userInfo to front without removing searchUsers from controls (so we can go back to it)
                    Methods.addPanelsMemberships(AddMembership.Instance.PanelMemberships, 5, dataGridViewSearchUsers.CurrentRow.Cells[4].Value.ToString());
                }

                if (triggerName == "buttonAddEntrance")
                {
                    callAddEntranceOrExitUserControl("Entrance");
                }

                if (triggerName == "buttonAddExit")
                {
                    callAddEntranceOrExitUserControl("Exit");
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
        private void callAddEntranceOrExitUserControl(string command)
        {
            if (!Base.Instance.panelWindowControl.Controls.ContainsKey("AddEntranceOrExit"))                // Checks for exitsting user control
            {                                                                                               // Does not exist
                AddEntranceOrExit AddEntranceOrExitUserControl = new AddEntranceOrExit(triggerName, dataGridViewSearchUsers.CurrentRow.Cells[0].Value.ToString(), dataGridViewSearchUsers.CurrentRow.Cells[1].Value.ToString(), dataGridViewSearchUsers.CurrentRow.Cells[4].Value.ToString());                   // Creates an instance
                AddEntranceOrExitUserControl.Dock = DockStyle.Fill;                                         //
                Base.Instance.panelWindowControl.Controls.Add(AddEntranceOrExitUserControl);                // Adds it to control

                Base.Instance.panelWindowControl.Controls["AddEntranceOrExit"].BringToFront();              // Bring userInfo to front without removing searchUsers from controls (so we can go back to it)
            }
        }

        public void loadDataGridView(string triggerName)
        {
            if (triggerName == "buttonUserInfo")
            {
                dataGridViewSearchUsers.DataSource = DBAcess.get(Queries.getUsers(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, textBoxBithDate.Text));
            }
            else if (triggerName == "buttonSignToGroup")
            {
                dataGridViewSearchUsers.DataSource = DBAcess.get(Queries.getUsers(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, textBoxBithDate.Text));
            }
            else if (triggerName == "buttonMembership")
            {
                dataGridViewSearchUsers.DataSource = DBAcess.get(Queries.getUsers(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, textBoxBithDate.Text));
            }
            else if (triggerName == "buttonAddEntrance")
            {
                dataGridViewSearchUsers.DataSource = DBAcess.get(Queries.getUserToAddEntrance(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, textBoxBithDate.Text));
            }
            else if (triggerName == "buttonAddExit")
            {
                dataGridViewSearchUsers.DataSource = DBAcess.get(Queries.getUserToAddExit(textBoxName.Text, textBoxSurname.Text, textBoxPersonalID.Text, textBoxBithDate.Text));
            }
        }

        //==================================
        //                                  
        // Get and set functions            
        //                                  
        //==================================
        public static SearchUsers Instance
        {
            get
            {
                if (_searchUsers == null)
                {
                    _searchUsers = new SearchUsers("Error");         // If _slimGym is null pointer create new instance of form
                }
                return _searchUsers;                   // Return pointer on form
            }
        }
    }
}

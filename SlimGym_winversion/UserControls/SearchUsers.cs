using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimGym_winversion.Pictures;

namespace SlimGym_winversion.UserControls
{
    public partial class SearchUsers : UserControl
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
        public SearchUsers()
        {
            InitializeComponent();
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
            if(textBoxName.ToString() == "Toni" || string.IsNullOrEmpty(textBoxName.Text.ToString()) &&                         // 
                textBoxSurname.ToString() == "Jakovceic" || string.IsNullOrEmpty(textBoxSurname.Text.ToString()) &&             // Check conditions for search
                textBoxPersonalID.ToString() == "Toni" || string.IsNullOrEmpty(textBoxPersonalID.Text.ToString()) &&            // 
                textBoxBithDate.ToString() == "Toni" || string.IsNullOrEmpty(textBoxBithDate.Text.ToString()))                  // 
            {
                dataGridViewSearchUsers.Rows.Add("Toni", "Jakovcevic", "12345678910", "1.1.1999.");
            }
        }

        //==================================
        //
        // Button Back 
        //
        //==================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("SearchUsers");       // Removes user control from controls
            if(Base.Instance.panelWindowControl.Controls.Count == 0)                    // Checks if the searchUsers is onley user control in controls
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
                if (!Base.Instance.panelWindowControl.Controls.ContainsKey("UserInfo"))             // Checks for exitsting user control
                {                                                                                   // Does not exist
                    UserInfo userInfoUserControl = new UserInfo();                                  // Creates an instance
                    userInfoUserControl.Dock = DockStyle.Fill;                                      //
                    Base.Instance.panelWindowControl.Controls.Add(userInfoUserControl);             // Adds it to control
                }

                Base.Instance.panelWindowControl.Controls["UserInfo"].BringToFront();               // Bring userInfo to front without removing searchUsers from controls (so we can go back to it)       
            }
        }

        //=======================================================//
        //                                                       //
        // ------------------CUSTOM FUNCTIONS------------------- //
        //                                                       //
        //=======================================================//

        //==================================
        //
        // Refresh data grid view
        //
        //==================================
        private void RefreshDataGridView(DataGrid dataGrid)
        {
          
        }
    }
}

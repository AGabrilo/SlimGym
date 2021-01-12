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
    public partial class AddEntranceOrExit : UserControl
    {
        //==================================
        //
        // Initializing all variables
        //
        //==================================
        static AddEntranceOrExit addEntranceOrExit;
        private string command;
        //==================================
        //
        // Loading AddEntranceOrExit usercontrol
        //
        //==================================
        public AddEntranceOrExit(string command, string name, string surname, string user_id)
        {
            InitializeComponent();
            addEntranceOrExit = this;
            labelNameValue.Text = name;
            labelSurnameValue.Text = surname;
            labelUserIDValue.Text = user_id;
            this.command = command;
            setEntranceOrExit();
        }

        //==================================
        //
        // Button Back
        //
        //==================================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("AddEntranceOrExit");       // Removes user control from controls
            if (Base.Instance.panelWindowControl.Controls.Count == 0)                  // Checks if the ListGroups is only user control in controls
            {
                Base.Instance.ResetButtonColors = Color.Gray;                          // To reset colors of buttons in panelButtons if it is first user control that button opens
            }

            Base.Instance.panelWindowControl.Controls.RemoveByKey("SearchUsers");       // Removes user control from controls
            if (Base.Instance.panelWindowControl.Controls.Count == 0)                  // Checks if the ListGroups is only user control in controls
            {
                Base.Instance.ResetButtonColors = Color.Gray;                          // To reset colors of buttons in panelButtons if it is first user control that button opens
            }
        }

        private void setEntranceOrExit()
        {
            if(command == "buttonAddEntrance")
            {
                labelExitTime.Visible = false;
                labelExitTimeValue.Visible = false;
                labelEntranceTimeValue.Text = DateTime.Now.ToString("t");
            }
            else
            {
                labelEntranceTimeValue.Text = DBAcess.get(Queries.getEntranceInfo(labelUserIDValue.Text.ToString())).Rows[0][0].ToString();
                labelExitTimeValue.Text = DateTime.Now.ToString("t");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (command == "buttonAddEntrance")
            {
                DBAcess.put(Queries.putRecordEntrance(labelUserIDValue.Text.ToString()));
            }
            else
            {
                DBAcess.put(Queries.putRecordExit(labelUserIDValue.Text.ToString()));
            }
            MessageBox.Show("Record Added!");
            buttonBack_Click(sender, e);

        }
        //==================================
        //                                  
        // Get and set functions            
        //                                  
        //==================================

        public static AddEntranceOrExit Instance
        {
            get
            {
                if(addEntranceOrExit == null)
                {
                    addEntranceOrExit = new AddEntranceOrExit("null", "null", "null", "null");
                }

                return addEntranceOrExit;
            }
        }

        public Label LabelExitTime
        {
            get => labelExitTime;
            set { labelExitTime = value; }
        }

        public Label LabelExitTimeValue
        {
            get => labelExitTimeValue;
            set { labelExitTimeValue = value; }
        }


    }
}

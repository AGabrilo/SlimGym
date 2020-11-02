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
        public SearchUsers()
        {
            InitializeComponent();            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxName.ToString() == "Toni" || string.IsNullOrEmpty(textBoxName.Text.ToString()) &&
                textBoxSurname.ToString() == "Jakovceic" || string.IsNullOrEmpty(textBoxSurname.Text.ToString()) &&
                textBoxPersonalID.ToString() == "Toni" || string.IsNullOrEmpty(textBoxPersonalID.Text.ToString()) &&
                textBoxBithDate.ToString() == "Toni" || string.IsNullOrEmpty(textBoxBithDate.Text.ToString()))
            {
                dataGridViewSearchUsers.Rows.Add("Toni", "Jakovcevic", "12345678910", "1.1.1999.");
            }
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Base.Instance.panelWindowControl.Controls.RemoveByKey("SearchUsers");
            if(Base.Instance.panelWindowControl.Controls.Count == 0)
            {
                Base.Instance.ResetButtonColors = Color.Gray;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridViewSearchUsers.SelectedRows.ToString()))
            {
                if (!Base.Instance.panelWindowControl.Controls.ContainsKey("UserInfo"))
                {
                    UserInfo usersUserControl = new UserInfo();
                    usersUserControl.Dock = DockStyle.Fill;
                    Base.Instance.panelWindowControl.Controls.Add(usersUserControl);
                }

                Base.Instance.panelWindowControl.Controls["UserInfo"].BringToFront();
                Base.Instance.panelWindowControl.Controls.RemoveByKey("SearchUsers");
            }
        }

        private void RefreshDataGridView(DataGrid dataGrid)
        {
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using SlimGym_winversion.Objects;
using System.Windows.Forms;
using SlimGym_winversion.DB_Connection;

namespace SlimGym_winversion.Objects
{
    public class panelItems : panelEllip
    {
        private Label labelName = new Label();
        private Label labelDescripton = new Label();
        private buttonEllip buttonSign = new buttonEllip();

        public panelItems(int parentWidth, int index, string name, string description, string user_id, int type)
        {
            setPanelStyle(parentWidth, index);
            setLabelNameStyle(labelName, name);
            setLabelDescription(labelDescripton, description, parentWidth);
            setButtonStyle(buttonSign);
            this.Controls.Add(labelName);
            this.Controls.Add(labelDescripton);
            this.Controls.Add(buttonSign);
            if (type == 1)
                buttonSign.Click += (s, e) => { DBAcess.put(Queries.putGroupRecord(user_id, (index + 1).ToString())); };
            else if (type == 2)
                buttonSign.Click += (s, e) => { DBAcess.put(Queries.putMembershipRecord(user_id, (index + 1).ToString())); };

        }

        private void setLabelNameStyle(Label label, string name)
        {
            label.Text = name;
            label.ForeColor = Color.FromArgb(75,180,30);
            label.Location = new Point(20, 10);
            label.Font = new Font("Arial", 15, FontStyle.Bold);
            label.AutoSize = true;
        }

        private void setLabelDescription(Label label, string description, int parentWidth)
        {
            label.Text = description;
            label.ForeColor = Color.White;
            label.Location = new Point(30, 50);
            label.Size = new Size(parentWidth - 300, 80); ;
        }

        private void setButtonStyle(buttonEllip button)
        {
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BorderColor = Color.FromArgb(75, 180, 30);
            button.BorderThickness = 6;
            button.ButtonRoundness = 2;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 180, 30);
            button.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button.OnClickTextColor = Color.FromArgb(75, 180, 30);
            button.OnHoverTextColor = Color.White;
            button.Text = "Sign";
            button.ForeColor = Color.FromArgb(75, 180, 30);
            button.Font = new Font("Microsoft San Sherif", 15, FontStyle.Bold);
            button.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            button.Size = new Size(150, 50);
            button.Location = new Point(Width - 200, (Height - button.Height) / 2);
        }

        private void setPanelStyle(int parentWidth, int index)
        {
            Size = new Size(parentWidth - 40, 150);
            Location = new Point(20, 160 * index + 5);
            BorderThickness = 3;
            BorderColor = Color.Gray;
            BorderStyle = BorderStyle.None;
            Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        }   


    }
}

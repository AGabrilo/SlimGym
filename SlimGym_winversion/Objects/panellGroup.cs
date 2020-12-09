using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using SlimGym_winversion.Objects;
using System.Windows.Forms;

namespace SlimGym_winversion.Objects
{
    public class panellGroup : panelEllip
    {
        private Label labelName = new Label();
        private Label labelDescripton = new Label();
        private buttonEllip buttonSign = new buttonEllip();

        public panellGroup(int parentWidth, int index)
        {
            setPanelStyle(parentWidth, index);
            setLabelNameStyle(labelName);
            setLabelDescription(labelDescripton);
            setButtonStyle(buttonSign);
            this.Controls.Add(labelName);
            this.Controls.Add(labelDescripton);
            this.Controls.Add(buttonSign);
        }

        private void setLabelNameStyle(Label label)
        {
            label.Text = "Group name";
            label.ForeColor = Color.FromArgb(75,180,30);
            label.Location = new Point(20, 10);
            label.Font = new Font("Arial", 15, FontStyle.Bold);
        }

        private void setLabelDescription(Label label)
        {
            label.Text = "dasdnijasndiuh h auish uidhasiu diuhaushoiduh oh oiudhaoiush dh oiahosihdo hoi hoi aoi";
            label.ForeColor = Color.White;
            label.Location = new Point(30, 50);
            label.AutoSize = true;
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

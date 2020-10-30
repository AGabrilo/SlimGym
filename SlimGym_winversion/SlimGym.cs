using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SlimGym_winversion
{

    public partial class SlimGym : Form
    {

        //
        // Make form rounded
        //
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        //
        // Creating functions
        //
        static SlimGym _slimGym; //creating a SlimGym object

        public static SlimGym Instance 
        {
            get
            {
                if (_slimGym == null)
                {
                    _slimGym = new SlimGym();   // If _slimGym is null pointer create new instance of form
                }

                return _slimGym;    // Return pointer on form
            }
        }

        public Panel panelBodyControl   // Returns pointer on panel body to be used in user control panel
        {
            get { return panelBody; }
            set { panelBody = value; }
        }
           

        //
        // Initializing all components
        //
        LogIn logInUserControl = new LogIn();
        Base baseUserControl = new Base();




        //
        // Loading the form
        //
        public SlimGym()
        {
            InitializeComponent();

            _slimGym = this;    // Seting _slimGym to pint on this form

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //applying round corners         
            
            logInUserControl.Dock = DockStyle.Fill;     //
            panelBody.Controls.Add(logInUserControl);   // Adding LogIn to controls
        }


        //
        // Minimize Button
        //
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //
        // Maximize Button
        //
        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));    //set normal corners when maximized
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));  //apply round corners when form size is normal
            }
        }
        
        //
        // Exit Button
        //
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

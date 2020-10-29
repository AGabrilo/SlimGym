using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimGym_winversion
{

    public partial class Form1 : Form
    {
        LogIn login = new LogIn();
        
        public Form1()
        {
            InitializeComponent();
            login.Dock = DockStyle.Fill;
            panelBody.Controls.Add(login);

        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

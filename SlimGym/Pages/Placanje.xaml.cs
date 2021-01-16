using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SlimGym
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Placanje : ContentPage
    {


        public Placanje()
        {
            InitializeComponent();

        }

        private void Btn_history_Clicked(object sender, EventArgs e)
        {
            history_scroll.IsVisible = true;
        }

    }
}
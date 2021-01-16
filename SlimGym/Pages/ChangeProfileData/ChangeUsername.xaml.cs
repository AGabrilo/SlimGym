using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlimGym.Pages.ChangeProfileData
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangeUsername : ContentPage
    {
        public ChangeUsername()
        {
            InitializeComponent();
        }
        public async void ChangeU(object sender, EventArgs e)
        {


            await Navigation.PushAsync(new Profile());

        }
    }
}
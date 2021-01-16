using SlimGym.Pages;
using SlimGym.Pages.PagesOfPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlimGym
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Pocetna : ContentPage
    {
        
        public Pocetna()
        {
            InitializeComponent();
        }

        public async void Clicked_toCrossfit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Crossfit());
        }
        public async void Clicked_toBoks(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Boks());
        }
        public async void Clicked_toZumba(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Zumba());
        }
        public async void Clicked_toSpinning(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Spinning());
        }
        public async void Clicked_toTotalBody(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TotalBody());
        }
    }
}
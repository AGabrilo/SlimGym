using SlimGym.Models;
using SlimGym.Pages;
using SlimGym.Pages.ChangeProfileData;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlimGym
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
            BindingContext = new ProfileListView();
        }

        async private void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            if (PLV.SelectedItem == null)
                return;

            var profileselecteditem = e.Item as ProfileModel;

            switch (profileselecteditem.id)
            {
                case 4:
                    await Navigation.PushAsync(new ChangeUsername());
                    break;
                case 5:
                    await Navigation.PushAsync(new ChangePassword());
                    break;

            }

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}

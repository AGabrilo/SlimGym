using SlimGym.Models;
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
    public partial class ChangePassword : ContentPage
    {

        public ChangePassword()
        {
            InitializeComponent();
        }
        public async void ChangeP(object sender, EventArgs e)
        {
           
            PasswordCheck p = new PasswordCheck(What_password.Text, Change_password.Text, ChangeAgain_password.Text);
            if (p.CheckRepeatedPassword().Equals(true))
                await Navigation.PushAsync(new Profile());
            else
                await DisplayAlert("Change password", "You didn't enter the same password twice!", "Oke");

        }
       

    }
}
using SlimGym.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SlimGym
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }
        
        public async void Clicked_ButtonAsync(object sender, EventArgs e)
        {
            Login user = new Login(Entry_username.Text, Entry_password.Text);
            if (user.CheckInformation().Equals(true))

                await Navigation.PushAsync(new MenuFeature());
            else
                await DisplayAlert("Login", "Login unsuccessful,wrong username or password", "Oke");
        }
        public async void Clicked_ButtonAsync2(object sender, EventArgs e)
        {
            

                await Navigation.PushAsync(new SignUp());
           
        }

    }
}

using SlimGym.Models;
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
    public partial class SignUp : ContentPage
    {
       

        public SignUp()
        {
            InitializeComponent();
        }

        //private void DateOfBirth(object sender, DateChangedEventArgs e)
        //{
        //    MainLabel.Text = e.NewDate.ToLongDateString();
        //}

        public async void Clicked_ButtonSignUp(object sender, EventArgs e)
        {
            Registration U = new Registration(Entry_username.Text,Entry_Name.Text, Entry_Surname.Text, Entry_Email.Text, Entry_Passw.Text);
            
            
                await Navigation.PushAsync(new MenuFeature());
            
        }
    }
}
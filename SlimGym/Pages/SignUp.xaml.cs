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

        private void MainDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            MainLabel.Text = e.NewDate.ToLongDateString();
        }
    }
}
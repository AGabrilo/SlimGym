using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlimGym.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Schedule : ContentPage
    {
        public Schedule()
        {
            InitializeComponent();

        }
        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Show();
            
        }

        void Show()
        {
            first_scroll.IsVisible = true;
        }
       

    }
}
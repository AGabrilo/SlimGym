using SlimGym.Models;
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
    public partial class Programs : ContentPage
    {
        public Programs()
        {
            InitializeComponent();
            BindingContext = new ListViewModel();
        }
        async private void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

            if (flowlistview.SelectedItem == null)
                return;

            var myselecteditem = e.Item as MyListModel;

            switch (myselecteditem.id)
            {

                case 1:
                    await Navigation.PushAsync(new Crossfit());
                    break;
                case 2:
                    await Navigation.PushAsync(new Boks());
                    break;
                case 3:
                    await Navigation.PushAsync(new Zumba());
                    break;
                case 4:
                    await Navigation.PushAsync(new Spinning());
                    break;
                case 5:
                    await Navigation.PushAsync(new TotalBody());
                    break;


            }
          ((ListView)sender).SelectedItem = null;



        }
    }
}
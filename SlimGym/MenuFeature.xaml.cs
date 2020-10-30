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
    public partial class MenuFeature : MasterDetailPage
    {
		public List<MenuFeatureMasterMenuItem> menuList
		{
			get;
			set;
		}
		public MenuFeature()
        {
            InitializeComponent();
			//removed toolbar
			NavigationPage.SetHasNavigationBar(this, false);
			Detail = new NavigationPage(new Pocetna());

            
			menuList = new List<MenuFeatureMasterMenuItem>();
			// Adding menu items to menuList and you can define title ,page and icon  
			menuList.Add(new MenuFeatureMasterMenuItem()
			{
				Title = "Home",
                Icon = "/images/home.png",
				TargetType = typeof(Pocetna)
			});
			menuList.Add(new MenuFeatureMasterMenuItem()
			{
				Title = "Programs",
				Icon = "/images/programs.png",
				TargetType = typeof(Programs)
			});
			menuList.Add(new MenuFeatureMasterMenuItem()
			{
				Title = "Activity",
				Icon = "/images/activity.png",
				TargetType = typeof(Placanje)
			});
			menuList.Add(new MenuFeatureMasterMenuItem()
			{
				Title = "Schedule",
				Icon = "/images/calendar.png",
				TargetType = typeof(SchedulePage)
			});
			menuList.Add(new MenuFeatureMasterMenuItem()
			{
				Title = "Logout",
				Icon = "/images/logout.png",
				TargetType = typeof(MainPage)
			});
			// Setting our list to be ItemSource for ListView in MainPage.xaml  
			navigationDrawerList.ItemsSource = menuList;
			// Initial navigation, this can be used for our home page  
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Pocetna)));
			

		}
		private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			//add try-catch
			var item = (MenuFeatureMasterMenuItem)e.SelectedItem;
			Type page = item.TargetType;
			Detail = new NavigationPage((Page)Activator.CreateInstance(page));
			IsPresented = false;
		}
        void OnImageTapped(object sender, System.EventArgs e)
        {
			//add try-catch
			Detail = new NavigationPage(new Profile());
            IsPresented = false;

        }


    }
}
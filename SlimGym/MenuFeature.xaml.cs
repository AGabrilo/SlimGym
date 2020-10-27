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

            IsPresented = false;

			//menuList = new List<MenuFeatureMasterMenuItem>();
			//// Adding menu items to menuList and you can define title ,page and icon  
			//menuList.Add(new MenuFeatureMasterMenuItem()
			//{
			//	Title = "Pocetna",
			//	Icon = "pocetna.png",
			//	TargetType = typeof(Page1)
			//});
			
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Pocetna());
			IsPresented = false;

		}

		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Programs());
			IsPresented = false;
		}

		void Handle_Clicked3(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Placanje());
			IsPresented = false;
		}

		void Handle_Clicked4(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new SchedulePage());
			IsPresented = false;
		}
		void Handle_Clicked5(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new AboutUs());
			IsPresented = false;
		}
	}
}
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class DashboardWithImagesPage : ContentPage
	{
		public DashboardWithImagesPage ()
		{
			InitializeComponent();

			BindingContext = new DashboardViewModel();
		}

		public async void NavigateToGrialSettingsPage(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new GrialDemoSettings());
		}
	}
}

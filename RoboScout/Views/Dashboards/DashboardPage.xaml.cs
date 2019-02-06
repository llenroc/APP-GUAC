using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class DashboardPage : ContentPage
	{
		public DashboardPage()
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
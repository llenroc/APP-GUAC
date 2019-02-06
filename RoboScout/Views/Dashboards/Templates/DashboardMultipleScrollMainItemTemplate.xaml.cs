using System;
using System.Collections.Generic;
using Xamarin.Forms;
using RoboScout.Resx;

namespace RoboScout
{
	public partial class DashboardMultipleScrollMainItemTemplate : ContentView
	{
		public DashboardMultipleScrollMainItemTemplate()
		{
			InitializeComponent();
		}

		public async void OnMovieTapped(object sender, EventArgs args)
		{
			await Application.Current.MainPage.DisplayAlert(
				AppResources.AlertTitleMovieTapped, 
				AppResources.AlertMessageMovieShouldPlayMovieNow, 
				AppResources.StringOK	
			);
		}
	}
}


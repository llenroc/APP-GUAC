using System;
using System.Collections.Generic;
using System.Globalization;
using UXDivers.Artina.Shared;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class SimpleSignUpPage : ContentPage
	{
		public SimpleSignUpPage()
		{
			InitializeComponent();

			NavigationPage.SetHasNavigationBar (this, false);
		}

		async void OnCloseButtonClicked (object sender, EventArgs args)
		{
			await Navigation.PopModalAsync ();
		}
	}
}


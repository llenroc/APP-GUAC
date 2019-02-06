using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoboScout
{
	public partial class CustomNavBarPage : ContentPage
	{
		public CustomNavBarPage ()
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}


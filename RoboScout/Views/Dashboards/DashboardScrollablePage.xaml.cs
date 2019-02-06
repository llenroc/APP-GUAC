using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class DashboardScrollablePage : ContentPage
	{
		public DashboardScrollablePage()
		{
			InitializeComponent();

			BindingContext = new DashboardScrollableViewModel();
		}
	}

}

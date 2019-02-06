using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class NotificationsPage : ContentPage
	{
		public NotificationsPage()
		{
			InitializeComponent();

			BindingContext = new NotificationsViewModel();
		}
	}
}


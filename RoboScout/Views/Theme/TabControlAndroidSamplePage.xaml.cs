using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoboScout
{
	public partial class TabControlAndroidSamplePage : ContentPage
	{
		public TabControlAndroidSamplePage()
		{
			InitializeComponent();

			BindingContext = new
			{
				Social = new SocialViewModel(),
				Chat = new ChatViewModel(useRecent: true)
			};
		}
	}
}

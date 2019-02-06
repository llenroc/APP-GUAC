using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoboScout
{
	public partial class TabControlBottomPlacementSamplePage : ContentPage
	{
		public TabControlBottomPlacementSamplePage()
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

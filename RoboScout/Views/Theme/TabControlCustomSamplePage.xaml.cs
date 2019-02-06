using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoboScout
{
	public partial class TabControlCustomSamplePage : ContentPage
	{
		public TabControlCustomSamplePage()
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

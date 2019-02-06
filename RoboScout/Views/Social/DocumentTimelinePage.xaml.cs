using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoboScout
{
	public partial class DocumentTimelinePage : ContentPage
	{
		public DocumentTimelinePage()
		{
			InitializeComponent ();
			BindingContext = new DocumentTimelineViewModel();
		}
	}
}


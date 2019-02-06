using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class ChatMessagesListPage : ContentPage
	{
		public ChatMessagesListPage ()
		{
			InitializeComponent ();

			BindingContext = new ChatViewModel(useRecent: false);
		}
	}
}


using System;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class MessagesListPage : ContentPage
	{
		public MessagesListPage()
		{
			InitializeComponent();

			BindingContext = new MessagesViewModel();
		}

		public async void OnMore (object sender, EventArgs e) 
		{
			var mi = ((MenuItem)sender);
			await DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
		}

		public async void OnDelete (object sender, EventArgs e) 
		{
			var mi = ((MenuItem)sender);
			await DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
		}

		public async void OnItemTapped (object sender, EventArgs e) 
		{
			var selectedItem = ((ListView)sender).SelectedItem;
			var userName = ((Message)selectedItem).From.Name;

			await DisplayAlert("Message Tapped", "You tapped on " + userName + "'s message.", "OK");
		}

		public void OnRefreshing (object sender, EventArgs e) 
		{
			var listView = (sender as ListView);
			listView.EndRefresh();
		}
	}
}


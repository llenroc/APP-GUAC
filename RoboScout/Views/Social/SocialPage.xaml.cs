using System;

using Xamarin.Forms;

namespace RoboScout
{
	public partial class SocialPage : ContentPage
	{
		private TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();

		public SocialPage()
		{
			InitializeComponent();

			BindingContext = new SocialViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			tapGestureRecognizer.Tapped += OnProfileHeaderStackTapped;
			avatar.GestureRecognizers.Add(tapGestureRecognizer);
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();

			tapGestureRecognizer.Tapped -= OnProfileHeaderStackTapped;
			avatar.GestureRecognizers.Remove(tapGestureRecognizer);
		}

		private async void OnProfileHeaderStackTapped(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ProfilePage());
		}
	}
}
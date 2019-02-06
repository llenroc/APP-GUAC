using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class RootPage : MasterDetailPage
	{
		private bool _showWelcome;

		public RootPage() 
			: this(false)
		{
		}

		public RootPage (bool sayWelcome)
		{
			InitializeComponent ();

			_showWelcome = sayWelcome;

			// Empty pages are initially set to get optimal launch experience
			Master = new ContentPage { Title = "Grial" };
			Detail = NavigationPageHelper.Create(new ContentPage());
		}

		public async void OnSettingsTapped(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SettingsPage());
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();

			SampleCoordinator.SampleSelected += SampleCoordinator_SampleSelected;

			if (_showWelcome) 
			{
				_showWelcome = false;

				await Navigation.PushModalAsync (NavigationPageHelper.Create(new WelcomePage()));

				await Task.Delay (500)
					.ContinueWith(t => NavigationService.BeginInvokeOnMainThreadAsync(InitializeMasterDetail));
			}
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();

			SampleCoordinator.SampleSelected -= SampleCoordinator_SampleSelected;
		}

		private void InitializeMasterDetail()
		{
			Master = new MainMenuPage (new NavigationService(Navigation, LaunchSampleInDetail));
			Detail = NavigationPageHelper.Create(new DashboardPage());
		}

		private void LaunchSampleInDetail(Page page, bool animated)
		{
			Detail = NavigationPageHelper.Create(page);
			IsPresented = false;
		}

		private void SampleCoordinator_SampleSelected(object sender, SampleEventArgs e)
		{
			if (e.Sample.PageType == typeof(RootPage))
			{
				IsPresented = true;
			}
		}
	}
}
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class SamplesListFromCategoryPage : ContentPage
	{
		private bool _processingSelection;

		public SamplesListFromCategoryPage(int categoryId)
		{
			InitializeComponent();

			BindingContext = new SampleCategoryViewModel(categoryId);
		}

		private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
		{
			if (_processingSelection) 
			{
				return;
			}

			_processingSelection = true;

			try
			{
				var listView = (ListView)sender;
				var selectedItem = listView.SelectedItem;
				var sample = (Sample) selectedItem;

				if (selectedItem != null) 
				{
					SampleCoordinator.SelectedSample = sample;

					await sample.NavigateToSample (Navigation);
					listView.SelectedItem = null;
				}
			}
			finally
			{
				_processingSelection = false;
			}
		}

		public static async Task NavigateToCategory(SampleCategory sampleCategory, INavigation navigation)
		{
			await navigation.PushAsync(new SamplesListFromCategoryPage(sampleCategory.Id));
		}

		public async void NavigateToGrialSettingsPage(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new GrialDemoSettings());
		}
	}
}
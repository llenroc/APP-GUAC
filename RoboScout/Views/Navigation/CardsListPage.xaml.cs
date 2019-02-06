using System;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class CardsListPage : ContentPage
	{
		public CardsListPage()
		{
			InitializeComponent();

			BindingContext = new SamplesViewModel();
		}

		private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
		{
			var selectedItem = ((ListView)sender).SelectedItem;
			var sampleCategory = (SampleCategory) selectedItem;

			await Navigation.PushAsync(new SamplesListFromCategoryPage(sampleCategory.Id));
		}
	}
}


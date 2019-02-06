using System;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class CategoriesListWithIconsPage : ContentPage
	{
		public CategoriesListWithIconsPage()
		{
			InitializeComponent();

			BindingContext = new SamplesViewModel();
		}

		private async void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			var selectedItem = ((ListView) sender).SelectedItem;
			var sampleCategory = (SampleCategory) selectedItem;

			await SamplesListFromCategoryPage.NavigateToCategory(sampleCategory, Navigation);
		}
	}
}


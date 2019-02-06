using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class ProductsCatalogPage : ContentPage
	{
		public ProductsCatalogPage()
		{
			InitializeComponent();

			BindingContext = new ProductListViewModel();
		}
		
		public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e) 
		{
			var selectedItem = ((ListView)sender).SelectedItem;

			var page = new ProductItemViewPage(((Product)selectedItem).Id);

			await Navigation.PushAsync(page);
		}
	}
}


using System;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class ProductItemViewPage : ContentPage
	{
		public ProductItemViewPage()
			: this(SampleData.Products[0].Id)
		{
		}

		public ProductItemViewPage(int productId)
		{
			InitializeComponent();

			BindingContext = new ProductViewModel(productId);
		}
			
		private async void OnImageTapped(Object sender, EventArgs e)
		{
			var imagePreview =  new ProductImageFullScreenPage((sender as FFImageLoading.Forms.CachedImage).Source);

			await Navigation.PushModalAsync(NavigationPageHelper.Create(imagePreview));
		}
	}
}


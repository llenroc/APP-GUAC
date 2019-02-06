using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class ProductsCarouselPage : CarouselPage
	{
		public ProductsCarouselPage()
		{
			InitializeComponent ();
			        
			var productsList = SampleData.Products;

			for (var i = 0; i < productsList.Count; i++) 
			{
				var item = new ProductItemViewPage();
				item.BindingContext = new ProductViewModel(productsList[i].Id);

				Children.Add(item);
			}
		}
	}
}
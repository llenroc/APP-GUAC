using System;
using System.Collections.Generic;
using System.Globalization;

namespace RoboScout
{
	public class ProductListViewModel : ObservableObject
	{
		private List<Product> _products;

		public ProductListViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public List<Product> Products
		{
			get { return _products; }
			set { SetProperty(ref _products, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			Products = SampleData.Products;
		}
	}
}

using System;
using System.Globalization;
using System.Linq;

namespace RoboScout
{
	public class ProductViewModel : ObservableObject
	{
		private int _productId;
		private Product _product;
		private double _thumbnailHeight;

		public ProductViewModel(int productId)
			: base(listenCultureChanges: true)
		{
			_productId = productId;
			ThumbnailHeight = 100;

			LoadData();
		}

		public string Name => _product?.Name;

		public string Description => _product?.Description;

		public string Price => _product?.Price;

		public string Image => _product?.Image;

		public double ThumbnailHeight
		{
			get { return _thumbnailHeight; }
			set { SetProperty(ref _thumbnailHeight, value); }
		}

		public double RatingValue => _product != null ? _product.RatingValue : 0;

		public double RatingMax => _product != null ? _product.RatingMax : 0;

		public string Manufacturer => _product?.Manufacturer;

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			_product = SampleData.Products.FirstOrDefault(p => p.Id == _productId);
			NotifyAllPropertiesChanged();
		}
	}
}

using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace RoboScout
{
	public class DashboardScrollableViewModel : ObservableObject
	{
		private List<SampleCategory> _itemsReverse;
		private List<SampleCategory> _items;

		public DashboardScrollableViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public List<SampleCategory> ItemsReverse 
		{
			get { return _itemsReverse; }
			set { SetProperty(ref _itemsReverse, value); }
		}

		public List<SampleCategory> Items
		{
			get { return _items; }
			set { SetProperty(ref _items, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			Items = SamplesDefinition.SamplesCategoryList;

			var reverse = SamplesDefinition.CreateSamples();
			reverse.Reverse();

			foreach (var item in reverse)
			{
				item.BackgroundColor = Color.FromHex("#525ABB");
				item.Badge = 0;
			}

			ItemsReverse = reverse;
		}
	}
}
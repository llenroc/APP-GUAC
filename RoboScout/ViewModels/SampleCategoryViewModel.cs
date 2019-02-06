using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace RoboScout
{
	public class SampleCategoryViewModel : ObservableObject
	{
		private int _categoryId;
		private SampleCategory _category;

		public SampleCategoryViewModel(int categoryId)
			: base(listenCultureChanges: true)
		{
			_categoryId = categoryId;
			LoadData();
		}

		public string Name => _category?.Name;

		public Color BackgroundColor => _category != null ? _category.BackgroundColor : Color.Default;

		public string BackgroundImage => _category?.BackgroundImage;

		public List<Sample> SamplesList => _category?.SamplesList;

		public string Icon => _category?.Icon;

		public int Badge => _category != null ? _category.Badge : 0;

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			_category = SamplesDefinition.SamplesCategoryList.FirstOrDefault(c => c.Id == _categoryId);
			NotifyAllPropertiesChanged();
		}
	}
}

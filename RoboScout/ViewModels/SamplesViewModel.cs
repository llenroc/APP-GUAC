using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace RoboScout
{
	public class SamplesViewModel : ObservableObject
	{
		private List<SampleCategory> _samplesCategories;
		private List<SampleGroup> _samplesGroupedByCategory;
		private List<Sample> _allSamples;

		public SamplesViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public List<SampleCategory> SamplesCategories
		{ 
			get { return _samplesCategories; }
			set { SetProperty(ref _samplesCategories, value); }
		}

		public List<Sample> AllSamples
		{
			get { return _allSamples; }
			set { SetProperty(ref _allSamples, value); }
		}

		public List<SampleGroup> SamplesGroupedByCategory
		{
			get { return _samplesGroupedByCategory; }
			set { SetProperty(ref _samplesGroupedByCategory, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			SamplesCategories = SamplesDefinition.SamplesCategoryList;
			AllSamples = SamplesDefinition.AllSamples;
			SamplesGroupedByCategory = SamplesDefinition.SamplesGroupedByCategory;
		}
	}
}
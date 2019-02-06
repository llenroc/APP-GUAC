using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RoboScout
{
	public class SocialViewModel : ObservableObject
	{
		private IEnumerable<ImageViewModel> _images;

		public SocialViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public IEnumerable<ImageViewModel> Images
		{
			get { return _images; }
			set { SetProperty(ref _images, value); }
		}

		public IEnumerable<User> Friends
		{
			get { return SampleData.Friends; }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			Images = SampleData.SocialImageGalleryItems.Select(i => new ImageViewModel(i));
			NotifyPropertyChanged(nameof(Friends));
		}
	}

    public class ImageViewModel
    {
        public ImageViewModel(string image)
        {
            ImageName = image;
        }

        public string ImageName { get; }
    }
}
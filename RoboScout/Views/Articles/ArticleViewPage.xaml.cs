using System;
using RoboScout.Resx;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class ArticleViewPage : ContentPage
	{
		public ArticleViewPage() 
			: this(new ArticleViewModel())
		{
		}

		public ArticleViewPage(ArticleViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = viewModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			outerScrollView.Scrolled += OnScroll;
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			outerScrollView.Scrolled -= OnScroll;
		}

		public void OnScroll(object sender, ScrolledEventArgs e)
		{
			var imageHeight = img.Height * 2;
			var scrollRegion = layeringGrid.Height - outerScrollView.Height;
			var parallexRegion = imageHeight - outerScrollView.Height;
			var factor = outerScrollView.ScrollY - parallexRegion * (outerScrollView.ScrollY / scrollRegion);
			if (factor < 0)
			{
				factor = 0;
			}
			else if (img.TranslationY > img.Height)
			{
				factor = img.Height;
			}

			img.TranslationY = factor / 2;
			img.Opacity = Math.Max(0, 1 - (outerScrollView.ScrollY / img.Height));
			headers.Scale = 1 - (factor / (imageHeight * 2));
		}

		public void OnMore(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);
			DisplayAlert(string.Format(AppResources.StringContextActionTapped, mi.Text), string.Format(AppResources.StringTappedOnContextAction, mi.Text), AppResources.StringOK);
		}

		public void OnDelete(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);
			DisplayAlert(string.Format(AppResources.StringContextActionTapped, mi.Text), string.Format(AppResources.StringTappedOnContextAction, mi.Text), AppResources.StringOK);
		}

		public void OnItemTapped(object sender, EventArgs e)
		{
			var message = (Message)((ListView)sender).SelectedItem;
			DisplayAlert(AppResources.StringMessageTapped, string.Format(AppResources.StringTappedOnAuthorMessage, message.From.Name), AppResources.StringOK);
		}

		public void OnPrimaryActionButtonClicked(object sender, EventArgs e)
		{
		}
	}
}
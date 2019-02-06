using System;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class ArticlesListPage : ContentPage
	{
		public ArticlesListPage ()
		{
			InitializeComponent ();

			BindingContext = new PostsViewModel ();
		}

		private async void OnItemTapped(object sender, EventArgs e)
		{
			var selectedItem = ((ListView)sender).SelectedItem;
			var post = (Post)selectedItem;
			var articleView = new ArticleViewPage(new ArticleViewModel(post.Id));

			await Navigation.PushAsync(articleView);
		}
	}
}


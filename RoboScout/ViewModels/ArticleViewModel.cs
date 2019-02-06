using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RoboScout
{
	public class ArticleViewModel : ObservableObject
	{
		private readonly int _postId;
		private Post _post;

		public ArticleViewModel()
			: this(SampleData.Posts[0].Id)
		{
		}

		public ArticleViewModel(int postId)
			: base(listenCultureChanges: true)
		{
			_postId = postId;

			LoadData();
		}

		public Post Post
		{
			get { return _post; }
			set { SetProperty(ref _post, value); }
		}

		public List<Message> Comments 
		{
			get { return SampleData.Comments; }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			Post = SampleData.Posts.FirstOrDefault(post => post.Id == _postId);
			NotifyPropertyChanged(nameof(Comments));
		}
	}
}
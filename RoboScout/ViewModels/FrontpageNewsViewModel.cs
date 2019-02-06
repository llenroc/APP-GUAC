using System;
using System.Collections.Generic;
using System.Globalization;
using RoboScout.Resx;

namespace RoboScout
{
	public class FrontPageNewsViewModel : ObservableObject
	{
		private List<News> _newsList;
		private MainNews _mainNews;

		public FrontPageNewsViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public List<News> NewsList
		{
			get { return _newsList; }
			set { SetProperty(ref _newsList, value); }
		}

		public MainNews MainNews
		{
			get { return _mainNews; }
			set { SetProperty(ref _mainNews, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			NewsList = new List<News>
			{
				new News 
				{
					Title           = DataResources.Post1Title,
					Subtitle        = DataResources.Post1SubTitle,
					Body            = DataResources.DasboardCard4Body,
					Section         = DataResources.DasboardCard4Section,
					Author          = DataResources.DasboardCard4Author,
					Avatar          = SampleData.Friends[3].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[0],
					Quote           = DataResources.PostQuote,
					QuoteAuthor     = SampleData.Friends[3].Name,
					When            = DataResources.Post1When,
					Likes           = "102",
					Followers       = "2.1K"
				},
				new News 
				{
					Title           = DataResources.Post2Title,
					Subtitle        = DataResources.Post2SubTitle,
					Body            = DataResources.DasboardCard1Body,
					Section         = DataResources.DasboardCard2Section,
					Author          = SampleData.Friends[0].Name,
					Avatar          = SampleData.Friends[0].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[1],
					Quote           = DataResources.PostQuote,
					QuoteAuthor     = SampleData.Friends[0].Name,
					When            = DataResources.Post2When,
					Likes           = "224",
					Followers       = "2.2K"
				},
				new News 
				{
					Title           = DataResources.Post3Title,
					Subtitle        = DataResources.Post3SubTitle,
					Body            = DataResources.DasboardCard1Body,
					Section         = DataResources.DasboardCard6Section,
					Author          = SampleData.Friends[2].Name,
					Avatar          = SampleData.Friends[2].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[2],
					Quote           = DataResources.PostQuote,
					QuoteAuthor     = SampleData.Friends[2].Name,
					When            = DataResources.Post3When,
					Likes           = "69",
					Followers       = "1.7K"
				},
				new News 
				{
					Title           = DataResources.Post4Title,
					Subtitle        = DataResources.Post4SubTitle,
					Body            = DataResources.DasboardCard1Body,
					Section         = DataResources.PostSectionScience,
					Author          = DataResources.DasboardCard4Author,
					Avatar          = SampleData.Friends[1].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[3],
					Quote           = DataResources.PostQuote,
					QuoteAuthor     = SampleData.Friends[1].Name,
					When            = DataResources.Post4When,
					Likes           = "91",
					Followers       = "2K"
				},
				new News 
				{
					Title           = DataResources.Post5Title,
					Subtitle        = DataResources.Post5SubTitle,
					Body            = DataResources.DasboardCard1Body,
					Section         = DataResources.PostSectionNature,
					Author          = SampleData.Friends[4].Name,
					Avatar          = SampleData.Friends[4].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[4],
					Quote           = DataResources.PostQuote,
					QuoteAuthor     = SampleData.Friends[0].Name,
					When            = DataResources.Post5When,
					Likes           = "42",
					Followers       = "1K"
				},
				new News 
				{
					Title           = DataResources.Post6Title,
					Subtitle        = DataResources.Post6SubTitle,
					Body            = DataResources.DasboardCard1Body,
					Section         = DataResources.PostSectionHealth,
					Author          = SampleData.Friends[5].Name,
					Avatar          = SampleData.Friends[5].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[5],
					Quote           = DataResources.PostQuote,
					QuoteAuthor     = SampleData.Friends[5].Name,
					When            = DataResources.Post6When,
					Likes           = "92",
					Followers       = "2K"
				}
			};

			MainNews = new MainNews
			{
				Title           = DataResources.Post5Title,
				Subtitle        = DataResources.Post5SubTitle,
				Body            = DataResources.MainNewsBody,
				When            = DataResources.Post5When,
				BackgroundImage = SampleData.ArticlesImagesList[4]
			};
		}
	}

	public class News
	{
		public string Title { get; set; }

		public string Subtitle { get; set; }

		public string Body { get; set; }

		public string Section { get; set; }

		public string Author { get; set; }

		public string Avatar { get; set; }

		public string BackgroundImage { get; set; }

		public string Quote { get; set; }

		public string QuoteAuthor { get; set; }

		public string When { get; set; }

		public string Followers { get; set; }

		public string Likes { get; set; }
	}
	
	public class MainNews
	{
		public string Title { get; set; }

		public string Subtitle { get; set; }

		public string Body { get; set; }

		public string When { get; set; }

		public string BackgroundImage { get; set; }
	}
}

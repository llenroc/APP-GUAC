using System;
using System.Collections.Generic;
using System.Linq;
using RoboScout.Resx;
using UXDivers.Artina.Shared;
using Xamarin.Forms;

namespace RoboScout
{
	public static class SampleData
	{
		private static CultureChangeNotifier _notifier;

		private static string[] _names;
		private static List<string> _socialImageGalleryItems;
		private static List<string> _articlesImagesList;
		private static List<string> _usersImagesList;
		private static List<string> _dashboardImagesList;
		private static List<string> _productsImagesList;
		private static List<User> _users;
		private static List<Post> _posts;
		private static List<Message> _comments;
		private static List<User> _smallUserList;
		private static List<Post> _smallPostList;
		private static List<Message> _messages;
		private static List<ChatMessage> _chatMessagesList;
		private static List<ChatMessage> _recentChatMessagesList;
		private static List<Product> _products;
		private static List<MovieSection> _movies;
		private static List<Notification> _notifications;

		public static void Initialize()
		{
			_notifier = new CultureChangeNotifier();
			_notifier.CultureChanged += (sender, args) => Reset();
		}

		public static List<Notification> Notifications
		{
			get
			{
				if (_notifications == null)
				{
					_notifications = InitNotifications();
				}

				return _notifications;
			}
		}

		public static void Reset()
		{
			_articlesImagesList = null;
			_chatMessagesList = null;
			_comments = null;
			_messages = null;
			_movies = null;
			_names = null;
			_notifications = null;
			_posts = null;
			_products = null;
			_productsImagesList = null;
			_recentChatMessagesList = null;
			_users = null;
		}

		public static string[] Names 
		{
			get
			{
				if (_names == null)
				{
					_names = InitNames();
				}

				return _names;
			}
		}

		public static List<string> SocialImageGalleryItems 
		{
			get
			{
				if (_socialImageGalleryItems == null)
				{
					_socialImageGalleryItems = InitSocialImageGalleryItems();
				}

				return _socialImageGalleryItems;
			}
		}

		public static List<string> ArticlesImagesList 
		{
			get
			{
				if (_articlesImagesList == null)
				{
					_articlesImagesList = InitArticlesImagesList();
				}

				return _articlesImagesList;
			}
		}

		public static List<string> UsersImagesList{
			get
			{
				if (_usersImagesList == null)
				{
					_usersImagesList = InitUsersImagesList();
				}

				return _usersImagesList;
			}
		}

		public static List<string> DashboardImagesList
		{
			get
			{
				if (_dashboardImagesList == null)
				{
					_dashboardImagesList = InitDashboardImagesList();
				}

				return _dashboardImagesList;
			}
		}

		public static List<string> ProductsImagesList 
		{
			get
			{
				if (_productsImagesList == null)
				{
					_productsImagesList = InitProductsImagesList();
				}

				return _productsImagesList;
			}
		} 

		public static List<User> Users 
		{
			get
			{
				if (_users == null)
				{
					_users = InitUsers();
				}

				return _users;
			}
		}

		public static List<User> Friends
		{
			get
			{
				return Users;
			}
		}

		public static List<Post> Posts
		{
			get
			{
				if (_posts == null)
				{
					_posts = InitPosts();
				}

				return _posts;
			}
		}

		public static List<Message> Messages
		{
			get
			{
				if (_messages == null)
				{
					_messages = InitMessages();
				}

				return _messages;
			}
		}

		public static List<Message> Comments
		{
			get
			{
				if (_comments == null)
				{
					_comments = Messages.GetRange((Messages.Count() / 2), (Messages.Count() / 2));
				}

				return _comments;
			}
		}	

		public static List<User> SmallUserList
		{
			get
			{
				if (_smallUserList == null)
				{
					_smallUserList = Users.GetRange(0, 2);
				}

				return _smallUserList;
			}
		}	

		public static List<Post> SmallPostList
		{
			get
			{
				if (_smallPostList == null)
				{
					_smallPostList = Posts.GetRange(0, 1);
				}

				return _smallPostList;
			}
		}	

		public static List<ChatMessage> ChatMessagesList
		{
			get
			{
				if (_chatMessagesList == null)
				{
					_chatMessagesList = InitChatMessagesList();
				}

				return _chatMessagesList;
			}
		}

		public static List<ChatMessage> RecentChatMessagesList
		{
			get
			{
				if (_recentChatMessagesList == null)
				{
					_recentChatMessagesList = InitRecentChatMessagesList();
				}

				return _recentChatMessagesList;
			}
		}

		public static List<Product> Products
		{
			get
			{
				if (_products == null)
				{
					_products = InitProducts();
				}

				return _products;
			}
		}

		public static List<MovieSection> Movies 
		{
			get
			{
				if (_movies == null)
				{
					_movies = InitMoviesSections();
				}

				return _movies;
			}
		}

		private static List<Notification> InitNotifications()
		{
			return new List<Notification> 
			{
				new Notification
				{
					Title = AppResources.StringConfirmation,				// "Confirmation",
					Type = NotificationType.Confirmation,
					Description = AppResources.StringPleaseConfirmAddress	// "Please confirm your email address"
				},

				new Notification
				{
					Title = AppResources.StringError,						// "Error",
					Type = NotificationType.Error,
					Description = AppResources.StringPleaseConfirmAddress	// "Please confirm your email address"
				},

				new Notification
				{
					Title = AppResources.StringWarning,						// "Warning",
					Type = NotificationType.Warning,
					Description = AppResources.StringCantReachLocation		// "Can't reach your current location"
				},

				new Notification
				{
					Title = AppResources.StringWarning,						// "Warning",
					Type = NotificationType.Warning,
					Description = AppResources.StringPleaseContactSupport	// "Please contact support center"
				},

				new Notification
				{
					Title = AppResources.StringNotification,				// "Notification",
					Type = NotificationType.Notification,
					Description = AppResources.StringYouHaveANewMessage		// "You have new message"
				},

				new Notification
				{
					Title = AppResources.StringSuccess,						// "Success",
					Type = NotificationType.Success,
					Description = AppResources.StringYouHaveANewFollower	// "You have a new follower"
				},
			};
		}

		private static string[] InitNames()
		{
			return new[] 
			{
				DataResources.User1Name,			// "Pat Davies",
				DataResources.User2Name,			// "Janis Spector",
				DataResources.User3Name,			// "Regina Joplin",
				DataResources.User4Name,			// "Jaco Morrison",
				DataResources.User5Name,			// "Margaret Whites",
				DataResources.User6Name,			// "Skyler Harrisson",
				DataResources.User7Name,			// "Al Pastorius",
			};
		}

		private static List<string> InitSocialImageGalleryItems()
		{
			return new List<string>
			{				
				"social_album_1.jpg",
				"social_album_2.jpg",
				"social_album_3.jpg",
				"social_album_4.jpg",
				"social_album_5.jpg",
				"social_album_6.jpg",
				"social_album_7.jpg",
				"social_album_8.jpg",
				"social_album_9.jpg",
			};
		}

		private static List<string> InitArticlesImagesList()
		{
			return new List<string> 
			{
				"article_image_0.jpg",
				"article_image_1.jpg",
				"article_image_2.jpg",
				"article_image_3.jpg",
				"article_image_4.jpg",
				"article_image_5.jpg"
			};
		}
		private static List<string> InitUsersImagesList()
		{
			return new List<string> 
			{
				"friend_thumbnail_27.jpg",
				"friend_thumbnail_31.jpg",
				"friend_thumbnail_34.jpg",
				"friend_thumbnail_55.jpg",
				"friend_thumbnail_71.jpg",
				"friend_thumbnail_75.jpg",
				"friend_thumbnail_93.jpg",
			};
		}

		private static List<string> InitDashboardImagesList()
		{
			return new List<string> 
			{
				"dashboard_thumbnail_0.jpg",
				"dashboard_thumbnail_1.jpg",
				"dashboard_thumbnail_2.jpg",
				"dashboard_thumbnail_3.jpg",
				"dashboard_thumbnail_4.jpg",
				"dashboard_thumbnail_5.jpg",
				"dashboard_thumbnail_6.jpg",
				"dashboard_thumbnail_7.jpg",
				"dashboard_thumbnail_8.jpg",
			};
		}
		private static List<string> InitProductsImagesList()
		{
			return new List<string>
			{
				"product_item_0.jpg",
				"product_item_1.jpg",
				"product_item_2.jpg",
				"product_item_3.jpg",
				"product_item_4.jpg",
				"product_item_5.jpg",
				"product_item_6.jpg",
				"product_item_7.jpg",
			};
		}

		private static List<User> InitUsers()
		{
			return new List<User>
			{
				new User( Names[0], UsersImagesList[0] ),
				new User( Names[1], UsersImagesList[1] ),
				new User( Names[2], UsersImagesList[2] ),
				new User( Names[3], UsersImagesList[3] ),
				new User( Names[4], UsersImagesList[4] ),
				new User( Names[5], UsersImagesList[5] ),
				new User( Names[6], UsersImagesList[6] ),
			};
		}

		private static List<Post> InitPosts()
		{
			return new List<Post>
			{
				new Post 
				{
					Id              = 0,
					Title           = DataResources.Post1Title,				// "United by faith",
					Subtitle        = DataResources.Post1SubTitle,			// "Friendship beyond everything",
					Body            = DataResources.Post1Body,				// "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent et aliquet nunc. \nSed ultricies sed augue sit amet maximus. In vel tellus sed ipsum volutpat venenatis et sit amet diam. Suspendisse feugiat mollis nibh, in facilisis diam convallis sit amet. \n\nMaecenas lectus turpis, rhoncus et est at, lacinia placerat urna. Praesent malesuada consectetur justo, scelerisque fermentum enim lobortis ullamcorper. Duis commodo sit amet ligula vitae luctus. Nulla commodo ipsum a lorem efficitur luctus.",
					Section         = DataResources.PostSectionActuality,	// "ACTUALITY",
					Author          = AppResources.UXDIVERS,				// "UXDIVERS",
					Avatar          = SampleData.Friends[3].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[0],
					Quote           = DataResources.PostQuote,				// "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
					QuoteAuthor     = SampleData.Friends[3].Name,
					When            = DataResources.Post1When,				// "JAN 6, 2017",
					Likes           = "2.1k",
					Followers       = "112",
				},
				new Post 
				{
					Id              = 1,
					Title           = DataResources.Post2Title,				// "Olympic dream",
					Subtitle        = DataResources.Post2SubTitle,			// "The way to the podium",
					Body            = DataResources.Post2Body,				// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
					Section         = DataResources.PostSectionSports,		// "SPORTS",
					Author          = SampleData.Friends[0].Name,
					Avatar          = SampleData.Friends[0].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[1],
					Quote           = DataResources.PostQuote,				// "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
					QuoteAuthor     = SampleData.Friends[0].Name,
					When            = DataResources.Post2When,				// "FEB 13, 2017",
					Likes           = "12K",
					Followers       = "340",

				},
				new Post
				{
					Id              = 2,
					Title           = DataResources.Post3Title,				// "Wheels of fortune",
					Subtitle        = DataResources.Post3SubTitle,			// "And the wind cries mary",
					Body            = DataResources.Post2Body,				// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
					Section         = DataResources.PostSectionFreeTime,	// "FREE TIME",
					Author          = SampleData.Friends[2].Name,
					Avatar          = SampleData.Friends[2].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[2],
					Quote           = DataResources.PostQuote,				// "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
					QuoteAuthor     = SampleData.Friends[2].Name,
					When            = DataResources.Post3When,				// "FEB 21, 2017",
					Likes           = "798",
					Followers       = "120",

				},
				new Post
				{
					Id              = 3,
					Title           = DataResources.Post4Title,				// "Last adventure",
					Subtitle        = DataResources.Post4SubTitle,			// "The conquest of space",
					Body            = DataResources.Post2Body,				// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
					Section         = DataResources.PostSectionScience,		// "SCIENCE",
					Author          = "UXDIVERS",
					Avatar          = SampleData.Friends[1].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[3],
					Quote           = DataResources.PostQuote,				// "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
					QuoteAuthor     = SampleData.Friends[1].Name,
					When            = DataResources.Post4When,				// "MAR 9, 2017",
					Likes           = "921",
					Followers       = "327",

				},
				new Post
				{
					Id              = 4,
					Title           = DataResources.Post5Title,				// "Sweet leaf",
					Subtitle        = DataResources.Post5SubTitle,			// "The rainforest newest hope",
					Body            = DataResources.Post2Body,				// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
					Section         = DataResources.PostSectionNature,		// "NATURE",
					Author          = SampleData.Friends[4].Name,
					Avatar          = SampleData.Friends[4].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[4],
					Quote           = DataResources.PostQuote,				// "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
					QuoteAuthor     = SampleData.Friends[0].Name,
					When            = DataResources.Post5When,				// "JUN 17, 2015",
					Likes           = "92",
					Followers       = "2K",

				},
				new Post
				{
					Id              = 5,
					Title           = DataResources.Post6Title,				// "Smoke kills",
					Subtitle        = DataResources.Post6SubTitle,			// "The war against tabacco",
					Body            = DataResources.Post2Body,				// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
					Section         = DataResources.PostSectionHealth,		// "HEALTH",
					Author          = SampleData.Friends[5].Name,
					Avatar          = SampleData.Friends[5].Avatar,
					BackgroundImage = SampleData.ArticlesImagesList[5],
					Quote           = DataResources.PostQuote,				// "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
					QuoteAuthor     = SampleData.Friends[5].Name,
					When            = DataResources.Post6When,				// "JUN 12, 2017",
					Likes           = "4.7K",
					Followers       = "235",
				},
			};
		}

		private static List<Message> InitMessages()
		{
			return new List<Message> 
			{
				new Message(
					Friends[5],
					7,
					true,
					DataResources.MessageDateMonthAndDay,
					DataResources.Message1Title,		// "Hey check this out!",
					DataResources.MessageBody,			// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
					true,
					true
				),
				new Message(
					Friends[1],
					3,
					false,
					DataResources.MessageDateYesterday,
					DataResources.Message2Title,		// "Artina is awesome...you'll love it",
					DataResources.MessageBody,			//"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
					false,
					true
				),
				new Message(
					Friends[2],
					1,
					true,
					DataResources.MessageDateMonthAndDay,
					DataResources.Message3Title,		// "Artina is awesome...you'll love it",
					DataResources.MessageBody,			// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
					false,
					false
				),
				new Message(
					Friends[3],
					2,
					true,
					DataResources.MessageDateMonthAndDay,
					DataResources.Message4Title,		// "Artina is awesome...you'll love it",
					DataResources.MessageBody,			// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
					false,
					false
				),
				new Message(
					Friends[4],
					10,
					false,
					DataResources.MessageDateMinutes,
					DataResources.Message5Title,		// "Artina is awesome...you'll love it",
					DataResources.MessageBody,			// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
					true,
					false
				),
				new Message(
					Friends[0],
					5,
					false,
					DataResources.MessageDateMonthAndDay,
					DataResources.Message6Title,		// "Artina is awesome...you'll love it",
					DataResources.MessageBody,			// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
					true,
					true
				),
				new Message(
					Friends[6],
					7,
					false,
					DataResources.MessageDateMonthAndDay,
					DataResources.Message7Title,		// "Artina is awesome...you'll love it",
					DataResources.MessageBody,			// "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
					true,
					false
				)
			};
		}

		private static List<ChatMessage> InitChatMessagesList()
		{
			return new List<ChatMessage> 
			{
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat1Body,		// "Hey buddy :), what's up? I'm currently working on this amazing stuff called Grial. Have you heard about it? You shoud give it a try....it really rocks!!!!!.",
					false,
					true
				),
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat2Body,		// "You should give it a try!",
					false,
					true
				),
				new ChatMessage(
					Friends [1],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat3Body			// "Wooow! Didn't know this exist!! Really cool stuff!"
				),
				new ChatMessage(
					Friends [1],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat4Body			// "I was wondering if something like this existed. This will save hundred of hours. I rather be skateboarding with my friends instead of compiling every little visual change." +
													// "Thanks for sharing!"
				),
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat5Body,		// "No problem! I hope you can find it useful. It really makes the difference to me.",
					false,
					true
				),
				new ChatMessage(
					Friends [1],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat6Body			// "Ok thanks and thanks again!! This is really awesome"
				),
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat7Body,		// "Indeed.",
					false,
					true
				),
				new ChatMessage(
					Friends [1],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat8Body			// "C u later tonight at Gillian Japi party, right?"
				),
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat9Body,			// "For sure! See you later :)"
					false,
					true
				),
			};
		}

		private static List<ChatMessage> InitRecentChatMessagesList()
		{
			return new List<ChatMessage> 
			{
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat1Body,		// "Hey buddy :), what's up? I'm currently working on this amazing stuff called Grial. Have you heard about it? You shoud give it a try....it really rocks!!!!!.",
					true
				),
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat2Body,		// "You should give it a try!",
					true
				),
				new ChatMessage(
					Friends [1],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat3Body			// "Wooow! Didn't know this exist!! Really cool stuff!"
				),
				new ChatMessage(
					Friends [1],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat4Body			// "I was wondering if something like this existed. This will save hundred of hours. I rather be skateboarding with my friends instead of compiling every little visual change." +
													// "Thanks for sharing!"
				),
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat5Body,		// "No problem! I hope you can find it useful. It really makes the difference to me.",
					true
				),
				new ChatMessage(
					Friends [1],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat6Body			// "Ok thanks and thanks again!! This is really awesome"
				),
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat7Body,		// "Indeed.",
					true
				),
				new ChatMessage(
					Friends [1],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat8Body			// "C u later tonight at Gillian Japi party, right?"
				),
				new ChatMessage(
					Friends [5],
					DataResources.MessageDateMonthAndDay,
					DataResources.Chat9Body,		// "For sure! See you later :)",
					true
				),
			};
		}

		private static List<Product> InitProducts()
		{
			return new List<Product> 
			{
				new Product 
				{
					Id              = 0,
					Name            = DataResources.Prod1Name,			// "Flannel Shirt",
					Description     = DataResources.Prod1Description,	// "Classic 90's Skateboarding style shirt. Feel like Pat Duffy or even flow like Edie from Pearl Jam. With that casual grunge style this is the shirt you need.",
					Image           = SampleData.ProductsImagesList[0],
					Price           = "$39.90",
					RatingMax       = 5,
					RatingValue     = 4.5,
				},
				new Product 
				{
					Id              = 1,
					Name            = DataResources.Prod2Name,			// "Bomber Jacket",
					Description     = DataResources.Prod2Description,	// "Top gun in every gentelman closet. This leather jacket will make you feel like Tom Cruise without that crazy look. Be a good boy make mom proud.",
					Image           = SampleData.ProductsImagesList[1],
					Price           = "$89.90",
					RatingMax       = 5,
					RatingValue     = 4.5,
				},
				new Product 
				{
					Id              = 2,
					Name            = DataResources.Prod3Name,			// "Classic Black",
					Description     = DataResources.Prod3Description,	// "Get that instant normal look that everybody wants. Blend with the humans, it will make you feel less strange. You know you are not normal",
					Image           = SampleData.ProductsImagesList[2],
					Price           = "$49.90",
					RatingMax       = 5,
					RatingValue     = 4.5,
				},
				new Product 
				{
					Id              = 3,
					Name            = DataResources.Prod4Name,			// "Flowers Shirt",
					Description     = DataResources.Prod4Description,	// "Our newest swim tees with a much looser fit than traditional rash guard for yet more comfort and versatility, is well known for great fit, function and colors.",
					Image           = SampleData.ProductsImagesList[3],
					Price           = "$29.90",
					RatingMax       = 5,
					RatingValue     = 4.5,
				},
				new Product 
				{
					Id              = 4,
					Name            = DataResources.Prod5Name,			// "Sccotish Shirt",
					Description     = DataResources.Prod5Description,	// "Not just another common shirt. Upgrade your sexappeal looking good. Rock and roll never gets old. Eric Burdon wears a shirt like this one when he wants to lood good. ",
					Image           = SampleData.ProductsImagesList[4],
					Price           = "$34.90",
					RatingMax       = 5,
					RatingValue     = 4.5,
				},
				new Product 
				{
					Id              = 5,
					Name            = DataResources.Prod6Name,			// "Silk Shirt",
					Description     = DataResources.Prod6Description,	// "Let's face it, this shirt does not look good on anybody. But how many times do you buy something that you don't need? Buy this one feel happy for a minute then dismiss it. ",
					Image           = SampleData.ProductsImagesList[5],
					Price           = "$39.90",
					RatingMax       = 5,
					RatingValue     = 4.5,
				},
				new Product 
				{
					Id              = 6,
					Name            = DataResources.Prod7Name,			// "Entrepreneur Shirt",
					Description     = DataResources.Prod7Description,	// "Do you have a meeting? Do you want to look good reliable and confident? This is the shirt that you need for those horrible meetings trying to find someone that lend you some money.",
					Image           = SampleData.ProductsImagesList[6],
					Price           = "$65.90",
					RatingMax       = 5,
					RatingValue     = 4.5,
				},
				new Product 
				{
					Id              = 7,
					Name            = DataResources.Prod8Name,			// "Soldier Shirt",
					Description     = DataResources.Prod8Description,	// "Now is your time. Wanna be the alpha male of your local bar? Common! Get this shirt now and feel like a sexy Rambo on your next date. Remember that girls loves peacefull soliders.",
					Image           = SampleData.ProductsImagesList[7],
					Price           = "$46.90",
					RatingMax       = 5,
					RatingValue     = 4.5,
				}
			};
		}

		private static List<MovieSection> InitMoviesSections() 
		{
			var actorOfTheMonth = new MovieSection();
			actorOfTheMonth.Id = 0;
			actorOfTheMonth.Title = DataResources.MovieSection1Title;
			actorOfTheMonth.Content = new List<Movie>
			{
				new Movie
				{
					Id = 1,
					Title = DataResources.MovieSection1Movie1Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection1Movie1Seasons,
					RatingValue = 4.4,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie1Director,
					Plot = DataResources.MovieSection1Movie1Plot,
					Cast = DataResources.MovieSection1Movie1Cast.Split(',')
				},
				new Movie
				{
					Id = 2,
					Title = DataResources.MovieSection1Movie2Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_UY190_CR0,0,128,190_AL_.jpg",
					Seasons = DataResources.MovieSection1Movie2Seasons,
					RatingValue = 4.25,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie2Director,
					Plot = DataResources.MovieSection1Movie2Plot,
					Cast = DataResources.MovieSection1Movie2Cast.Split(',')
				},
				new Movie
				{
					Id = 3,
					Title = DataResources.MovieSection1Movie3Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMjU4NDExNDM1NF5BMl5BanBnXkFtZTgwMDIyMTgxNzE@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection1Movie3Seasons,
					RatingValue = 4.05,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie3Director,
					Plot = DataResources.MovieSection1Movie3Plot,
					Cast = DataResources.MovieSection1Movie3Cast.Split(',')
				},
				new Movie
				{
					Id = 4,
					Title = DataResources.MovieSection1Movie4Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMTI1MTY2OTIxNV5BMl5BanBnXkFtZTYwNjQ4NjY3._V1_UX148_CR0,0,148,216_AL_.jpg",
					Seasons = DataResources.MovieSection1Movie4Seasons,
					RatingValue = 4.25,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie4Director,
					Plot = DataResources.MovieSection1Movie4Plot,
					Cast = DataResources.MovieSection1Movie4Cast.Split(',')
				},
				new Movie
				{
					Id = 5,
					Title = DataResources.MovieSection1Movie5Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMzg1MDA0MTU2Nl5BMl5BanBnXkFtZTcwMTMzMjkxNw@@._V1_UX148_CR0,0,148,216_AL_.jpg",
					Seasons = DataResources.MovieSection1Movie5Seasons,
					RatingValue = 3.85,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie5Director,
					Plot = DataResources.MovieSection1Movie5Plot,
					Cast = DataResources.MovieSection1Movie5Cast.Split(',')
				},
				new Movie
				{
					Id = 6,
					Title = DataResources.MovieSection1Movie6Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjZlOTAzNTYtMTA5YS00NjU0LThiZTEtYTBjYmZkMGE1NDRlXkEyXkFqcGdeQXVyNDkzNTM2ODg@._V1_SY1000_CR0,0,710,1000_AL_.jpg",
					Seasons = DataResources.MovieSection1Movie6Seasons,
					RatingValue = 3.7,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie6Director,
					Plot = DataResources.MovieSection1Movie6Plot,
					Cast = DataResources.MovieSection1Movie6Cast.Split(',')
				},
				new Movie
				{
					Id = 7,
					Title = DataResources.MovieSection1Movie7Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMTkxNTk1ODcxNl5BMl5BanBnXkFtZTcwMDI1OTMzOQ@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection1Movie7Seasons,
					RatingValue = 3.65,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie7Director,
					Plot = DataResources.MovieSection1Movie7Plot,
					Cast = DataResources.MovieSection1Movie7Cast.Split(',')
				},
				new Movie
				{
					Id = 8,
					Title = DataResources.MovieSection1Movie8Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMTMxMTIyNzMxMV5BMl5BanBnXkFtZTcwOTc4OTI3Mg@@._V1_UX128_CR0,0,128,190_AL_.jpg",
					Seasons = DataResources.MovieSection1Movie8Seasons,
					RatingValue = 4.05,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie8Director,
					Plot = DataResources.MovieSection1Movie8Plot,
					Cast = DataResources.MovieSection1Movie8Cast.Split(',')
				},
				new Movie
				{
					Id = 9,
					Title = DataResources.MovieSection1Movie9Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMTY5MTYyNjkwNV5BMl5BanBnXkFtZTcwODE3MTI0MQ@@._V1_UY190_CR0,0,128,190_AL_.jpg",
					Seasons = DataResources.MovieSection1Movie9Seasons,
					RatingValue = 4,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie9Director,
					Plot = DataResources.MovieSection1Movie9Plot,
					Cast = DataResources.MovieSection1Movie9Cast.Split(',')
				},
				new Movie
				{
					Id = 10,
					Title = DataResources.MovieSection1Movie10Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMTY5MzYzNjc5NV5BMl5BanBnXkFtZTYwNTUyNTc2._V1_UY190_CR0,0,128,190_AL_.jpg",	
					Seasons = DataResources.MovieSection1Movie10Seasons,
					RatingValue = 4,
					RatingMax = 5,
					Director = DataResources.MovieSection1Movie10Director,
					Plot = DataResources.MovieSection1Movie10Plot,
					Cast = DataResources.MovieSection1Movie10Cast.Split(',')
				}
			};

			var lastBestPicture = new MovieSection();
			lastBestPicture.Id = 1;
			lastBestPicture.Title = DataResources.MovieSection2Title;
			lastBestPicture.Content = new List<Movie>
			{
				new Movie
				{
					Id = 11,
					Title = DataResources.MovieSection2Movie1Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMjIyOTM5OTIzNV5BMl5BanBnXkFtZTgwMDkzODE2NjE@._V1_UX182_CR0,0,182,268_AL_.jpg",	
					Seasons = DataResources.MovieSection2Movie1Seasons,
					RatingValue = 4.05,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie1Director,
					Plot = DataResources.MovieSection2Movie1Plot,
					Cast = DataResources.MovieSection2Movie1Cast.Split(',')
				},
				new Movie
				{
					Id = 12,
					Title = DataResources.MovieSection2Movie2Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BODAzNDMxMzAxOV5BMl5BanBnXkFtZTgwMDMxMjA4MjE@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection2Movie2Seasons,
					RatingValue = 3.9,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie2Director,
					Plot = DataResources.MovieSection2Movie2Plot,
					Cast = DataResources.MovieSection2Movie2Cast.Split(',')
				},
				new Movie
				{
					Id = 13,
					Title = DataResources.MovieSection2Movie3Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMjExMTEzODkyN15BMl5BanBnXkFtZTcwNTU4NTc4OQ@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection2Movie3Seasons,
					RatingValue = 4.05,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie3Director,
					Plot = DataResources.MovieSection2Movie3Plot,
					Cast = DataResources.MovieSection2Movie3Cast.Split(',')
				},
				new Movie
				{
					Id = 14,
					Title = DataResources.MovieSection2Movie4Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMTc3MjI0MjM0NF5BMl5BanBnXkFtZTcwMTYxMTQ1OA@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection2Movie4Seasons,
					RatingValue = 3.85,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie4Director,
					Plot = DataResources.MovieSection2Movie4Plot,
					Cast = DataResources.MovieSection2Movie4Cast.Split(',')
				},
				new Movie
				{
					Id = 15,
					Title = DataResources.MovieSection2Movie5Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMzk0NzQxMTM0OV5BMl5BanBnXkFtZTcwMzU4MDYyNQ@@._V1_UY268_CR9,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection2Movie5Seasons,
					RatingValue = 4,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie5Director,
					Plot = DataResources.MovieSection2Movie5Plot,
					Cast = DataResources.MovieSection2Movie5Cast.Split(',')
				},
				new Movie
				{
					Id = 16,
					Title = DataResources.MovieSection2Movie6Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMzU5MjEwMTg2Nl5BMl5BanBnXkFtZTcwNzM3MTYxNA@@._V1_UY268_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection2Movie6Seasons,
					RatingValue = 4,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie6Director,
					Plot = DataResources.MovieSection2Movie6Plot,
					Cast = DataResources.MovieSection2Movie6Cast.Split(',')
				},
				new Movie
				{
					Id = 17,
					Title = DataResources.MovieSection2Movie7Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BNzEwNzQ1NjczM15BMl5BanBnXkFtZTcwNTk3MTE1Mg@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection2Movie7Seasons,
					RatingValue = 2.5,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie7Director,
					Plot = DataResources.MovieSection2Movie7Plot,
					Cast = DataResources.MovieSection2Movie7Cast.Split(',')
				},
				new Movie
				{
					Id = 18,
					Title = DataResources.MovieSection2Movie8Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMTU2NTA5NzI0N15BMl5BanBnXkFtZTcwMjUxMjYxMg@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection2Movie8Seasons,
					RatingValue = 4,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie8Director,
					Plot = DataResources.MovieSection2Movie8Plot,
					Cast = DataResources.MovieSection2Movie8Cast.Split(',')
				},
				new Movie
				{
					Id = 19,
					Title = DataResources.MovieSection2Movie9Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMjA5Njk3MjM4OV5BMl5BanBnXkFtZTcwMTc5MTE1MQ@@._V1_UY268_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection2Movie9Seasons,
					RatingValue = 1.05,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie9Director,
					Plot = DataResources.MovieSection2Movie9Plot,
					Cast = DataResources.MovieSection2Movie9Cast.Split(',')
				},
				new Movie
				{
					Id = 20,
					Title = DataResources.MovieSection2Movie10Title,
					Source = "http://ia.media-imdb.com/images/M/MV5BMTI1MTY2OTIxNV5BMl5BanBnXkFtZTYwNjQ4NjY3._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection2Movie10Seasons,
					RatingValue = 4.25,
					RatingMax = 5,
					Director = DataResources.MovieSection2Movie10Director,
					Plot = DataResources.MovieSection2Movie10Plot,
					Cast = DataResources.MovieSection2Movie10Cast.Split(',')
				},
			};

			var sciFiClassic = new MovieSection();
			sciFiClassic.Id = 2;
			sciFiClassic.Title = DataResources.MovieSection3Title;
			sciFiClassic.Content = new List<Movie>
			{
				new Movie
				{
					Id = 21,
					Title = DataResources.MovieSection3Movie1Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BZWZlYmEyYTItNGRjYy00ZmMxLWEzMWItM2Q2NjZlNTMwMjQ3XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection3Movie1Seasons,
					RatingValue = 4.1,
					RatingMax = 5,
					Director = DataResources.MovieSection3Movie1Director,
					Plot = DataResources.MovieSection3Movie1Plot,
					Cast = DataResources.MovieSection3Movie1Cast.Split(',')
				},
				new Movie
				{
					Id = 22,
					Title = DataResources.MovieSection3Movie2Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection3Movie2Seasons,
					RatingValue = 4.25,
					RatingMax = 5,
					Director = DataResources.MovieSection3Movie2Director,
					Plot = DataResources.MovieSection3Movie2Plot,
					Cast = DataResources.MovieSection3Movie2Cast.Split(',')
				},
				new Movie
				{
					Id = 23,
					Title = DataResources.MovieSection3Movie3Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BZTMxMGM5MjItNDJhNy00MWI2LWJlZWMtOWFhMjI5ZTQwMWM3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection3Movie3Seasons,
					RatingValue = 3.9,
					RatingMax = 5,
					Director = DataResources.MovieSection3Movie3Director,
					Plot = DataResources.MovieSection3Movie3Plot,
					Cast = DataResources.MovieSection3Movie3Cast.Split(',')
				},
				new Movie
				{
					Id = 24,
					Title = DataResources.MovieSection3Movie4Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BYjhlMGYxNmMtOWFmMi00Y2M2LWE5NWYtZTdlMDRlMGEzMDA3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,676,1000_AL_.jpg",
					Seasons = DataResources.MovieSection3Movie4Seasons,
					RatingValue = 3.7,
					RatingMax = 5,
					Director = DataResources.MovieSection3Movie4Director,
					Plot = DataResources.MovieSection3Movie4Plot,
					Cast = DataResources.MovieSection3Movie4Cast.Split(',')
				},
				new Movie
				{
					Id = 25,
					Title = DataResources.MovieSection3Movie5Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BODE1MDczNTUxOV5BMl5BanBnXkFtZTcwMTA0NDQyNA@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection3Movie5Seasons,
					RatingValue = 4.5,
					RatingMax = 5,
					Director = DataResources.MovieSection3Movie5Director,
					Plot = DataResources.MovieSection3Movie5Plot,
					Cast = DataResources.MovieSection3Movie5Cast.Split(',')
				},
				new Movie
				{
					Id = 26,
					Title = DataResources.MovieSection3Movie6Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BZDM2YjYwYWMtMWZlNi00ZDQxLWExMDctMDAzNzQ0OTkzZjljXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection3Movie6Seasons,
					RatingValue = 4.05,
					RatingMax = 5,
					Director = DataResources.MovieSection3Movie6Director,
					Plot = DataResources.MovieSection3Movie6Plot,
					Cast = DataResources.MovieSection3Movie6Cast.Split(',')
				}
			};

			var sciFiMovies = new MovieSection();
			sciFiMovies.Id = 3;
			sciFiMovies.Title = DataResources.MovieSection4Title;
			sciFiMovies.Content = new List<Movie>
			{
				new Movie
				{
					Id = 31,
					Title = DataResources.MovieSection4Movie1Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUyMTE0ODcxNF5BMl5BanBnXkFtZTgwODE4NDQzNTE@._V1_UY268_CR1,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie1Seasons,
					RatingValue = 4.05,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie1Director,
					Plot = DataResources.MovieSection4Movie1Plot,
					Cast = DataResources.MovieSection4Movie1Cast.Split(',')
				},
				new Movie
				{
					Id = 32,
					Title = DataResources.MovieSection4Movie2Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTc2MTQ3MDA1Nl5BMl5BanBnXkFtZTgwODA3OTI4NjE@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie2Seasons,
					RatingValue = 4,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie2Director,
					Plot = DataResources.MovieSection4Movie2Plot,
					Cast = DataResources.MovieSection4Movie2Cast.Split(',')
				},
				new Movie
				{
					Id = 33,
					Title = DataResources.MovieSection4Movie3Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BYmViZGM0MGItZTdiYi00ZDU4LWIxNDYtNTc1NWQ5Njc2N2YwXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UY268_CR2,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie3Seasons,
					RatingValue = 3.7,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie3Director,
					Plot = DataResources.MovieSection4Movie3Plot,
					Cast = DataResources.MovieSection4Movie3Cast.Split(',')
				},
				new Movie
				{
					Id = 34,
					Title = DataResources.MovieSection4Movie4Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTk4NTk4MTk1OF5BMl5BanBnXkFtZTcwNTE2MDIwNA@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie4Seasons,
					RatingValue = 3.4,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie4Director,
					Plot = DataResources.MovieSection4Movie4Plot,
					Cast = DataResources.MovieSection4Movie4Cast.Split(',')
				},
				new Movie
				{
					Id = 35,
					Title = DataResources.MovieSection4Movie5Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BNjE5MzYwMzYxMF5BMl5BanBnXkFtZTcwOTk4MTk0OQ@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie5Seasons,
					RatingValue = 3.9,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie5Director,
					Plot = DataResources.MovieSection4Movie5Plot,
					Cast = DataResources.MovieSection4Movie5Cast.Split(',')
				},
				new Movie
				{
					Id = 36,
					Title = DataResources.MovieSection4Movie6Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQwMDY0MTA4MF5BMl5BanBnXkFtZTcwNzI3MDgxOQ@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie6Seasons,
					RatingValue = 3.5,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie6Director,
					Plot = DataResources.MovieSection4Movie6Plot,
					Cast = DataResources.MovieSection4Movie6Cast.Split(',')
				},
				new Movie
				{
					Id = 37,
					Title = DataResources.MovieSection4Movie7Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BM2NmZjQ4MjUtZGQ1YS00NjY0LTgzMDQtZjM4ZjJmMjNmZGY3XkEyXkFqcGdeQXVyNjA2MDM5MjU@._V1_UY268_CR120,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie7Seasons,
					RatingValue = 3.5,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie7Director,
					Plot = DataResources.MovieSection4Movie7Plot,
					Cast = DataResources.MovieSection4Movie7Cast.Split(',')
				},
				new Movie
				{
					Id = 38,
					Title = DataResources.MovieSection4Movie8Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BNDc2NjU0MTcwNV5BMl5BanBnXkFtZTcwMjg4MDg2OQ@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie8Seasons,
					RatingValue = 3.3,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie8Director,
					Plot = DataResources.MovieSection4Movie8Plot,
					Cast = DataResources.MovieSection4Movie8Cast.Split(',')
				},
				new Movie
				{
					Id = 39,
					Title = DataResources.MovieSection4Movie9Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjM1NTc0NzE4OF5BMl5BanBnXkFtZTgwNDkyNjQ1NTE@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie9Seasons,
					RatingValue = 3.3,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie9Director,
					Plot = DataResources.MovieSection4Movie9Plot,
					Cast = DataResources.MovieSection4Movie9Cast.Split(',')
				},
				new Movie
				{
					Id = 40,
					Title = DataResources.MovieSection4Movie10Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTY3NTY0MjEwNV5BMl5BanBnXkFtZTcwNTE3NDA1OA@@._V1_UY268_CR12,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection4Movie10Seasons,
					RatingValue = 3.7,
					RatingMax = 5,
					Director = DataResources.MovieSection4Movie10Director,
					Plot = DataResources.MovieSection4Movie10Plot,
					Cast = DataResources.MovieSection4Movie10Cast.Split(',')
				}
			};

			var marvelUniverse = new MovieSection();
			marvelUniverse.Id = 4;
			marvelUniverse.Title = DataResources.MovieSection5Title;
			marvelUniverse.Content = new List<Movie>
			{
				new Movie
				{
					Id = 41,
					Title = DataResources.MovieSection5Movie1Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BZWRhMzdhMzEtZTViNy00YWYyLTgxZmUtMTMwMWM0NTEyMjk3XkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection5Movie1Seasons,
					RatingValue = 3.35,
					RatingMax = 5,
					Director = DataResources.MovieSection5Movie1Director,
					Plot = DataResources.MovieSection5Movie1Plot,
					Cast = DataResources.MovieSection5Movie1Cast.Split(',')
				},
				new Movie
				{
					Id = 42,
					Title = DataResources.MovieSection5Movie2Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection5Movie2Seasons,
					RatingValue = 3.95,
					RatingMax = 5,
					Director = DataResources.MovieSection5Movie2Director,
					Plot = DataResources.MovieSection5Movie2Plot,
					Cast = DataResources.MovieSection5Movie2Cast.Split(',')
				},
				new Movie
				{
					Id = 43,
					Title = DataResources.MovieSection5Movie3Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTM0MDgwNjMyMl5BMl5BanBnXkFtZTcwNTg3NzAzMw@@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection5Movie3Seasons,
					RatingValue = 3.5,
					RatingMax = 5,
					Director = DataResources.MovieSection5Movie3Director,
					Plot = DataResources.MovieSection5Movie3Plot,
					Cast = DataResources.MovieSection5Movie3Cast.Split(',')
				},
				new Movie
				{
					Id = 44,
					Title = DataResources.MovieSection5Movie4Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTkzMjEzMjY1M15BMl5BanBnXkFtZTcwNTMxOTYyOQ@@._V1_UY268_CR3,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection5Movie4Seasons,
					RatingValue = 3.6,
					RatingMax = 5,
					Director = DataResources.MovieSection5Movie4Director,
					Plot = DataResources.MovieSection5Movie4Plot,
					Cast = DataResources.MovieSection5Movie4Cast.Split(',')
				},
				new Movie
				{
					Id = 45,
					Title = DataResources.MovieSection5Movie5Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTk0OTMyMDA0OF5BMl5BanBnXkFtZTgwMzY5NTkzNTE@._V1_UX182_CR0,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection5Movie5Seasons,
					RatingValue = 2.15,
					RatingMax = 5,
					Director = DataResources.MovieSection5Movie5Director,
					Plot = DataResources.MovieSection5Movie5Plot,
					Cast = DataResources.MovieSection5Movie5Cast.Split(',')
				},
				new Movie
				{
					Id = 46,
					Title = DataResources.MovieSection5Movie6Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQxNzUxNTE4Nl5BMl5BanBnXkFtZTYwMjcyNTk5._V1_UY268_CR4,0,182,268_AL_.jpg",
					Seasons = DataResources.MovieSection5Movie6Seasons,
					RatingValue = 2.85,
					RatingMax = 5,
					Director = DataResources.MovieSection5Movie6Director,
					Plot = DataResources.MovieSection5Movie6Plot,
					Cast = DataResources.MovieSection5Movie6Cast.Split(',')
				},
				new Movie
				{
					Id = 47,
					Title = DataResources.MovieSection5Movie7Title,
					Source = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUyNzk3MjA1OF5BMl5BanBnXkFtZTcwMTE1Njg2MQ@@._V1_UY190_CR0,0,128,190_AL_.jpg",
					Seasons = DataResources.MovieSection5Movie7Seasons,
					RatingValue = 3.4,
					RatingMax = 5,
					Director = DataResources.MovieSection5Movie7Director,
					Plot = DataResources.MovieSection5Movie7Plot,
					Cast = DataResources.MovieSection5Movie7Cast.Split(',')
				}
			};

			return new List<MovieSection> 
			{ 
				actorOfTheMonth, 
				lastBestPicture, 
				sciFiClassic, 
				sciFiMovies, 
				marvelUniverse 
			};
		}
	}
}
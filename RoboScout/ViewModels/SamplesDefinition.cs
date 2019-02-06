using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using RoboScout.Resx;
using UXDivers.Artina.Shared;

namespace RoboScout
{
	public static class SamplesDefinition
	{
		private static CultureChangeNotifier _notifier;

		private static List<SampleCategory> _samplesCategoryList;
		private static List<Sample> _allSamples;
		private static List<SampleGroup> _samplesGroupedByCategory;

		private static string[] _categoriesColors = 
		{
			"#921243",
			"#B31250",
			"#CD195E",
			"#56329A",
			"#6A40B9",
			"#7C4ECD",
			"#525ABB",
			"#5F7DD4",
			"#7B96E5"
		};

		public static void Initialize()
		{
			_notifier = new CultureChangeNotifier();
			_notifier.CultureChanged += (sender, args) => InitializeSamples();
		}

		public static List<SampleCategory> SamplesCategoryList
		{
			get
			{
				if (_samplesCategoryList == null)
				{
					InitializeSamples();
				}

				return _samplesCategoryList;
			}
		}

		public static List<Sample> AllSamples 
		{ 
			get
			{
				if (_allSamples == null) 
				{
					InitializeSamples();
				}

				return _allSamples;
			}
		}

		public static List<SampleGroup> SamplesGroupedByCategory 
		{ 
			get
			{
				if (_samplesGroupedByCategory == null) 
				{
					InitializeSamples();
				}

				return _samplesGroupedByCategory;
			}
		}

		public static List<SampleCategory> CreateSamples()
		{
			var result = new List<SampleCategory>();

			result.Add(
				new SampleCategory
				{
					Id = 0,
					Name = AppResources.StringCategorySocial,				// "Social",
					BackgroundColor = Color.FromHex(_categoriesColors[0]),
					BackgroundImage = SampleData.DashboardImagesList[6],
					Icon = GrialShapesFont.Person,
					Badge = 2,
					SamplesList = new List<Sample> {
						new Sample(AppResources.PageTitleDocumentTimeline	/*"Document Timeline"*/		, typeof(DocumentTimelinePage), SampleData.DashboardImagesList[6], GrialShapesFont.QueryBuilder, false, true),
						new Sample(AppResources.PageTitleTimeline			/*"Timeline"*/				, typeof(TimelinePage), SampleData.DashboardImagesList[6], GrialShapesFont.QueryBuilder, false, true),

						new Sample(AppResources.SampleUserProfile			/*"User Profile"*/			, typeof(ProfilePage), SampleData.DashboardImagesList[6], GrialShapesFont.AccountCircle),
						new Sample(AppResources.PageTitleSocial				/*"Social"*/				, typeof(SocialPage), SampleData.DashboardImagesList[6], GrialShapesFont.Group),
						new Sample(AppResources.PageTitleSocialVariant		/*"Social Variant"*/		, typeof(SocialVariantPage), SampleData.DashboardImagesList[6], GrialShapesFont.Group)
					}
				}
			);

			result.Add(
				new SampleCategory
				{
					Id = 1,
					Name = AppResources.StringCategoryArticles,					// "Articles",
					BackgroundColor = Color.FromHex(_categoriesColors[1]),
					BackgroundImage = SampleData.DashboardImagesList[4],
					Icon = GrialShapesFont.InsertFile,
					Badge = 2,
					SamplesList = new List<Sample> {
						new Sample(AppResources.PageTitleArticleClassicView		/*"Articles Classic View"*/		, typeof(ArticlesClassicViewPage), SampleData.DashboardImagesList[4], GrialShapesFont.InsertFile, false, true),
						new Sample(AppResources.PageTitleFrontPageNews			/*"Front Page News"*/			, typeof(FrontPageNewsPage), SampleData.DashboardImagesList[4], GrialShapesFont.InsertFile, false, true),

						new Sample(AppResources.PageTitleArticleView			/*"Article View"*/				, typeof(ArticleViewPage), SampleData.DashboardImagesList[4], GrialShapesFont.InsertFile),
						new Sample(AppResources.PageTitleArticleList			/*"Articles List"*/				, typeof(ArticlesListPage), SampleData.DashboardImagesList[4], GrialShapesFont.InsertFile),
						new Sample(AppResources.PageTitleArticlesListVariant	/*"Articles List Variant"*/		, typeof(ArticlesListVariantPage), SampleData.DashboardImagesList[4], GrialShapesFont.InsertFile),
						new Sample(AppResources.PageTitleArticlesFeed			/*"Articles Feed"*/				, typeof(ArticlesFeedPage), SampleData.DashboardImagesList[4], GrialShapesFont.InsertFile)
					}
				}
			);

			result.Add(
				new SampleCategory
				{
					Id = 2,
					Name = AppResources.StringCategoryDashboards,				//"Dashboards",
					BackgroundColor = Color.FromHex(_categoriesColors[2]),
					BackgroundImage = SampleData.DashboardImagesList[3],
					Badge = 5,
					Icon = GrialShapesFont.Dashboard,
					SamplesList = new List<Sample> {
						new Sample(AppResources.SampleDashboardGrialMovies		/*"Grial Movies"*/			, typeof(DashboardMultipleScrollPage), SampleData.DashboardImagesList[3], GrialShapesFont.LocalMovies, false, true),
						new Sample(AppResources.PageTitleMovieSelection			/*"Movie Selection"*/		, typeof(MovieSelectionPage), SampleData.DashboardImagesList[3], GrialShapesFont.LocalMovies, false, true),
						new Sample(AppResources.PageTitleDashboardCards			/*"Dashboard Cards"*/		, typeof(DashboardCardsPage), SampleData.DashboardImagesList[3], GrialShapesFont.Dashboard, false, true),
						new Sample(AppResources.PageTitleDashboardMultipleTiles	/*"Multiple Tiles"*/		, typeof(DashboardMultipleTilesPage), SampleData.DashboardImagesList[3], GrialShapesFont.Dashboard, false, true),
						new Sample(AppResources.PageTitleDashboardScrollable	/*"Scrollable Dashboards"*/	, typeof(DashboardScrollablePage), SampleData.DashboardImagesList[3], GrialShapesFont.Dashboard, false, true),
																		  
						new Sample(AppResources.PageMenuTitleDashboardIcons		/*"Icons Dashboard"*/		, typeof(DashboardPage), SampleData.DashboardImagesList[3], GrialShapesFont.Dashboard),
						new Sample(AppResources.PageTitleDashboardFlat			/*"Flat Dashboard"*/		, typeof(DashboardFlatPage), SampleData.DashboardImagesList[3], GrialShapesFont.Dashboard),
						new Sample(AppResources.PageTitleDashboardWithImages	/*"Images Dashboard"*/		, typeof(DashboardWithImagesPage), SampleData.DashboardImagesList[3], GrialShapesFont.Dashboard, false)
					}
				}
			);

			result.Add(
				new SampleCategory
				{
					Id = 3,
					Name = AppResources.StringCategoryNavigation,					// "Navigation",
					BackgroundColor = Color.FromHex(_categoriesColors[3]),
					BackgroundImage = SampleData.DashboardImagesList[2],
					Badge = 5,
					Icon = GrialShapesFont.Menu,
					SamplesList = new List<Sample> {
						new Sample(AppResources.PageTitleCardsList					/*"Card List"*/				, typeof(CardsListPage), SampleData.DashboardImagesList[2], GrialShapesFont.List, false, true),
						new Sample(AppResources.PageTitleEmptyState					/*"Empty State"*/			, typeof(EmptyStatePage), SampleData.DashboardImagesList[2], GrialShapesFont.Hourglass, false, true),
						new Sample(AppResources.PageTitleTitleNotifications			/*"Notifications"*/			, typeof(NotificationsPage), SampleData.DashboardImagesList[2], GrialShapesFont.Notifications, false, true),
						new Sample(AppResources.PageTitleWelcome					/*"Welcome Page"*/			, typeof (WelcomePage), SampleData.DashboardImagesList[2], GrialShapesFont.Place, true, true),
						new Sample(AppResources.PageTitleCategoriesListFlat			/*"Categories List Flat"*/	, typeof(CategoriesListFlatPage), SampleData.DashboardImagesList[2], GrialShapesFont.List),
						new Sample(AppResources.PageTitleCategoryListImages			/*"Image Categories"*/		, typeof(CategoriesListWithImagesPage), SampleData.DashboardImagesList[2], GrialShapesFont.List),
						new Sample(AppResources.PageTitleCategoriesListWithIcons	/*"Icon Categories"*/		, typeof(CategoriesListWithIconsPage), SampleData.DashboardImagesList[2], GrialShapesFont.List),
						new Sample(AppResources.PageTitleCustomNavBar				/*"Custom NavBar"*/			, typeof(CustomNavBarPage), SampleData.DashboardImagesList[2], GrialShapesFont.WebAsset),
						new Sample(AppResources.SampleTitleRootPage					/*"Root Page"*/				, typeof(RootPage), SampleData.DashboardImagesList[2], GrialShapesFont.Menu, false)
					}
				}
			);

			result.Add(
				new SampleCategory
				{
					Id = 4,
					Name = AppResources.StringCategoryLogins,				// "Logins",
					BackgroundColor = Color.FromHex(_categoriesColors[4]),
					BackgroundImage = SampleData.DashboardImagesList[5],
					Badge = 2,
					Icon = GrialShapesFont.Lock,
					SamplesList = new List<Sample> {
						new Sample(AppResources.PageTitleSimpleSignup		/*"Simple Sign Up"*/		, typeof(SimpleSignUpPage), SampleData.DashboardImagesList[5], GrialShapesFont.CheckCircle, true, true),
						new Sample(AppResources.PageTitleSimpleLogin		/*"Simple Login"*/			, typeof(SimpleLoginPage), SampleData.DashboardImagesList[5], GrialShapesFont.CheckCircle, true, true),
						new Sample(AppResources.PageTitleLogin				/*"Login"*/					, typeof(LoginPage), SampleData.DashboardImagesList[5], GrialShapesFont.Lock, true),
						new Sample(AppResources.PageTitleSignup				/*"Sign Up"*/				, typeof(SignUpPage), SampleData.DashboardImagesList[5], GrialShapesFont.CheckCircle, true),
						new Sample(AppResources.PageTitlePasswordRecovery	/*"Password Recovery"*/		, typeof(PasswordRecoveryPage), SampleData.DashboardImagesList[5], GrialShapesFont.SettingsRestore, true)
					}
				}
			);

			result.Add(
				new SampleCategory
				{
					Id = 5,
					Name = AppResources.StringCategoryECommerce,				// "Ecommerce",
					BackgroundColor = Color.FromHex(_categoriesColors[5]),
					BackgroundImage = SampleData.DashboardImagesList[1],
					Badge = 3,
					Icon = GrialShapesFont.ShoppingCart,
					SamplesList = new List<Sample> {
						new Sample(AppResources.SampleProductFullscreen			/*"Product FullScreen"*/	, typeof(ProductItemFullScreenPage), SampleData.DashboardImagesList[1], GrialShapesFont.CardGiftcard, false, true),
						new Sample(AppResources.PageTitleProductsCatalog		/*"Products Catalog"*/		, typeof(ProductsCatalogPage), SampleData.DashboardImagesList[1], GrialShapesFont.CardGiftcard, false, true),
						new Sample(AppResources.PageTitleProductOrder			/*"Product Order"*/			, typeof(ProductOrder), SampleData.DashboardImagesList[5], GrialShapesFont.CardGiftcard, false, true),

						new Sample(AppResources.PageTitleProductGrid			/*"Products Grid"*/			, typeof(ProductsGridPage), SampleData.DashboardImagesList[1] , GrialShapesFont.Module),
						new Sample(AppResources.PageTitleProductGridVariant		/*"Products Grid Variant"*/	, typeof(ProductsGridVariantPage), SampleData.DashboardImagesList[1] , GrialShapesFont.Module),
						new Sample(AppResources.SampleProductItemView			/*"Product Item View"*/		, typeof(ProductItemViewPage), SampleData.DashboardImagesList[1], GrialShapesFont.CardGiftcard),
						new Sample(AppResources.SampleProductCarousel			/*"Products Carousel"*/		, typeof(ProductsCarouselPage), SampleData.DashboardImagesList[1], GrialShapesFont.CardGiftcard)
					}
				}
			);

			result.Add(
				new SampleCategory
				{
					Id = 6,
					Name = AppResources.StringCategoryWalkthroughs,				// "Walkthroughs",
					BackgroundColor = Color.FromHex(_categoriesColors[6]),
					BackgroundImage = SampleData.DashboardImagesList[7],
					Badge = 2,
					Icon = GrialShapesFont.Carousel,
					SamplesList = new List<Sample> {
						new Sample(AppResources.SampleTitleWalkthrough			/*"Walkthrough"*/			, typeof(WalkthroughPage), SampleData.DashboardImagesList[7], GrialShapesFont.Carousel, true, true),
						new Sample(AppResources.SampleTitleWalkthroughFlat		/*"Walkthrough Flat"*/		, typeof(WalkthroughFlatPage), SampleData.DashboardImagesList[7], GrialShapesFont.Carousel, true, true),
						new Sample(AppResources.SampleTitleWalkthroughVariant	/*"Walkthrough Variant"*/	, typeof(WalkthroughVariantPage), SampleData.DashboardImagesList[7], GrialShapesFont.Carousel, true)
					}
				}
			);

			result.Add(
				new SampleCategory
				{
					Id = 7,
					Name = AppResources.StringCategoryMessages,				// "Messages",
					BackgroundColor = Color.FromHex(_categoriesColors[7]),
					BackgroundImage = SampleData.DashboardImagesList[8],
					Badge = 2,
					Icon = GrialShapesFont.Email,
					SamplesList = new List<Sample> {
						new Sample(AppResources.PageTitleChatTimeLine		/*"Chat Timeline"*/			, typeof( ChatTimelinePage ), SampleData.DashboardImagesList[2], GrialShapesFont.QueryBuilder, false, true),
						new Sample(AppResources.PageTitleRecentChatList		/*"Recent Chat List"*/		, typeof(RecentChatListPage), SampleData.DashboardImagesList[2], GrialShapesFont.QueryBuilder, false, true),
						new Sample(AppResources.PageTitleMessages			/*"Messages"*/				, typeof(MessagesListPage), SampleData.DashboardImagesList[8], GrialShapesFont.Email),
						new Sample(AppResources.PageTitleChatMessageList	/*"Chat Messages List"*/	, typeof(ChatMessagesListPage), SampleData.DashboardImagesList[8], GrialShapesFont.Forum)
					}
				}
			);

			result.Add(
				new SampleCategory
				{
					Id = 8,
					Name = AppResources.StringCategoryTheme,						// "Grial Theme",
					BackgroundColor = Color.FromHex(_categoriesColors[8]),
					BackgroundImage = SampleData.DashboardImagesList[0],
					Badge = 9,
					Icon = GrialShapesFont.ColorPalette,
					SamplesList = new List<Sample> {

						new Sample(AppResources.PageTitleAnimation					/*"Animations"*/				, typeof(AnimationsPage), SampleData.DashboardImagesList[0], GrialShapesFont.LogoLottie, false, true),
						new Sample(AppResources.PageTitleTabControl					/*"Tab Control"*/				, typeof(TabControlCustomSamplePage), SampleData.DashboardImagesList[0], GrialShapesFont.LogoGrial, false, true),
						new Sample(AppResources.PageTitleAndroidTabControl			/*"Tab Control Android"*/		, typeof(TabControlAndroidSamplePage), SampleData.DashboardImagesList[0], GrialShapesFont.LogoGrial, false, true),
						new Sample(AppResources.PageTitleiOSTabControl				/*"Tab Control iOS" */			, typeof(TabControliOSSamplePage), SampleData.DashboardImagesList[0], GrialShapesFont.LogoGrial, false, true),
						new Sample(AppResources.PageTitleBottomTabControl			/*"Tab Control bottom" */		, typeof(TabControlBottomPlacementSamplePage), SampleData.DashboardImagesList[0], GrialShapesFont.LogoGrial, false, true),
						new Sample(AppResources.PageTitleTabbedPage					/*"Tabbed Page"*/				, typeof(TabsPage), SampleData.DashboardImagesList[0], GrialShapesFont.Tab, false, true),
						new Sample(AppResources.SampleTitleThemeDemoSettings		/*"Demo Settings"*/				, typeof(GrialDemoSettings), SampleData.DashboardImagesList[0], GrialShapesFont.Settings, false, true),
						new Sample(AppResources.PageTitleAbout						/*"About"*/						, typeof(GenericAboutPage), SampleData.DashboardImagesList[0], GrialShapesFont.Help, false, true),
						new Sample(AppResources.PageTitleCustomSettings				/*"Custom Settings Page"*/		, typeof(CustomSettingsPage), SampleData.DashboardImagesList[0], GrialShapesFont.Settings, false, true),
						new Sample(AppResources.PageTitleCustomActivityIndicator	/*"Custom Activity Indicator"*/	, typeof(CustomActivityIndicatorPage), SampleData.DashboardImagesList[0], GrialShapesFont.Loop, false, true),
						new Sample(AppResources.PageTitleResponsiveHelpers			/*"Responsive Helpers"*/		, typeof(ResponsiveHelpersPage), SampleData.DashboardImagesList[0], GrialShapesFont.TabletAndroid, false, true),
						new Sample(AppResources.PageTitleThemeFontIcons				/*"Grial Font Icons"*/			, typeof(IconsPage), SampleData.DashboardImagesList[0], GrialShapesFont.LogoGrial, false, true),
						new Sample(AppResources.PageTitleNativeControls				/*"Native Controls"*/			, typeof(ThemePage), SampleData.DashboardImagesList[0], GrialShapesFont.ColorPalette),
						new Sample(AppResources.PageTitleCustomRenderers			/*"Custom Renderers"*/			, typeof(CustomRenderersPage), SampleData.DashboardImagesList[0], GrialShapesFont.ColorPalette),
						new Sample(AppResources.PageTitleCommonViews				/*"Grial Common Views"*/		, typeof(CommonViewsPage), SampleData.DashboardImagesList[0], GrialShapesFont.LogoGrial),
						new Sample(AppResources.PageTitleSettings					/*"Settings Page"*/				, typeof(SettingsPage), SampleData.DashboardImagesList[0], GrialShapesFont.Settings),
						new Sample(AppResources.PageTitleWebview					/*"WebView"*/					, typeof(WebViewPage), SampleData.DashboardImagesList[0], GrialShapesFont.Public)
					}
				}
			);

			return result;
		}

		public static void InitializeSamples()
		{
			_samplesCategoryList = CreateSamples();

			_allSamples = new List<Sample>();

			_samplesGroupedByCategory = new List<SampleGroup>();

			foreach (var sampleCategory in _samplesCategoryList)
			{
				var sampleItem = new SampleGroup(sampleCategory.Name.ToUpper());

				foreach (var sample in sampleCategory.SamplesList)
				{
					_allSamples.Add(sample);
					sampleItem.Add(sample);
				}

				_samplesGroupedByCategory.Add(sampleItem);
			}
		}
	}

	public class SampleGroup : List<Sample>
	{
		public SampleGroup(string name)
		{
			Name = name;
		}

		public string Name { get; }
	}
}

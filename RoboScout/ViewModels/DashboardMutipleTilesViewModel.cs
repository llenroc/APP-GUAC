using System;
using System.Collections.Generic;
using System.Globalization;
using RoboScout.Resx;

namespace RoboScout
{
	public class DashboardMutipleTilesViewModel : ObservableObject
	{
		private List<DashboardMultipleTileItem> _dashboardMutipleTilesList;

		public DashboardMutipleTilesViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public List<DashboardMultipleTileItem> DashboardMutipleTilesList
		{
			get { return _dashboardMutipleTilesList; }
			set { SetProperty(ref _dashboardMutipleTilesList, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			DashboardMutipleTilesList = new List<DashboardMultipleTileItem> 
			{
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem1Title,
					Body = "",
					Avatar = "",
					BackgroundColor = "#774C4C4C",
					ShowBackgroundColor = false,
					IsNotification = false,
					BackgroundImage = "profile_preview.jpg",
					Icon = "",
					Badge = 0
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem2Title,
					Body = "",
					Avatar = "",
					BackgroundColor = "#48B5BA",
					ShowBackgroundColor = true,
					IsNotification = false,
					BackgroundImage = "",
					Icon = GrialShapesFont.Person,
					Badge = 2
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem3Title,
					Body = "",
					Avatar = "",
					BackgroundColor = "#CD195E",
					ShowBackgroundColor = false,
					IsNotification = false,
					BackgroundImage = "",
					Icon = GrialShapesFont.LogoGrial,
					Badge = 0
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem4Title,
					Body = "",
					Avatar = "",
					BackgroundColor = "#77742DAF",
					ShowBackgroundColor = false,
					IsNotification = false,
					BackgroundImage = "social_album_2.jpg",
					Icon = GrialShapesFont.PhotoCamera,
					Badge = 0
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem5Title,
					Body = "",
					Avatar = "",
					BackgroundColor = "#BD3434",
					ShowBackgroundColor = true,
					IsNotification = false,
					BackgroundImage = "",
					Icon = GrialShapesFont.Music,
					Badge = 0
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem6Title,
					Body = "",
					Avatar = "",
					BackgroundColor = "#770C60AF",
					ShowBackgroundColor = false,
					IsNotification = false,
					BackgroundImage = "product_item_4.jpg",
					Icon = GrialShapesFont.ShoppingCart,
					Badge = 1
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem7Title,
					Body = DataResources.DashboardMultipleTileItem7Body,
					Avatar = SampleData.UsersImagesList[4],
					BackgroundColor = "#1DA1F2",
					ShowBackgroundColor = false,
					IsNotification = true,
					BackgroundImage = SampleData.DashboardImagesList[8],
					Icon = GrialShapesFont.SocialTwitter,
					Badge = 2
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem8Title,
					Body = "",
					Avatar = "",
					BackgroundColor = "#770A002B",
					ShowBackgroundColor = false,
					IsNotification = false,
					BackgroundImage = "dashboard_thumbnail_0.jpg",
					Icon = GrialShapesFont.Public,
					Badge = 1
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem9Title,
					Body = DataResources.DashboardMultipleTileItem9Body,
					Avatar = SampleData.UsersImagesList[2],
					BackgroundColor = "#3b5998",
					ShowBackgroundColor = false,
					IsNotification = true,
					BackgroundImage = "",
					Icon = GrialShapesFont.SocialFacebook,
					Badge = 2
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem10Title,
					Body = DataResources.DashboardMultipleTileItem10Body,
					Avatar = SampleData.UsersImagesList[0],
					BackgroundColor = "#833ab4",
					ShowBackgroundColor = false,
					IsNotification = true,
					BackgroundImage = "SampleData.DashboardImagesList[7]",
					Icon = GrialShapesFont.SocialInstagram,
					Badge = 2
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem11Title,
					Body = "",
					Avatar = "",
					BackgroundColor = "#319E3A",
					ShowBackgroundColor = true,
					IsNotification = false,
					BackgroundImage = "",
					Icon = GrialShapesFont.Event,
					Badge = 0
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem12Title,
					Body = DataResources.DashboardMultipleTileItem12Body,
					Avatar = SampleData.UsersImagesList[1],
					BackgroundColor = "#128c7e",
					ShowBackgroundColor = false,
					IsNotification = true,
					BackgroundImage = "SampleData.DashboardImagesList[7]",
					Icon = GrialShapesFont.SocialWhatsapp,
					Badge = 2
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem13Title,
					Body = DataResources.DashboardMultipleTileItem13Body,
					Avatar = SampleData.UsersImagesList[6],
					BackgroundColor = "#0077b5",
					ShowBackgroundColor = false,
					IsNotification = true,
					BackgroundImage = SampleData.DashboardImagesList[7],
					Icon = GrialShapesFont.SocialLinkedin,
					Badge = 0
				},
				new DashboardMultipleTileItem
				{
					Title = DataResources.DashboardMultipleTileItem14Title,
					Body = "",
					Avatar = "",
					BackgroundColor = "#DE6D3B",
					ShowBackgroundColor = true,
					IsNotification = false,
					BackgroundImage = "",
					Icon = GrialShapesFont.FlashOn,
					Badge = 0
				}
			};
		}
	}

	public class DashboardMultipleTileItem
	{
		public string Title { get; set; }
		public string Body { get; set; }
		public string Avatar { get; set; }
		public string BackgroundColor { get; set; }
		public string BackgroundImage { get; set; }
		public bool ShowBackgroundColor { get; set; }
		public bool IsNotification { get; set; }
		public string Icon { get; set; }
		public int Badge { get; set; }
	}
}

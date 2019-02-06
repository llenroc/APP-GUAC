using System.Collections.Generic;
using System.Globalization;
using RoboScout.Resx;

namespace RoboScout
{
	public class DashboardCardsViewModel : ObservableObject
	{
		private List<DashboardCardItem> _dashboardCardsList;

		public DashboardCardsViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public List<DashboardCardItem> DashboardCardsList
		{
			get { return _dashboardCardsList; }
			set { SetProperty(ref _dashboardCardsList, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			DashboardCardsList = new List<DashboardCardItem>
			{
				new DashboardCardItem
				{
					Title = DataResources.DasboardCard1Title,
					Body = DataResources.DasboardCard1Body,
					Section = DataResources.DasboardCard1Section,
					Author = DataResources.DasboardCard1Author,
					BackgroundImage = SampleData.DashboardImagesList[3],
					Avatar = SampleData.UsersImagesList[3],
					BackgroundColor = "#d81b60"
				},
				new DashboardCardItem
				{
					Title = DataResources.DasboardCard2Title,
					Body = DataResources.DasboardCard2Body,
					Section = DataResources.DasboardCard2Section,
					Author = DataResources.DasboardCard2Author,
					BackgroundImage = SampleData.DashboardImagesList[4],
					Avatar = SampleData.UsersImagesList[4],
					BackgroundColor = "#c2185b"
				},
				new DashboardCardItem
				{
					Title = DataResources.DasboardCard3Title,
					Body = DataResources.DasboardCard3Body,
					Section = DataResources.DasboardCard3Section,
					Author = DataResources.DasboardCard3Author,
					BackgroundImage = SampleData.DashboardImagesList[5],
					Avatar = SampleData.UsersImagesList[5],
					BackgroundColor = "#56329A"
				},
				new DashboardCardItem
				{
					Title = DataResources.DasboardCard4Title,
					Body = DataResources.DasboardCard4Body,
					Section = DataResources.DasboardCard4Section,
					Author = DataResources.DasboardCard4Author,
					BackgroundImage = SampleData.DashboardImagesList[0],
					Avatar = SampleData.UsersImagesList[0],
					BackgroundColor = "#4B436E"
				},
				new DashboardCardItem
				{
					Title = DataResources.DasboardCard5Title,
					Body = DataResources.DasboardCard5Body,
					Section = DataResources.DasboardCard5Section,
					Author = DataResources.DasboardCard5Author,
					BackgroundImage = SampleData.DashboardImagesList[1],
					Avatar = SampleData.UsersImagesList[1],
					BackgroundColor = "#1e88e5"
				},
				new DashboardCardItem
				{
					Title = DataResources.DasboardCard6Title,
					Body = DataResources.DasboardCard6Body,
					Section = DataResources.DasboardCard6Section,
					Author = DataResources.DasboardCard6Author,
					BackgroundImage = SampleData.DashboardImagesList[2],
					Avatar = SampleData.UsersImagesList[2],
					BackgroundColor = "#1565c0"
				},
				new DashboardCardItem
				{
					Title = DataResources.DasboardCard7Title,
					Body = DataResources.DasboardCard7Body,
					Section = DataResources.DasboardCard7Section,
					Author = DataResources.DasboardCard7Author,
					BackgroundImage = SampleData.DashboardImagesList[6],
					Avatar = SampleData.UsersImagesList[6],
					BackgroundColor = "#0097a7"
				},
				new DashboardCardItem
				{
					Title = DataResources.DasboardCard8Title,
					Body = DataResources.DasboardCard8Body,
					Section = DataResources.DasboardCard8Section,
					Author = DataResources.DasboardCard8Author,
					BackgroundImage = SampleData.DashboardImagesList[7],
					Avatar = SampleData.UsersImagesList[0],
					BackgroundColor = "#00838f"
				},
				new DashboardCardItem
				{
					Title = DataResources.DasboardCard9Title,
					Body = DataResources.DasboardCard9Body,
					Section = DataResources.DasboardCard9Section,
					Author = DataResources.DasboardCard9Author,
					BackgroundImage = SampleData.DashboardImagesList[8],
					Avatar = SampleData.UsersImagesList[1],
					BackgroundColor = "#2e7d32"
				}
			};
		}
	}

	public class DashboardCardItem
	{
		public string Title { get; set; }
		public string Body { get; set; }
		public string Section { get; set; }
		public string Author { get; set; }
		public string Avatar { get; set; }
		public string BackgroundImage { get; set; }
		public string BackgroundColor { get; set; }
	}
}
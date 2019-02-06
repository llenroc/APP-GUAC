using System;
using System.Collections.Generic;
using System.Globalization;
using RoboScout.Resx;

namespace RoboScout
{
	public class DocumentTimelineViewModel : ObservableObject
	{
		private List<DocumentTimelineEvent> _documentTimelineList;

		public DocumentTimelineViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public List<DocumentTimelineEvent> DocumentTimelineList
		{ 
			get { return _documentTimelineList; }
			set { SetProperty(ref _documentTimelineList, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			DocumentTimelineList = new List<DocumentTimelineEvent>
			{
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent1Title,
					Author = DataResources.DocumentTimelineEvent1Author,
					Icon = GrialShapesFont.QueryBuilder,
					When = DataResources.DocumentTimelineEvent1When,
					IsInbound = true
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent2Title,
					Author = DataResources.DocumentTimelineEvent2Author,
					Icon = GrialShapesFont.InsertFile,
					When = DataResources.DocumentTimelineEvent2When,
					IsInbound = false
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent3Title,
					Author = DataResources.DocumentTimelineEvent3Author,
					Icon = GrialShapesFont.InsertFile,
					When = DataResources.DocumentTimelineEvent3When,
					IsInbound = true
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent4Title,
					Author = DataResources.DocumentTimelineEvent4Author,
					Icon = GrialShapesFont.Forum,
					When = DataResources.DocumentTimelineEvent4When,
					IsInbound = false
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent5Title,
					Author = DataResources.DocumentTimelineEvent5Author,
					Icon = GrialShapesFont.Forum,
					When = DataResources.DocumentTimelineEvent5When,
					IsInbound = true
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent6Title,
					Author = DataResources.DocumentTimelineEvent6Author,
					Icon = GrialShapesFont.Check,
					When = DataResources.DocumentTimelineEvent6When,
					IsInbound = false
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent7Title,
					Author = DataResources.DocumentTimelineEvent7Author,
					Icon = GrialShapesFont.Notifications,
					When = DataResources.DocumentTimelineEvent7When,
					IsInbound = true
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent8Title,
					Author = DataResources.DocumentTimelineEvent8Author,
					Icon = GrialShapesFont.QueryBuilder,
					When = DataResources.DocumentTimelineEvent8When,
					IsInbound = true
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent9Title,
					Author = DataResources.DocumentTimelineEvent9Author,
					Icon = GrialShapesFont.InsertFile,
					When = DataResources.DocumentTimelineEvent9When,
					IsInbound = false
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent10Title,
					Author = DataResources.DocumentTimelineEvent10Author,
					Icon = GrialShapesFont.QueryBuilder,
					When = DataResources.DocumentTimelineEvent10When,
					IsInbound = true
				},
				new DocumentTimelineEvent
				{
					Title = DataResources.DocumentTimelineEvent11Author,
					Author = DataResources.DocumentTimelineEvent11Author,
					Icon = GrialShapesFont.InsertFile,
					When = DataResources.DocumentTimelineEvent11When,
					IsInbound = false
				}
			};
		}
	}

	public class DocumentTimelineEvent
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string Icon { get; set; }
		public string When { get; set; }
		public bool IsInbound
		{
			get;
			set;
		}
	}
}

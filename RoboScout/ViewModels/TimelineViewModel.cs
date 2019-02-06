using System;
using System.Collections.Generic;
using System.Globalization;
using RoboScout.Resx;

namespace RoboScout
{
	public class TimelineViewModel : ObservableObject
	{
		private List<TimelineEvent> _timelineList;

		public TimelineViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public List<TimelineEvent> TimelineList 
		{
			get { return _timelineList; }
			set { SetProperty(ref _timelineList, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			TimelineList = new List<TimelineEvent>
			{
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent1Title,
					EventDescription = DataResources.TimelineEvent1Description,
					Image = "friend_thumbnail_27.jpg",
					When = DataResources.TimelineEvent1When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent2Title,
					EventDescription = DataResources.TimelineEvent2Description,
					Image = "friend_thumbnail_34.jpg",
					When = DataResources.TimelineEvent2When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent3Title,
					EventDescription = DataResources.TimelineEvent3Description,
					Image = "friend_thumbnail_55.jpg",
					When = DataResources.TimelineEvent3When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent4Title,
					EventDescription = DataResources.TimelineEvent4Description,
					Image = "friend_thumbnail_71.jpg",
					When = DataResources.TimelineEvent4When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent5Title,
					EventDescription = DataResources.TimelineEvent5Description,
					Image = "friend_thumbnail_75.jpg",
					When = DataResources.TimelineEvent5When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent6Title,
					EventDescription = DataResources.TimelineEvent6Description,
					Image = "friend_thumbnail_93.jpg",
					When = DataResources.TimelineEvent6When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent7Title,
					EventDescription = DataResources.TimelineEvent7Description,
					Image = "friend_thumbnail_93.jpg",
					When = DataResources.TimelineEvent7When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent8Title,
					EventDescription = DataResources.TimelineEvent8Description,
					Image = "friend_thumbnail_71.jpg",
					When = DataResources.TimelineEvent8When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent9Title,
					EventDescription = DataResources.TimelineEvent9Description,
					Image = "friend_thumbnail_27.jpg",
					When = DataResources.TimelineEvent9When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent10Title,
					EventDescription = DataResources.TimelineEvent10Description,
					Image = "friend_thumbnail_75.jpg",
					When = DataResources.TimelineEvent10When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent11Title,
					EventDescription = DataResources.TimelineEvent11Description,
					Image = "friend_thumbnail_34.jpg",
					When = DataResources.TimelineEvent11When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent12Title,
					EventDescription = DataResources.TimelineEvent12Description,
					Image = "friend_thumbnail_27.jpg",
					When = DataResources.TimelineEvent12When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent13Title,
					EventDescription = DataResources.TimelineEvent13Description,
					Image = "friend_thumbnail_27.jpg",
					When = DataResources.TimelineEvent13When
				},
				new TimelineEvent 
				{
					EventTitle = DataResources.TimelineEvent14Title,
					EventDescription = DataResources.TimelineEvent14Description,
					Image = "friend_thumbnail_71.jpg",
					When = DataResources.TimelineEvent14When
				}
			};
		}
	}

	public class TimelineEvent
	{
		public string EventTitle { get; set; }
		public string EventDescription { get; set; }
		public string Image { get; set; }
		public string When { get; set; }
	}
}


using System;
using System.Collections.Generic;
using System.Globalization;

namespace RoboScout
{
	public class NotificationsViewModel : ObservableObject
	{
		public NotificationsViewModel()
			: base(listenCultureChanges: true)
		{
		}

		public List<Notification> Notifications
		{
			get
			{
				return SampleData.Notifications;
			}
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			NotifyPropertyChanged(nameof(Notifications));
		}
	}
}
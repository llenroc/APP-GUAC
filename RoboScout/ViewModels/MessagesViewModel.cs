using System.Collections.Generic;
using System.Globalization;

namespace RoboScout
{
	public class MessagesViewModel : ObservableObject
	{
		private List<Message> _messages;

		public MessagesViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public List<Message> Messages
		{
			get { return _messages; }
			set { SetProperty(ref _messages, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			Messages = SampleData.Messages;
		}
	}
}


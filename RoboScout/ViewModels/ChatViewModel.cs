using System.Collections.Generic;
using System.Globalization;

namespace RoboScout
{
	public class ChatViewModel : ObservableObject
	{
		private List<ChatMessage> _messages;
		private bool _useRecent;

		public ChatViewModel(bool useRecent)
			: base(listenCultureChanges: true)
		{
			_useRecent = useRecent;
			LoadData();
		}

		public List<ChatMessage> Messages 
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
			Messages = _useRecent ?
				SampleData.RecentChatMessagesList :
				SampleData.ChatMessagesList;
		}
	}
}
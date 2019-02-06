using Xamarin.Forms;

namespace RoboScout
{
	public partial class ChatTimelinePage : ContentPage
	{
		public ChatTimelinePage()
		{
			InitializeComponent();
			BindingContext = new ChatViewModel(useRecent: false);
		}
	}
}

using Xamarin.Forms;

namespace RoboScout
{
	public partial class DashboardMultipleScrollPage : ContentPage
	{
		public DashboardMultipleScrollPage ()
		{
			InitializeComponent ();

			BindingContext = new DashboardMultipleScrollPageViewModel();
		}
	}
}

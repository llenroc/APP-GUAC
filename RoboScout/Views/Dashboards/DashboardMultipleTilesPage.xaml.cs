using Xamarin.Forms;

namespace RoboScout
{
	public partial class DashboardMultipleTilesPage : ContentPage
	{
		public DashboardMultipleTilesPage ()
		{			
			InitializeComponent();

			BindingContext = new DashboardMutipleTilesViewModel();
		}
	}
}
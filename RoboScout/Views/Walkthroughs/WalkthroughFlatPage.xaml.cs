using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class WalkthroughFlatPage : CarouselPage
	{
		public WalkthroughFlatPage()
		{
			InitializeComponent ();

			NavigationPage.SetHasNavigationBar (this, false);

			BindingContext = new WalkthroughViewModel(Close, GoToStep);
		}

		private async Task GoToStep ()
		{
			var index = Children.IndexOf (CurrentPage);
			var moveToIndex = 0;
			if (index < Children.Count - 1) {
				moveToIndex = index + 1;

				CurrentPage = Children [moveToIndex];
			} else {
				await Close ();
			}
		}

		private async Task Close() 
		{
			if (Navigation.ModalStack.Count > 0)
			{
				await Navigation.PopModalAsync();
			}
		}

		protected async override void OnCurrentPageChanged ()
		{
			base.OnCurrentPageChanged ();
			var currentStep = (WalkthroughFlatStepItemTemplate)CurrentPage;

			await currentStep.AnimateIn ();
		}
	}
}


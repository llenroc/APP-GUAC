using System;
using Xamarin.Forms;

namespace RoboScout
{
	public partial class GrialDemoSettings : ContentPage
	{
		public GrialDemoSettings()
		{
			InitializeComponent();
		}

		public void OnBtnLightClicked(object sender, EventArgs e)
		{
            Settings.SetTheme(Theme.Light);
		}

		public void OnBtnDarkClicked(object sender, EventArgs e)
		{
            Settings.SetTheme(Theme.Dark);
		}

		public void OnBtnEnterpriseClicked(object sender, EventArgs e)
		{
            Settings.SetTheme(Theme.Enterprise);
		}

		public void OnBtnCustomClicked(object sender, EventArgs e)
		{
			//var uri = "mailto:hello@grialkit.com?subject=I%20want%20a%20custom%20theme%20for%20my%20Grial%20app&body=Please%20leave%20us%20your%20comments.";
			var uri = "http://grialkit.com/getquote";
			Device.OpenUri(new Uri(uri));
		}
	}
}

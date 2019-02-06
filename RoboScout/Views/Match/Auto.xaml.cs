using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoboScout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Auto : ContentPage
	{
		public Auto ()
		{
			InitializeComponent ();
		}

        private void LatchedClicked(object sender, EventArgs e)
        {

            if (LatchedToggle.Text == "Yes!")
                LatchedToggle.Text = " No ";
            else LatchedToggle.Text = "Yes!";

        }

        private void ClaimedClicked(object sender, EventArgs e)
        {

            if (ClaimedToggle.Text == "Yes!")
                ClaimedToggle.Text = " No ";
            else ClaimedToggle.Text = "Yes!";
            
        }

        private void SampleClicked(object sender, EventArgs e)
        {

            if (SampleToggle.Text == "Yes!")
                SampleToggle.Text = " No ";
            else SampleToggle.Text = "Yes!";

        }

        private void ParkAutoClicked(object sender, EventArgs e)
        {

            if (ParkToggle.Text == "Yes!")
                ParkToggle.Text = " No ";
            else ParkToggle.Text = "Yes!";

        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            LanderMinerals.Text = string.Format("{0}", value);
            value = value * 5;
            ScoredLander.Text = string.Format("Scored {0} Points", value);
        }

        void OnStepperValueChanged2(object sender, ValueChangedEventArgs c)
        {
            double value2 = c.NewValue;
            DepotMinerals.Text = string.Format("{0}", value2);
            value2 = value2 * 2;
            ScoredDepot.Text = string.Format("Scored {0} Points", value2);
        }
    }
}
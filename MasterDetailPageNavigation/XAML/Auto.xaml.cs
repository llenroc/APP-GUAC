using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Auto : ContentPage
	{
		public Auto ()
		{
			InitializeComponent ();
		}

        private void buttonClicked(object sender, EventArgs e)
        {

            if (mybutton.Text == "Yes!")
                mybutton.Text = " No ";
            else mybutton.Text = "Yes!";

        }

        private void numberClicked(object sender, EventArgs e)
        {

            if (my2ndbutton.Text == "Yes!")
                my2ndbutton.Text = " No ";
            else my2ndbutton.Text = "Yes!";
            
        }

        private void thirdClicked(object sender, EventArgs e)
        {

            if (thirdButton.Text == "Yes!")
                thirdButton.Text = " No ";
            else thirdButton.Text = "Yes!";

        }

        private void fouredClicked(object sender, EventArgs e)
        {

            if (fouredButton.Text == "Yes!")
                fouredButton.Text = " No ";
            else fouredButton.Text = "Yes!";

        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            numberof.Text = string.Format("{0}", value);
            value = value * 5;
            pointsof.Text = string.Format("Scored {0} Points", value);
        }

        void OnStepperValueChanged2(object sender, ValueChangedEventArgs c)
        {
            double value2 = c.NewValue;
            numberof2.Text = string.Format("{0}", value2);
            value2 = value2 * 2;
            pointsof2.Text = string.Format("Scored {0} Points", value2);
        }
    }
}
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
	public partial class TeleOp : ContentPage
	{
		public TeleOp ()
		{
			InitializeComponent ();
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
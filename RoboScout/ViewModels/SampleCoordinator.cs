using System;

namespace RoboScout
{
	public class SampleCoordinator : ObservableObject
	{
		public static event EventHandler<SampleEventArgs> SelectedSampleChanged;
		public static event EventHandler<EventArgs> PresentMainMenuOnAppearance;
		public static event EventHandler<SampleEventArgs> SampleSelected;

		private static Sample _selectedSample;

		public static void RaisePresentMainMenuOnAppearance() 
		{
			PresentMainMenuOnAppearance?.Invoke(typeof(SampleCoordinator), null);
		}

		public static void RaiseSampleSelected(Sample sample) 
		{
			SampleSelected?.Invoke(typeof(SampleCoordinator), new SampleEventArgs(sample));
		}

		public static Sample SelectedSample
		{
			get
			{
				return _selectedSample;
			}

			set
			{
				if (_selectedSample != value) 
				{
					_selectedSample = value;

					SelectedSampleChanged?.Invoke(typeof(SampleCoordinator), new SampleEventArgs(value));
				}
			}
		}
	}
		
	public class SampleEventArgs : EventArgs 
	{
		public SampleEventArgs(Sample newSample)
		{
			Sample = newSample;
		}

		public Sample Sample { get; }
	}
}
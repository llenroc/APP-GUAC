using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RoboScout
{
	public class SampleCategory
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public Color BackgroundColor { get; set; }

		public String BackgroundImage { get; set; }

		public List<Sample> SamplesList { get; set; }

		public string Icon { get; set; }
	
		public int Badge { get; set; }
	}
}
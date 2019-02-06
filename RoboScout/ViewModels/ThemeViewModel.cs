using System;

namespace RoboScout
{
	public class ThemeViewModel
	{
		private readonly static DateTime MinDate = new DateTime(2000, 1, 1);
		private readonly static DateTime MaxDate = new DateTime(2050, 12, 31);

		public DateTime Now => DateTime.Now;

		public DateTime MinimumDate => MinDate;

		public DateTime MaximumDate => MaxDate;
	}
}
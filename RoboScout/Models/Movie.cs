namespace RoboScout
{
	public class Movie
	{
		public int Id { get; set; }
		
		public string Title { get; set; }

		public string Source { get; set; }

		public string Seasons { get; set; }

		public double RatingValue { get; set; }

		public double RatingMax { get; set; }
		
		public string Director { get; set; }

		public string Plot { get; set; }
		
		public string[] Cast { get; set; }
	}
}

namespace RoboScout
{
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string Price { get; set; }

		public string Image { get; set; }

		public double RatingValue { get; set; }

		public double RatingMax { get; set; }

		public string Manufacturer
		{
			get { return "UXDIVERS"; }
		}
	}
}


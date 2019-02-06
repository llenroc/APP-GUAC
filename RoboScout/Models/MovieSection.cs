using System.Collections.Generic;

namespace RoboScout
{
	public class MovieSection
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public List<Movie> Content { get; set; }
	}
}

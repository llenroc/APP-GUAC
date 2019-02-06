using System.ComponentModel;
using System.Collections.Generic;
using RoboScout.Resx;
using System.Globalization;
using System;
using System.Linq;

namespace RoboScout
{
	public class DashboardMultipleScrollPageViewModel : ObservableObject
	{
		private string _highlightMovieTitle;
		private string _highlightMovieDescription;
		private string _highlightMovieImage;
		private List<MovieSectionViewModel> _sections;

		public DashboardMultipleScrollPageViewModel()
			: base(listenCultureChanges: true)
		{
			LoadData();
		}

		public string HighlightMovieTitle
		{
			get { return _highlightMovieTitle; }
			set { SetProperty(ref _highlightMovieTitle, value); }
		}

		public string HighlightMovieDescription 
		{
			get { return _highlightMovieDescription; }
			set { SetProperty(ref _highlightMovieDescription, value); }
		}

		public string HighlightMovieImage 
		{
			get { return _highlightMovieImage; }
			set { SetProperty(ref _highlightMovieImage, value); }
		}

		public List<MovieSectionViewModel> Sections 
		{
			get { return _sections; }
			set { SetProperty(ref _sections, value); }
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			HighlightMovieTitle = DataResources.HighlightMovieTitle;
			HighlightMovieDescription = DataResources.HighlightMovieDescription;
			HighlightMovieImage = "http://ia.media-imdb.com/images/M/MV5BYWRhMjlmNGUtYTIwYS00OTYyLThjYmMtMTU2MWU3MmRhNGNkXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_SY1000_SX1500_AL_.jpg";

			var movieSections = new List<MovieSectionViewModel>();

			foreach (var movieSection in SampleData.Movies)
			{
				movieSections.Add(new MovieSectionViewModel(movieSection));
			}

			Sections = movieSections;
		}
	}

	public class MovieSectionViewModel : ObservableObject 
	{
		public MovieSectionViewModel(MovieSection section, bool related = false)
		{
			Title = related ? string.Format(AppResources.StringMoreFrom, section.Title) : section.Title;

			var content = new List<MovieViewModel>();

			foreach (var m in section.Content)
			{
				content.Add(new MovieViewModel(m, section));
			}

			Content = content;
		}

		public string Title { get; private set; }

		public List<MovieViewModel> Content { get; private set; }
	}

	public class MovieViewModel : ObservableObject
	{
		private Movie _movie;
		private MovieSection _movieSection;
		private MovieSectionViewModel _movieSectionViewModel;

		public MovieViewModel(Movie movie, MovieSection section)
			: base(listenCultureChanges: true)
		{
			_movie = movie;
			_movieSection = section; 
		}

		public string Title => _movie.Title;
		public string Source => _movie.Source;
		public string Seasons => _movie.Seasons;
		public double RatingValue => _movie.RatingValue;
		public double RatingMax => _movie.RatingMax;
		public string Director => _movie.Director;
		public string Plot => _movie.Plot;
		public string[] Cast => _movie.Cast;

		public MovieSectionViewModel Section 
		{ 
			get
			{
				if (_movieSectionViewModel == null)
				{
					_movieSectionViewModel = new MovieSectionViewModel(_movieSection, related: true);
				}

				return _movieSectionViewModel; 
			}
		}

		protected override void OnCultureChanged(CultureInfo culture)
		{
			LoadData();
		}

		private void LoadData()
		{
			_movieSection = SampleData.Movies.FirstOrDefault(x => x.Id == _movieSection.Id);
			if (_movieSection != null)
			{
				_movie = _movieSection.Content.FirstOrDefault(x => x.Id == _movie.Id);
				_movieSectionViewModel = null;

				NotifyAllPropertiesChanged();
			}
		}
	}
}
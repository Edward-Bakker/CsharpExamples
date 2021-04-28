using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DatabindingExample
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// This is the propertychanged event databindings listen to.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The private movieList. This list can only be updated internally or via the designated property in MovieList.
        /// </summary>
        private List<Movie> movieList = new List<Movie>();

        /// <summary>
        /// A selected movie (updated via binding).
        /// </summary>
        private Movie selectedMovie;

        /// <summary>
        /// The Public MovieList property. This property has no real value as it uses the private movieList as its datastorage.
        /// </summary>
        public List<Movie> MovieList
        {
            get { return movieList; }
            set
            {
                movieList = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Public SelectedMovie property. This property has no real value as it uses the private movieList as its datastorage.
        /// </summary>
        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Constructor for MainWindowViewModel
        /// </summary>
        public MainWindowViewModel()
        {
            movieList = MovieFactory.CreateRandomMoviesList();
        }

        /// <summary>
        /// The important notifier method of changed properties. This function should be called whenever you want to inform other classes that some property has changed.
        /// </summary>
        /// <param name="propertyName">The name of the updated property. Leaving this blank will fill in the name of the calling property.</param>
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

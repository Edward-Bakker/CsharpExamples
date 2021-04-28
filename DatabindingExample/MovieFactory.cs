using System;
using System.Collections.Generic;
using System.Text;

namespace DatabindingExample
{
    class MovieFactory
    {
        /// <summary>
        /// Create a "random" list of movies (predefined) to test with.
        /// </summary>
        /// <returns>A list containing some movies.</returns>
        public static List<Movie> CreateRandomMoviesList()
        {
            List<Movie> l = new List<Movie>();
            l.Add(new Movie("Mad Max", "Action"));
            l.Add(new Movie("Deadpool", "Comedy", new Uri("https://fanart.tv/fanart/movies/293660/movieposter/deadpool-56948e5115048.jpg"))); //Uri's might die over time, replace them if needed
            l.Add(new Movie("Dracula", "Horror"));
            l.Add(new Movie("The Matrix", "Sci-Fi", new Uri("https://c1.staticflickr.com/9/8819/17072638696_f871731849_b.jpg"))); //Uri's might die over time, replace them if needed
            return l;
        }
    }
}

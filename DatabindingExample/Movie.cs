using System;
using System.Collections.Generic;
using System.Text;

namespace DatabindingExample
{
    /// <summary>
    /// Contains all the information regarding a single movie
    /// </summary>
    class Movie
    {
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public Uri ImageLocation { get; private set; }

        private int rating = 0;
        public int Rating
        {
            get { return rating; }
            set
            {
                if (value > 0 && value < 11)
                    rating = value;
            }
        }



        public Movie(string Title, string Genre)
        {
            this.Title = Title;
            this.Genre = Genre;
        }

        public Movie(string Title, string Genre, Uri ImageLocation)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.ImageLocation = ImageLocation;
        }
    }
}

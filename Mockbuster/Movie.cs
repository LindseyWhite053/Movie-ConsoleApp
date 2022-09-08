using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockbuster
{
    public class Movie
    {
        // Fields: Movie Name, Main Actor, Genre, Director
        public string MovieTitle { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        // Include constructor that assigns values to each property
        public Movie(string movieTitle, string mainActor, string genre, string director)
        {
            MovieTitle = movieTitle;
            MainActor = mainActor;
            Genre = genre;
            Director = director;
        }

        // Include an overriden ToString to include a formatted string of: Movie Name, Main Actor, Genre, and Director
        public override string ToString()
        {
            return $"{MovieTitle} starring {MainActor} ({Genre}), Directed by {Director}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockbuster
{
    public class MovieRepo
    {
        // houses the repository of movie in the application 
        public static List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            return movies;
        }
    }
}

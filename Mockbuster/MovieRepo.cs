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
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont", 1994, "R", 142, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola", 1972, "R", 175, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson", 2001, "PG-13", 178, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson", 2003, "PG-13", 201, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan", 2008, "PG-13", 152, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
            };

            return movies;
        }
    }
}

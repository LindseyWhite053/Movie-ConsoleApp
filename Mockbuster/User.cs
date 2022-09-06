using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockbuster
{
    public class User
    {

        public static void ViewMovies(List<Movie> theList)
        {

            foreach (Movie m in theList)
            {
                Console.WriteLine(m);
            }

        }

        // filters a list by movie title. Returns a list of movies of only those movie names. 
        public static List<Movie> FindTitle(List<Movie> theList, string search)
        {
            List<Movie> filteredList = new List<Movie>();

            foreach (Movie m in theList)
            {
                if (m.MovieTitle.ToLower().Contains(search.ToLower()))
                {
                    filteredList.Add(m);
                }
            }

            return filteredList;
        }

        // filters a list by genre title. Returns a list of movies of only those genre. 
        public static List<Movie> FindGenre(List<Movie> theList, string search)
        {
            List<Movie> filteredList = new List<Movie>();

            foreach (Movie m in theList)
            {
                if (m.Genre.ToLower().Contains(search.ToLower()))
                {
                    filteredList.Add(m);
                }
            }

            return filteredList;
        }

        // filters a list by main actor. Returns a list of movies of only the referenced main actor. 
        public static List<Movie> FindMainActor(List<Movie> theList, string search)
        {
            List<Movie> filteredList = new List<Movie>();

            foreach (Movie m in theList)
            {
                if (m.MainActor.ToLower().Contains(search.ToLower()))
                {
                    filteredList.Add(m);
                }
            }

            return filteredList;

        }

        // filters a list by director. Returns a list of movies with the specified director. 
        public static List<Movie> FindDirector(List<Movie> theList, string search)
        {
            List<Movie> filteredList = new List<Movie>();

            foreach (Movie m in theList)
            {
                if (m.Director.ToLower().Contains(search.ToLower()))
                {
                    filteredList.Add(m);
                }
            }

            return filteredList;
        }
    }
}

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

            for (int i = 0; i < theList.Count; i++)
            {
                Console.WriteLine($"({i+1}) {theList[i]}");
            }

        }

        public static void ViewMenu()
        {
            Console.WriteLine("User Menu");
            Console.WriteLine("(1) View All Movies");
            Console.WriteLine("(2) Find a movie by title.");
            Console.WriteLine("(3) Find a movie by genre.");
            Console.WriteLine("(4) Find a movie by lead actor/actress.");
            Console.WriteLine("(5) Find a movie by director.");

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

            if (filteredList.Count > 0)
            {
                Console.WriteLine("Movies that fit your search: ");
                User.ViewMovies(filteredList);
            }
            else
            {
                Console.WriteLine($"Unable to find any movies with the title {search}. ");
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

            if (filteredList.Count > 0)
            {
                Console.WriteLine("Movies that fit your search: ");
                User.ViewMovies(filteredList);
            }
            else
            {
                Console.WriteLine($"Unable to find any movies with the genre {search}. ");
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

            if (filteredList.Count > 0)
            {
                Console.WriteLine("Movies that fit your search: ");
                User.ViewMovies(filteredList);
            }
            else
            {
                Console.WriteLine($"Unable to find any movies with the lead actor/actress {search}. ");
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

            if (filteredList.Count > 0)
            {
                Console.WriteLine("Movies that fit your search: ");
                User.ViewMovies(filteredList);
            }
            else
            {
                Console.WriteLine($"Unable to find any movies with the director {search}. ");
            }


            return filteredList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockbuster
{
    public class User
    {
        public static void ViewMenu()
        {
            Console.Clear();

            string userMenuLine1 = "╔════════════════════════════════╗	";
            string userMenuLine2 = "║	       User Menu           ║	";
            string userMenuLine3 = "╚════════════════════════════════╝	";
            Console.SetCursorPosition((Console.WindowWidth - userMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(userMenuLine1);
            Console.SetCursorPosition((Console.WindowWidth - userMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(userMenuLine2);
            Console.SetCursorPosition((Console.WindowWidth - userMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(userMenuLine3);

            Console.SetCursorPosition((Console.WindowWidth - userMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(1) View all movies.");
            Console.SetCursorPosition((Console.WindowWidth - userMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(2) Find a movie by title.");
            Console.SetCursorPosition((Console.WindowWidth - userMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(3) Find a movie by genre.");
            Console.SetCursorPosition((Console.WindowWidth - userMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(4) Find a movie by lead actor/actress.");
            Console.SetCursorPosition((Console.WindowWidth - userMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(5) Find a movie by director.");

        }

        public static void ViewMovies(List<Movie> theList)
        {

            for (int i = 0; i < theList.Count; i++)
            {
                Console.WriteLine($"({i+1}) {theList[i]}");
            }

        }

        public static int FindIndex(List<Movie> theList, string search)
        {
            int movieIndex = -1;
            for (int i = 0; i < theList.Count; i++)
            {
                if (search == theList[i].MovieTitle)
                {
                    movieIndex = i;
                }
            }
            return movieIndex;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockbuster
{
    public class Admin : User
    {
        public static void ViewMenu()
        {
            Console.WriteLine();
            string adminMenuLine1 = "╔════════════════════════════════╗	";
            string adminMenuLine2 = "║	   Administrator Menu      ║	";
            string adminMenuLine3 = "╚════════════════════════════════╝	";
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(adminMenuLine1);
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(adminMenuLine2);
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(adminMenuLine3);

            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(1) View all movies.");
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(2) Find a movie by title.");
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(3) Find a movie by genre.");
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(4) Find a movie by lead actor/actress.");
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(5) Find a movie by director.");
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(6) Add a movie.");
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(7) Edit an existing movie.");
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine("(8) Remove an existing movie.");
            Console.SetCursorPosition((Console.WindowWidth - adminMenuLine1.Length) / 2, Console.CursorTop);

        }

        // Admin should have the ability to add, update, and delete movies from the repository. 
        public static bool AddMovie(List<Movie> thelist, string title, string mainActor, string genre, string director)
        {

            thelist.Add(new Movie(title, mainActor, genre, director));
            Console.WriteLine($"Your movie has been added");
            return true;
        }

        public static void UpdateMovie(List<Movie> theList, int index, string attribute, string newText, int newYear, int newTime)
        {
            // using  the list, index number, attribute name, and new string update the attribute according to the users input
            if (attribute == "title")
            {
                theList[index-1].MovieTitle = newText;
            }
            else if (attribute == "actor")
            {
                theList[index - 1].MainActor = newText;
            }
            else if (attribute == "genre")
            {
                theList[index - 1].Genre = newText;
            }
            else if (attribute == "director")
            {
                theList[index - 1].Director = newText;
            }
            else if (attribute == "year")
            {
                theList[index - 1].Year = newYear;
            }
            else if (attribute == "rating")
            {
                theList[index - 1].Rating = newText;
            }
            else if (attribute == "run time" || attribute == "time")
            {
                theList[index - 1].RunTime = newTime;
            }
            else if (attribute == "description" || attribute == "desc")
            {
                theList[index - 1].Description = newText;
            }

            Console.WriteLine($"Your movie has been updated to");
            theList[index - 1].ViewInfo();

        }

        // Removes the admin selected movie from the movie repository 
        public static void RemoveMovie(List<Movie> theList, int index)
        {
            // using  the list, index number delete the movie
            theList.RemoveAt(index);

            Console.WriteLine("Your selection has been removed from the list of movies.");

        }
    }
}

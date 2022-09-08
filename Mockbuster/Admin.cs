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
            Console.WriteLine("Administrator Menu");
            Console.WriteLine("(1) View All Movies");
            Console.WriteLine("(2) Find a movie by title.");
            Console.WriteLine("(3) Find a movie by genre.");
            Console.WriteLine("(4) Find a movie by lead actor/actress.");
            Console.WriteLine("(5) Find a movie by director.");
            Console.WriteLine("(6) Add a movie.");
            Console.WriteLine("(7) Edit an existing movie.");
            Console.WriteLine("(8) Remove an existing movie.");

        }

        // Admin should have the ability to add, update, and delete movies from the repository. 
        public static bool AddMovie(List<Movie> thelist, string title, string mainActor, string genre, string director)
        {
            
            bool found = false;

            foreach (Movie movie in thelist)
            {
                if (movie.MovieTitle == title)
                {
                    found = true;
                }
            }

            if (found == true)
            {
                Console.WriteLine("That movie already exists");
                return false;
            } 
            else
            {
                thelist.Add(new Movie(title, mainActor, genre, director));
                Console.WriteLine($"Your movie has been added");
                return true;
            }

        }

        public static void DisplayAttributes(List<Movie> theList, int index)
        {
            // - using the list and index number display the attributes and ask which one they would like to edit
            Console.WriteLine($"Title: {theList[index - 1].MovieTitle}");
            Console.WriteLine($"Actor: {theList[index - 1].MainActor}");
            Console.WriteLine($"Genre: {theList[index - 1].Genre}");
            Console.WriteLine($"Director: {theList[index - 1].Director}");
        }


        public static void UpdateMovie(List<Movie> theList, int index, string attribute, string newText)
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
            else
            {
                theList[index - 1].Director = newText;
            }

            Console.WriteLine($"Your movie has been updated to {theList[index-1]}");

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

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
        public int Year { get; set; }
        public string Rating { get; set; }
        public int RunTime { get; set; }
        public string Description { get; set; }

        // Include constructor that assigns values to each property
        public Movie(string movieTitle, string mainActor, string genre, string director)
        {
            MovieTitle = movieTitle;
            MainActor = mainActor;
            Genre = genre;
            Director = director;
            Year = 0;
            Rating = "TBD";
            RunTime = 0;
            Description = "TBD";

        }

        public Movie(string movieTitle, string mainActor, string genre, string director, int year, string rating, int runtime, string description)
        {
            MovieTitle = movieTitle;
            MainActor = mainActor;
            Genre = genre;
            Director = director;
            Year = year;
            Rating = rating;
            RunTime = runtime;
            Description = description;

        }

        // Method to view all additional info
        public void ViewInfo()
        {
            if (Description == "TBD")
            {
                Console.WriteLine("No additional information is available for this movie.");
            }
            else
            {
                Console.WriteLine($"{MovieTitle} ({Year})");
                Console.WriteLine($"Genre: {Genre}");
                Console.WriteLine($"Run time: {RunTime} minutes");
                Console.WriteLine($"Rated: {Rating}");
                Console.WriteLine($"Starring: {MainActor}");
                Console.WriteLine($"Directed by: {Director}");
                Console.WriteLine($"Description: \n{Description}");
            }
        }

        // Include an overriden ToString to include a formatted string of: Movie Name, Main Actor, Genre, and Director
        public override string ToString()
        {
            return $"{MovieTitle} starring {MainActor} ({Genre}), Directed by {Director}";
        }


    }
}

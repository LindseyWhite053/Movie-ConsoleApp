using Mockbuster;

namespace Mockbuster_Tests
{
    public class User_Tests
    {
        // Unit testing 
        // Include at least one effective unit test on each of the dollowing methods: 
        // User Class Methods 
        // filter by movie 
        // filter by main actor
        // Filter by director 

        [Fact]
        public void Test1()
        {

        }
    }

    public class Admin_Tests
    {
        //Admin Class Methods
        // Add 
        // Edit
        // Remove

        [Fact]
        public void Test1()
        {

        }
    }

    public class MovieRepo_Tests
    {
        //Repository Method 
        //Get all movies

        [Fact]
        public void TestMovieRepo()
        {
            List<Movie> expectedList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            List<Movie> actualList = MovieRepo.GetMovies();

            Assert.Equal(expectedList, actualList);
        }
    }
}
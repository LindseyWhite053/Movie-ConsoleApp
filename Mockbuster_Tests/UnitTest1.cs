using Mockbuster;


namespace Mockbuster_Tests
{
    public class User_Tests
    {
        // FindMovie() tests

        [Fact]
        public void TestFindTitleLowerCase()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "the godfather";

            List<Movie> actualList = User.FindTitle(testList, testInput);

            Assert.Equal("The Godfather", actualList[0].MovieTitle);
        }

        [Fact]
        public void TestFindTitleShortened()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "father";

            List<Movie> actualList = User.FindTitle(testList, testInput);

            Assert.Equal("The Godfather", actualList[0].MovieTitle);
        }


        [Fact]
        public void TestFindTitleMultipleResults()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "The";

            List<Movie> actualList = User.FindTitle(testList, testInput);


            Assert.Equal("The Dark Knight", actualList[4].MovieTitle);
        }


        //FindGenre() Tests
        [Fact]
        public void TestFindGenreAdventure0()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "Adventure";

            List<Movie> actualList = User.FindGenre(testList, testInput);

            Assert.Equal("The Lord of the Rings: The Fellowship of the Ring", actualList[0].MovieTitle);
        }


        [Fact]
        public void TestFindGenreAdventure1()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "Adventure";

            List<Movie> actualList = User.FindGenre(testList, testInput);

            Assert.Equal("The Lord of the Rings: Return of the King", actualList[1].MovieTitle);
        }


        [Fact]
        public void TestFindGenreDrama0()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "Drama";

            List<Movie> actualList = User.FindGenre(testList, testInput);


            Assert.Equal("The Shawshank Redemption", actualList[0].MovieTitle);
        }

        [Fact]
        public void TestFindGenreDrama1()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "Drama";

            List<Movie> actualList = User.FindGenre(testList, testInput);


            Assert.Equal("The Godfather", actualList[1].MovieTitle);
        }

        // FindMainActor() Tests
        [Fact]
        public void TestFindMainActor()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "Tim Robbins";

            List<Movie> actualList = User.FindMainActor(testList, testInput);


            Assert.Equal("The Shawshank Redemption", actualList[0].MovieTitle);
        }

        // FindDirector() tests
        [Fact]
        public void TestFindDirector()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "Christopher Nolan";

            List<Movie> actualList = User.FindDirector(testList, testInput);

            Assert.Equal("The Dark Knight", actualList[0].MovieTitle);
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

        [Fact]
        public void TestMovieRepoMovieTitle()
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

            Assert.Equal(expectedList[0].MovieTitle, actualList[0].MovieTitle);

        }

        [Fact]
        public void TestMovieRepoActor()
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

            Assert.Equal(expectedList[0].MainActor, actualList[0].MainActor);

        }

        [Fact]
        public void TestMovieRepoGenre()
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

            Assert.Equal(expectedList[0].Genre, actualList[0].Genre);

        }

        [Fact]
        public void TestMovieRepoDirectors()
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

            Assert.Equal(expectedList[0].Director, actualList[0].Director);

        }

        [Fact]
        public void TestMovieRepoLastIndexDirectors()
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

            Assert.Equal(expectedList[4].Director, actualList[4].Director);

        }
    }
}
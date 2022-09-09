using Mockbuster;

namespace Mockbuster_Tests
{
    public class MovieRepo_Tests
    {

        [Fact]
        public void TestMovieRepoMovieTitle1()
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

            Assert.Contains<Movie>(actualList, item =>
                {
                    return item.MovieTitle == "The Shawshank Redemption";
                });

        }

        [Fact]
        public void TestMovieRepoMovieTitle2()
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

            Assert.Contains<Movie>(actualList, item =>
            {
                return item.MovieTitle == "The Dark Knight";
            });

        }

        [Fact]
        public void TestMovieRepoMainActor()
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

            Assert.Contains<Movie>(actualList, item =>
            {
                return item.MainActor == "Marlon Brando";
            });

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

            Assert.Contains<Movie>(actualList, item =>
            {
                return item.Genre == "Adventure";
            });

        }

        [Fact]
        public void TestMovieRepoDirector()
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

            Assert.Contains<Movie>(actualList, item =>
            {
                return item.Director == "Peter Jackson";
            });

        }
    }

    public class User_Tests
    {

        //FindIndex() tests
        [Fact]
        public void TestFindIndex0()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "The Shawshank Redemption";

            int actual = User.FindIndex(testList, testInput);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void TestFindIndex4()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testInput = "The Dark Knight";

            int actual = User.FindIndex(testList, testInput);

            Assert.Equal(4, actual);
        }


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

        // AddMovie() tests
        [Fact]
        public void TestAddMovieTrue()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testTitle = "Little Miss Sunshine";
            string testActor = "Steve Carell";
            string testGenre = "Comedy";
            string testDirector = "Jonathan Dayton";

            bool actual = Admin.AddMovie(testList, testTitle, testActor, testGenre, testDirector);

            Assert.True(actual);

        }

        [Fact]
        public void TestAddMovie()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            string testTitle = "Little Miss Sunshine";
            string testActor = "Steve Carell";
            string testGenre = "Comedy";
            string testDirector = "Jonathan Dayton";

            bool actual = Admin.AddMovie(testList, testTitle, testActor, testGenre, testDirector);

            Assert.Equal("Little Miss Sunshine", testList[5].MovieTitle);
            Assert.True(actual);

        }

        // UpdateMovie() tests

        [Fact]
        public void TestUpdateMovieTitle()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            int index = 1;

            Admin.UpdateMovie(testList, index, "title", "Shawshank Redemption", 0, 0);

            Assert.Equal("Shawshank Redemption", testList[0].MovieTitle);
        }

        [Fact]
        public void TestUpdateMovieActor()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            int index = 1;

            Admin.UpdateMovie(testList, index, "actor", "Morgan Freeman", 0, 0);

            Assert.Equal("Morgan Freeman", testList[0].MainActor);
        }

        [Fact]
        public void TestUpdateMovieGenre()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            int index = 2;

            Admin.UpdateMovie(testList, index, "genre", "Crime", 0, 0);

            Assert.Equal("Crime", testList[1].Genre);
        }

        [Fact]
        public void TestUpdateMovieDirector()
        {
            List<Movie> testList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Francis Ford Coppola"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            int index = 2;

            Admin.UpdateMovie(testList, index, "genre", "Frank Darabont", 0, 0);

            Assert.Equal("Frank Darabont", testList[1].Genre);
        }

        [Fact]
        public void TestUpdateMovieYear()
        {
            List<Movie> testList = new List<Movie>
            {
               new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont", 1994, "R", 142, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola", 2001, "R", 175, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson", 2001, "PG-13", 178, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson", 2003, "PG-13", 201, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan", 2008, "PG-13", 152, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
            };

            int index = 2;

            Admin.UpdateMovie(testList, index, "year", "", 1972, 0);

            Assert.Equal(1972, testList[1].Year);
        }

        [Fact]
        public void TestUpdateMovieRating()
        {
            List<Movie> testList = new List<Movie>
            {
               new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont", 1994, "R", 142, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola", 2001, "PG-13", 175, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson", 2001, "PG-13", 178, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson", 2003, "PG-13", 201, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan", 2008, "PG-13", 152, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
            };

            int index = 2;

            Admin.UpdateMovie(testList, index, "rating", "R", 0, 0);

            Assert.Equal("R", testList[1].Rating);
        }

        [Fact]
        public void TestUpdateMovieRunTime()
        {
            List<Movie> testList = new List<Movie>
            {
               new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont", 1994, "R", 142, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola", 2001, "PG-13", 175, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson", 2001, "PG-13", 178, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson", 2003, "PG-13", 201, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan", 2008, "PG-13", 152, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
            };

            int index = 2;

            Admin.UpdateMovie(testList, index, "run time", "", 0, 200);

            Assert.Equal(200, testList[1].RunTime);
        }

        [Fact]
        public void TestUpdateMovieRunTime2()
        {
            List<Movie> testList = new List<Movie>
            {
               new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont", 1994, "R", 142, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola", 2001, "PG-13", 175, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson", 2001, "PG-13", 178, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson", 2003, "PG-13", 201, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan", 2008, "PG-13", 152, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
            };

            int index = 2;

            Admin.UpdateMovie(testList, index, "time", "", 0, 300);

            Assert.Equal(300, testList[1].RunTime);
        }


        [Fact]
        public void TestUpdateMovieDescription()
        {
            List<Movie> testList = new List<Movie>
            {
               new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont", 1994, "R", 142, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola", 2001, "R", 175, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson", 2001, "PG-13", 178, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson", 2003, "PG-13", 201, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan", 2008, "PG-13", 152, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
            };

            int index = 2;

            Admin.UpdateMovie(testList, index, "description", "New Description", 0, 0);

            Assert.Equal("New Description", testList[1].Description);
        }

        [Fact]
        public void TestUpdateMovieDescription2()
        {
            List<Movie> testList = new List<Movie>
            {
               new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont", 1994, "R", 142, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola", 2001, "R", 175, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson", 2001, "PG-13", 178, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson", 2003, "PG-13", 201, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan", 2008, "PG-13", 152, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
            };

            int index = 2;

            Admin.UpdateMovie(testList, index, "desc", "New Description", 0, 0);

            Assert.Equal("New Description", testList[1].Description);
        }

        // RemoveMovie() tests

        [Fact]
        public void TestRemoveMovie0()
        {
            List<Movie> actualList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            Admin.RemoveMovie(actualList, 0);

            Assert.DoesNotContain<Movie>(actualList, item =>
            {
                return item.MovieTitle == "The Shawshank Redemption";
            });
        }

        [Fact]
        public void TestRemoveMovieIndex3()
        {
            List<Movie> actualList = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Tim Robbins", "Drama", "Frank Darabont"),
                new Movie("The Godfather", "Marlon Brando", "Crime Drama", "Francis Ford Coppola"),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Lord of the Rings: Return of the King", "Elijah Wood", "Adventure", "Peter Jackson"),
                new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan")
            };

            //Passed in as the number on the list. 
            Admin.RemoveMovie(actualList, 3);

            Assert.DoesNotContain<Movie>(actualList, item =>
            {
                return item.MovieTitle == "The Lord of the Rings: Return of the King";
            });
        }

    }

}
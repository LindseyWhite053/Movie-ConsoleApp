using Mockbuster;

List<Movie> Movies = MovieRepo.GetMovies();

MainLibrary.WelcomeMessage();

Console.Write("Are you a \"user\" or an \"administrator\"? ");
string userType = Console.ReadLine().ToLower().Trim();

while (true)
{
    if (userType == "user")
    {
        break;

    } else if (userType == "administrator" || userType == "admin")
    {
        userType = "admin";
        break;
    }
    else
    {
        Console.Write("Please enter \"user\" or an \"administrator\": ");
        userType = Console.ReadLine().ToLower().Trim();
    }
}

bool keepGoing = true;
while (keepGoing == true)
{

    if (userType == "user")
    {
        User.ViewMenu();
    }
    else if (userType == "admin")
    {
        Admin.ViewMenu();
    }

    Console.Write("\nWhat would you like to do?(select by number): ");
    string input;
    int num;

    while (true)
    {
        int.TryParse(Console.ReadLine().Trim(), out num);
        if ((userType == "user") && (num > 0) && (num < 6))
        {
            break;
        }
        else if ((userType == "admin") && (num > 0) && (num < 9))
        {
            break;
        }
        else
        {
            Console.Write("Please enter a valid selection: ");
        }
    }


    string text;
    string yesNo;
    List<Movie> newList;
    DateTime now = DateTime.Now;
    int todayYear = now.Year;
    switch (num)
    {
        case 1:
            // View all movies
            Console.WriteLine("All Movies:");
            User.ViewMovies(Movies);

            // Ask the user if they would like to view additional information about the movie
            Console.Write("\nWould you like to view additional information about a movie(y/n): ");
            yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

                if (yesNo == "yes")
                {

                    do {
                        Movie.ViewMovieFromList(Movies);    

                        Console.Write("\nWould you like information on another movie(y/n): ");

                        yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

                    } while (MainLibrary.GoAgain(yesNo));
                }

            break;

        case 2:
            //Find a movie by title
            do
            {
                Console.Write("\nEnter the movie title: ");
                text = Console.ReadLine().Trim();
                newList = User.FindTitle(Movies, text);

                if (newList.Count > 0)
                {
                    Console.WriteLine("Movies that fit your search: ");
                    User.ViewMovies(newList);

                    // Ask the user if they would like to view additional information about the movie
                    Console.Write("\nWould you like to view additional information about a movie(y/n): ");
                    yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());


                    if (yesNo == "yes")
                    {
                        Movie.ViewMovieFromList(newList);
                    }
                }
                else
                {
                    Console.WriteLine($"Unable to find any movies with the title {text}. ");
                }

                Console.Write("\nWould you like to find another movie by title(y/n): ");

                yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

            } while (MainLibrary.GoAgain(yesNo));           
            break;

        case 3:
            //find a movie by genre
            do { 
                Console.Write("\nEnter the movie genre: ");
                text = Console.ReadLine().Trim();
                newList = User.FindGenre(Movies, text);

                if (newList.Count > 0)
                {
                    Console.WriteLine("Movies that fit your search: ");
                    User.ViewMovies(newList);

                    // Ask the user if they would like to view additional information about the movie
                    Console.Write("\nWould you like to view additional information about a movie(y/n): ");
                    yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());


                    if (yesNo == "yes")
                    {

                        Movie.ViewMovieFromList(newList);

                    }
                }
                else
                {
                    Console.WriteLine($"Unable to find any movies with the genre {text}. ");
                }

                Console.Write("\nWould you like to find another movie by genre(y/n): ");

                yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

            } while (MainLibrary.GoAgain(yesNo));
            break;

        case 4:
            do { 
                // find a movie by lead actor/actress
                Console.Write("\nEnter the movie's lead actor/actress: ");
                text = Console.ReadLine().Trim();
                newList = User.FindMainActor(Movies, text);

                if (newList.Count > 0)
                {
                    Console.WriteLine("Movies that fit your search: ");
                    User.ViewMovies(newList);

                    // Ask the user if they would like to view additional information about the movie
                    Console.Write("\nWould you like to view additional information about a movie(y/n): ");
                    yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());


                    if (yesNo == "yes")
                    {

                        Movie.ViewMovieFromList(newList);

                    }
                }
                else
                {
                    Console.WriteLine($"Unable to find any movies with the lead actor/actress {text}. ");
                }


                Console.Write("\nWould you like to find another movie by lead actor/actress(y/n): ");

                yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

            } while (MainLibrary.GoAgain(yesNo));

            break;

        case 5:
            do { 
                //find movie by director
                Console.Write("\nEnter the movie's director: ");
                text = Console.ReadLine().Trim();
                newList = User.FindDirector(Movies, text);

                if (newList.Count > 0)
                {
                    Console.WriteLine("Movies that fit your search: ");
                    User.ViewMovies(newList);

                    // Ask the user if they would like to view additional information about the movie
                    Console.Write("\nWould you like to view additional information about a movie(y/n): ");
                    yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());


                    if (yesNo == "yes")
                    {

                        Movie.ViewMovieFromList(newList);
                    }
                }
                else
                {
                    Console.WriteLine($"Unable to find any movies with the director {text}. ");
                }

                Console.Write("\nWould you like to find another movie by director(y/n): ");

                yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

            } while (MainLibrary.GoAgain(yesNo));
            break;

        case 6:
            do { 
                // Add a new movie to the repository 
                Console.Write("\nEnter the new movie title: ");
                string title = Console.ReadLine().Trim();

                List<Movie> existingMovies = User.FindTitle(Movies, title);
                bool exists = false;

                if (existingMovies.Count > 0)
                {
                    Console.WriteLine("The following movies are similar to your new movie title: ");
                    foreach (Movie m in existingMovies)
                    {
                        Console.WriteLine(m);
                    }

                    Console.WriteLine("\nDoes this list include the movie you are trying to add(y/n): ");
                    string answer = Console.ReadLine().ToLower().Trim();

                    answer = MainLibrary.YesNo(answer);

                    if (answer == "yes")
                    {
                        exists = true;
                     
                    }
                }


                if (exists == true)
                {
                    Console.WriteLine("That movie already exists. A duplicate should not be added. ");

                }
                else if (exists == false)
                {
                    Console.Write("Enter the lead actor/actress name: ");
                    string actor = Console.ReadLine().Trim();

                    Console.Write("Enter the movie genre: ");
                    string genre = Console.ReadLine().Trim();

                    Console.Write("Enter the movie director: ");
                    string director = Console.ReadLine().Trim();

                    // Prompt the user to add additional information to the movie
                    Console.Write("Would you like to add additional information such as the year released, rating, run time, and description at this time?\n(y/n): ");
                    yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

                    Movie newMovie;
                    if (yesNo == "yes")
                    {
                        Console.Write("Enter the year your movie was released: ");
                        int year;
                        while (true)
                        {
                            int.TryParse(Console.ReadLine().Trim(), out year);

                            if ((year >= 1878) && (year <= todayYear))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Please enter a valid year: ");
                            }
                        }

                        Console.Write("Enter the movie rating: ");
                        string rating = Console.ReadLine().Trim();

                        Console.Write("Enter the your movie's runtime in minutes: ");
                        int runTime;

                        while (true)
                        {
                            int.TryParse(Console.ReadLine().Trim(), out runTime);

                            if ((runTime > 3))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Please enter the run time in minutes: ");
                            }
                        }

                        Console.Write("Enter the movie decription: ");
                        string description = Console.ReadLine().Trim();

                        newMovie = new Movie(title, actor, genre, director, year, rating, runTime, description);

                        Console.WriteLine($"\nYour new movie is: ");
                        newMovie.ViewInfo();
                        Console.Write($"\nWould you like to add {newMovie} to the movie list(y/n)? ");

                    }
                    else
                    {
                        newMovie = new Movie(title, actor, genre, director);

                        Console.Write($"\nWould you like to add {newMovie} to the movie list(y/n)? ");
                    }
                
                    yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());


                    if (yesNo == "yes")
                    {
                        Movies.Add(newMovie);
                    }
                    else if (yesNo == "no")
                    {
                        Console.WriteLine("This movie has not been added.");
                    }
                }

                Console.Write("\nWould you like to add another movie(y/n): ");

                yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

            } while (MainLibrary.GoAgain(yesNo));
            break;

        case 7:
            do { 
                // Edit an existing movie in the Movie Repository 
                Console.Write("\nEnter the title of the movie you would like to update: ");
                text = Console.ReadLine().ToLower().Trim();

                // using their input search the list to display a list of movies they would like and have them select by number 
                newList = User.FindTitle(Movies, text);

                if (newList.Count > 0)
                {
                    Console.WriteLine("Movies that fit your search: ");
                    User.ViewMovies(newList);
                    Console.Write("\nWhich movie would you like to edit(select by number): ");

                    while (true)
                    {
                        int.TryParse(Console.ReadLine().Trim(), out num);

                        if ((num > 0) && (num <= newList.Count))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Please enter a valid selection: ");
                        }
                    }

                    Console.WriteLine($"\nYou have selected:");
                    newList[num - 1].ViewInfo();
                    Console.Write("\nWould you like to continue with editing(y/n): ");
                    yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

                    if (yesNo == "yes")
                    {
                        // Display the selected movie info and ask which one they would like to edit
                        Console.Write("\nWhich attribute would you like to update \"title\", \"year\", \"genre\", \"run time\", \"rating\", \"actor\", \"director\", \"description\": ");
                        input = Console.ReadLine().ToLower().Trim();

                        string newText = "";
                        int newYear = 0;
                        int newRunTime = 0;
                        while (true)
                        {
                            if (input == "title")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].MovieTitle}\": ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1].MovieTitle}\" title will be updated to \"{newText}\"");
                                break;
                            }
                            else if (input == "actor" || input == "actress")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].MainActor}\": ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1].MovieTitle}\" lead actor/acress will be updated to \"{newText}\"");
                                break;
                            }
                            else if (input == "genre")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].Genre}\": ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1].MovieTitle}\" genre will be updated to \"{newText}\"");
                                break;
                            }
                            else if (input == "director")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].Director}\": ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1].MovieTitle}\" director will be updated to \"{newText}\"");
                                break;
                            }
                            else if (input == "year")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].Year}\": ");

                                while (true)
                                {
                                    int.TryParse(Console.ReadLine().Trim(), out newYear);

                                    if ((newYear >= 1878) && (newYear <= todayYear))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("Please enter a valid year: ");
                                    }
                                }

                                Console.WriteLine($"\"{newList[num - 1].MovieTitle}\" year released will be updated to \"{newYear}\"");
                                break;
                            }
                            else if (input == "rating")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].Rating}\": ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1].MovieTitle}\" rating will be updated to \"{newText}\"");
                                break;
                            }
                            else if (input == "run time" || input == "time")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].RunTime}\": ");

                                while (true)
                                {
                                    int.TryParse(Console.ReadLine().Trim(), out newRunTime);

                                    if ((newRunTime > 3))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("Please enter the run time in minutes: ");
                                    }
                                }

                                Console.WriteLine($"\"{newList[num - 1].MovieTitle}\" run time will be updated to: \"{newRunTime}\" minutes");
                                break;
                            }
                            else if (input == "description" || input == "desc")
                            {
                                Console.WriteLine($"Current description: \"{newList[num - 1].Description}\"");
                                Console.Write($"Enter new text to replace this description: ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1].MovieTitle}\" description will be updated to: \n\"{newText}\"");
                                break;
                            }
                            else
                            {
                                Console.Write("Please enter \"title\", \"actor\", \"genre\", \"director\", \"year\", \"rating\", \"run time\", \"description\": ");
                                input = Console.ReadLine().ToLower().Trim();
                            }
                        }

                        Console.Write("\nWould you like to continue with this update(y/n): ");
                        yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

                        if (yesNo == "yes")
                        {
                            Admin.UpdateMovie(newList, num, input, newText, newYear, newRunTime);
                        }
                        else if (yesNo == "no")
                        {
                            Console.WriteLine("This movie has not been updated.");
                        }
                    
                    }
                    else
                    {
                        Console.WriteLine("No updates will be made.");
                    }
                } 
                else
                {
                    Console.WriteLine("There are no existing movies that match your search.");
                }

                Console.Write("\nWould you like to edit another movie(y/n): ");

                yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

            } while (MainLibrary.GoAgain(yesNo));
            break;

        case 8:
            do { 
                // Delete an existing movie in the movie repository
                Console.Write("\nEnter the title of the movie you would like to remove: ");
                text = Console.ReadLine().Trim();

                // using their input search the list to display a list of movies they would like and have them select by number 
                newList = User.FindTitle(Movies, text);

                if (newList.Count > 0)
                {
                    Console.WriteLine("Movies that fit your search: ");
                    User.ViewMovies(newList);
                    Console.Write("\nWhich movie would you like to remove(select by number): ");

                    while (true)
                    {
                        int.TryParse(Console.ReadLine().Trim(), out num);

                        if ((num > 0) && (num <= newList.Count))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Please enter a valid selection: ");
                        }
                    }


                    int index = User.FindIndex(Movies, newList[num - 1].MovieTitle);

                    Console.WriteLine($"You have selected \"{Movies[index]}\".");
                    Console.Write("\nWould you like to continue removing this movie(y/n): ");
                    yesNo = MainLibrary.YesNo(Console.ReadLine().Trim());


                    if (yesNo == "yes")
                    {
                        Admin.RemoveMovie(Movies, index);
                    }
                    else if (yesNo == "no")
                    {
                        Console.WriteLine("This movie has not been removed.");
                    }

                } 
                else
                {
                    Console.WriteLine($"No movies with the title \"{text}\" currently exists.");
                }
                Console.Write("\nWould you like to remove another movie(y/n): ");

                yesNo = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

            } while (MainLibrary.GoAgain(yesNo));
            break;
    
    }

    Console.Write("\nWould you like to return to the main menu (y/n): ");
    input = MainLibrary.YesNo(Console.ReadLine().ToLower().Trim());

    if (input == "no")
    {
        Console.WriteLine("Goodbye!");
        keepGoing = false;
    }

}





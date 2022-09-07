using Mockbuster;

List<Movie> Movies = MovieRepo.GetMovies();

Console.WriteLine("Welcome to MockBuster!");

Console.Write("Are you a \"user\" or an \"administrator\"? ");
string userType = Console.ReadLine().ToLower();

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
        userType = Console.ReadLine().ToLower();
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

    Console.Write("What would you like to do?(select by number): ");
    string input = Console.ReadLine().ToLower();
    int num = 0;


    while (true)
    {
        bool isNum = int.TryParse(input, out num);
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
            input = Console.ReadLine();
        }
    }


    string text = "";
    List<Movie> newList = new List<Movie>();
    switch (num)
    {
        case 1:
            Console.WriteLine("All Movies:");
            User.ViewMovies(Movies);
            break;
        case 2:
            //Find a movie by title
            Console.Write("Enter the movie title: ");
            text = Console.ReadLine();
            User.FindTitle(Movies, text);
            break;
        case 3:
            //find a movie by genre
            Console.Write("Enter the movie genre: ");
            text = Console.ReadLine();
            User.FindGenre(Movies, text);
            break;
        case 4:
            // find a movie by lead actor/actress
            Console.Write("Enter the movie's lead actor/actress: ");
            text = Console.ReadLine();
            User.FindMainActor(Movies, text);
            break;
        case 5:
            //find movie by director
            Console.Write("Enter the movie's director: ");
            text = Console.ReadLine();
            User.FindDirector(Movies, text);
            break;
        case 6:
            // Add a new movie to the repository 
            Console.Write("Enter the new movie title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the lead actor/actress name: ");
            string actor = Console.ReadLine();

            Console.Write("Enter the movie genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter the movie director: ");
            string director = Console.ReadLine();

            //Validate the information entered was correct 
            Movie newMovie = new Movie(title, actor, genre, director);
            Console.Write($"Would you like to add {newMovie} to the movie list(y/n)? ");
            string yesNo = Console.ReadLine().ToLower();

            while (true)
            {
                if (yesNo == "y" || yesNo == "yes")
                {
                    Admin.AddMovie(Movies, title, actor, genre, director);
                    break;
                }
                else if (yesNo == "n" || yesNo == "no")
                {
                    Console.WriteLine("This movie has not been added.");
                    break;
                }
                else
                {
                    Console.Write("Please enter \"yes\" or \"no\": ");
                    yesNo = Console.ReadLine().ToLower();
                }
            }
            break;
        case 7:
            // Edit an existing movie in the Movie Repository 
            Console.Write("Enter the title of the movie you would like to update: ");
            text = Console.ReadLine().ToLower();

            // using their input search the list to display a list of movies they would like and have them select by number 
            newList = User.FindTitle(Movies, text);

            if (newList.Count > 0)
            {

                Console.Write("Which movie would you like to edit(select by number): ");

                while (true)
                {
                    bool isNum = int.TryParse(Console.ReadLine(), out num);

                    if ((isNum == true) && (num >= 0) && (num <= newList.Count))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Please enter a valid selection: ");
                    }
                }

                Console.WriteLine($"Would you like to edit {newList[num - 1]} (y/n): ");
                yesNo = Console.ReadLine();

                while (true)
                {
                    if (yesNo == "y" || yesNo == "yes")
                    {
                        // using the index number display the attributes and ask which one they would like to edit
                        Admin.DisplayAttributes(newList, num);
                        Console.Write("Which attribute would you like to update \"title\", \"actor\", \"genre\", \"director\": ");
                        input = Console.ReadLine().ToLower();

                        string newText;
                        while (true)
                        {
                            if (input == "title")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].MovieTitle}\": ");
                                newText = Console.ReadLine();

                                Console.WriteLine($"{newList[num - 1]} will be updated to {newText} starring {newList[num - 1].MainActor} ({newList[num - 1].Genre}), Directed by {newList[num - 1].Director}");
                                break;
                            }
                            else if (input == "actor" || input == "actress")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].MainActor}\": ");
                                newText = Console.ReadLine();

                                Console.WriteLine($"{newList[num - 1]} will be updated to {newList[num - 1].MovieTitle} starring {newText} ({newList[num - 1].Genre}), Directed by {newList[num - 1].Director}");
                                break;
                            }
                            else if (input == "genre")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].Genre}\": ");
                                newText = Console.ReadLine();

                                Console.WriteLine($"{newList[num - 1]} will be updated to {newList[num - 1].MovieTitle} starring {newList[num - 1].MainActor} ({newText}), Directed by {newList[num - 1].Director}");
                                break;
                            }
                            else if (input == "director")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].Director}\": ");
                                newText = Console.ReadLine();

                                Console.WriteLine($"{newList[num - 1]} will be updated to {newList[num - 1].MovieTitle} starring {newList[num - 1].MainActor} ({newList[num - 1].Genre}), Directed by {newText}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter \"title\", \"actor\", \"genre\", \"director\": ");
                                input = Console.ReadLine();
                            }
                        }

                        Console.WriteLine("Would you like to continue with this update(y/n): ");
                        yesNo = Console.ReadLine();
                        while (true)
                        {
                            if (yesNo == "y" || yesNo == "yes")
                            {
                                Admin.UpdateMovie(newList, num, input, newText);
                                break;
                            }
                            else if (yesNo == "n" || yesNo == "no")
                            {
                                Console.WriteLine("This movie has not been added.");
                                break;
                            }
                            else
                            {
                                Console.Write("Please enter \"yes\" or \"no\": ");
                                yesNo = Console.ReadLine().ToLower();
                            }
                        }

                        break;
                    }
                    else if (yesNo == "n" || yesNo == "no")
                    {
                        Console.WriteLine("Returning to the menu.");
                        break;
                    }
                    else
                    {
                        Console.Write("Please enter \"yes\" or \"no\": ");
                        yesNo = Console.ReadLine().ToLower();
                    }
                }
            }

            break;
        case 8:
            // Delete an existing movie in the movie repository
            Console.Write("Enter the title of the movie you would like to remove: ");
            text = Console.ReadLine();

            // using their input search the list to display a list of movies they would like and have them select by number 
            newList = User.FindTitle(Movies, text);

            if (newList.Count > 0)
            {
                Console.Write("Which movie would you like to remove(select by number): ");

                while (true)
                {
                    bool isNum = int.TryParse(Console.ReadLine(), out num);

                    if ((isNum == true) && (num >= 0) && (num <= newList.Count))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Please enter a valid selection: ");
                    }
                }

                int movieIndex = -1;
                for (int i = 0; i < Movies.Count; i++)
                {
                    if (newList[num-1].MovieTitle == Movies[i].MovieTitle)
                    {
                        movieIndex = i;
                    }
                }

                Console.WriteLine($"Your have selected {Movies[movieIndex]}");
                Console.WriteLine("Would you like to continue removing this movie(y/n): ");
                yesNo = Console.ReadLine();
                while (true)
                {
                    if (yesNo == "y" || yesNo == "yes")
                    {
                        Admin.RemoveMovie(Movies, num);
                        break;
                    }
                    else if (yesNo == "n" || yesNo == "no")
                    {
                        Console.WriteLine("This movie has not been removed.");
                        break;
                    }
                    else
                    {
                        Console.Write("Please enter \"yes\" or \"no\": ");
                        yesNo = Console.ReadLine().ToLower();
                    }
                }

            }

            break;
    
    }

    Console.WriteLine();
    Console.Write("Would you like to return to the main menu (y/n): ");
    input = Console.ReadLine().ToLower();

    while (true)
    {
        if (input == "y" || input == "yes")
        {
            break;
        } 
        else if (input == "n" || input == "no")
        {
            Console.WriteLine("Goodbye!");
            keepGoing = false;
            break;
        }
        else
        {
            Console.Write("Please enter \"yes\" or \"no\": ");
            input = Console.ReadLine().ToLower();
        }
    }
    
    Console.WriteLine();
}

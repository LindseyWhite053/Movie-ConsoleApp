﻿using Mockbuster;

List<Movie> Movies = MovieRepo.GetMovies();

Console.WriteLine("Welcome to MockBuster!");

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
    bool goAgain;
    switch (num)
    {
        case 1:
            Console.WriteLine("All Movies:");
            User.ViewMovies(Movies);
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
                }
                else
                {
                    Console.WriteLine($"Unable to find any movies with the title {text}. ");
                }

                Console.Write("\nWould you like to find another movie by title(y/n): ");

                yesNo = YesNo(Console.ReadLine().ToLower().Trim());

            } while (GoAgain(yesNo));           
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
                }
                else
                {
                    Console.WriteLine($"Unable to find any movies with the genre {text}. ");
                }

                Console.Write("\nWould you like to find another movie by genre(y/n): ");

                yesNo = YesNo(Console.ReadLine().ToLower().Trim());

            } while (GoAgain(yesNo));
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
                }
                else
                {
                    Console.WriteLine($"Unable to find any movies with the lead actor/actress {text}. ");
                }

                Console.Write("\nWould you like to find another movie by lead actor/actress(y/n): ");

                yesNo = YesNo(Console.ReadLine().ToLower().Trim());

            } while (GoAgain(yesNo));

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
                }
                else
                {
                    Console.WriteLine($"Unable to find any movies with the director {text}. ");
                }
            
                Console.Write("\nWould you like to find another movie by director(y/n): ");

                yesNo = YesNo(Console.ReadLine().ToLower().Trim());

            } while (GoAgain(yesNo));
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

                    answer = YesNo(answer);

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

                    //Validate the information entered was correct 
                    Movie newMovie = new Movie(title, actor, genre, director);
                    Console.Write($"\nWould you like to add {newMovie} to the movie list(y/n)? ");
                
                    yesNo = YesNo(Console.ReadLine().ToLower().Trim());


                    if (yesNo == "yes")
                    {
                        Admin.AddMovie(Movies, title, actor, genre, director);
                    }
                    else if (yesNo == "no")
                    {
                        Console.WriteLine("This movie has not been added.");
                    }
                }

                Console.Write("\nWould you like to add another movie(y/n): ");

                yesNo = YesNo(Console.ReadLine().ToLower().Trim());

            } while (GoAgain(yesNo));
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

                    Console.WriteLine($"\n{newList[num - 1]} has been selected.");
                    Console.Write("Continue with editing(y/n): ");
                    yesNo = YesNo(Console.ReadLine().ToLower().Trim());

                    if (yesNo == "yes")
                    {
                        // using the index number display the attributes and ask which one they would like to edit
                        Admin.DisplayAttributes(newList, num);
                        Console.Write("\nWhich attribute would you like to update \"title\", \"actor\", \"genre\", \"director\": ");
                        input = Console.ReadLine().ToLower().Trim();

                        string newText;
                        while (true)
                        {
                            if (input == "title")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].MovieTitle}\": ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1]}\" will be updated to: \n\"{newText} starring {newList[num - 1].MainActor} ({newList[num - 1].Genre}), Directed by {newList[num - 1].Director}\"");
                                break;
                            }
                            else if (input == "actor" || input == "actress")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].MainActor}\": ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1]}\" will be updated to: \n\"{newList[num - 1].MovieTitle} starring {newText} ({newList[num - 1].Genre}), Directed by {newList[num - 1].Director}\"");
                                break;
                            }
                            else if (input == "genre")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].Genre}\": ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1]}\" will be updated to: \n\"{newList[num - 1].MovieTitle} starring {newList[num - 1].MainActor} ({newText}), Directed by {newList[num - 1].Director}\"");
                                break;
                            }
                            else if (input == "director")
                            {
                                Console.Write($"Enter new text to replace \"{newList[num - 1].Director}\": ");
                                newText = Console.ReadLine().Trim();

                                Console.WriteLine($"\"{newList[num - 1]}\" will be updated to: \n\"{newList[num - 1].MovieTitle} starring {newList[num - 1].MainActor} ({newList[num - 1].Genre}), Directed by {newText}\"");
                                break;
                            }
                            else
                            {
                                Console.Write("Please enter \"title\", \"actor\", \"genre\", \"director\": ");
                                input = Console.ReadLine().ToLower().Trim();
                            }
                        }

                        Console.Write("\nWould you like to continue with this update(y/n): ");
                        yesNo = YesNo(Console.ReadLine().ToLower().Trim());

                        if (yesNo == "yes")
                        {
                            Admin.UpdateMovie(newList, num, input, newText);
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

                yesNo = YesNo(Console.ReadLine().ToLower().Trim());

            } while (GoAgain(yesNo));
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
                    yesNo = YesNo(Console.ReadLine().Trim());


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

                yesNo = YesNo(Console.ReadLine().ToLower().Trim());

            } while (GoAgain(yesNo));
            break;
    
    }

    Console.Write("\nWould you like to return to the main menu (y/n): ");
    input = YesNo(Console.ReadLine().ToLower().Trim());

    if (input == "no")
    {
        Console.WriteLine("Goodbye!");
        keepGoing = false;
    }
     
    Console.WriteLine();
}

static string YesNo(string input)
{
    string yesNo;
    while (true)
    {

        if (input == "y" || input == "yes")
        {
            yesNo = "yes";
            break;
        }
        else if (input == "n" || input == "no")
        {
            yesNo = "no";
            break;
        }
        else
        {
            Console.Write("Please enter \"yes\" or \"no\": ");
            input = Console.ReadLine().ToLower().Trim();
        }

    }

    return yesNo;
}

//Only pass in input validated first with YesNo() method above. 
static bool GoAgain(string input)
{
   if (input == "yes")
    {
        return true;
    }
    else{
        return false;
    }
}
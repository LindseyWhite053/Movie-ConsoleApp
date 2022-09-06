using Mockbuster;

Console.WriteLine("Welcome to MockBuster!");

List<Movie> Movies = MovieRepo.GetMovies();

string input = "elijah";

List<Movie> newList = User.FindMainActor(Movies, input);

foreach (Movie movie in newList)
{
    Console.WriteLine(movie);
}

//foreach (Movie movie in Movies)
//{
//    Console.WriteLine(movie);
//}

// Program Class / User Interface
// Conrol the flow of the application here. 
// Show available menus based on the users role 
// Allow the client ro access the functionality built out in other classes. 

//If the client is a USER provide access to: 
// Filter by movie name
// Filter by main actor 
// Filter by genre
// Filter by director
// Only display objects that match the filter entery
// When items are displayed, display all properties: Movie name, Main Actor, Genre, Director

//If the client is an ADMIN 
//Include same filter functionality listed above 
// Include additional options: 
// Add a new movie to the repository 
// Edit an existing movie in the Movie Repository 
// Delete an existing movie in the movie repository


//Return the client back to their specific menu until they choose to quit


//Client Validation 
//Validate all client input and ensure the client receives messages for any invalid input. 










/*
 * OOP.1.1 Solution by Lukas Johansen
 */
Movie movieA = new Movie("Alien", "Ridley Scott", 112);
Movie movieB = new Movie("Inception", "Christopher Nolan", 162);

// Creating a third object and tinkering with properties
Movie movieC = new Movie("The Matrix", "The Wachowskis", 136);
movieC.Watch();
Console.WriteLine("Movie C object:");
Console.WriteLine($"Views: {movieC.NoOfViews} Title: {movieC.Title} Director: {movieC.Director} Runtime: {movieC.Runtime}");
Console.WriteLine();


Console.WriteLine("Before calls of Watch():");
Console.WriteLine($"{movieA.Title}, by {movieA.Director}, " +
                  $"watched it {movieA.NoOfViews} time(s)");
Console.WriteLine($"{movieB.Title}, by {movieB.Director}, " +
                  $"watched it {movieB.NoOfViews} time(s)");
Console.WriteLine();

movieA.Watch();
movieA.Watch();
movieB.Watch();

Console.WriteLine("After calls of Watch():");
Console.WriteLine($"{movieA.Title}, by {movieA.Director}, " +
                  $"watched it {movieA.NoOfViews} time(s)");
Console.WriteLine($"{movieB.Title}, by {movieB.Director}, " +
                  $"watched it {movieB.NoOfViews} time(s)");
Console.WriteLine();

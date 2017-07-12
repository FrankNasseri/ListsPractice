using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            ////Use the Count property to get the length of the list
            //Console.WriteLine(favNumbers.Count);

            //List<string> books = new List<string> {"Cat in the hat", "Toad and frog", "Green eggs and ham" };
            //Console.WriteLine(books[0]);
            ////Inserts at the current index moving the previous element down one
            //books.Insert(0, "Horton hears a Who");
            //Console.WriteLine(books[0]);

            //Create a List and add five animals using the .Add()
            //Print each animal in the list
            //List<string> favAnimals = new List<string>();
            //favAnimals.Add("Monkey");
            //favAnimals.Add("Cats");
            //favAnimals.Add("Penguins");
            //favAnimals.Add("Panthers");
            //favAnimals.Add("Jelly Fish");

            //foreach(string animal in favAnimals)
            //{
            //    Console.WriteLine(animal);
            //}
            ////OR, WITH THE SAME FAV ANIMALS, just using a for loop instead of foreach loop
            //for(int i= 0; i< favAnimals.Count; i++)
            //{
            //    Console.WriteLine(favAnimals[i]);
            //}

            //Create the following list:
            //A bool list {true,false,false,true,false}
            //Loop through each value 
            //If the value is true print "Better bring an umbrella"
            //If the value is false print "No rain today enjoy the sun"
            //List<bool> weather = new List<bool> { true, false, false, true, false };
            //foreach(bool day in weather)
            //{
            //    if(day == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today, enjoy the sun");
            //    }
            //}

            //Create a list of our favorite foods using a .Contains
            //List<string> faveFoods = new List<string> { "Steak", "Fish", "Katsudon", "Ice Cream", "Nachos" };

            //if(faveFoods.Contains("Fish"))
            //{
            //    Console.WriteLine("I like fish too!");
            //}

            //Create a list with the following numbers: 1 23 9 77 922 6 32 14 5
            //use the contains method with the following values: 23 77 15
            //Remove these elements: 23 77 32 and 6
            //use Contains() again on these values 23 77 15

            //List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 14, 5 };
            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));

            //numbers.Remove(23);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);

            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));

            //Create a list of movies
            List<string> movieList = new List<string> { "forrest gump", "nightcrawler", "dunkirk", "fight club" };
            List<string> moviesOrdered = new List<string>();
            //Ask the user for a movie 
            Console.WriteLine("Hello, welcome to BlockBuster! What movie would you like to order?");
            string userMovie = Console.ReadLine().ToLower();

            do
            {
                if (userMovie.ToLower() == "quit")
                {
                    break;
                }
               else if (movieList.Contains(userMovie))
                {
                    Console.WriteLine("Thanks for ordering your movie, {0} should be here shortly", userMovie);
                    moviesOrdered.Add(userMovie);
                }
                else if (movieList.Contains(userMovie) == false)
                {
                    Console.WriteLine("Currently {0} is not available at this time but we have added it and its on the way.", userMovie);
                    moviesOrdered.Add(userMovie);
                    movieList.Add(userMovie);
                }
                Console.WriteLine("What other movies would you like to add to your list?");
                userMovie = Console.ReadLine().ToLower();
            }
            while (userMovie.ToLower() != "quit");

            foreach (string movie in movieList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine("Thanks for shopping with us we enjoyed your business!");



                //if the movie is not in the list add it 
                //inform the user that the movie has been added 
                //if the movie is in the list inform them that the movie is on the way
                //if the user enters quit the program should exit 
                //The user should be able to add as many movies as they want 


        }
    }
}

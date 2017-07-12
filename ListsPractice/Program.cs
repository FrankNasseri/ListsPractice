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
            List<string> faveFoods = new List<string> { "Steak", "Fish", "Katsudon", "Ice Cream", "Nachos" };

            if(faveFoods.Contains("Fish"))
            {
                Console.WriteLine("I like fish too!");
            }

        }
    }
}

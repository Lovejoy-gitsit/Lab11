using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate MovieList
            List<Movie> MoviesList = new List<Movie>();
            //adding movies to the movie list
            MoviesList.Add(new Movie("13th", "documentary"));
            MoviesList.Add(new Movie("Food Inc", "documentary"));
            MoviesList.Add(new Movie("The Notebook", "romance"));
            MoviesList.Add(new Movie("Finding Forrester", "drama"));
            MoviesList.Add(new Movie("Gridiron Gang", "drama"));
            MoviesList.Add(new Movie("Bad Boys", "action"));
            MoviesList.Add(new Movie("The Bodyguard", "drama"));
            MoviesList.Add(new Movie("Fast & Furious", "action"));
            MoviesList.Add(new Movie("The Big Short", "drama"));
            MoviesList.Add(new Movie("Love Jones", "romance"));
            //putting movie categories in an array
            string[] categories = { "documentary", "romance", "drama", "action" };
            bool repeat = true;
            while (repeat)
            {
                //asking user for input
                Console.Write("Enter a number between 1-5: ");
                int selection = 0;
                //validating user input
                while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
                {
                    Console.WriteLine("Enter a valid number: ");
                }
                //once valid number is put, a loop checks user number to corresponding categories
                //then the console writes out the movies that match that category
                foreach (Movie element in MoviesList)
                {
                    if (categories[selection - 1] == element.Category)
                    {
                        element.PrintInfo();
                    }
                }

                //asking user if they want to go again
                Console.WriteLine("Continue: y/n");
                string again = Console.ReadLine();
                if (again == "y")
                {
                    repeat = true;
                }
                else
                {
                    break;
                }



            }
        }
    }
}

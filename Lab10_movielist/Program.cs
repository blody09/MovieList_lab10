using System;
using System.Collections.Generic;

namespace Lab10_movielist
{
    class Program
    {
        static void Main(string[] args)
        {


            //List of ten movies with cats

            List<Movie> movieList = new List<Movie>
            {
                new Movie ("Your Name", "Animated"),
                new Movie ("SpiderMan Into the SpiderVers", "Animated"),
                new Movie ("A Silent Voice", "Animated"),
                new Movie ("Once Upon A time in Holly", "Drama"),
                new Movie ("Joker", "Drama"),
                new Movie ("Dallas Buyers Club", "Drama"),
                new Movie ("Serenity", "Scifi"),
                new Movie ("Blade Runner", "Scifi"),
                new Movie ("Hereditaey", "Horror"),
                new Movie ("IT", "Horroe"),

            };
                


            bool userContinue = true;
            while (userContinue)
            {
                string userInput = GetUserInput("What genere are you interested in?\nScifi\tDrama\tHorroe\tAnimated");

                Console.WriteLine();
                Movie.PrintMoviesByType(movieList, userInput);
                Console.WriteLine();

                userContinue = AnotherGenre("Would you like to see another genre? (y/n)", "n", "y");
            }

        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool AnotherGenre(string message, string yes, string no)
        {
            string anothergenre = GetUserInput(message);
            if (anothergenre == yes)
            {
                return false;
            }
            else if (anothergenre == no)
            {
                return true;
            }
            else
            {
                return AnotherGenre(message, yes, no);
            }
            

               
            
        }

    }
}

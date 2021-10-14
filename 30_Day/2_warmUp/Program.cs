using System;
using System.Collections.Generic;

namespace _2_warmUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("How many movies do you wanna add: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if(userChoice > 1)
            {
                AddMovies(userChoice);
            }
            else
            {
                AddMovie();
            }


        }

        static void AddMovie()
        {
            Console.WriteLine("Movie name: ");
            string newMovie = Console.ReadLine();

            Console.WriteLine("Movie year: ");
            int newYear = Convert.ToInt32(Console.ReadLine());

            var theMovie = new Movie() { Name = newMovie, Year = newYear };

            using (var theDB = new MovieDB_01Context())
            {
                theDB.Movies.Add(theMovie);

                theDB.SaveChanges();
                Console.WriteLine("Movie added to db.");
            }

        }

        static void AddMovies(int key)
        {

            var newMovies = new List<Movie>();

            for(var f = 0; f < key; f++)
            {
                Console.WriteLine($"{f + 1}. Movie name: ");
                string newName = Console.ReadLine();

                Console.WriteLine($"{f + 1}. Movie year: ");
                int newYear = Convert.ToInt32(Console.ReadLine());

                newMovies.Add(new Movie() { Name = newName, Year = newYear });
            }

            using (MovieDB_01Context theDB = new MovieDB_01Context())
            {
                theDB.Movies.AddRange(newMovies);

                theDB.SaveChanges();
                Console.WriteLine("Movies added to db.");
            }
        }
    }
}

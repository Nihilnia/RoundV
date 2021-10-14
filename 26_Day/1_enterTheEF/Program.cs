using System;
using System.Collections.Generic;

namespace _1_enterTheEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var dataBaze = new MovieDBContext())
            {
                var newMovie = new Movies { Name = "Movie_01", Year = 1234 };

                dataBaze.Movies.Add(newMovie);

                dataBaze.SaveChanges();

                Console.WriteLine("All changes applied.");
            }
        }
    }
}

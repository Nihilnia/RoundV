using System;
using System.Collections.Generic;

namespace _2_warmUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var theDB = new GlrMoviesContext())
            {
                var newMovie = new Movie() { Name = "Movie_03", Year = 2003 };

                theDB.Movies.Add(newMovie);

                theDB.SaveChanges();
            }
        }

    }
}

using System;
using System.Collections.Generic;

namespace _3_dooM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            updateTheDB();
        }

        static void updateTheDB()
        {
            using (var theDB = new DoomDBContext())
            {
                var newMovies = new List<Movie>
                {
                    new Movie{Name = "Movie_X3", Year = 2001},
                    new Movie{Name = "Movie_X4", Year = 2002},
                    new Movie{Name = "Movie_X5", Year = 2003},
                    new Movie{Name = "Movie_X6", Year = 2004}
                };

                theDB.AddRange(newMovies);

                theDB.SaveChanges();

                Console.WriteLine("DB Updated succesfuly.");
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _1_efToDB
{
    public class Movies
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Year { get; set; }
    }

    public class Categories
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
    }

    public class MovieDBContext: DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = NihilMoviesDB.db");
            //Optional
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("How many movies do you wanna add: ");
            int userRange = Convert.ToInt32(Console.ReadLine());

            if(userRange == 1)
            {
                AddMovie();
            }
            else
            {
                AddMovies(userRange);
            }


            //AddRandomMovies(userRange);
            
        }

        static void AddMovies(int howMany)
        {

            var newMovies = new List<Movies>();

            for (int f = 0; f < howMany; f++)
            {
                Console.WriteLine("Movie name: ");
                string inputMovie = Console.ReadLine();

                Console.WriteLine("Year: ");
                int inputYear = Convert.ToInt32(Console.ReadLine());
                newMovies.Add(new Movies { Name = inputMovie, Year = inputYear });
            }


            using (var dataBaze = new MovieDBContext())
            {
                dataBaze.Movies.AddRange(newMovies);
                dataBaze.SaveChanges();

                Console.WriteLine("Database updated.");
            }
        }

        static void AddMovie()
        {
            Console.WriteLine("Movie name: ");
            string inputMovie = Console.ReadLine();

            Console.WriteLine("Year: ");
            int inputYear = Convert.ToInt32(Console.ReadLine());


            var newMovie = new Movies {Name = inputMovie, Year = inputYear};

            using (var dataBaze = new MovieDBContext())
            {
                dataBaze.Movies.Add(newMovie);
                dataBaze.SaveChanges();

                Console.WriteLine("Database updated.");
            }
        }

        static void AddRandomMovies(int randomNumb)
        {
            for (int f = 0; f < randomNumb; f++)
            {
                var newMovie = new Movies { Name = "Movie_" + f, Year = 202 + f};

                using (var db = new MovieDBContext())
                {
                    db.Movies.Add(newMovie);

                    db.SaveChanges();

                    Console.WriteLine("Random movie added to database");
                }
            }
        }
    }

    
}

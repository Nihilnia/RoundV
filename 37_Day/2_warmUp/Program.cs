using System;
using System.Collections.Generic;

namespace _2_warmUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("How many cars do you wanna add:");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            AddRandomCars(userChoice); 
        }

        static void AddRandomCars(int daCars)
        {
            using (var DB = new ProjectCarsContext())
            {
                List<Car> randomCars = new List<Car>();

                for (int f = 0; f < daCars; f++)
                {
                    randomCars.Add(new Car { Name = "randomCar_" + f, Speed = 10.0 + f });
                }

                DB.Cars.AddRange(randomCars);
                DB.SaveChanges();

                Console.WriteLine($"Random {daCars} added to database.");
            }
        }
    }
}

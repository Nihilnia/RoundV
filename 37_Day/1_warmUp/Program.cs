using System;
using System.Collections.Generic;

namespace _1_warmUp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    static void AddRandomCars(int daCars)
    {
        using (var DB = new ProjectCarContext())
        {
            List<Car> randomCars = new List<Car>();

            for (int f = 0; f < daCars; f++)
            {
                randomCars.Add(new Car { Name = "randomCar_" + f, Speed = 100 + f });
            }

            DB.Cars.AddRange(randomCars);
            DB.SaveChanges();

            Console.WriteLine($"Random Cars {daCars} added to database.");
        }
    }
}

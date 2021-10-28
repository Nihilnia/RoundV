using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_warmUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Project Cars System!");

            int key = 1;
            while (key == 1)
            {
                Console.WriteLine(@"
                    1)Find a Car
                    2)Add Speed
                    3)Add a Car
                    4)Add Random Cars
                    5)Update a Car
                    6)Delete a Car
                    
                    -1) Gloria Delete
                    0)Exit!

            ");

                string userChoice  = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Car name: ");
                        string carName = Console.ReadLine();
                        IntroduceCar(carName);
                        break;

                    case "2":
                        Console.WriteLine("Car name: ");
                        string speedCarName = Console.ReadLine();
                        Console.WriteLine("Speed: ");
                        double speedCarSpeed = Convert.ToDouble(Console.ReadLine());
                        AddSpeed(speedCarName, speedCarSpeed);
                        break;

                    case "3":
                        Console.WriteLine("Car name: ");
                        string newCarName = Console.ReadLine();
                        Console.WriteLine("Speed: ");
                        double newCarSpeed = Convert.ToDouble(Console.ReadLine());
                        AddCar(newCarName, newCarSpeed);
                        break;

                    case "4":
                        Console.WriteLine("How many cars do you wanna add?: ");
                        int randomCarAmount = Convert.ToInt32(Console.ReadLine());
                        AddRandomCars(randomCarAmount);
                        break;

                    case "5":
                        Console.WriteLine("Current Car name: ");
                        string updateCarName = Console.ReadLine();
                        UpdateCar(updateCarName);
                        break;

                    case "6":
                        Console.WriteLine("Car name to delete: ");
                        string deleteCarName = Console.ReadLine();
                        DeleteCar(deleteCarName);
                        break;

                    case "-1":
                        GloriaDelete();
                        break;

                    case "0":
                        key = 0;
                        break;


                }
            }

            
        }

        static void IntroduceCar(string cName)
        {
            using (var DB = new ProjectCarsContext())
            {
                var foundCar = DB.Cars.Where(c => c.Name == cName).ToList();

                if(foundCar.Count > 0 || foundCar.Count > 1)
                {
                    Console.WriteLine(@$"There are {foundCar.Count} car/s found.");
                    Console.WriteLine("----------------------");
                    foreach (var f in foundCar)
                    {
                        Console.WriteLine($@"Car ID: {f.ID}, Name: {f.Name}, Speed: {f.Speed}");
                    }
                    Console.WriteLine("----------------------");
                }
                else
                {
                    Console.WriteLine($@"There is no Car {cName} in the Database.");
                }

                
            }
        }

        static void AddSpeed(string cName, double cNewSpeed)
        {
            using (var DB = new ProjectCarsContext())
            {
                var foundCar = DB.Cars.Where(c => c.Name == cName).FirstOrDefault();

                if(foundCar != null)
                {

                    foundCar.Speed += cNewSpeed;
                    DB.SaveChanges();

                    Console.WriteLine($@"Car {foundCar.Name}' s speed was: {foundCar.Speed - cNewSpeed}
                                        And now speed is: {foundCar.Speed}");
                }
                else
                {
                    Console.WriteLine("Car " + cName + " not found.");
                }
            }
        }

        static void AddCar(string cName, double cSpeed)
        {
            using (var DB = new ProjectCarsContext())
            {
                Car newCar = new Car();
                newCar.Name = cName;
                newCar.Speed = cSpeed;

                DB.Cars.Add(newCar);
                DB.SaveChanges();

                Console.WriteLine("New car {newCar.Name}, '{newCar.Speed}' added to Database.");
            }
        }

        static void AddRandomCars(int daCars)
        {
            using(var DB = new ProjectCarsContext())
            {
                List<Car> randomCars = new List<Car>();

                for (int f = 0; f < daCars; f++)
                {
                    randomCars.Add(new Car() { Name = "randomCar_" + f, Speed = 10.0 + f});

                }

                DB.Cars.AddRange(randomCars);
                DB.SaveChanges();

                Console.WriteLine($"Random {daCars} added to Database.");
            }
        }

        static void UpdateCar(string cCarName)
        {
            using (var DB = new ProjectCarsContext())
            {
                var foundCar = DB.Cars.Where(c => c.Name == cCarName).ToList();

                if (foundCar.Count > 0 && foundCar.Count > 1)
                {
                    Console.WriteLine(@$"There are {foundCar.Count} car/s found.");
                    Console.WriteLine("----------------------");
                    foreach (var f in foundCar)
                    {
                        Console.WriteLine($@"Car ID: {f.ID}, Name: {f.Name}, Speed: {f.Speed}");
                    }
                    Console.WriteLine("----------------------");
                }
                else
                {
                    Console.WriteLine($@"There is no Car {cCarName} in the Database.");
                }

                Console.WriteLine("Which one do you wanna update? (ID): ");
                int givenCarID = Convert.ToInt32(Console.ReadLine());

                
                var foundWithID = DB.Cars.Where(c => c.ID == givenCarID).FirstOrDefault();
                //const string oldCarInfos = foundWithID.Name;

                if (foundWithID != null)
                {
                    Console.WriteLine("New Car name: ");
                    string newCarNameUpdate = Console.ReadLine();
                    Console.WriteLine("Speed: ");
                    double newCarSpeedUpdate = Convert.ToDouble(Console.ReadLine());
                    foundWithID.Name = newCarNameUpdate;
                    foundWithID.Speed = newCarSpeedUpdate;
                    DB.SaveChanges();

                    Console.WriteLine(@$"Car {foundWithID.Name} updated.

                        

                        NEW INFORMATIONS--
                            Name: {foundWithID.Name}
                            Speed: {foundWithID.Speed}


                            "); //It's not gonna work imo.
                }


            }
        }

        static void DeleteCar(string cCarName)
        {
            using(var DB = new ProjectCarsContext())
            {
                var foundCar = DB.Cars.Where(c => c.Name == cCarName).FirstOrDefault();
                if(foundCar != null)
                {
                    DB.Cars.Remove(foundCar);
                    DB.SaveChanges();

                    Console.WriteLine($"Car {foundCar.Name} deleted from Database.");
                }
                else
                {
                    Console.WriteLine($"Car {cCarName} not found.");
                }
            }
        }

        static void GloriaDelete()
        {
            using (var DB = new ProjectCarsContext())
            {
                var allIntel = DB.Cars.Where(c => c.ID > 0).ToList();

                foreach (var f in allIntel)
                {
                    DB.Cars.Remove(f);
                }

                DB.SaveChanges();

                Console.WriteLine("All car's deleted from Database.");
            }
        }

        
    }
}

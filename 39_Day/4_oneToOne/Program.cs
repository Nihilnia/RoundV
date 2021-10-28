using System;
using System.Linq;

namespace _4_oneToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int key = 0;
            while (key == 0)
            {
                Console.WriteLine(@"Options:
                    1)Add new Model
                    2)Introduce a Model



                    0)Exit

                ");

                string userChoice = Console.ReadLine();


                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Model name: ");
                        string newModelName = Console.ReadLine();
                        Console.WriteLine("Year: ");
                        int newYear = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Color: ");
                        string newColor = Console.ReadLine();
                        Console.WriteLine("Car ID: ");
                        int newCarID = Convert.ToInt32(Console.ReadLine());

                        AddModel(newModelName, newYear, newColor, newCarID);
                        break;

                    case "2":
                        Console.WriteLine("Model ID:");
                        int findModelID = Convert.ToInt32(Console.ReadLine());
                        IntroduceModel(findModelID);
                        break;

                    case "0":
                        key = 1;
                        break;
                }
            }
        }

        static void IntroduceModel(int cID)
        {
            using (var DB = new GridContext())
            {
                var findTheCar = DB.Models.Where(c => c.CarID == cID).FirstOrDefault();

                if(findTheCar != null)
                {
                    Console.WriteLine($@"

                        ########################
                        Car ID: {findTheCar.ID},
                        Name: {findTheCar.Name},
                        Year: {findTheCar.Year},
                        Color: {findTheCar.Color}
                        ########################                        
                    "); //It will return an error,
                }
                else
                {
                    Console.WriteLine("Car not found.");
                }
            }
        }

        static void AddModel(string cName, int cYear, string cColor, int cID)
        {
            using (var DB = new GridContext())
            {
                var newModel = new Model() {Name = cName, Year = cYear, Color = cColor, CarID = cID, Car = new Car() { ID = cID} };
                DB.Models.Add(newModel);
                DB.SaveChanges(); ;
                Console.WriteLine(@"

                                ############### NEW MODEL ADDED TO DB. ###############
                        ");
            }
        }
    }
}

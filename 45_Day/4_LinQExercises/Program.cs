using _4_LinQExercises.Lily.Data;
using System;
using System.Linq;

namespace _4_LinQExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1- Question
            //DevilsDatabase.GetEmployees();

            //2- Question
            //DevilsDatabase.GetCustomers();

            //3- Question
            //DevilsDatabase.GetNYCustomers();

            //4- Question
            //DevilsDatabase.GetBeverages();

            //5- Question
            //DevilsDatabase.FiveProducts();

            //6- Question
            //DevilsDatabase.TenAndThirty();

            //7- Question
            //DevilsDatabase.AverageBeverageLOL();

            //8- Question
            //DevilsDatabase.HowManBeverages();

            //9- Question
            //DevilsDatabase.TotalPriceOfBandC();

            //10- Question
            //DevilsDatabase.GetTheTeasMan();

            //11- Question
            DevilsDatabase.ExpensiveNDCheaper();


        }

        static class DevilsDatabase
        {

            //1- Question
            public static void GetEmployees()
            {
                int key = 1;

                using (var DB = new DevilsTattooContext())
                {
                    var allEmployees = DB.Employees.ToList();

                    foreach (var f in allEmployees)
                    {
                        Console.WriteLine($@"Employee: {key}, Name: {f.FirstName}, Surname: {f.LastName}");

                        key++;
                    }
                }
            }


            //2- Question
            public static void GetCustomers()
            {
                using (var DB = new DevilsTattooContext())
                {
                    var allCustomers = DB.Customers.Select(c => new
                    {
                        c.FirstName,
                        c.LastName
                    });

                    int key = 1;

                    foreach (var f in allCustomers)
                    {
                        Console.WriteLine($@"Customer: {key}, Name: {f.FirstName}, Surname: {f.LastName}");

                        key++;
                    }
                }
            }

            //3- Question (Customers from NY, with order.)
            public static void GetNYCustomers()
            {
                using (var DB = new DevilsTattooContext())
                {
                    var nyCustomers = DB.Customers
                        .Where(c => c.City == "New York")
                        .Select(c => new
                        {
                            c.FirstName,
                            c.LastName,
                            c.City
                        });

                    int key = 1;

                    foreach (var f in nyCustomers)
                    {
                        Console.WriteLine($@"Customer: {key}, Name: {f.FirstName}, Surname: {f.LastName}, City: {f.City}");
                        key++;
                    }
                }
            }

            //4- Question (Get product names that which ones Baverages, lmao that english.)
            public static void GetBeverages()
            {
                using (var DB = new DevilsTattooContext())
                {
                    var beverageZ = DB.Products
                        .Where(p => p.Category == "Beverages")
                        .Select(p => p.ProductName)
                        .ToList();

                    int key = 1;

                    foreach (var f in beverageZ)
                    {
                        Console.WriteLine($@"Product: {key}, Name: {f}");
                    }
                }
            }


            //5- Question (Latest added five products)
            public static void FiveProducts()
            {
                using (var DB = new DevilsTattooContext())
                {
                    var fiveOfEm = DB.Products.Select(p => new { p.Id, p.ProductName }).OrderByDescending(p => p.Id).Take(5);

                    foreach (var f in fiveOfEm)
                    {
                        Console.WriteLine($@"Product: ID: {f.Id}, Name: {f.ProductName}");
                    }

                }
            }

            //6- Question (Get the products that prices between 10 and 30 with higher to lower.)
            public static void TenAndThirty()
            {
                using (var DB = new DevilsTattooContext())
                {
                    var getEm = DB.Products.Select(p => new
                    {
                        p.Id,
                        p.ProductName,
                        p.ListPrice
                    }).Where(p => p.ListPrice >= 10 && p.ListPrice <= 30).ToList().OrderByDescending(p => p.ListPrice);

                    foreach (var f in getEm)
                    {
                        Console.WriteLine($@"Product ID: {f.Id}, Name: {f.ProductName} and the Price: {f.ListPrice}");
                    }
                }
            }

            //7- What is the average price of the products that belongs the Beverage category.
            public static void AverageBeverageLOL()
            {
                using (var DB = new DevilsTattooContext())
                {
                    var averageOfEm = DB.Products.Where(p => p.Category == "Beverages").Average(p => p.ListPrice);

                    //decimal totalPrice = 0;

                    //foreach (var f in averageOfEm)
                    //{
                    //    totalPrice += f;
                    //}

                    //Console.WriteLine($"Average: {totalPrice / averageOfEm.Count()}");

                    Console.WriteLine($"Average: {averageOfEm}");
                }
            }

            //8- How many products belongs Beverage category?
            public static void HowManBeverages()
            {
                using (var DB = new DevilsTattooContext())
                {
                    var howMany = DB.Products.Count(p => p.Category == "Beverages");

                    Console.WriteLine($"Total Beverages: {howMany}");
                }
            }

            //9- What is the total price of the products that belongs Beverages and Condiments
            public static void TotalPriceOfBandC()
            {
                using (var DB = new DevilsTattooContext())
                {
                    var totalPrice = DB.Products.Where(p => p.Category == "Condiments" || p.Category == "Beverages").Sum(p => p.ListPrice);

                    Console.WriteLine($@"Total price of em: {totalPrice}");
                }
            }

            //10- Find the products who has 'Tea' in their name
            public static void GetTheTeasMan()
            {
                using (var DB = new DevilsTattooContext())
                {
                    var teaaaas = DB.Products.Where(p => p.ProductName.ToLower().Contains("Tea") || p.Description.ToLower().Contains("Tea")).ToList();

                    foreach (var f in teaaaas)
                    {
                        Console.WriteLine(f.ProductName);
                    }
                }
            }


            //11- Most expensive and most cheap products
            public static void ExpensiveNDCheaper()
            {
                using (var DB = new DevilsTattooContext())
                {

                    var minProduct = DB.Products.Where(p => p.ListPrice == DB.Products.Min(p => p.ListPrice)).FirstOrDefault();
                    var maxProduct = DB.Products.Where(p => p.ListPrice == DB.Products.Max(p => p.ListPrice)).FirstOrDefault();

                    Console.WriteLine($"Min price products {minProduct.ProductName}, price: {minProduct.ListPrice}");
                    Console.WriteLine($"Max price products {maxProduct.ProductName}, price: {maxProduct.ListPrice}");
                }
            }


        }
    }
}

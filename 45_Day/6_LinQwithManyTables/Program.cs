using _6_LinQwithManyTables.Lily.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_LinQwithManyTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LilyProcess.GetCustomersWhoHasOrders();
        }

        public class CustomerDemo
        {
            public CustomerDemo()
            {
                Orderzz = new List<OrderDemo>();
            }

            public int ID { get; set; }
            public string Name { get; set; }
            public int TotalOrders { get; set; }
            public List<OrderDemo> Orderzz { get; set; }
        }

        public class OrderDemo
        {
            public int ID { get; set; }
            public decimal Total { get; set; }
        }



        public static class LilyProcess
        {
            public static void GetCustomersWhoHasOrders()
            {
                using (var DB = new LilyContext())
                {
                    var daCustomers = DB.Customers.Where(c => c.Orders.Count() > 0)  //You can use any() instead count() > 0
                                                                                     //opposite of it: Where(c => !c.Orders.Any())
                        .Select(c => new CustomerDemo
                        {
                            ID = c.Id,
                            Name = c.FirstName + c.LastName,
                            TotalOrders = c.Orders.Count(),
                            Orderzz = c.Orders.Select(o => new OrderDemo {
                                ID = o.Id,
                                Total = (decimal)o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice)
                            }).ToList()
                        })
                        .OrderByDescending(c => c.TotalOrders)
                        .ToList();

                    //IMA FUC

                    //EN cok siparis veren ilk 5 kisiyi yazdir
                    //wow mate

                    //en cok siparis veren ilk 5 kisinin toplam tutarini
                    //Sadece elizabeth' i al.

                    decimal allTotal = 0;

                    foreach (var f in daCustomers)
                    {
                        Console.WriteLine($@"
                        Customer ID: {f.ID},
                        Name: {f.Name}
                        Total Orders: {f.TotalOrders}
                        ");

                        foreach (var c in f.Orderzz)
                        {
                            Console.WriteLine($@"Order ID: {c.ID}, Total: {c.Total}");
                            allTotal += c.Total;
                        }
                        
                    }

                    Console.WriteLine($"ALL TOTAL: {allTotal}");
                }
            }
        }
    }
}

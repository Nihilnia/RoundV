using _1_sqlCommandsAtCSharp.Lily.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace _1_sqlCommandsAtCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //LilyDatabaseQ.GetAllCustomers();

            //LilyDatabaseQ.UpdateEMailsCustomers(29);



            ClassicSQL.GetAllCustomers("New York");
        }
    }

    //SQL Querries in C#
    public static class ClassicSQL
    {
        public static void GetAllCustomers(string cCity)
        {
            using (var DB = new LilyContext())
            {
                var allCustomers = DB.Customers.FromSqlRaw("SELECT * FROM customers WHERE city = {0}", cCity).ToList();

                foreach (var f in allCustomers)
                {
                    Console.WriteLine(@$"
                                Customer ID: {f.Id},
                                Customer Name: {f.FirstName + " " + f.LastName},
                                Customer City: {f.City}
                    ");
                }
            }
        }
    }



















    //Warm Up
    public class AllCustomersDemo
    {
        public int CustomerID { get; set; }
        public string CustomerWho { get; set; }
        public string CustomerTitle { get; set; }
    }

    static class LilyDatabaseQ
    {
        public static void GetAllCustomers()
        {
            using (var DB = new LilyContext())
            {
                var allCustomers = DB.Customers.Select(c => new AllCustomersDemo
                {
                    CustomerID = c.Id,
                    CustomerWho = c.FirstName + c.LastName,
                    CustomerTitle = c.JobTitle
                }).ToList();

                foreach (var f in allCustomers)
                {
                    Console.WriteLine($@"
                        Customer ID: {f.CustomerID},
                        Name: {f.CustomerWho},
                        Job Title: {f.CustomerTitle}              

                    ");
                }
            }
        }

        public static void UpdateEMailsCustomers(int cID = 0, string cNewEMail = "default@Email.com")
        {
            using (var DB = new LilyContext())
            {
                

                if(cID == 0)
                {
                    var allCustomerEMails = DB.Customers.ToList();
                    foreach (var f in allCustomerEMails)
                    {
                        f.EmailAddress = "Gloria@Project.com";
                    }

                    DB.SaveChanges();
                    Console.WriteLine("All customer' s e-mail addresses changed.");
                }
                else
                {
                    var partCustomers = DB.Customers.Where(c => c.Id == cID).ToList();

                    foreach (var f in partCustomers)
                    {
                        f.EmailAddress = "AAAGloria@Project.com";
                    }

                    DB.SaveChanges();

                    Console.WriteLine("Some customer' s e-mail addresses changed.");
                }
            }
        }
    }
}

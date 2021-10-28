using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_oneToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var DB = new ImagineShopContext())
            {
                //var newCustomer = new Customer()
                //{
                //    FirstName = "DenemeName2",
                //    LastName = "DenemeLastName2",
                //    UserID = 2
                //};

                //DB.Customers.Add(newCustomer);
                //DB.SaveChanges();

                //Console.WriteLine("Customer added.");

                var newCustomer = new Customer()
                {
                    FirstName = "DenemeName3",
                    LastName = "DenemeLastName3",
                    User = new User() { FirstName = "FirstName3", LastName = "LastName3", UserName = "UserName3" }
                };

                DB.Customers.Add(newCustomer);
                DB.SaveChanges();
                Console.WriteLine("Added to dtabase.");
            }

            int key = 0;

            while(key == 0)
            {
                Console.WriteLine(@"Options:

                1)Add New User
                2)Add New Adress
                3)Introduce the User
                4)Try With Adress
                5)Add Random Users
                6)Add Random Adresses




                0)Exit");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Username: ");
                        string newUserName = Console.ReadLine();
                        Console.WriteLine("First name: ");
                        string newUserFirstName = Console.ReadLine();
                        Console.WriteLine("Last name: ");
                        string newUserLastName = Console.ReadLine();
                        AddUser(newUserName, newUserFirstName, newUserLastName);
                        break;

                    case "2":
                        Console.WriteLine("Adress Title: ");
                        string newAdressTitle = Console.ReadLine();
                        Console.WriteLine("Adress Body: ");
                        string newAdressBody = Console.ReadLine();
                        Console.WriteLine("User ID: ");
                        int newAdressUserID = Convert.ToInt32(Console.ReadLine());
                        AddAdress(newAdressTitle, newAdressBody, newAdressUserID);
                        break;

                    case "3":
                        Console.WriteLine("User ID To Find: ");
                        int findUserID = Convert.ToInt32(Console.ReadLine());
                        IntroduceUser(findUserID);
                        break;

                    case "4":
                        Console.WriteLine("User ID to try: ");
                        int givenID = Convert.ToInt32(Console.ReadLine());
                        FindUserWithAdress(givenID);
                        break;

                    case "5":
                        Console.WriteLine("How many random user/s do you wanna add: ");
                        int userAmount = Convert.ToInt32(Console.ReadLine());
                        AddRandomUsers(userAmount);
                        break;

                    case "6":
                        Console.WriteLine("How many random adresse/s do you wanna add: ");
                        int adressAmount = Convert.ToInt32(Console.ReadLine());
                        AddRandomAdresses(adressAmount);
                        break;

                    case "0":
                        key = 1;
                        break;
                }
            }
        }

        static void AddUser(string uUserName, string uFirstName, string uLastName = null)
        {
            using (var DB = new ImagineShopContext())
            {
                var newUser = new User() { UserName = uUserName, FirstName = uFirstName, LastName = uLastName};
                DB.Users.Add(newUser);
                DB.SaveChanges();

                Console.WriteLine($"User: {uUserName} added to Database.");
            }
        }

        static void AddAdress(string aTitle, string aBody, int aUserID)
        {
            using (var DB = new ImagineShopContext())
            {
                var newAdress = new Adress() { Title = aTitle, Body = aBody, UserID = aUserID };
                DB.Adresses.Add(newAdress);
                DB.SaveChanges();

                Console.WriteLine($@"Adress: {aTitle} added to Database.");
            }
        }

        static void IntroduceUser(int userID)
        {
            using (var DB = new ImagineShopContext())
            {
                var findUser = DB.Users.Where(u => u.ID == userID).FirstOrDefault();

                if (findUser != null)
                {

                    var allAdresses = DB.Adresses.Where(a => a.UserID == findUser.ID).ToList();

                    Console.WriteLine($@"
                        ###########
                        User ID: {findUser.ID},
                        UserName: {findUser.UserName},
                        First Name: {findUser.FirstName},
                        Last Name: {findUser.LastName},
                        All Adresses:");

                    foreach (var f in allAdresses)
                    {
                        Console.WriteLine(@$"
                        Adress ID: {f.ID}
                        Title: {f.Title},
                        Body: {f.Body}");
                    }

                    Console.WriteLine($"There are {allAdresses.Count} adresses belongs to this user.");
                    Console.WriteLine($@"
                        ###########");





                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }
        }

        static void FindUserWithAdress(int cUserID)
        {
            using (var DB = new ImagineShopContext())
            {
                //var findIt = DB.Adresses.Where(c => c.UserID == cUserID).ToList();
                //var findIt = DB.Adresses.Where(c => c.UserID == cUserID).FirstOrDefault();
                //var daUser = DB.Users.Where(c => c.ID == findIt.UserID).FirstOrDefault();

                //Console.WriteLine($"Adress: {findIt.ID}, {findIt.Body}");
                //Console.WriteLine($"asdas: {daUser.UserName}");

                //foreach (var f in findIt)
                //{
                //    var daUser = DB.Users.Where(c => c.ID == f.UserID).FirstOrDefault();

                //    Console.WriteLine(@$"

                //                        ##################################
                //                        Adress Title: {f.Title}
                //                        Adress body: {f.Body},
                //                        Belong to user: {f.User.UserName};
                //                        ##################################
                //    ");
                //}



            }
        }

        static void AddRandomUsers(int amount)
        {
            using (var DB = new ImagineShopContext())
            {
                List<User> randomUsers = new List<User>();
                for (int f = 0; f < amount; f++)
                {
                    randomUsers.Add(new User() { UserName = "userName_" + f, FirstName = "firstName_" + f });
                }

                DB.Users.AddRange(randomUsers);
                DB.SaveChanges();

                Console.WriteLine($@"Random {amount} user/s added to Database.");
            }
        }

        static void AddRandomAdresses(int amount)
        {
            using (var DB = new ImagineShopContext())
            {
                List<Adress> randomADresses = new List<Adress>();

                Random rnd = new Random();
                int userAmount = DB.Users.Where(u => u.ID > 0).ToList().Count;

                for (int f = 0; f < amount; f++)
                {
                    int jayChou = rnd.Next(1, userAmount);
                    randomADresses.Add(new Adress() { Title = "randomTitle_" + f, Body = "randomBody_" + f,  UserID = jayChou});
                }

                DB.Adresses.AddRange(randomADresses);
                DB.SaveChanges();

                Console.WriteLine($@"Random {amount} adresse/s added to Database.");
            }
        }

    }
}

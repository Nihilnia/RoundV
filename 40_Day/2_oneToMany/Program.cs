using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_oneToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello f World!");

            int key = 1;

            while (key == 1)
            {
                Console.WriteLine(@"Options..
                    1)Add Random Users
                    2)Add Random Adresses
                    3)Find a user' s adresse/s
                    4)Add Random Adresses to A User


                    0)Exit


                ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("How many random user/s do you wanna add: ");
                        int randUserAmount = Convert.ToInt32(Console.ReadLine());
                        AddRandomUsers(randUserAmount);
                        break;

                    case "2":
                        Console.WriteLine("How many random adresse/s do you wanna add: ");
                        int randAdressAmount = Convert.ToInt32(Console.ReadLine());
                        AddRandomAdresses(randAdressAmount);
                        break;

                    case "3":
                        Console.WriteLine("User ID To Find Adresse/s: ");
                        int adUserID = Convert.ToInt32(Console.ReadLine());
                        FindAdress(adUserID);
                        break;

                    case "4":
                        Console.WriteLine("Which user? (ID): ");
                        int sAmount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How many random adresses do you wanna add: ");
                        int sUserID = Convert.ToInt32(Console.ReadLine());
                        AddRandomAdressesToUser(sUserID, sAmount);
                        break;

                    case "0":
                        key = 2;
                        break;
                }
            }
        }

        static void AddRandomUsers(int amount)
        {
            using (var DB = new NordaContext())
            {
                var randomUsers = new List<User>();

                for (int f = 0; f < amount; f++)
                {
                    randomUsers.Add(new User()
                    {
                        UserName = "RandomUser_" + f,
                        Email = $"random_{f}@email.com"

                    });
                }

                DB.Users.AddRange(randomUsers);
                DB.SaveChanges();

                Console.WriteLine($"Random {amount} user/s added to database.");
            }
        }

        static void AddRandomAdresses(int amount)
        {
            using (var DB = new NordaContext())
            {
                var randomAdresses = new List<Adress>();

                var random = new Random();
                var userCount = DB.Users.Where(u => u.ID > 0).Count();
                


                for (int f = 0; f < amount; f++)
                {
                    var randomUserIDs = random.Next(0, userCount);

                    randomAdresses.Add(new Adress()
                    {
                        Title = "RandomTitle_" + f,
                        Body = "RandomBody_" + f,
                        UserID = randomUserIDs

                    });

                    Console.WriteLine("#####Random user id: " + randomUserIDs);
                }

                DB.Adresses.AddRange(randomAdresses);
                DB.SaveChanges();

                Console.WriteLine($"Random {amount} adresses added to Database.");
            }
        }

        static void AddRandomAdressesToUser(int aAmount, int aUserID)
        {
            using (var DB = new NordaContext())
            {
                var currentUser = DB.Users.Where(u => u.ID == aUserID).FirstOrDefault();

                if(currentUser != null)
                {
                    currentUser.Adresses = new List<Adress>();

                    for (int f = 0; f < aAmount; f++)
                    {
                        currentUser.Adresses.Add(new Adress()
                        {
                            Title = "SpesificRandomTitle_" + f,
                            Body = "SpesificRandomBody_" + f,
                        });
                    }

                    DB.SaveChanges();

                    Console.WriteLine($"Random {aAmount} adresses added to user: {currentUser.UserName}");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }
        }


        static void FindAdress(int fUserID)
        {
            using (var DB = new NordaContext())
            {
                var theUser = DB.Users.Where(u => u.ID == fUserID).FirstOrDefault();

                if(theUser != null)
                {
                    theUser.Adresses = new List<Adress>();

                    foreach (var f in theUser.Adresses) 
                    {
                        Console.WriteLine(@$"   $$$$$$$$$$$$$$$$$$$$$
                                                Title: {f.Title},
                                                Body: {f.Body},
                                                UserID: {f.UserID},
                                                $$$$$$$$$$$$$$$$$$$$$
                    
                        ");
                    }
                }
                else
                {
                    Console.WriteLine($"User not found.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_oneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //InsertRandomUsers(5);

            int bang = 1;

            while (bang == 1)
            {
                Console.WriteLine(@"
                    1) Add random users
                    2) Add random addresses
                    
                    -99) Exit
        


                ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("How many user do you wanna add:");
                        int randomUserAdd = Convert.ToInt32(Console.ReadLine());
                        InsertRandomUsers(randomUserAdd);
                        break;

                    case "2":
                        InsertRandomAdresses();
                        break;

                    case "-99":
                        bang = 0;
                        break;
                }
            }
        }

        static void InsertRandomUsers(int u)
        {
            using (var DB = new RestaurantContext())
            {
                List<User> randomUsers = new List<User>();

                for (int i = 0; i < u; i++)
                {
                    randomUsers.Add(new User()
                    {
                        UserName = "Gloria_" + i,
                        FullName = "Nihil nia_" + i,
                        EMail = "user_" + i + "@info.com"
                    });
                }

                DB.Users.AddRange(randomUsers);

                DB.SaveChanges();

                Console.WriteLine($@"{u} users added to DB.");
            }
        }

        static void InsertRandomAdresses()
        {
            using (var DB = new RestaurantContext())
            {
                var randomAdresses = new List<Adress>();

                int userz = DB.Users.Where(u => u.ID >= 0).ToList().Count;

                for (int f = 0; f < userz; f++)
                {
                    randomAdresses.Add(new Adress() { FullAdress = "FullAdress_" + f, Title = "Title_" + f, UserID = f });
                }

                DB.AddRange(randomAdresses);

                DB.SaveChanges();

                Console.WriteLine(@$"{randomAdresses}Random addresses added to DB.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_allRelations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = 1;

            while (key == 1)
            {
                Console.WriteLine(@"Options__

                            1)Add New User
                            2)Add New Adress
                            3)Find an User
                            4)Find Adresses


                            0)Exit


                ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("New User Name: ");
                        string newUserName = Console.ReadLine();
                        Console.WriteLine("New User EMail: ");
                        string newUserMail = Console.ReadLine();
                        AddUser(newUserName, newUserMail);
                        break;

                    case "2":
                        Console.WriteLine("New adress title: ");
                        string newAdTitle = Console.ReadLine();
                        Console.WriteLine("New adress body: ");
                        string newAdBody = Console.ReadLine();
                        Console.WriteLine("User ID: ");
                        int newAdUserID = Convert.ToInt32(Console.ReadLine());
                        AddAdress(newAdTitle, newAdBody, newAdUserID);
                        break;

                    case "3":
                        Console.WriteLine("User ID to find: ");
                        int findUser = Convert.ToInt32(Console.ReadLine());
                        FindUser(findUser);
                        break;

                    case "4":
                        Console.WriteLine("UserName_ to find Adresses: ");
                        string adressUserName = Console.ReadLine();
                        FindAdressses(adressUserName);
                        break;

                    case "0":
                        key = 0;
                        break;

                }
            }
        }

        static void FindUser(int fUserID)
        {
            using (var DB = new WitchContext())
            {
                var findUser = DB.Users.Where(f => f.ID == fUserID).FirstOrDefault();
                

                if(findUser != null)
                {
                    findUser.Adresses = new List<Adress>();

                    Console.WriteLine($@"
                    User ID: {findUser.ID},
                    UserName: {findUser.UserName},
                    E-Mail: {findUser.EMail}
                ");

                    Console.WriteLine("All Adresses: ");
                    foreach (var f in findUser.Adresses)
                    {
                        Console.WriteLine(@$"
                        Title: {f.Title},
                        Body: {f.Body}
                    ");
                    }
                }
            }
        }

        static void FindAdressses(string fUserName)
        {
            using (var DB = new WitchContext())
            {
                var findTheUser = DB.Users.Where(u => u.UserName == fUserName).FirstOrDefault();

                if(findTheUser != null)
                {
                    findTheUser.Adresses = new List<Adress>();

                    foreach (var f in findTheUser.Adresses)
                    {
                        Console.WriteLine(@$"##########
                        Title: {f.Title},
                        Body: {f.Body}
                    ");
                    }
                    Console.WriteLine("##########");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }

                

            }
        }
        static void AddUser(string userName, string eMail)
        {
            using (var DB = new WitchContext())
            {
                var newUser = new User() { UserName = userName, EMail = eMail};
                DB.Users.Add(newUser);
                DB.SaveChanges();

                Console.WriteLine($"New user {userName} added to database.");
            }

        }

        static void AddAdress(string aTitle, string aBody, int aUserID)
        {
            using (var DB = new WitchContext())
            {
                var belongsUser = DB.Users.Where(u => u.ID == aUserID).FirstOrDefault();

                if(belongsUser != null)
                {
                    belongsUser.Adresses = new List<Adress>();

                    belongsUser.Adresses.Add(new Adress() { Title = aTitle, Body = aBody });

                    DB.SaveChanges();

                    Console.WriteLine($"New adress: {aTitle} added to user: {belongsUser.UserName}");
                }
                else
                {
                    Console.WriteLine($"Given userID {aUserID} not in the database.");
                }

                
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _3_ManyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int key = 1;

            while (key == 1)
            {
                Console.WriteLine(@"
                    1)Add Random Muhendis
                    
                    
                    0)Exit

                ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("How many: ");
                        int randomAmount = Convert.ToInt32(Console.ReadLine());
                        AddRandomMuhendis(randomAmount);
                        break;


                    case "0":
                        key = 0;
                        break;
                }
            }
        }

        static void AddRandomMuhendis(int amount)
        {
            
            using (var DB = new GloriaContext())
            {
                List<Muhendis> randomMuhendisler = new List<Muhendis>();

                for (int f = 0; f < amount; f++)
                {
                    randomMuhendisler.Add(new Muhendis()
                    {
                        Ad = "RandomMuhendis_" + f,
                        Soyad = "RandomSoyad_" + f,
                        Brans = "RandomBrans_" + f,
                        Bolum = "RandomBolum_" + f,
                        ProjeID = f
                    });
                }

                DB.AddRange(randomMuhendisler);
                DB.SaveChanges();

                Console.WriteLine($"Random {amount} muhendis added to db.");
            }
        }
    }
}

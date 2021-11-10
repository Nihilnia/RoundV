using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_oneToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddArtist();
            //AddInfo();
            //IntroduceArtist();
            YesBandNoBand();
        }

        static void AddArtist()
        {
            using (var DB = new CardigansContext())
            {
                var newArtist = new Artist() { Name = "ArtistX_1" };
                DB.Artists.Add(newArtist);
                DB.SaveChanges();

                Console.WriteLine("Artist added.");
            }
        }

        static void AddInfo()
        {
            using (var DB = new CardigansContext())
            {
                var newInfo = new Info() { FullName = "Aaaax1", YearOfBirth = 2000, isBand = false, Varios = "Rock", ArtistID = 1};
                DB.Infos.Add(newInfo);
                DB.SaveChanges();

                Console.WriteLine("Info added.");
            }
        }

        static void IntroduceArtist()
        {
            using(var DB = new CardigansContext())
            {
                var findArtist = DB.Artists.Where(a => a.ID == 1).Include(i => i.Info).FirstOrDefault();

                Console.WriteLine("Artist name: " + findArtist.Name);
                Console.WriteLine(@$"All other informations:
                    Fullname: {findArtist.Info.FullName},
                    Birth: {findArtist.Info.YearOfBirth},
                    Various: {findArtist.Info.Varios},
                    isBand: {findArtist.Info.isBand}

                ");
            }
        }

        static void YesBandNoBand()
        {
            

            using (var DB = new CardigansContext())
            {
                var addBands = new List<isBand>();

                addBands.Add(new isBand() { TextIsBand = "Yes, it's a band." });
                addBands.Add(new isBand() { TextIsBand = "No, it's not a band." });

                DB.AddRange(addBands);
                DB.SaveChanges();
            }

            
        }
    }
}

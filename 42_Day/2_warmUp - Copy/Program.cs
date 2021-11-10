using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_warmUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int key = 0;

            while (key == 0)
            {
                Console.WriteLine(@$"#### Options:

                    1)Add new Artist
                    2)Add new Song
                    3)Find the Artist

                    4)Add Random Artist/s
                    5)Add Random Song/s


                    0)Exit

                ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Artist name: ");
                        string newArtistName = Console.ReadLine();
                        AddArtist(newArtistName);
                        break;

                    case "2":
                        Console.WriteLine("Song name: ");
                        string newSongName = Console.ReadLine();
                        Console.WriteLine("Duration: ");
                        double newSongDuration = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Artist ID: ");
                        int newSongArtist = Convert.ToInt32(Console.ReadLine());
                        AddSong(newSongName, newSongDuration, newSongArtist);
                        break;

                    case "3":
                        Console.WriteLine("Give the artist ID: ");
                        int findArtistID = Convert.ToInt32(Console.ReadLine());
                        FindArtist(findArtistID);
                        break;

                    case "4":
                        Console.WriteLine("Amount: ");
                        int rndArtistAmount = Convert.ToInt32(Console.ReadLine());
                        AddRandomArtists(rndArtistAmount);
                        break;

                    case "5":
                        Console.WriteLine("Amount: ");
                        int rndSongAmount = Convert.ToInt32(Console.ReadLine());
                        AddRandomSongs(rndSongAmount);
                        break;

                    case "0":
                        key = 1;
                        break;
                }
            }

        }


        //

        static void AddArtist(string aName)
        {
            using (var DB = new GloriaContext())
            {
                var newArtist = new Artist() { Name = aName };
                DB.Artists.Add(newArtist);
                DB.SaveChanges();

                Console.WriteLine(@$"
                # # # # # # # # # # #

                New artist added to database: {aName}

                # # # # # # # # # # #
                ");
            }
        }


        static void AddSong(string sName, double sDuration, int sArtistID)
        {
            using (var DB = new GloriaContext())
            {
                var findArtist = DB.Artists.Where(a => a.ID == sArtistID).FirstOrDefault();

                if(findArtist != null)
                {
                    var newSong = new Song() { Name = sName, Duration = sDuration, ArtistID = sArtistID };
                    DB.Songs.Add(newSong);
                    DB.SaveChanges();

                    Console.WriteLine(@$"
                # # # # # # # # # # #

                New song added to database: {sName}

                # # # # # # # # # # #
                ");
                }
                else
                {
                    Console.WriteLine(@$"
                # # # # # # # # # # #

                Artist not found with ID: {sArtistID}

                # # # # # # # # # # #
                ");
                }
            }
        }

        
        static void FindArtist(int fArtistID)
        {
            using (var DB = new GloriaContext())
            {
                var findArtist = DB.Artists.Include(s => s.Songs).Where(a => a.ID == fArtistID).FirstOrDefault();

                if(findArtist != null)
                {
                    Console.WriteLine(@$"

                    Artist found: {findArtist.Name}");

                    if (findArtist.Songs.Count > 0)
                    {
                        foreach (var f in findArtist.Songs)
                        {
                            Console.WriteLine(@$"Song ID: {f.ID}, Song Name: {f.Name}, Duration: {f.Duration}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This artist has no song yet.");
                    }

                    
                }
                else
                {
                    Console.WriteLine(@$"
                # # # # # # # # # # #

                Artist not found with ID: {fArtistID}

                # # # # # # # # # # #
                ");
                }
            }
        }


        static void AddRandomArtists(int aAmount)
        {
            using (var DB = new GloriaContext())
            {
                var randomArtists = new List<Artist>();

                Random rnd = new Random();
                var countOfArtists = DB.Artists.Count();

                for (int f = 0; f < aAmount; f++)
                {
                    var randomNumb = rnd.Next(countOfArtists, countOfArtists + 100);
                    randomArtists.Add(new Artist() { Name = "randomArtistX_" + randomNumb });
                }

                DB.Artists.AddRange(randomArtists);
                DB.SaveChanges();

                Console.WriteLine(@$"Random {aAmount} artist added to Database.");
            }

            
        }


        static void AddRandomSongs(int sAmount)
        {
            using (var theDB = new GloriaContext())
            {
                var randomSongs = new List<Song>();

                Random rnd = new Random();
                var countOfSongs = theDB.Songs.Count();

                var countOfArtists = theDB.Artists.Count();

                for (int f = 0; f < sAmount; f++)
                {
                    var randomNumb = rnd.Next(countOfSongs, countOfSongs + 100);
                    randomSongs.Add(new Song() { Name = "randomSongX_" + randomNumb, Duration = 2.22, ArtistID = rnd.Next(1, countOfArtists + 1) });
                }

                theDB.Songs.AddRange(randomSongs);
                theDB.SaveChanges();

                Console.WriteLine(@$"Random {sAmount} song/s added to Database.");
            }
        }
    }
}

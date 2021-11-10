using System;
using System.Linq;

namespace _2_oneToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int key = 0;

            while (key == 0) {

                Console.WriteLine(@"Options:
                    1)Add A Song
                    2)Add an Artist
                    3)Introduce an Artist/Band




                    0)Exit

                ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Song name: ");
                        string newSongName = Console.ReadLine();
                        Console.WriteLine("Duration: ");
                        double newSongDuration = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Category: ");
                        string newSongCategory = Console.ReadLine();
                        Console.WriteLine("Artist ID: ");
                        int newSongArtistID = Convert.ToInt32(Console.ReadLine());
                        AddSong(newSongName, newSongCategory, newSongDuration, newSongArtistID);
                        break;

                    case "2":
                        Console.WriteLine("Artist name: ");
                        string newArtistName = Console.ReadLine();
                        Console.WriteLine("A band?: ");
                        bool newArtistIsBand = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine("Category: ");
                        string newArtistCategory = Console.ReadLine();
                        AddArtist(newArtistName, newArtistIsBand, newArtistCategory);
                        break;

                    case "3":
                        Console.WriteLine("Artist/Band ID:");
                        int givenID = Convert.ToInt32(Console.ReadLine());
                        AllSongsOfAnArtist(givenID);
                        break;


                    case "0":
                        key = 1;
                        break;
                }



            }
        }

        static void AddSong(string sSongName, string sCategory, double sDuration, int sArtistID)
        {
            using (var DB = new GloriaGridContext())
            {
                var findArtist = DB.Artists.Where(a => a.ID == sArtistID).FirstOrDefault();

                if(findArtist != null)
                {
                    var newSong = new Song() { Name = sSongName, Duration = sDuration, Category = sCategory, Artist = findArtist };
                    DB.Songs.Add(newSong);
                    DB.SaveChanges();

                    Console.WriteLine($@"New song : {sSongName} added to artist {findArtist.Name}' s portfolio.");
                }
                else
                {
                    Console.WriteLine("Artist not found.");
                }

                
            }
                
        }

        static void AddArtist(string aName, bool aIsBand, string aCategory)
        {
            using (var Grid = new GloriaGridContext())
            {
                var newArtist = new Artist() { Name = aName, Category = aCategory, isBand = aIsBand };
                Grid.Add(newArtist);
                Grid.SaveChanges();

                Console.WriteLine($"Artist: {aName} added to Grid.");
            }
        }

        static void AllSongsOfAnArtist(int xArtistID)
        {
            using (var DB = new GloriaGridContext())
            {
                var findTheArtist = DB.Artists.Where(a => a.ID == xArtistID).FirstOrDefault();

                if(findTheArtist != null)
                {
                    var allDaSongs = DB.Songs.Where(s => s.ArtistID == findTheArtist.ID).ToList();

                    var isBand = "No, it's not a band.";

                    if(findTheArtist.isBand == true)
                    {
                        isBand = "Yes, it's a band.";
                    }

                    Console.WriteLine(@$"

                            ##########
                                ID: {findTheArtist.ID},
                                Artist: {findTheArtist.Name},
                                isBand?: {isBand}.                             
                    
                    ");

                    foreach(var f in allDaSongs)
                    {
                        Console.WriteLine(@$"
                            ALL DA SONGS
                            ##########
                                Song Name: {f.Name},
                                Duration: {f.Duration},
                                Category: {f.Category},
                        ");
                    }
                }
                else
                {
                    Console.WriteLine("Artist not found.");
                }
            }
        }
    }
}

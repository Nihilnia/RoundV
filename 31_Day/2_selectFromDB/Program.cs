using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_selectFromDB
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 1;

            while (key == 1)
            {
                Console.WriteLine(@$"

                    Here is the options:

                    1) Add a new song
                    2) Add multiple new songs
                    3) Get All Songs
                    4) Get a Song by ID:
                    5) Get a Song by Name:
                    6) Get a Song by Artist:
                    0)Exit

                ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        AddSong();
                        break;

                    case "2":
                        Console.WriteLine("How many songs do you wanna add: ");
                        int freak = Convert.ToInt32(Console.ReadLine());
                        AddSongs(freak);
                        break;

                    case "3":
                        GetAllSongs();
                        break;

                    case "4":
                        Console.WriteLine("Song ID To Find: ");
                        int findID = Convert.ToInt32(Console.ReadLine());
                        GetSongByID(findID);
                        break;

                    case "5":
                        Console.WriteLine("Song Name To Find: ");
                        string findName = Console.ReadLine();
                        GetSongByName(findName);
                        break;

                    case "6":
                        Console.WriteLine("Artist Name To Find: ");
                        string artistName = Console.ReadLine();
                        GetSongByArtist(artistName);
                        break;

                    case "0":
                        key = 0;
                        break;
                }
            }
        }



        static void AddSong()
        {
            using (var DB = new SongsDB_01Context())
            {
                Console.WriteLine("Song name: ");
                string songName = Console.ReadLine();

                Console.WriteLine("Artist: ");
                string artist = Console.ReadLine();

                Console.WriteLine("Length: ");
                double songLength = Convert.ToDouble(Console.ReadLine());

                var newSong = new Song() { Name = songName, Artist = artist, Length = songLength };

                DB.Songs.Add(newSong);

                DB.SaveChanges();

                Console.WriteLine("New song added to database..");
            }
        }

        static void AddSongs(int howMany)
        {

            using (var DB = new SongsDB_01Context())
            {

                List<Song> multipleSongs = new List<Song>();

                for (int f = 0; f < howMany; f++)
                {
                    Console.WriteLine($"{f + 1}.Song name: ");
                    string songName = Console.ReadLine();

                    Console.WriteLine($"{f + 1}.Artist: ");
                    string artist = Console.ReadLine();

                    Console.WriteLine($"{f + 1}.Length: ");
                    double songLength = Convert.ToDouble(Console.ReadLine());

                    multipleSongs.Add(new Song() { Name = songName, Artist = artist, Length = songLength });
                }



                DB.Songs.AddRange(multipleSongs);

                DB.SaveChanges();

                Console.WriteLine("New song/s added to database..");
            }
        }

        static void GetAllSongs()
        {
            using (var DB = new SongsDB_01Context())
            {
                var allSongs = DB.Songs.Select(s => new
                {
                    s.Name,
                    s.Artist,
                    s.Length
                }).ToList();

                foreach (var f in allSongs)
                {
                    Console.WriteLine($@"
                -----------------------------
                    Song: {f.Name},
                    Artist: {f.Artist},
                    Length: {f.Length}
                -----------------------------


                ");
                }
            }
        }

        static void GetSongByID(int ID)
        {
            using (var DB = new SongsDB_01Context())
            {
                var theSong = DB.Songs.Where(s => s.ID == ID).FirstOrDefault();

                if (theSong != null)
                {
                    Console.WriteLine($@"
                -----------------------------
                    Song: {theSong.Name},
                    Artist: {theSong.Artist},
                    Length: {theSong.Length}
                -----------------------------


                ");
                }
                else
                {
                    Console.WriteLine("Song not found..");
                }


            }
        }

        static void GetSongByName(string sName)
        {
            using (var DB = new SongsDB_01Context())
            {
                var theSongZ = DB.Songs.Where(s => s.Name.ToLower().Contains(sName.ToLower())).ToList();

                Console.WriteLine(@$"{theSongZ.Count}' song/s found:");

                foreach (var f in theSongZ)
                {
                    Console.WriteLine($@"
                -----------------------------
                    Song: {f.Name},
                    Artist: {f.Artist},
                    Length: {f.Length}
                -----------------------------


                ");


                }
            }
        }

        static void GetSongByArtist(string aName)
        {
            using (var DB = new SongsDB_01Context())
            {
                var theSongZ = DB.Songs.Where(s => s.Artist.ToLower().Contains(aName.ToLower())).ToList();

                Console.WriteLine(@$"{aName}'s {theSongZ.Count}' song/s found:");

                foreach (var f in theSongZ)
                {
                    Console.WriteLine($@"
                -----------------------------
                    Song: {f.Name},
                    Artist: {f.Artist},
                    Length: {f.Length}
                -----------------------------


                ");


                }
            }
        }
    }
}
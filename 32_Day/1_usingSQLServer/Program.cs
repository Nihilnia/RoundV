using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_updateDB
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
                    4) Get a Song by ID
                    5) Get a Song by Name
                    6) Get a Song by Artist
                    7) Update a Song
                    8) Delete a Song by ID
                    9) Delete a Song by Name
                    10) Add Random Songs to DB
                    -1) Gloria- Update
                    -2) Gloria- Delete
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

                    case "7":
                        Console.WriteLine("Song ID To Update: ");
                        int updateSongID = Convert.ToInt32(Console.ReadLine());
                        UpdateSongByID(updateSongID);
                        break;

                    case "8":
                        Console.WriteLine("Song ID To Delete: ");
                        int deleteIt = Convert.ToInt32(Console.ReadLine());
                        DeleteSongByID(deleteIt);
                        break;
                    
                    case "9":
                        Console.WriteLine("Song Name To Delete: ");
                        string deleteByName = Console.ReadLine();
                        DeleteSongByName(deleteByName);
                        break;

                    case "10":
                        Console.WriteLine("How many random songs do you wanna add?: ");
                        int userRandom = Convert.ToInt32(Console.ReadLine());
                        AddRandomSongs(userRandom);
                        break;

                    case "-1":
                        UpdateGloria();
                        break;

                    case "-2":
                        DeleteGloria();
                        break;

                    case "0":
                        key = 0;
                        break;
                }
            }
        }



        static void AddSong()
        {
            using (var DB = new SongsDB_02Context())
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

            using (var DB = new SongsDB_02Context())
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
            using (var DB = new SongsDB_02Context())
            {
                var allSongs = DB.Songs.AsNoTracking().Select(s => new
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

                Console.WriteLine($"There are {allSongs.Count} song/s in the database rn.");
            }
        }

        static void GetSongByID(int ID)
        {
            using (var DB = new SongsDB_02Context())
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
            using (var DB = new SongsDB_02Context())
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
            using (var DB = new SongsDB_02Context())
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

        static void UpdateSongByID(int ID)
        {
            using (var DB = new SongsDB_02Context())
            {
                var theSong = DB.Songs.Where(s => s.ID == ID).FirstOrDefault();

                if(theSong != null)
                {
                    theSong.Artist = "Gloria";
                    DB.SaveChanges();

                    Console.WriteLine(@$"-- Song: {theSong.Name}' s artist changed as Gloria.");
                }
            
            }

             
        }

        static void DeleteSongByID(int ID)
        {
            using (var DB = new SongsDB_02Context())
            {
                var songToDelete = DB.Songs.Where(s => s.ID == ID).FirstOrDefault();

                if(songToDelete != null)
                {
                    DB.Songs.Remove(songToDelete);
                    DB.SaveChanges();

                    Console.WriteLine($@"Song {songToDelete.Name} deleted from DB.");
                }
                else
                {
                    Console.WriteLine("Song not found.");
                }
            }
        }

        static void DeleteSongByName(string Name)
        {
            using (var DB = new SongsDB_02Context())
            {
                var songToDelete = DB.Songs.Select(s => new { 
                    s.ID,
                    s.Name,
                    s.Artist
                }).Where(s => s.Name == Name).ToList();

                if (songToDelete.Count > 1)
                {
                    Console.WriteLine("Found song/s");
                    foreach (var f in songToDelete)
                    {
                        Console.WriteLine($@"Song ID: {f.ID} name: {f.Name}, artist: {f.Artist}");
                        
                    }

                    Console.WriteLine("Which one do you wanna delete (ID): ");
                    int usrChc = Convert.ToInt32(Console.ReadLine());
                    DeleteSongByID(usrChc);

                }
                else
                {
                    Console.WriteLine("Found song");
                    foreach (var f in songToDelete)
                    {
                        Console.WriteLine($@"Song ID: {f.ID} name: {f.Name}, artist: {f.Artist}");
                        Console.WriteLine("Do you wanna delete this song? (Y/N): ");
                        string usrChc = Console.ReadLine();
                        if(usrChc.ToLower() == "y")
                        {
                            DeleteSongByID(f.ID);
                        }
                        else
                        {
                            Console.WriteLine("Goodbye then.");
                        }

                    }
                }

                
            }
        }

        static void AddRandomSongs(int howMany)
        {
            using (var theDB = new SongsDB_02Context())
            {
                var key = 0;
                List<Song> randomSongz = new List<Song>();
                while(key < howMany)
                {
                    randomSongz.Add(new Song { Name = "Song_" + key.ToString(), Artist = "Artist_" + key.ToString(), Length = 123 + key });
                    key++;
                }

                theDB.Songs.AddRange(randomSongz);
                theDB.SaveChanges();

                Console.WriteLine($"{howMany} Random Songs added to Database..");
            }
        }

        static void UpdateGloria()
        {
            using (var DB = new SongsDB_02Context())
            {
                var updateEm = DB.Songs.Where(s => s.ID != -1).ToList();

                foreach(var f in updateEm)
                {
                    f.Artist = "Gloria";
                    f.Name = "Gloria";
                    f.Length = 99999;
                    DB.SaveChanges();

                    Console.WriteLine(@"


                    -------------------
                     ALL OF EM CHANGED
                    -------------------


                    ");
                }
            }
        }

        static void DeleteGloria()
        {
            using (var DB = new SongsDB_02Context())
            {
                var allOfEm = DB.Songs.Where(s => s.ID != -1).ToList();

                foreach (var f in allOfEm)
                {
                    DB.Songs.Remove(f);
                    DB.SaveChanges();

                    Console.WriteLine(@"


                    -------------------
                     ALL OF EM DELETED
                    -------------------


                    ");
                }
            }
        }
    }
}
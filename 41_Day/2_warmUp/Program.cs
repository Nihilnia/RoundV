using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace _2_warmUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddSong();
            FindArtist();
        }

        static void FindArtist()
        {
            using (var DB = new SongLibraryContext())
            {
                var theArtist = DB.Artists.Include("Songs").Where(a => a.ID == 1).FirstOrDefault();


                if (theArtist != null)
                {
                    Console.WriteLine(@$"Artist ID: {theArtist.ID}, Name: {theArtist.Name}");

                    foreach (var f in theArtist.Songs)
                    {
                        Console.WriteLine($@"Song Name: {f.Name},
                                            Duration: {f.Duration}
                        ");
                    }
                }
            }
        }

        static void AddArtist()
        {
            using (var DB = new SongLibraryContext())
            {
                var newArtist = new Artist() { Name = "Artist_X1" };
                DB.Artists.Add(newArtist);

                DB.SaveChanges();

                Console.WriteLine("Success.");
            }
        }

        static void AddSong()
        {
            using (var DB = new SongLibraryContext())
            {
                var newSong = new Song() { Name = "Song_X2", Duration = 3.44, ArtistID = 1};
                DB.Songs.Add(newSong);

                DB.SaveChanges();

                Console.WriteLine("Success.");
            }
        }
    }
}

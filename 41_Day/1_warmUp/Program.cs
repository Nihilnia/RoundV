using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_warmUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddArtist();
            AddSong();

            using (var DB = new PlaylistContext())
            {
                var theArtist = DB.Artists.Where(a => a.Id == 1).FirstOrDefault();
                foreach (var item in theArtist.Songs)
                {
                    Console.WriteLine(item.Name);
                }
            }

        }

        static void AddArtist()
        {
            using (var DB = new PlaylistContext())
            {
                var newArtist = new Artist() { Name = "Artist_x1" };
                DB.Artists.Add(newArtist);
                DB.SaveChanges();

                Console.WriteLine("Artist added to db.");
            }
        }

        static void AddSong()
        {
            using(var DB = new PlaylistContext())
            {
                var newSong = new Song() { Name = "Songx_2", Duratio = 2.32, ArtistId = 1 };
                DB.Song.Add(newSong);
                DB.SaveChanges();

                Console.WriteLine("Added to db, song.");
            }

            
            
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_DataSeeding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DataFeeeeeding.Feeeed(new LibraryContext());
        }

        public static class DataFeeeeeding
        {

            public static void Feeeed(DbContext context)
            {
                if (context.Database.GetPendingMigrations().Count() == 0)
                {
                    LibraryContext _context = context as LibraryContext;


                    //Check if there are info's in tables.
                    if(_context.Artists.Count() == 0)
                    {
                        _context.Artists.AddRange(AddArtists());
                    }
                    if (_context.Songs.Count() == 0)
                    {
                        _context.Songs.AddRange(AddSongs());
                    }

                    context.SaveChanges();

                    Console.WriteLine("d o n e.");
                }
            }

            private static List<Artist> AddArtists()
            {
                var newArtists = new List<Artist>()
                {
                    new Artist(){Name = "newArtistXYZ_01"},
                    new Artist(){Name = "newArtistXYZ_02"},
                    new Artist(){Name = "newArtistXYZ_03"},
                    new Artist(){Name = "newArtistXYZ_04"}
                };

                return newArtists;
            }

            private static List<Song> AddSongs()
            {
                var newSongs = new List<Song>()
                {
                    new Song(){Name = "newSongXYZ_01", Length = 1.12},
                    new Song(){Name = "newArtistXYZ_02", Length = 2.2342},
                    new Song(){Name = "newArtistXYZ_03", Length = 3.1234},
                    new Song(){Name = "newArtistXYZ_04", Length = 4.56}
                };

                return newSongs;
            }
        }
    }
}

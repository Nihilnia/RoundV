using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DataSeeding
{
    internal class LibraryContext: DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = SongLibrary.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

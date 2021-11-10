using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_warmUp
{
    internal class GloriaContext: DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<JubileeStreet> JubileeStreets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Gloria.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

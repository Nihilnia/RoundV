using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_oneToMany
{
    internal class GloriaGridContext: DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<CheckBand> CheckBand { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Gloria.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

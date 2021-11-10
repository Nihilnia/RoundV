using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_oneToOne
{
    internal class CardigansContext: DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<isBand> IsBands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Toxic.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

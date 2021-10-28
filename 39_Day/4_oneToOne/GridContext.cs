using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_oneToOne
{
    internal class GridContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Grid.db");
            //optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

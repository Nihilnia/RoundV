using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_oneToOne
{
    internal class GridContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Information> Informations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = StudentGrid.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

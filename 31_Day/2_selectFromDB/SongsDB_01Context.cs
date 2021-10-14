using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_selectFromDB
{
    class SongsDB_01Context: DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = SongsDB_01.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

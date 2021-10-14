using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_updateDB
{
    class SongsDB_02Context: DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = SongsDB_02.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

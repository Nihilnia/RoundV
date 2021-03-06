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
        public DbSet<Gloria> Glorian { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //MySQL
            //optionsBuilder.UseMySQL(@"server = localhost; port = 3306; database = Recep; user = root; password = 1234;"); 

            //SQL
            //optionsBuilder.UseSqlServer(@"Data Source  = .\SQLEXPRESS; Initial Catalog = SongsDB_04; Integrated Security = SSPI");   

            //SqlLite
            optionsBuilder.UseSqlite("Data Source = SongsDB_02.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_oneToMany
{
    class RestaurantContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Restaurant.db");
        }
    }
}

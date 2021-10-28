using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_warmUp
{
    internal class warmup_01Context: DbContext
    {
        public DbSet<Gloria> Glorian { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = WarmUp_01.db");
        }
    }
}

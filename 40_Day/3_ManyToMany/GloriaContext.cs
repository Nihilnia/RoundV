using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ManyToMany
{
    internal class GloriaContext: DbContext
    {
        public DbSet<Muhendis> Muhendisler { get; set; }
        public DbSet<Proje> Projeler { get; set; }
        public DbSet<MuhendisProje> MuhendislerProjeler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ProjectGloria.db");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}

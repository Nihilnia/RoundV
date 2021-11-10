using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_warmUp
{
    class PlaylistContext: DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Song { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = MaPlaylist.db");
        }
    }
}

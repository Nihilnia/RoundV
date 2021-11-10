using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_warmUp
{
    class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Duratio { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
    }
}

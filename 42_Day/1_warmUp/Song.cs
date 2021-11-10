using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_warmUp
{
    internal class Song
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        public Artist Artist { get; set; }
        public int ArtistID { get; set; }
    }
}

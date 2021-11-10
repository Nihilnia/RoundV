using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_oneToMany
{
    internal class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool isBand { get; set; }
        public string Category { get; set; }
        public List<Song> Songs { get; set; }
    }
}

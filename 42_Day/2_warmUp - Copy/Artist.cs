using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_warmUp
{
    internal class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public JubileeStreet JubileeStreet { get; set; }
    }
}

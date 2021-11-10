using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_oneToOne
{
    internal class Artist
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public Info Info { get; set; }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_oneToOne
{
    internal class Info
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; }
        public int YearOfBirth { get; set; }
        public bool isBand { get; set; }
        public string Varios { get; set; }
        public Artist Artist { get; set; }
        public int ArtistID { get; set; }



    }
}

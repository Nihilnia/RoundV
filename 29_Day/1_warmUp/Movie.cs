using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_warmUp
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}

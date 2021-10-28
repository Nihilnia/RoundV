using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_oneToOne
{
    internal class Car
    {
        [Key]
        public int ID { get; set; }
        public Model Model { get; set; }
       
    }
}

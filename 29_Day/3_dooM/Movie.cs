﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_dooM
{
    class Movie
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Year { get; set; }
    }
}

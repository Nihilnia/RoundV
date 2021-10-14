using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_dooM
{
    class Category
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
    }
}

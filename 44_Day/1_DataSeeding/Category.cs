using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DataSeeding
{
    internal class Category
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50), MinLength(5)]
        public string Name { get; set; }
        public int ProductID { get; set; }
    }
}

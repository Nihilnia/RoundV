using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_oneToMany
{
    internal class Adress
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Body { get; set; }

        public User User { get; set; }
        public int UserID { get; set; }
    }
}

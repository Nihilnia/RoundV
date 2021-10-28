using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_oneToMany
{
    class Adress
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string FullAdress { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_oneToMany
{
    class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(100)]
        public string EMail { get; set; }

        public List<Adress> Adresses { get; set; }

    }
}

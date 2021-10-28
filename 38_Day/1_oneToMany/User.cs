using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_oneToMany
{
    internal class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(15)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Adress> Adresses { get; set; }
    }
}

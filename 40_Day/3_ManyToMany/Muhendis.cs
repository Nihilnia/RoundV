using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ManyToMany
{
    internal class Muhendis
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Bolum { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ad { get; set; }

        [Required]
        [MaxLength(50)]
        public string Soyad { get; set; }

        [Required]
        [MaxLength(50)]
        public string Brans { get; set; }

        public List<Proje> Projeler { get; set; }
        public int ProjeID { get; set; }
    }
}

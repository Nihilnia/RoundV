using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ManyToMany
{
    internal class Proje
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ad { get; set; }

        [Required]
        [MaxLength(50)]
        public string Tanim { get; set; }

        [Required]
        public double Baslangic { get; set; }

        [Required]
        public double Bitis { get; set; }

        public List<Muhendis> Muhendisler { get; set; }
        public int MuhendisID { get; set; }
    }
}

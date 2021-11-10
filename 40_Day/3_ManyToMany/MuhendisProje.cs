using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ManyToMany
{
    internal class MuhendisProje
    {
        public int ID { get; set; }
        public List<Muhendis> Muhendisler { get; set; }
        public List<Proje> Projeler { get; set; }
    }
}

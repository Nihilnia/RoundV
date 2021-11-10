using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_manyToMany
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime InsertDate { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public List<ProductCategory> ProductCategories { get; set; }
    }
}

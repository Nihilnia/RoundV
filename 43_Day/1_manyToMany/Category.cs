using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_manyToMany
{
    internal class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}




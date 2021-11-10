using _3_ScaffoldingDatabase.Data.Lily;
using System;
using System.Linq;

namespace _3_ScaffoldingDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UpdateProductsDescription("D3V1L");
            
        }


        static void UpdateProductsDescription(string newDescription)
        {
            using (var DB = new LilyContext())
            {
                var allProducts = DB.Products.Where(p => p.Id % 2 == 1).ToList();

                int key = 0;

                foreach (var f in allProducts)
                {
                    f.Description = newDescription;
                    key ++;
                }

                DB.SaveChanges();

                Console.WriteLine(@$"Updated succesfuly. {key} rows affected.");
            }
        }
    }
}

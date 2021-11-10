using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_DataSeeding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //HelperMethods.sayHi("asd");

            //AddProduct("KillaBlokk", new List<Category>() { new Category() { Name = "Cat_01" }, new Category() { Name = "Cat_02" } });
            //AddCategory("MF");

            DataSeeding.Seed(new ShopContext());
        }

        //static void AddProduct(string pName, List<Category> pCategory)
        //{
        //    using (var DB = new ShopContext())
        //    {
        //        var newProduct = new Product() { Name = pName};
        //        if (pCategory.Count > 1)
        //        {
        //            for (int f = 0; f < pCategory.Count; f++)
        //            {
        //                DB.Categories.Add(new Category() { Name = pCategory[f].ToString(), Product = newProduct });
        //            }
        //        }
        //        else
        //        {
        //            DB.Categories.Add(new Category() { Name = pCategory[0].ToString(), Product = newProduct });
        //        }

        //        DB.Products.Add(newProduct);
        //        DB.SaveChanges();

        //        Console.WriteLine($"New product {pName} added to database with following categories:");

        //        foreach (var f in pCategory)
        //        {
        //            Console.WriteLine($"---> {f}");
        //        }

        //        //newProduct.Categories.Add(new Category() { Name = "Deneme", Product = newProduct });
        //    }
        //}


        //static void AddCategory(string cName)
        //{
        //    using (var DB = new ShopContext())
        //    {
        //        var newCat = new Category() { Name = cName , ProductID = 1};
        //        DB.Categories.Add(newCat);
        //        DB.SaveChanges();

        //        Console.WriteLine("New category added to db.");
        //    }
        //}

        static class DataSeeding
        {
            public static void Seed(DbContext daContext)
            {
                if (daContext.Database.GetPendingMigrations().Count() == 0)

                {
                    if (daContext is ShopContext)
                    {
                        ShopContext _daContext = daContext as ShopContext;
                        if (_daContext.Products.Count() == 0)
                        {
                            _daContext.Products.AddRange(AddProducts());
                        }
                        if (_daContext.Categories.Count() == 0)
                        {
                            _daContext.Categories.AddRange(AddCategories());
                        }

                        

                        
                    }

                    daContext.SaveChanges();
                }
            }

            private static List<Product> AddProducts()
            {
                var newProducts = new List<Product>()
                {
                    new Product() { Name = "ProductXYZ_01"},
                    new Product() { Name = "ProductXYZ_02"},
                    new Product() { Name = "ProductXYZ_03"},
                    new Product() { Name = "ProductXYZ_04"},
                };
                
                return newProducts;
            }

            private static List<Category> AddCategories()
            {
                var newCategories = new List<Category>()
                {
                    new Category() { Name = "CategoryXYZ_01"},
                    new Category() { Name = "CategoryXYZ_01"},
                    new Category() { Name = "CategoryXYZ_01"},
                    new Category() { Name = "CategoryXYZ_01"}
                };

                return newCategories;
            }
        }
    }
}

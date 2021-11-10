using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_manyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddProducts(2);
            //AddCategories()
            //RelateThem();
            FindProduct(15);

            //AddANewProduct(pName: "Close", pPrice: 99.0);
            //UpdateProduct(pID: 15, pNewName: "Higher");
        }

        static void AddANewProduct(string pName, double pPrice)
        {
            using (var DB = new ShopContext())
            {
                var newProduct = new Product() { Name = pName, Price = pPrice};
                DB.Products.Add(newProduct);
                DB.SaveChanges();

                Console.WriteLine("New product added to database bitches.");
            }
        }

        static void UpdateProduct(int pID, string pNewName)
        {
            using (var theDB = new ShopContext())
            {
                var findProduct = theDB.Products.Find(pID);
                if (findProduct != null)
                {
                    findProduct.Name = pNewName;
                    theDB.SaveChanges();
                }
            }
        }


        static void AddProducts(int amount)
        {
            using (var DB = new ShopContext())
            {
                var newProducts = new List<Product>();

                for (int f = 0; f < amount; f++)
                {
                    newProducts.Add(new Product() { Name = "Product_" + f, Price = 10 });
                }

                DB.Products.AddRange(newProducts);
                DB.SaveChanges();

                Console.WriteLine($@"{amount} Products added to database.");
            }
        }

        static void AddCategories()
        {
            using (var DB = new ShopContext())
            {
                var newCategories = new List<Category>() {
                    new Category() { Name = "Computer" },
                    new Category() { Name = "Electronic" },
                    new Category() { Name = "Watch" }};

                DB.Categories.AddRange(newCategories);
                DB.SaveChanges();

                Console.WriteLine("New categories added to database.");
            }
        }

        static void RelateThem()
        {
            using (var DB = new ShopContext())
            {
                var theProduct = DB.Products.Find(1);
                int[] catIDs = new int[2] { 1, 2 };

                theProduct.ProductCategories = catIDs.Select(cID => new ProductCategory()
                {
                    ProductID = theProduct.ID,
                    CategoryID = cID
                }).ToList();

                DB.SaveChanges();
            }
        }

        static void FindProduct(int pID)
        {
            using (var DB = new ShopContext())
            {
                var theProduct = DB.Products.Include(p => p.ProductCategories).Where(p => p.ID == pID).FirstOrDefault();

                var theProductCats = theProduct.ProductCategories.ToList();

                var daCategories = DB.Categories.Where(c => c.ID > 0).ToList();



                Console.WriteLine($@"
                    Product ID: {theProduct.ID}
                    Product Name: {theProduct.Name}
                ");

                Console.WriteLine("And da categories:");

                foreach (var f in theProductCats)
                {
                    Console.WriteLine($"{daCategories[f.CategoryID - 1].Name}");
                }


            }
        }
    }
}

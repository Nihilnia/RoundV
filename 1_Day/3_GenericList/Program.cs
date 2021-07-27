using System;
using System.Collections.Generic;

namespace _3_GenericList
{
    class Gloria
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //* GenericList */

            //? You have to assign the type of the list when you're creating them
            List<int> numberZ = new List<int>();
            numberZ.Add(1);
            numberZ.Add(2);
            numberZ.Add(3);
            numberZ.Add(4);
            numberZ.Add(5);

            Console.WriteLine("List<int>;");
            foreach(var f in numberZ)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\n");
            //Add

            List<string> nameZ = new List<string> {"Nihil", "Gloria"};
            nameZ.Add("No Scrubs");

            Console.WriteLine("List<string>;");
            foreach (var f in nameZ)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\n");

            List<Gloria> listGloria = new List<Gloria>() { 
                new Gloria() {ID = 0, Name = "Glr_01"},
                new Gloria() {ID = 1, Name = "Glr_02"},
                new Gloria() {ID = 2, Name = "Glr_03"},
                new Gloria() {ID = 3, Name = "Glr_04"},
                new Gloria() {ID = 4, Name = "Glr_05"},
            };

            listGloria.Add(new Gloria() { ID = 5, Name = "Glr_06" });

            Console.WriteLine("List<Gloria>;");
            foreach (var f in listGloria)
            {
                Console.WriteLine(f.Name + " " + f.ID);
            }

            Console.WriteLine("\n");
            //AddRange

            List<Gloria> listGloria_02 = new List<Gloria>() { new Gloria() { ID = 6, Name = "Glr_07" }};
            var Glr_08 = new Gloria();
            Glr_08.ID = 7;
            Glr_08.Name = "Glr_08";
            listGloria_02.Add(Glr_08);

            Console.WriteLine("List<Gloria> 2;");

            foreach (var f in listGloria_02)
            {
                Console.WriteLine(f.Name + " " + f.ID);
            }

            Console.WriteLine("\n");
            Console.WriteLine("After combine them;");

            listGloria_02.AddRange(listGloria);

            foreach (var f in listGloria_02)
            {
                Console.WriteLine(f.Name + " " + f.ID);
            }

            Console.WriteLine("\n\nInsert");
            //Insert, same like ArrayList

            listGloria_02.Insert(0, new Gloria() { ID = 8, Name = "Glr_09_______" });

            foreach (var f in listGloria_02)
            {
                Console.WriteLine(f.Name + " " + f.ID);

            }

            Console.WriteLine("\nInsertRange");
            //InsertRange, same like ArrayList

            List<Gloria> XYZ = new List<Gloria>() { new Gloria() { ID = 9, Name = "Glr_10_______" } };

            XYZ.InsertRange(1, listGloria_02);

            foreach (var f in XYZ)
            {
                Console.WriteLine(f.Name + " " + f.ID);
            }

            Console.WriteLine("\nCount");
            //Count
            Console.WriteLine(listGloria_02.Count);

            //Remove, RemoveAt, same like arrayList

        }
    }
}

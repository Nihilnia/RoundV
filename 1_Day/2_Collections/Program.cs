using System;
using System.Collections;

namespace _2_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //* Arrays */
            //? They are fixed (type[] = new type[size])
            int[] numberZ = new int[5];
            numberZ[0] = 1;
            numberZ[1] = 2;
            numberZ[2] = 3;
            numberZ[3] = 4;
            numberZ[4] = 5;

            foreach(var f in numberZ)
            {
                Console.WriteLine(f);
            }


            //* Collections
            //1- Non- Generic Collections
            //? **ArrayList, **SortedList

            //! ARRAY LIST
            ArrayList myList = new ArrayList();
            for(var f = 0; f < 10; f++)
            {
                myList.Add(f + 1);
            }

            foreach(var f in myList)
            {
                Console.WriteLine($"{f}.Item: " + f);
            }

            ArrayList myList_02 = new ArrayList() { 10, 20, 30, 40, 50 };
            myList_02.Add("asdas");
            myList_02.Add("asdas2");

            //Insert(index, object);

            myList_02.Insert(1, "Bang ba bang");

            foreach(var f in myList_02)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\n############\n");

            //InsertRange (adding a list to the list)
            myList_02.InsertRange(2, myList);
            Console.WriteLine("myList2 has changed;");
            foreach (var f in myList_02)
            {
                Console.WriteLine(f);
            }


            //Remove (remove with object)
            ArrayList Gloria = new ArrayList() { 1, 2, 3, 4, 5};
            Gloria.Remove(3);

            foreach(var f in Gloria)
            {
                Console.WriteLine(f);
            }
            
            //RemoveAt (remove with index)
            ArrayList Gloria2 = new ArrayList() { 1, 2, 3, 4, 5};
            Gloria2.RemoveAt(0);

            foreach(var f in Gloria2)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\n\nRemoveRange();");

            //RemoveRange (bulk remove)
            ArrayList Gloria3 = new ArrayList() { 1, 2, 3, 4, 5};
            Gloria3.RemoveRange(0, 2);

            foreach(var f in Gloria3)
            {
                Console.WriteLine(f);
            }

            //Contains (check that if the item in the list)
            Console.WriteLine(Gloria3.Contains("Gloria")); //false
            Console.WriteLine(Gloria3.Contains(3)); //true


            //Sort (you know)

            ArrayList Gloria_04 = new ArrayList() {"G", "L", "O", "R", "I", "A"};
            foreach (var f in Gloria_04)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\nAfter sort:");

            Gloria_04.Sort();

            foreach (var f in Gloria_04)
            {
                Console.WriteLine(f);
            }

            //Reverse, ofc.




            //2- Generic Collections
            //? **int, **string, **product




        }
    }
}

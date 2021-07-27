using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Dictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //* Dictoinary */

            // Dictionary<TKey, TValue>

            Dictionary<int, string> ayvaCicekAcmis = new Dictionary<int, string>();
            ayvaCicekAcmis.Add(34, "Gloria");
            ayvaCicekAcmis.Add(64, "Nihil");

            Console.WriteLine(ayvaCicekAcmis[64]);

            Dictionary<int, double> deneme = new Dictionary<int, double>() {
                {5, 5.1 },
                {6, 6.1 },
                {7, 7.1 },
                {8, 8.1 },
                {9, 9.1 },
                {10, 10.1 }
            };

            Console.WriteLine(deneme[9]);

            Console.WriteLine("\nKey and Value");
            Console.WriteLine("Keys:");

            foreach (var f in deneme)
            {
                Console.WriteLine(f.Key);
            }

            Console.WriteLine("\nValues:");

            foreach (var f in deneme)
            {
                Console.WriteLine(f.Value);
            }

            Console.WriteLine("\nElementAt:");

            for (var f = 0; f < deneme.Count; f++)
            {
                Console.WriteLine($"Key: {deneme.Keys.ElementAt(f)} Value: {deneme.Values.ElementAt(f)}");
            }

            //Contains key, value

            Console.WriteLine("\nContains- key");
            Console.WriteLine(deneme.ContainsKey(33)); //false

            Console.WriteLine("\nContains- value");
            Console.WriteLine(deneme.ContainsValue(10.1)); //true

            //Remove
            Console.WriteLine("\nRemove");

            deneme.Remove(8);
            for (var f = 0; f < deneme.Count; f++)
            {
                Console.WriteLine($"Key: {deneme.Keys.ElementAt(f)} Value: {deneme.Values.ElementAt(f)}");
            }
        }
    }
}
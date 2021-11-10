using System;

namespace _1_warmUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //

        static void AddArtist(string aName)
        {
            using (var DB = new GloriaContext())
            {
                var newArtist = new Artist() { Name = aName };
                DB.SaveChanges
            }
        }
    }
}

using System;

namespace _1_warmUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var DB = new warmup_01Context())
            {
                var info = new Gloria() { Name = "Gloria_XYZ" };
                DB.Glorian.Add(info);

                DB.SaveChanges();

                Console.WriteLine("Info.");


            }






        }
    }
}

using System;
using System.Collections;
using System.Linq;

namespace _4_exerciseErrorHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //* Question- 1

            ArrayList something = new ArrayList() { "1", "2", "5a", "abc", "10", "50" };

            foreach (var f in something)
            {
                int xItem;

                try
                {
                    xItem = int.Parse((string)f);
                }
                catch (Exception err)
                {
                    Console.WriteLine("Err:" + err.Message + $": {f}");
                }

            }


            //* Question- 2
            while (true)
            {
                Console.WriteLine("Type anything..");
                string userInput = Console.ReadLine();

                if(userInput.ToLower() != "q")
                {
                    try
                    {
                        int Gloria = int.Parse(userInput);
                        Console.WriteLine("Given value is ok. " + Gloria);
                    }
                    catch (Exception errGloria)
                    {
                        Console.WriteLine("The given value is not a numeric.");
                        Console.WriteLine("Original message of the error: " + errGloria.Message);
                    }
                }
                else
                {
                    break;
                }


            }

            //* Question- 3 (turkish char check.)

            Console.WriteLine("Password: ");
            string userPass = Console.ReadLine();

            ArrayList trChars = new ArrayList() { "ş", "ç", "ü", "ö", "ı", "ğ"};


            //foreach (var f in trChars)
            //{
            //    ArrayList found = new ArrayList();
            //    if(userPass.Any(value => value = f))
            //    {
            //        found.Add(f);
            //    }
            //}

            //check here later.

        }
    }
}
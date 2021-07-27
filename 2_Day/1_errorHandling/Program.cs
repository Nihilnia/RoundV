using System;

namespace _1_errorHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //* Error Handling

            //** Try and Except

            //Possible error processes
            try
            {
                Console.WriteLine("Give me a number: ");
                int userInput_01 = int.Parse(Console.ReadLine());

                Console.WriteLine("Give me another number: ");
                int userInput_02 = int.Parse(Console.ReadLine());

                Console.WriteLine($"First numb / second numb: " + (userInput_01 / userInput_02));
            }
            catch (FormatException err)
            {
                Console.WriteLine("You need to give a number, not a char or smt.");
                Console.WriteLine("Original error message: " + err.Message);
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine("You cannot divide a number to zero");
                Console.WriteLine("Original error message: " + err.Message);
            }
            catch (Exception err) //Expection object
            {
                Console.WriteLine("Bir hata olustu.");
                Console.WriteLine("Original error message: " + err.Message);
            }
            finally
            {
                Console.WriteLine("'Finally: 'Nice try bitch.");
            }
        }
    }
}
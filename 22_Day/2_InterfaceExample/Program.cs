using System;

namespace _2_InterfaceExample
{
    interface IPoet
    {
        void greet(string name);

    }

    class Da : IPoet
    {
        public void greet(string name)
        {
            Console.WriteLine("Hi mf," + name);
        }
    }

    static class HelperMethods
    {
        public static void sayHello(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HelperMethods.sayHello("asdas");

        }
    }

}
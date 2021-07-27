using System;
using System.Linq;

namespace _2_throwException
{
    class Gloria
    {
        public int ID { get; set; }
        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value == "Gloria") throw new Exception("Name cannot be \"Gloria\"");
                _Name = value;
            }
        }

        internal class Program
        {
            private static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");

                //* Throwing Exceptions */

                static void passwordCheck(string userPass)
                {
                    if (userPass.Any(char.IsDigit) && userPass.Any(char.IsLetter))
                    {
                        Console.WriteLine("Password accepted");
                    }
                    else
                    {
                        throw new Exception("At least a char must be number/letter");
                    }
                }

                try
                {
                    Console.WriteLine("Ur password: ");
                    string userPass = Console.ReadLine();
                    passwordCheck(userPass);
                }
                catch (Exception err)
                {
                    Console.WriteLine("Message: " + err.Message);
                }

                //I like that structure.

                var Glr_01 = new Gloria();
                Glr_01.ID = 0;
                Glr_01.Name = "Gloria";

                var Glr_02 = new Gloria();
                Glr_02.ID = 1;
                Glr_02._Name = "asdasd";

                Console.WriteLine("Obj:" + Glr_01.ID + Glr_01.Name);
            }
        }
    }
}
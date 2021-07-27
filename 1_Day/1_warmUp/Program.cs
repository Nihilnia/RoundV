using System;

namespace _1_warmUp
{

    static class Helpers { 
    
        public static void Add(int x, int y)
        {
            Console.WriteLine("Result: " + (x + y));
        }
    }

    interface IEmp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool isActive { get; set; }
    }

    interface IEmpEx
    {
        public double ExtraSalary { get; set; }
    }

    class Level1Emp: IEmp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool isActive { get; set; }

        public Level1Emp(int lvl1ID, string lvl1Name, double lvl1Salary, bool lvl1IsActive)
        {
            this.ID = lvl1ID;
            this.Name = lvl1Name;
            this.Salary = lvl1Salary;
            this.isActive = lvl1IsActive;
        }

        public void Introduce()
        {
            string activity;
            if (this.isActive)
            {
                activity = "Active";
            }
            else
            {
                activity = "Non-Active";
            }
            Console.WriteLine($"Hi, my name is {this.Name}, id {this.ID}, salary {this.Salary} and I am {activity}");
        }
    }

    class Level2Emp: IEmpEx
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool isActive { get; set; }
        public double ExtraSalary { get; set; }

        public Level2Emp(int lvl2ID, string lvl2Name, double lvl2Salary, bool lvl2IsActive, double lvl2ExtraSalary)
        {
            this.ID = lvl2ID;
            this.Name = lvl2Name;
            this.Salary = lvl2Salary;
            this.isActive = lvl2IsActive;
            this.ExtraSalary = lvl2ExtraSalary;
        }

        public void Introduce()
        {
            string activity;
            if (this.isActive)
            {
                activity = "Active";
            }
            else
            {
                activity = "Non-Active";
            }
            Console.WriteLine($"Hi, my name is {this.Name}, id {this.ID}, salary {this.Salary} + extra salary {this.ExtraSalary} and I am {activity}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Emp_01 = new Level1Emp(0, "Emp_01", 1000, false);
            var Emp_02 = new Level2Emp(1, "Emp_02", 2000, true, 2000);

            Emp_01.Introduce();
            Emp_02.Introduce();

            Helpers.Add(2, 3);


        }
    }
}

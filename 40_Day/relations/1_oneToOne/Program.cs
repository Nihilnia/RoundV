using System;
using System.Linq;

namespace _1_oneToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello f World!");

            int key = 0;

            while (key == 0)
            {
                Console.WriteLine(@"DA OPTIONS:


                                  1)Add Student
                                  2)Add Information
                                  3)Find a MF Student





                                  0)Exit


                ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("First name: ");
                        string sFirstName = Console.ReadLine();
                        Console.WriteLine("Last name: ");
                        string sLastName = Console.ReadLine();
                        AddStudent(sFirstName, sLastName);
                        break;

                    case "2":
                        Console.WriteLine("Student ID: ");
                        int sStudentID = Convert.ToInt32(Console.ReadLine());
                        AddInformation(sStudentID);
                        break;

                    case "3":
                        Console.WriteLine("Da Student ID: ");
                        int daStudentID = Convert.ToInt32(Console.ReadLine());
                        FindStudent(daStudentID);
                        break;

                    case "0":
                        key = 1;
                        break;
                }
            }


        }

        static void AddStudent(string sFirstName, string sLastName)
        {
            using (var DB = new GridContext())
            {
                var newStudent = new Student() { FirstName = sFirstName, LastName = sLastName};
                DB.Students.Add(newStudent);
                DB.SaveChanges();

                Console.WriteLine($"New student {newStudent.FirstName} added to database.");
            }
        }

        static void AddInformation(int aStudentID)
        {
            using (var DB = new GridContext())
            {
                var findStudent = DB.Students.Where(s => s.ID == aStudentID).FirstOrDefault();

                if(findStudent != null)
                {
                    var findInformations = DB.Informations.Where(i => i.StudentID == aStudentID).FirstOrDefault();

                    if(findInformations != null)
                    {
                        Console.WriteLine("Informations already given.");
                    }
                    else
                    {
                        var newInformation = new Information()
                        {
                            FatherName = "ExampleFather_1",
                            MotherName = "ExampleMother_1",
                            YearOfBirth = 1994,
                            Gender = "Male",
                            Student = findStudent
                        };

                        DB.Informations.Add(newInformation);
                        DB.SaveChanges();

                        Console.WriteLine($"With given informations, intel added to database, student: {findStudent.FirstName}");
                    }

                    
                }
                else
                {
                    Console.WriteLine("With given ID student not found.");
                }
            }
        }

        static void FindStudent(int sStudentID)
        {
            using(var DB = new GridContext())
            {
                var daStudent = DB.Students.Where(s => s.ID == sStudentID).FirstOrDefault();

                if(daStudent != null)
                {
                    var daInformation = DB.Informations.Where(i => i.StudentID == sStudentID).FirstOrDefault();
          

                    Console.WriteLine(@$"
                        #### ALL INFORMATIONS ABOUT STUDENT: {daStudent.ID} #####

                        First Name: {daStudent.FirstName},
                        Last- Name: {daStudent.LastName},
                        Father Name: {daInformation.FatherName},
                        Motha Name: {daInformation.MotherName},
                        Year of Birth: {daInformation.YearOfBirth},
                        Genda: {daInformation.Gender}

                        #### EN OF THE LINE MF. ####
                    ");
                }
                else
                {
                    Console.WriteLine("There's not such a student.");
                }
            }
        }
    }
}

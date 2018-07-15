using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.OTM.Enroll
{
    public static class EnrollMenu
    {
        public static void MainMenu() 
        {
            Console.Clear();
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Enroll Qualifying Students");
            Console.WriteLine("2. Register Students for Test");
            Console.WriteLine("3. Back to Main Menu");
            switch (Console.ReadLine().Trim())
            {
                case "1":  EnrollQualifyingMenu();break;
                case "2": RegisterForTestMenu(); break;
                case "3":  Program.TopMainMenu(); break;
                default: Console.Clear(); Console.WriteLine("Invalid Input"); MainMenu(); break;
            }

        }

        public static void EnrollQualifyingMenu()
        {
            Console.Clear();
            EnrollQualifyingStudents();
            Console.WriteLine("The following students were enrolled: ");
            foreach(var student in Program.EnrolledStudents)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("Press any key to go to previous menu.");
            Console.ReadKey();
            MainMenu();
        }

        public static void EnrollQualifyingStudents()
        {
            Program.EnrolledStudents = Program.Students.Where(x => x.Results.First().HasPassed).ToList();
            Program.Students.RemoveAll(x => Program.EnrolledStudents.Contains(x));
        }

        public static void RegisterForTestMenu()
        {
            Console.Clear();
            Console.WriteLine("Select a student by typing the number of the student");
            for(int i = 0; i < Program.Students.Count(); i++)
            {
                Console.WriteLine($"{i+1}. {Program.Students[i].Name}");
            }
            int indexStudent = Int32.Parse(Console.ReadLine().Trim()) - 1;
            Console.WriteLine("Select a test by typing the number of the test");
            for (int i = 0; i < Program.Students.Count(); i++)
            {
                Console.WriteLine($"{i}. {Program.Tests[i].Name}");
            }
            int indexTest = Int32.Parse(Console.ReadLine().Trim()) - 1;

            Program.Students[indexStudent].RegisteredTests.Add(Program.Tests[indexTest]);
            Console.WriteLine("Press any key to go to previous menu.");
            Console.ReadKey();
            MainMenu();
        }
    }
}

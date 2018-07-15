using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.OTM.Grade
{
    public class GradeMenu
    {
        public static void MainMenu() 
        {
            Console.Clear();
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Passed Students");
            Console.WriteLine("2. Failed Students");
            Console.WriteLine("3. Back to Main Menu");
            switch (Console.ReadLine().Trim())
            {
                case "1":  ListPassedStudents(); break;
                case "2":  ListFailedStudents(); break;
                case "3": Program.TopMainMenu(); break;
                default: Console.Clear(); MainMenu(); break;
            }
        }
        public static void ListFailedStudents()
        {
            Console.Clear();
            Console.WriteLine("Failed Student Names:");
            foreach(var student in Program.Students.Where(x => x.Results.First().HasPassed != true))
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("Press any key to go to previous menu.");
            Console.ReadKey();
            MainMenu();
        }
        public static void ListPassedStudents()
        {
            Console.Clear();
            Console.WriteLine("Passed Student Names:");
            foreach (var student in Program.Students.Where(x => x.Results.First().HasPassed == true))
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("Press any key to go to previous menu.");
            Console.ReadKey();
            MainMenu();
        }
    }
}

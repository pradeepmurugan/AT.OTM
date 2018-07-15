using AT.OTM.Common.Models;
using AT.OTM.Enroll;
using AT.OTM.Grade;
using AT.OTM.Schedule;
using AT.OTM.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AT.OTM
{
    class Program
    {
        public static List<Student> EnrolledStudents = new List<Student>();
        public static List<Student> Students = new List<Student>();
        public static List<Common.Models.Test> Tests = new List<Common.Models.Test>();
        public static List<Subject> Subjects = new List<Subject>();
        public static List<Result> Results = new List<Result>();

        static void Main(string[] args) { AddSampleData(); TopMainMenu(); }

        public static void AddSampleData()
        {
            var result = new Result();
            result.CorrectQuestions.Add(new Question()); result.CorrectQuestions.Add(new Question());
            var student = new Student();
            student.Results.Add(result);
            student.Name = "Donald Trump";
            student.RollNumber = "911";
            student.EmailId = "satya.nadella@microsoft.com";
            Students.Add(student);
        }

        public static void TopMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Ameex Technologies Admin");
            Console.WriteLine();
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Students");
            Console.WriteLine("2. Tests");
            Console.WriteLine("3. Schedule");
            Console.WriteLine("4. Enroll");
            Console.WriteLine("5. Grade");
            switch (Console.ReadLine().Trim())
            {
                case "1": Console.Clear(); Console.WriteLine("Student Entry not implemented. Resetting..."); Thread.Sleep(4000); TopMainMenu(); break;
                case "2":  TestMenu.MainMenu(); break; 
                case "3":  ScheduleMenu.MainMenu(); break; 
                case "4":  EnrollMenu.MainMenu(); break;
                case "5": GradeMenu.MainMenu(); break;
                default: Console.Clear(); Console.WriteLine("Invalid Input. Resetting..."); Thread.Sleep(3000); TopMainMenu(); break;
            }
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}

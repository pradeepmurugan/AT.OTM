using AT.OTM.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.OTM.Test
{
    static class TestMenu
    {
        public static void MainMenu() 
        {
            Console.Clear();
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. List Tests");
            Console.WriteLine("2. Create Test");
            Console.WriteLine("3. Back to Main Menu");
            switch(Console.ReadLine().Trim())
            {
                case "1":  ListTests(); break;
                case "2":  CreateTest(); break;
                case "3": Program.TopMainMenu(); break;
                default: Console.Clear(); Console.WriteLine("Invalid Input"); MainMenu(); break;
            }

        }
        public static void ListTests() 
        {
            Console.Clear();
            Console.WriteLine("─────────────────────");
            foreach (var test in  Program.Tests)
            {
                Console.WriteLine("Name: " + test.Name);
                for (int i = 1; i <= 2; i++)
                {
                    Console.WriteLine($"Subject {i}: {(test.Subjects[i - 1]).Name}");
                }
                Console.WriteLine("Registered Student names:");
                {
                    foreach (var student in test.RegisteredStudents)
                    {
                        Console.WriteLine(student.Name);
                    }
                }
                foreach (var questionChoicePair in test.QuestionChoices)
                {
                    Console.WriteLine($"Question Text: {questionChoicePair.Key.Text}");
                    foreach (var choice in questionChoicePair.Value)
                    {
                        Console.WriteLine("Is Choice correct: " + choice.IsCorrectChoice);
                        Console.WriteLine("Choice Text: " + choice.Text);
                    }
                }
                Console.WriteLine("─────────────────────");
            }
            Console.WriteLine("Press any key to go to previous menu.");
            Console.ReadKey();
            MainMenu();
        }
        public static void CreateTest()
        {
            Console.Clear();
            var test = new Common.Models.Test();
            Console.WriteLine("Enter a unique Test name");
            test.Name = (Console.ReadLine().Trim());
            for(int i = 1; i <=2; i++)
            { 
                Console.WriteLine($"Enter subject {i}");
                test.Subjects.Add(new Subject { Name = Console.ReadLine().Trim() });
                Console.Clear();
            }
            for(int i = 1; i <= 2; i++) //TODO Change Questions to 5
            {
                var question = new Question();
                Console.WriteLine($"Enter question number {i}");
                question.Text = Console.ReadLine().Trim();
                test.QuestionOrder.Add(question);
                var choices = new List<Choice>();
                Console.Clear();
                for(int j = 1; j <= 4; j++)
                {
                    var choice = new Choice();
                    Console.WriteLine($"Enter choice number {j}");
                    choice.Text = Console.ReadLine().Trim();
                    tryAgain:
                    Console.Clear();
                    Console.WriteLine($"If choice number {j} is a correct choice, type true, otherwise type false.");
                    try
                    {
                        choice.IsCorrectChoice = Boolean.Parse(Console.ReadLine().Trim()); //TODO Handle Exception
                    }
                    catch(Exception ex)
                    {
                        Console.Write("Invalid Input. Try Again.");
                        goto tryAgain;
                    }
                    choices.Add(choice);
                    Console.Clear();
                }
                Console.Clear();
                test.QuestionChoices.Add(question, choices);
            }
            Program.Tests.Add(test);
            Console.WriteLine("Press any key to go to previous menu.");
            Console.ReadKey();
            MainMenu();
        }
    }
}

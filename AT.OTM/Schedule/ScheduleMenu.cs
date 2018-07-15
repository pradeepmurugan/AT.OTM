using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.OTM.Schedule
{
    public static class ScheduleMenu
    {
        public static void MainMenu() // TODO add go to top level main menu
        {
            Console.Clear();
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Schedule Test");
            Console.WriteLine("2. Back to Main Menu");
            switch (Console.ReadLine().Trim())
            {
                case "1": ScheduleTest(); break;
                case "2": Program.TopMainMenu(); break;
                default: Console.Clear(); MainMenu(); break;
            }
        }
        
        public static void ScheduleTest() // TODO add go to top level main menu
        {
            Console.Clear();
            Console.WriteLine("Select a test by typing the number of the test");
            for (int i = 0; i < Program.Tests.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {Program.Tests[i].Name}");
            }
            int index = Int32.Parse(Console.ReadLine().Trim()) - 1; //TODO Handle Exception
            Console.WriteLine("Enter a date for the test");
            Program.Tests[index].Date = DateTimeOffset.Parse(Console.ReadLine().Trim(), CultureInfo.InvariantCulture);
            Program.Tests[index].RegisteredStudents.Clear();
            Console.WriteLine("Press any key to go to previous menu.");
            Console.ReadKey();
            MainMenu();
        }
    }
}

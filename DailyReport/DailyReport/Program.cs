using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // Splash intro
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Ask user name and store in variable
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Ask user course info and store in variable
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Ask user for page number and store in variable
            Console.WriteLine("What page number are you on?");
            string pageNum = Console.ReadLine();
            int intPageNum = Convert.ToInt32(pageNum);

            // Ask user if any help needed and store in variable
            Console.WriteLine("Do you need help with anything? Please answer true or false");
            string help = Console.ReadLine();
            bool boolHelp = Convert.ToBoolean(help);

            // Ask user about experience and store in variable
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string shareExp = Console.ReadLine();

            // Ask user for feedback and store in variable
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Ask user for hours worked and store in variable
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int intHours = Convert.ToInt32(hours);

            // End program
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
        }
    }
}
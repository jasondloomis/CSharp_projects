using System;

namespace ApplicationQualification
{
    class Program
    {
        static void Main()
        {
            // Intro splash
            Console.WriteLine("Car Insurance Questionaire");
            // Ask user for age
            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            // Ask user for DUI convictions
            Console.WriteLine("Have you ever been convicted of a DUI? Please enter \"true\" or \"false\"");
            string dui = Console.ReadLine();
            // Ask user for speeding ticket citations
            Console.WriteLine("Have you ever had a speeding ticket? Please enter the number of how many.");
            string tickets = Console.ReadLine();
            // check all three conditions for true to be qualified
            bool isQualified = (Convert.ToInt16(age) > 15 && Convert.ToBoolean(dui) == false && Convert.ToInt16(tickets) <= 3);
            Console.WriteLine(isQualified);
        }
    }
}

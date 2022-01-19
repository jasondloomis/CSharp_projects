using System;

namespace IncomeComp
{
    class Program
    {
        static void Main()
        {
            // print intro banner
            Console.WriteLine("Anonymous Income Comparison Program");

            // Enter person 1 rate and hours
            Console.WriteLine("Enter Person 1 hourly rate:");
            string person1Rate = Console.ReadLine();
            Console.WriteLine("Enter Person 1 hours per week:");
            string person1Hours = Console.ReadLine();

            // Enter person 2 rate and hours
            Console.WriteLine("Enter Person 2 hourly rate:");
            string person2Rate = Console.ReadLine();
            Console.WriteLine("Enter Person 2 hours per week:");
            string person2Hours = Console.ReadLine();

            // Display person 1 rate and hours
            Console.WriteLine("Person 1 rate $" + person1Rate + " per hour.");
            Console.WriteLine("Person 1 hours worked: " + person1Hours);

            // Display person 2 rate and hours
            Console.WriteLine("Person 2 rate $" + person2Rate + " per hour.");
            Console.WriteLine("Person 2 hours worked: " + person2Hours);

            // Calculate person 1 annual salary
            int person1Annual = (Convert.ToInt32(person1Rate) * Convert.ToInt32(person1Hours) * 56);
            Console.WriteLine("Person 1 annual salary: $" + String.Format("{0:n}", person1Annual));

            // Calculate person 2 annual salary
            int person2Annual = (Convert.ToInt32(person2Rate) * Convert.ToInt32(person2Hours) * 56);
            Console.WriteLine("Person 2 annual salary: $" + String.Format("{0:n}", person2Annual));

            // Find which person makes more annually
            bool boolAnnual = person1Annual > person2Annual;
            Console.WriteLine(boolAnnual);
        }
    }
}

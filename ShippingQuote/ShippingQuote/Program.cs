using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            // Display intro
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // ask for weight of package and store in variable
            Console.WriteLine("Enter weight of package:");
            string weight = Console.ReadLine();
            int intWeight = Convert.ToInt16(weight);
            // start nested conditional checks for weight max and diminsion max
            if (intWeight > 50)
            {
                // error for max weight exceeded
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // request diminsions for package
                Console.WriteLine("Enter package width:");
                string width = Console.ReadLine();
                int intWidth = Convert.ToInt16(width);
                Console.WriteLine("Enter package height:");
                string height = Console.ReadLine();
                int intHeight = Convert.ToInt16(height);
                Console.WriteLine("Enter package length:");
                string length = Console.ReadLine();
                int intLength = Convert.ToInt16(length);
                // add dimisions for max conditional statement
                int packageDiminsions = intWidth + intHeight + intLength;
                // check if package 
                if (packageDiminsions > 50)
                {
                    // error for max dimisions exceeded
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // calculate and display cost
                    int result = (((intWidth * intHeight * intLength) * intWeight)  / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + String.Format("{0:n}", result));
                    Console.WriteLine("Thank you!");
                }
            }
        }
    }
}

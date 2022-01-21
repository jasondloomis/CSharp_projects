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
            // start nested conditional checks for weight max and diminsions
            if (intWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Enter package width:");
                string width = Console.ReadLine();
                int intWidth = Convert.ToInt16(width);
                Console.WriteLine("Enter package height:");
                string height = Console.ReadLine();
                int intHeight = Convert.ToInt16(height);
                Console.WriteLine("Enter package length:");
                string length = Console.ReadLine();
                int intLength = Convert.ToInt16(length);

                int packageDiminsions = intWidth + intHeight + intLength;

                if (packageDiminsions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int result = ((intWeight * intHeight * intLength) / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + result);
                }
            }

        }
    }
}

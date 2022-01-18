using System;

namespace ConsoleMath
{
    class Program
    {
        static void Main()
        {
            // user enters a number to multiply by 50
            Console.WriteLine("Enter a number to multiply by 50:");
            string inputFifty = Console.ReadLine();
            double dblFifty = 50 * Convert.ToDouble(inputFifty);
            Console.WriteLine(dblFifty);

            // user enters a number to add 25
            Console.WriteLine("Enter a number to add 25:");
            string inputTwFive = Console.ReadLine();
            double dblTwFive = 25 + Convert.ToDouble(inputTwFive);
            Console.WriteLine(dblTwFive);

            // user enters a number to divide by 12.5
            Console.WriteLine("Enter a number to divide by 12.5:");
            string inputDivide = Console.ReadLine();
            double dblDivide = Convert.ToDouble(inputDivide) / 12.5;
            Console.WriteLine(dblDivide);

            // user enters a number to find out if it is greater than 50
            Console.WriteLine("Enter a number to find out if it is greater than 50:");
            string inputBool = Console.ReadLine();
            bool boolFifty = Convert.ToInt32(inputBool) > 50;
            Console.WriteLine(boolFifty);

            // user enters a number to find its modulus 
            Console.WriteLine("Enter a number to divide by 7, answer is its remainder:");
            string inputMod = Console.ReadLine();
            double dblMod = Convert.ToDouble(inputMod) / 7;
            Console.WriteLine(dblMod);



        }
    }
}

using System;

namespace ConsoleDoWhileBool
{
    class Program
    {
        static void Main()
        {
            // declare variables
            int n = 10;
            bool i = n == 1;
            // check first condition, n
            while (n>=1)
            {
                // check second condiiton, i
                do
                {
                    // display n on console
                    Console.WriteLine(n);
                    // subtract 1 from variable
                    n--;
                }
                while (i);
            }
            // complete conditions and display
            Console.WriteLine("Loops complete!");
            Console.Read();
        }
    }
}

using System;

namespace ConsoleDoWhileBool
{
    class Program
    {
        static void Main()
        {
                int index = 0;
                // start loop until condition meets criteria
                while (true)
                {
                    int value = ++index;
                    // Check loop limit
                    if (value > 5)
                    {
                        Console.WriteLine("While-loop break");
                        break;
                    }
                    // throw exception if value exceeds 100
                    if (value > 100)
                    {
                        throw new Exception("Never hit");
                    }
                    // write screen statement 
                    Console.WriteLine("While-loop statement");
                }

            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 20);
           
        }
    }
}

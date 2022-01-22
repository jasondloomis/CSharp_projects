using System;

namespace ConsoleDoWhileBool
{
    class Program
    {
        static void Main()
        {
            // ask user for number and declare variables           
            Console.WriteLine("Pick a number between 1 and 100:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool i = number == 99;


            if (number < 1 || number > 100)
            {
                Console.WriteLine("Number is not between 1 and 100.");
            }
            else if (number == 50)
            {
                while ()
                {
                }
            }
            else 
            {
                do
                {
                    Console.WriteLine("Your number is 50. The countdown has begun...RUN!");

                    while ();
            }
            // complete conditions and display
            Console.WriteLine("Loops complete!");
            Console.Read();
        }
    }
}

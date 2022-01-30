using System;

namespace ConsoleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // start program and ask user for two number to divide
            // declare variables for user input
            try
            {
                Console.WriteLine("Pick a number:");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number:");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the number...");
                int numThree = numOne / numTwo;
                Console.WriteLine(numOne + " divided by " + numTwo + " equals " + numThree);
            }
            catch (FormatException ex) // exception for using string 
            {
                Console.WriteLine("Please use a whole number:");
                return;
            }
            catch (DivideByZeroException ex) // exception for using zero
            {
                Console.WriteLine("Cannot divede by zero.");
            }
            catch (Exception ex) // general exception
            {
                Console.WriteLine(ex.Message);
            }
            finally // keep screen on after program runs
            {
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace ArraysLists
{
    class Program
    {
        static void Main()
        {

            string[] strArray = { "Die Hard", "Home Alone", "Elf", "The Santa Clause", "Christmas Vacation" };
            int[] numArray = { 1988, 1990, 2003, 1994, 1989 };
            List<string> strList = new List<string>();
            strList.Add("Bruce Willis");
            strList.Add("MaCaulay Culkin");
            strList.Add("Will Farrell");
            strList.Add("Tim Allen");
            strList.Add("Chevy Chase");

            Console.WriteLine("Enter a number to select an index for Christmas movie name:");
            string numMovie = Console.ReadLine();
            int intMovie = Convert.ToInt32(numMovie);

            if (intMovie > 4 || intMovie < 0)
            {
                Console.WriteLine("You entered a number that is invalid.");
            }
            else
            {
                Console.WriteLine(strArray[intMovie]);
            }

            Console.WriteLine("Enter a number to find the year a Chritmas movie was made:");
            string numYear = Console.ReadLine();
            int intYear = Convert.ToInt32(numYear);

            if (intYear > 4 || intYear < 0)
            {
                Console.WriteLine("You entered a number that is invalid.");
            }
            else
            {
                Console.WriteLine(numArray[intYear] + " : " + strArray[intYear]);
            }

            Console.WriteLine("Enter a number to retrieve the main character from a Christmas movie:");
            string numName = Console.ReadLine();
            int intName = Convert.ToInt32(numName);

            if (intName > 4 || intName < 0)
            {
                Console.WriteLine("You entered a number that is invalid.");
            }
            else
            {
                Console.WriteLine(strList[intName] + " : " + strArray[intName]);
            }
        }
    }
}

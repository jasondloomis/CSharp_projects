using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleAssign
{
    class Program
    {
        static void Main()
        {
            // assignment 1
            // declare string array and ask user for a noun
            string[] strLibsArr = { "What", "came", "first", "the", "chicken", "or", "the", "noun", 
                "Love", "is", "what", "makes", "noun", "go", "round"  };
            Console.WriteLine("Enter a noun to add to the sentence:"); 
            string strWord = Console.ReadLine();
            // replace all words with user input
            for (int i = 0; i < strLibsArr.Length; i++)
            {
                if (strLibsArr[i] == "noun")
                {
                    strLibsArr[i] = strWord;
                }
            }
            // display array
            foreach (string word in strLibsArr)
            {
                Console.Write(word + " ");
            }

            // assignment 2

            // declare variable to test for infinite loop
            int num = 0; 
            // run loop to print each item to 25
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 5); // assignment 3

            // declare variable
            int j = 15;
            // loop until number is 19
            while (j < 20) // assignment 3
            {
                Console.WriteLine(j);
                j++;
            }

            // Assignment 4

            // create list of names
            List<string> strNames = new List<string>();
            strNames.Add("bud");
            strNames.Add("lou");
            strNames.Add("laurel");
            strNames.Add("hardy");
            strNames.Add("shemp");
            strNames.Add("curly");
            strNames.Add("moe");
            strNames.Add("larry");
            strNames.Add("chevy");
            // ask user for name to search in list
            Console.WriteLine("Enter a name to see if it exist in list:");
            string strInput = Console.ReadLine();
            int notFound = 0;
            // iterate thru list to find name
            foreach (string name in strNames)
            {
                // check list against user input
                if (name.Contains(strInput))
                {
                    Console.WriteLine(strNames.IndexOf(strInput));
                    notFound++;
                    break;
                }
            }
            if (notFound == 0)
            {
                Console.WriteLine("Name not found");
            }

            // assignment 5
            int index = 0;
            // create list of last names
            List<string> lastNames = new List<string>();
            lastNames.Add("carmen");
            lastNames.Add("garcia");
            lastNames.Add("smith");
            lastNames.Add("smith");
            lastNames.Add("santiago");
            lastNames.Add("taylor");
            lastNames.Add("taylor");
            // ask user for last name
            Console.WriteLine("Enter Last Name:");
            string strLast = Console.ReadLine();
            // iterate thru last names
            foreach (string name in lastNames)
            {
                if (name.Contains(strLast))
                {
                    // display index of name
                    Console.WriteLine(index);
                    
                }
                index++;
            }
            if (!lastNames.Contains(strLast))
            {
                Console.WriteLine("Name not found.");
            }

            // assignment 6
            int intDupl = 0;
            List<string> firstName = new List<string>();
            firstName.Add("carrie");
            firstName.Add("Kali");
            firstName.Add("Lucia");
            firstName.Add("Mary");
            firstName.Add("Mary");
            firstName.Add("Mary");
            firstName.Add("Sandy");
            firstName.Add("Mary");

            Console.WriteLine("Duplicate first names in list:");
            // group duplicate names
            IEnumerable<string> duplicates = firstName.GroupBy(y => y)
                                       .SelectMany(j => j.Skip(1));

            // iterate thru first name
            foreach (string name in firstName)
            {
                if (duplicates.Contains(name) && intDupl == 0) 
                {
                    Console.WriteLine(name + " has not been see in the list.");
                    intDupl++;
                }
                else if (duplicates.Contains(name) && intDupl > 0)
                {
                    Console.WriteLine(name + " has already been seen in the list.");
                }
                else
                {
                    Console.WriteLine(name + " has not been seen in the list");
                }
            }

            //Console.ReadLine();
        }
    }
}

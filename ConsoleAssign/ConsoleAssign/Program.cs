using System;
using System.Collections.Generic;
namespace ConsoleAssign
{
    class Program
    {
        static void Main()
        {
            // declare string array and ask user for a noun
            string[] strLibsArr = { "What", "came", "first", "the", "chicken", "or", "the", "noun", "Love", "is", "what", "makes", "noun", "go", "round"  };
            Console.WriteLine("Enter a noun to add to the sentence:"); // assignment 1 & 5
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
                Console.WriteLine(word);
            }

            // declare variable to test for infinite loop
            int num = 0; // assignment 2
            // run loop to print each item to 25
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 5); // assignment 3

            // declare variable
            int j = 15; // assignment 3
            // loop until number is 19
            while (j < 20)
            {
                Console.WriteLine(j);
                j++;
            }
            // create list of names
            List<string> strNames = new List<string>(); // assignment 4
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
            // iterate thru list to find name
            foreach (string name in strNames)
            {
                    // check list against user input
                    if (name == strInput)
                    {
                        Console.WriteLine(name.Contains(strInput));
                        //Console.WriteLine(name.IndexOf(strInput));
                        break; // exit loop if found
                    }
                    else // if name not found display error
                    {
                        Console.WriteLine("Name is not in list.");
                    }
            }


            //Console.ReadLine();
        }
    }
}

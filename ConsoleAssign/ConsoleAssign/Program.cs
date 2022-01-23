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
                Console.WriteLine(word);
            }
            //Console.ReadLine();
        }
    }
}

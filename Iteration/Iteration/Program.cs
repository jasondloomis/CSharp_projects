using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main()
        {
            int[] testScores = { 98, 99, 85, 70, 82, 43, 56, 79, 89, 99, 97, 100};

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}


            //string[] names = { "Bruce", "Macaulay", "Tim", "Chevy" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Bruce")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}

            //List<int> testResults = new List<int>();
            //testResults.Add(97);
            //testResults.Add(56);
            //testResults.Add(78);
            //testResults.Add(86);
            //testResults.Add(86);
            //testResults.Add(41);
            //testResults.Add(90);
            //testResults.Add(73);

            //foreach (int score in testResults)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}

            //List<string> strNames = new List<string>();
            //strNames.Add("Bruce");
            //strNames.Add("Jim");
            //strNames.Add("Macaulay");
            //strNames.Add("Shemp");
            //strNames.Add("Curly");
            //strNames.Add("Moe");
            //strNames.Add("Larry");
            //strNames.Add("Chevy");

            //foreach (string name in strNames)
            //{
            //    if (name == "Curly")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}

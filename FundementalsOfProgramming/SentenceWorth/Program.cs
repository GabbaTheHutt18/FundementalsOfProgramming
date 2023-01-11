using System;
using System.Collections.Generic;
using System.Linq;

namespace SentenceWorth
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter your Phrase:");
            string userInput = Console.ReadLine();
            Calculate(userInput);
        }

  
        static void Calculate(string userInput)
        {
            int value = 0;
            int total = 0;
            string[] sentences = userInput.Split(' ');
            List<int> values = new List<int>();
            for (int i = 0; i < sentences.Length; i++)
            {
                value = 0;
                for (int j = 0; j < sentences[i].Length; j++)
                {
                    
                    char character = sentences[i][j];
                    total += ((int)character);
                    value += ((int)character);
                }
                values.Add(value);
            }

            for (int k = 0; k < values.Count(); k++)
            {
                Console.WriteLine($"{values[k]}");
            }
            Console.WriteLine($"Total: {total}");

        }

    }
}
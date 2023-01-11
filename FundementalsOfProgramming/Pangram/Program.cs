using System;
using System.Collections.Generic;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word");
            string userWord = Console.ReadLine().ToLower();
            char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            List<char> notContain = new List<char>();
            bool pangram = true; 
            for (int i = 0; i < alphabet.Length; i++)
            {
                int check = userWord.IndexOf(alphabet[i]);
                if (check == -1)
                {
                    pangram = false;
                    notContain.Add(alphabet[i]);
                }
            }
            if (pangram == true)
            {
                Console.WriteLine("You have entered a pangram which contains every letter in the alphabet at least once.");
            }
            else if (pangram == false)
            {
                Console.WriteLine("Your sentence is not a pangram as it does not contain the following letters: ");
                for (int i = 0; i < notContain.Count; i++)
                {
                    Console.WriteLine($"{notContain[i]}");
                }
            }
        }
    }
}

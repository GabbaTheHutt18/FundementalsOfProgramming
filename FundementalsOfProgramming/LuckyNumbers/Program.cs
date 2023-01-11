using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 9, 0};
            Console.WriteLine("Please enter a number");
            string usernumber = Console.ReadLine();

            bool lucky = CheckIfLucky(usernumber);
            if (lucky == true)
            {
                Console.WriteLine($"{lucky}, it is lucky!");
            }
            else
            {
                Console.WriteLine($"{lucky}, it isn't lucky!");
            }

            
        }

        static bool CheckIfLucky(string userinput)
        {
            bool lucky = true;
            
            List<char> RepeatedValues = new List<char>();    


            for (int i = 0; i < userinput.Length - 1; i++)
            {
                for (int j = i + 1; j < userinput.Length; j++)
                {
                    if (userinput[i] == userinput[j])
                    {
                        lucky = false;
                        RepeatedValues.Add(userinput[i]);
                        
                    }
                }
            }
            List<char> uniqueList = RepeatedValues.Distinct().ToList();
            if (lucky == false)
            {
                Console.WriteLine("Repeated values: ");
                uniqueList.ForEach(i => Console.WriteLine($"{i}"));
               
            }

            return lucky;
        }
    }
}

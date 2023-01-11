using System;

namespace PolitenessOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int userNumber = Int32.Parse(Console.ReadLine());
            CheckNumber(userNumber);
        }

        static void CheckNumber(int userNumber)
        {
            int total = 0;
            int politeness = 0;
            for (int i = 1; i < userNumber; i++)
            {
                total = 0;
                for (int j = i; j < userNumber; j++)
                {
                    total = total + j;
                    Console.WriteLine(total);
                    if (total == userNumber)
                    {
                        politeness += 1;
                    }
                }
                
            }
            Console.WriteLine($"Total:{politeness}");
            



        }
    }
}

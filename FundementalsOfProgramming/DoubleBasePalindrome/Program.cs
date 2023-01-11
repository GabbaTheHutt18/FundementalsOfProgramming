using System;

namespace DoubleBasePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int noPalindrome = 0;
            Console.WriteLine("Denary Binary");
            while (noPalindrome < 20)
            {
                bool checkpalindrome = CheckPalindrome(input.ToString());
                string binary = ConvertToBinary(input);
                bool checkpalindromeBinary = CheckPalindrome(binary);
                if (checkpalindromeBinary == true && checkpalindrome == true)
                {
                    noPalindrome += 1;
                    Console.WriteLine($"{input} {binary}");
                }
                input += 1;

            }
            
        }



        static bool CheckPalindrome(string userInput)
        {
            string backwardsnum = "";
            bool checkPalindrome = false;
            for (int i = (userInput.Length - 1); i > -1; i--)
            {
                backwardsnum += userInput[i];
            }
            if (backwardsnum == userInput)
            {
                checkPalindrome = true;
            }
            return checkPalindrome;

        }

        static string ConvertToBinary(int Input)
        {
            
            string binary = Convert.ToString(Input, 2);

            return binary;
        }

    }
}

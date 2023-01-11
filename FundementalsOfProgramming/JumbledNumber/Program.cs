using System;

namespace JumbledNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            bool jumblenumber = CheckJumbled(userInput);
            if (jumblenumber == true)
            {
                Console.WriteLine("True, it is jumbled");
            }
            else
            {
                Console.WriteLine("False, not jumbled");
            }

        }

        static bool CheckJumbled(string userinput)
        {
            bool jumblenumber = true;
            for (int i = 0; i < (userinput.Length - 1); i++)
            {
                int num1 = userinput[i];
                int num2 = userinput[i + 1];
                int result = Math.Abs(num1 - num2);

                if (result != 1 && result != 0)
                {
                     jumblenumber = false;
                }
    
            }

            return jumblenumber;
        
        
        }
    }
}

namespace RomanNumerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter:");
            string user = Console.ReadLine();

           

        }

        static Dictionary<string, int> RomanNum()
        {
            Dictionary<string, int> RomanNum = new Dictionary<string, int>();
            RomanNum.Add("I", 1);
            RomanNum.Add("V", 5);
            RomanNum.Add("X", 10);
            return RomanNum;
        }

        static bool valid(string userString)
        {
            bool isvalid = false;
            int noI = 0;
            int noV = 0;
            int noX = 0;
            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == 'I')
                {
                    noI += 1;
                }
                else if (userString[i] == 'V')
                {
                    noV += 1;
                }
                else if (userString[i] == 'X')
                {
                    noX += 1;
                }
            }

            if (noI > 4 || noV > 1 || noX > 4)
            {
                isvalid = false;
            }

            

        }
    }
}
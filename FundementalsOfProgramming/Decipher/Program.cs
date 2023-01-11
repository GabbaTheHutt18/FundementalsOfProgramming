using System;

namespace Decipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your cipher text");
            string cipherText = Console.ReadLine();
            Decrypt(cipherText);
        }

        static void Decrypt(string cipherText)
        {
            int lengthOfText = cipherText.Length;
            int position = 0;
            string value = "";
            char character = ' ';
            List<char> list = new List<char>();
            string final = "";
            while (position < lengthOfText)
            {
                if (cipherText[position] == '1')
                {
                    char[] chars = { cipherText[position], cipherText[position + 1], cipherText[position + 2] };
                    string merged = new string(chars);
                    character = (char)Int32.Parse(merged);
                    position += 3;
                }
                else
                {
                    char[] chars = { cipherText[position], cipherText[position + 1]};
                    string merged = new string(chars);
                    character = (char)Int32.Parse(merged);
                    position += 2;
                }
                list.Add(character);
                    
            }
            for (int i = 0; i < list.Count; i++)
            {
                final += list[i];
            }
            Console.WriteLine(final);

        }

    }
}
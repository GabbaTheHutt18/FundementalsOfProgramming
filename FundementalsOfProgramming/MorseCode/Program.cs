using System;
using System.Collections.Generic;
using System.Linq;

namespace MorseCode
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Hi would you like to encode or decode Morse Code? 1. Encode, 2. Decode, 3. Exit");
            string choice = Console.ReadLine();
            string newtext = "";
            switch (choice)
            {
                case "1":
                    newtext = EncodeMorse();

                    break;
                case "2":
                    newtext = DecodeMorse();
                    break;
                default:
                    Console.WriteLine("Bye");
                    break;
            }

            Console.WriteLine(newtext);
        }

        static Dictionary<char,string> Dictionary()
        {
            Dictionary<char, string> MorseCodeAlphabet = new Dictionary<char, string>();
            MorseCodeAlphabet.Add('A',".-");
            MorseCodeAlphabet.Add('B', "-...");
            MorseCodeAlphabet.Add('C', "-.-.");
            MorseCodeAlphabet.Add('D', "-..");
            MorseCodeAlphabet.Add('E', ".");
            MorseCodeAlphabet.Add('F', "..-.");
            MorseCodeAlphabet.Add('G', "--.");
            MorseCodeAlphabet.Add('H', "....");
            MorseCodeAlphabet.Add('I', "..");
            MorseCodeAlphabet.Add('J', ".---");
            MorseCodeAlphabet.Add('K', "-.-");
            MorseCodeAlphabet.Add('L', ".-..");
            MorseCodeAlphabet.Add('M', "--");
            MorseCodeAlphabet.Add('N', "-.");
            MorseCodeAlphabet.Add('O', "---");
            MorseCodeAlphabet.Add('P', ".--.");
            MorseCodeAlphabet.Add('Q', "--.-");
            MorseCodeAlphabet.Add('R', ".-.");
            MorseCodeAlphabet.Add('S', "...");
            MorseCodeAlphabet.Add('T', "-");
            MorseCodeAlphabet.Add('U', "..-");
            MorseCodeAlphabet.Add('V', "...-");
            MorseCodeAlphabet.Add('W', "..-");
            MorseCodeAlphabet.Add('X', ".--.");
            MorseCodeAlphabet.Add('Y', "-.--");
            MorseCodeAlphabet.Add('Z', "--..");

            return MorseCodeAlphabet;
        }

        static string EncodeMorse()
        {
            Dictionary<char, string> MorseCodeAlphabet = Dictionary();
            Console.WriteLine("Please enter your string: ");
            string plaintext = Console.ReadLine().ToUpper();
            string morse = "";

            for (int i = 0; i < plaintext.Length; i++)
            {
                morse = morse + MorseCodeAlphabet[plaintext[i]] + " ";  
            }
            return morse;
        }

        static string DecodeMorse()
        {
            Dictionary<char, string> MorseCodeAlphabet = Dictionary();
            Console.WriteLine("Please enter your string: ");
            string morse = Console.ReadLine().ToUpper();
            string[] seperate = morse.Split(' ');
            string plaintext = "";
            for (int i = 0; i < seperate.Length; i++)
            {
                foreach (var key in MorseCodeAlphabet.Keys)
                {
                    if (MorseCodeAlphabet[key] == seperate[i])
                    {
                        plaintext += key;
                    }
                }
            }

            return plaintext;
        }

    
    }
}

using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your plain text: ");
            string plaintext = Console.ReadLine();
            Console.WriteLine("Enter your key: ");
            int key = Int32.Parse(Console.ReadLine());
            string ciphertext = Encrypt(plaintext, key);
            Console.WriteLine($"Encrypted text:{ciphertext}");
            string decryptedText = Decrypt(ciphertext, key);
            Console.WriteLine($"Decrypted text:{decryptedText}");
            Console.WriteLine($"Encrypted text:{ciphertext}");
            Console.WriteLine("Brute force");
            BruteForce(ciphertext);
            Console.WriteLine("- is a shift to the left :)");
        }

        static string Encrypt(string plaintext, int key)
        {
            string ciphertext = "";
            foreach (char letter in plaintext)
            {
                int asciiCode = (int)letter;
                int newCode = asciiCode + key;
                if (newCode > 127)
                {
                    newCode = (newCode - 126) + 33;
                }
                else if (newCode < 33)
                {
                    newCode = 126 - (33 - newCode);
                }
                char newLetter = (char)newCode;
                ciphertext = ciphertext + newLetter;

            }
            return ciphertext;
        }

        static string Decrypt(string ciphertext, int key)
        {
            string decryptedText = "";
            foreach (char letter in ciphertext)
            { 
                int asciiCode = (int)letter;
                int newCode = asciiCode - key;
                if (newCode > 127)
                {
                    newCode = (newCode - 126) + 33; 
                }
                else if (newCode < 33)
                {
                    newCode = 126 - (33 - newCode);
                }
                char newLetter = (char)newCode;
                decryptedText = decryptedText + newLetter;
            }
            return decryptedText;
        }

        static string BruteForce(string ciphertext)
        {
            string decryptedText = "";
            int key = 0;
            for (int i = 33; i < 127; i++)
            {
                decryptedText = "";
                
                foreach (char letter in ciphertext)
                {
                    int asciiCode = (int)letter;
                    int newCode = asciiCode - i;
                    if (newCode > 127)
                    {
                        newCode = (newCode - 126) + 33;
                    }
                    else if (newCode < 33)
                    {
                        newCode = 126 - (33 - newCode);
                    }
                    char newLetter = (char)newCode;
                    decryptedText = decryptedText + newLetter;
                    key = newCode - asciiCode;
                }
                Console.WriteLine($"Key shifted {key}:");
                Console.WriteLine(decryptedText);
            }
            return decryptedText;
        }

    }

    
}

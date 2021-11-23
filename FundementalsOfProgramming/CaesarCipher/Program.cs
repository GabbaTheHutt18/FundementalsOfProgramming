using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your plain text: ");
            string plaintext = Console.ReadLine().ToLower();
            Console.WriteLine("Enter your key: ");
            int key = Int32.Parse(Console.ReadLine());
            string ciphertext = Encrypt(plaintext, key);
            Console.WriteLine($"Encrypted text:{ciphertext}");
            string decryptedText = Decrypt(ciphertext, key);
            Console.WriteLine($"Decrypted text:{decryptedText}");
            Console.WriteLine($"Encrypted text:{ciphertext}");
            Console.WriteLine("Brute force");
            var answer = BruteForce(ciphertext);
            Console.WriteLine(" a - is a shift to the left :)");
            Console.WriteLine(answer);
        }

        static string Encrypt(string plaintext, int key)
        {
            string ciphertext = "";
            foreach (char letter in plaintext)
            {
                int asciiCode = (int)letter;
                int newCode = asciiCode + key;
                if (newCode > 123)
                {
                    newCode = (newCode - 123) + 97;
                }
                else if (newCode < 96)
                {
                    newCode = 123 - (97 - newCode);
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
                if (newCode > 123)
                {
                    newCode = (newCode - 123) + 97; 
                }
                else if (newCode < 96)
                {
                    newCode = 123 - (97- newCode);
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
            for (int i = 0; i < 26; i++)
            {
                decryptedText = "";
                
                foreach (char letter in ciphertext)
                {
                    int asciiCode = (int)letter;
                    int newCode = asciiCode - i;
                    if (newCode > 123)
                    {
                        newCode = (newCode - 123) + 97;
                    }
                    else if (newCode < 97)
                    {
                        newCode = 123 - (97 - newCode);
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

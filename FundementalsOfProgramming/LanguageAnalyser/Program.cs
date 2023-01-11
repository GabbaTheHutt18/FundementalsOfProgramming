using System;
using System.Collections.Generic;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace LanguageAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text.");
            string usertext = Console.ReadLine().ToLower();

            var languages = GetlanguageFrequencies();
            CheckText(usertext, languages);
        }


        static void CheckText(string userText, List<Dictionary<string, string>> languages)
        {
            Dictionary<char, double> letters2 = new Dictionary<char, double>();
            letters2.Add('a', 0);
            letters2.Add('b', 0);
            letters2.Add('c', 0);
            letters2.Add('d', 0);
            letters2.Add('e', 0);
            letters2.Add('f', 0);
            letters2.Add('g', 0);
            letters2.Add('h', 0);
            letters2.Add('i', 0);
            letters2.Add('j', 0);
            letters2.Add('k', 0);
            letters2.Add('l', 0);
            letters2.Add('m', 0);
            letters2.Add('n', 0);
            letters2.Add('o', 0);
            letters2.Add('p', 0);
            letters2.Add('q', 0);
            letters2.Add('r', 0);
            letters2.Add('s', 0);
            letters2.Add('t', 0);
            letters2.Add('u', 0);
            letters2.Add('v', 0);
            letters2.Add('w', 0);
            letters2.Add('x', 0);
            letters2.Add('y', 0);
            letters2.Add('z', 0);
            letters2.Add('à', 0);
            letters2.Add('â', 0);
            letters2.Add('œ', 0);
            letters2.Add('ç', 0);
            letters2.Add('è', 0);
            letters2.Add('é', 0);
            letters2.Add('ê', 0);
            letters2.Add('ë', 0);
            letters2.Add('î', 0);
            letters2.Add('ï', 0);
            letters2.Add('ô', 0);
            letters2.Add('ù', 0);
            letters2.Add('û', 0);

            Dictionary<char, double> letters = new Dictionary<char, double>();
            letters.Add('a', 0);
            letters.Add('b', 0);
            letters.Add('c', 0);
            letters.Add('d', 0);
            letters.Add('e', 0);
            letters.Add('f', 0);
            letters.Add('g', 0);
            letters.Add('h', 0);
            letters.Add('i', 0);
            letters.Add('j', 0);
            letters.Add('k', 0);
            letters.Add('l', 0);
            letters.Add('m', 0);
            letters.Add('n', 0);
            letters.Add('o', 0);
            letters.Add('p', 0);
            letters.Add('q', 0);
            letters.Add('r', 0);
            letters.Add('s', 0);
            letters.Add('t', 0);
            letters.Add('u', 0);
            letters.Add('v', 0);
            letters.Add('w', 0);
            letters.Add('x', 0);
            letters.Add('y', 0);
            letters.Add('z', 0);
            letters.Add('à', 0);
            letters.Add('â', 0);
            letters.Add('œ', 0);
            letters.Add('ç', 0);
            letters.Add('è', 0);
            letters.Add('é', 0);
            letters.Add('ê', 0);
            letters.Add('ë', 0);
            letters.Add('î', 0);
            letters.Add('ï', 0);
            letters.Add('ô', 0);
            letters.Add('ù', 0);
            letters.Add('û', 0);
            int total = 0;
            List<double> listDifferences = new List<double>();
            
            foreach (char key in letters2.Keys)
            {
                total = 0;
                int characterCount = 0;
                foreach (char letter in userText)
                {
                    
                    if (letters.ContainsKey(letter))
                    {
                        characterCount++;
                    }
                    if (letter == key)
                    {
                        total += 1;
                       
                    }
                }
                letters[key] = (total/characterCount) * 100;
                
            }

            
            foreach (var language in languages)
            {
                double differences = 0;
                foreach (var item in letters)
                {
                    
                    if (letters.ContainsKey(item.Key))
                    {
                        var inputPercentage = item.Value;
                        var languagePercentage = Double.Parse(language[item.Key.ToString()]);
                        differences = differences + Math.Abs(languagePercentage - inputPercentage);
                        

                    }

                }
                listDifferences.Add(differences);

            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{languages[i]["Language"]} {listDifferences[i]}");
            }
            

        }

        static List<Dictionary<string, string>> GetlanguageFrequencies()
        {
            var languages = new List<Dictionary<string, string>>();

            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            var datapath = Path.Combine(path.FullName,"LanguageData");
            var files = Directory.GetFiles(datapath);

            foreach (var filepath in files)
            {
                var data = File.ReadAllText(filepath).Split("\n");
                var languageName = Path.GetFileName(filepath).Replace(".txt", "");
                var languageFrequecies = new Dictionary<string, string>();
                languageFrequecies.Add("Language", languageName);
                foreach (var line in data)
                {
                    var values = line.Split(",");
                    string letter = values[0];
                    var percentage = values[1];
                    languageFrequecies.Add(letter, percentage);
                }
                languages.Add(languageFrequecies);

            }

            return languages;
        }
    }
}

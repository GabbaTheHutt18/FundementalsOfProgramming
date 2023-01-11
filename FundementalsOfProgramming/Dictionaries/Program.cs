using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "one");
            Console.WriteLine(numberNames[1]);

            numberNames[1] = "hello";
            Console.WriteLine(numberNames[1]);

            numberNames.Remove("hello");


        }
    }
}

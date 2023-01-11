using System;

namespace SuperclassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish thisFish = new Fish("little fish", 1);
            thisFish.SetMaxSize(3);
            Duck thisDuck = new Duck("little duck", 3);
            for (int i = 0; i < 4; i++)
            {
                thisDuck.Feed();
                Console.WriteLine($"{thisDuck.GetState()}");
                thisFish.Feed();
                Console.WriteLine($"{thisFish.GetState()}");
            }
        }
    }

}

using System;

namespace FishProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string thisFishState = "Fish";
            int thisFishSize = 1;
            Console.WriteLine($"{thisFishState} is of size {thisFishSize}");
            while (thisFishState != "FISH")
            {
                feed(ref thisFishState, ref thisFishSize);
            }
            Console.WriteLine($"This is now a big {thisFishState}");
        }

        static void feed(ref string state, ref int size) 
        {
            state = "fish";
            size += 1;
            Console.WriteLine("Fish fed");
            if (size == 5)
            {
                state = "FISH";
            }
        
        }
    }
}

using System;


namespace AnimalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal thisFish = new Animal("Fish", 1);
            Console.WriteLine($"{thisFish.GetState()} is the size of {thisFish.GetSize()}");
            while (thisFish.GetState() != "FISH")
            {
                thisFish.Feed();
            }
            Console.WriteLine($"This is now a big {thisFish.GetState()}");
           
        }
    }

    class Animal
    {
        //private fields
        private string _state;
        private int _size;
        //constructors
        public Animal(string state, int size)
        {
            _state = state;
            _size = size;
        }
        public void Feed()
        {
            _size += 1;
            Console.WriteLine("Feeding fish...");
            if (_size == 5)
            {
                _state = "FISH";

            }
        }

        public string GetState()
        {
            return _state;
        }
        public int GetSize()
        {
            return _size;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SuperclassesPractice
{
    class Fish:Animal
    {
        //private
        private int _maxSize;

        //Constructor
        public Fish(string s, int n):base(s,n)
        { 

        }

        public void SetMaxSize(int m)
        {
            _maxSize = m;
        }

        public void Feed()
        {
            _size += 2;
            Console.WriteLine($"{_state} fed");
            if (_size >= _maxSize)
            {
                _state = "BIG FISH";
            }
        }

    }
}

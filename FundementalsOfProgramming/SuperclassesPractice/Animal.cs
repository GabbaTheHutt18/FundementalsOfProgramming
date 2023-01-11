using System;
using System.Collections.Generic;
using System.Text;

namespace SuperclassesPractice
{
    public class Animal
    {
        //Protected
        protected string _state;
        protected int _size;

        //Public
        //Constructors
        public Animal(string s, int n)
        {
            _state = s;
            _size = n;
        }
        //procedure
        public virtual void Feed()
        {
            _size += 1;
            Console.WriteLine($"{_state} fed");

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

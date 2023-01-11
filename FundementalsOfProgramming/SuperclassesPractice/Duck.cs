using System;
using System.Collections.Generic;
using System.Text;

namespace SuperclassesPractice
{
    class Duck:Animal
    {
        //private

        //Constructor
        public Duck(string s, int n) : base(s, n)
        {

        }

        public void Feed()
        {
            base.Feed();
            if (_size == 5)
            {
                _state = "BIG DUCK";
            }
            
        }
    }
}

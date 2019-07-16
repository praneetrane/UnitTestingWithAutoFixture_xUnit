using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoFixture
{
    public class IntCalculator
    {
       public  int value { get; private set; } 
        public void Subtract(int number)
        {
            value -= number;
        }
        public void Add(int number)
        {
            value += number;

        }
    }
}

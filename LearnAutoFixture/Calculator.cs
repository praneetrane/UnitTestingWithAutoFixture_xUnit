using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoFixture
{
    public class Calculator
    {
        public int value { get; private set; }
        public void Add(int number)
        {
            value += number;

        }
    }
}

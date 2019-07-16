using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoFixture
{
    public class DecimalCalculator
    {
        public decimal value { get; private set; }
        public void Subtract(decimal number)
        {
            value -= number;
        }
        public void Add(decimal number)
        {
            value += number;

        }
    }
}

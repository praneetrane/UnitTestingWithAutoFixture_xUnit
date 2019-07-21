using AutoFixture.Xunit2;
using LearnAutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearnAutoFixure.UnitTests
{
   public  class CalculatorTests
    {

        [Theory] 
        [InlineData (1,2)]
        [InlineData(0, 2)]
        [InlineData(-5, 2)]
        public void ShouldAdd_InlineData(int a, int b)
        {
            var sut = new Calculator();
            sut.Add(a);
            sut.Add(b);
            Assert.Equal(a + b, sut.value);
        }

        [Theory]
        [AutoData]

        public void ShouldAdd_AutoData(int a, int b,Calculator sut)
        {
            //var sut = new Calculator();

            sut.Add(a);
            sut.Add(b);

            Assert.Equal(a + b, sut.value);
        }


        [Theory]
        [InlineAutoData] //Add two positive numbers
        [InlineAutoData(0)] //Add Zero and positive numbers
        [InlineAutoData(-5)] //Add Negative and positive numbers
        public void ShouldAdd_AutoInlineData_With_Sut(int a, int b, Calculator sut)
        {
            sut.Add(a);
            sut.Add(b);

            Assert.Equal(a + b, sut.value);
        }
    }

   
}

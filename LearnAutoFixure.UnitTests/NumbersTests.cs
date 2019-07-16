using AutoFixture;
using Xunit;
using LearnAutoFixture;

namespace LearnAutoFixure.UnitTests
{
    public class NumbersTests
    {
        [Fact]

        public void Integer()
        {
            //arrange
            var fixture = new Fixture();
            var sut = new IntCalculator();
            int num = fixture.Create<int>();

            //act

            sut.Add(num);
            //assert

            Assert.Equal(num,sut.value);
        }

        [Fact]

        public void Decimal()
        {
            //arrange
            var fixture = new Fixture();
            var sut = new DecimalCalculator();
            decimal num = fixture.Create<decimal>();

            //act

            sut.Add(num);
            //assert

            Assert.Equal(num, sut.value);
        }

        [Fact]

        public void Numbers()
        {
            var fixture = new Fixture();

            byte b = fixture.Create<byte>();

            short s= fixture.Create<short>();

            long l = fixture.Create<long>();
            sbyte sb = fixture.Create<sbyte>();
            float f = fixture.Create<float>();
            ushort us = fixture.Create<ushort>();
            uint ui = fixture.Create<uint>();
            ulong ul = fixture.Create<ulong>();
        }

    }
}

using Xunit;
using AutoFixture;
using LearnAutoFixture;

namespace LearnAutoFixure.UnitTests
{
    public class AutoFixtureUnitTests
    {
        [Fact]
       public void BasicString()
        {
            //arrange
            var fixture = new Fixture();
            var sut = new NameJoiner();

            var firstName = fixture.Create<string>("FirstNAme:");
            var lastName = fixture.Create<string>("LastNAme:");

            //act
            var result = sut.Join(firstName, lastName);

            //assert
            Assert.Equal(firstName + " " + lastName, result);
        }

        [Fact]
        public void Chars()
        {
            var fixture = new Fixture();
            var annoChar = fixture.Create<char>();
        }
    }
}

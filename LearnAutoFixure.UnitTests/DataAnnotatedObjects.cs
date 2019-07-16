using AutoFixture;
using LearnAutoFixture;
using Xunit;

namespace LearnAutoFixure.UnitTests
{
    
    public class DataAnnotatedObjects
    {
        [Fact]

        public void BasicString()
        {
            //arrange
            var fixture = new Fixture();
            var player = fixture.Create<PlayerCharacter>();

            //act

            //assert
        }
    }
}

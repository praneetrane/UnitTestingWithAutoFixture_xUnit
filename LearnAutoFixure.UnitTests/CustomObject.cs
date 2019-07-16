using AutoFixture;
using LearnAutoFixture;
using Xunit;

namespace LearnAutoFixure.UnitTests
{
   public class CustomObject
    {
        [Fact]

        public void ManualCreation()
        {
            //arrange
            var sut = new EmailMessageBuffer();
            EmailMessage message = new EmailMessage("praneet.rane@aptify.com", "Hope you are doing well", false);
            message.Subject = "Hi";
            
            //act
            sut.Add(message);

            //assert
            Assert.Single(sut.Emails);
            // Assert.Equal(12,sut.Emails.Count);
        }

        [Fact]
        public void AutoCreation()
        {
            var fixture = new Fixture();
            var sut = new EmailMessageBuffer();

            EmailMessage message = fixture.Create<EmailMessage>();

            //act
            sut.Add(message);

            //assert
            Assert.Single(sut.Emails);
        }
    }
}

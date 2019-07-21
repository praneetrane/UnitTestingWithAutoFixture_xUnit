using AutoFixture;
using AutoFixture.AutoMoq;
using LearnAutoFixture;
using Moq;
using Xunit;

namespace LearnAutoFixure.UnitTests
{
    public class EmailMessageBuffer_AutoMockMoqTests
    {
        [Fact]
        public void ShouldSendEmailToGateway_Manual_Moq()
        {
            //arrange
            var fixture = new Fixture();

            var mockGateway = new Mock<IEmailGateway>();

            var sut = new EmailMessageBuffer_AutoMockMoq(mockGateway.Object);

            sut.Add(fixture.Create<EmailMessage>());
            //act

            sut.SendAll();
            //assert
            mockGateway.Verify(x => x.Send(It.IsAny<EmailMessage>()), Times.Once());

        }

        [Fact]

        public void ShouldSendEmailToGateway_WithoutAutoMoq_Error()
        {
            //arrange
            var fixture = new Fixture();

            var sut = fixture.Create<EmailMessageBuffer_AutoMockMoq>();//error

        }

        [Fact]

        public void ShouldSendEmailToGateway_autoMoq()
        {
            //arrange
            var fixture = new Fixture();
            //Add auto mocking support for Moq
            fixture.Customize(new AutoMoqCustomization());

            var sut = fixture.Create<EmailMessageBuffer_AutoMockMoq>();

            sut.Add(fixture.Create<EmailMessage>());
            //act
            sut.SendAll();
            //assert
            //no reference to the mock IEmailGateway that was automatically pro
        }

        [Fact]

        public void ShoudSendEmailToGateway_autoMoq_withFreeze()
        {
            //arrange
            var fixture = new Fixture();
            //Add auto mocking support for Moq
            fixture.Customize(new AutoMoqCustomization());
            var mockGateway = fixture.Freeze<Mock<IEmailGateway>>();

            var sut = fixture.Create<EmailMessageBuffer_AutoMockMoq>();

            sut.Add(fixture.Create<EmailMessage>());

            //act
            sut.SendAll();

            //assert

            mockGateway.Verify(x=>x.Send(It.IsAny<EmailMessage>()),Times.Once());
        }
    }
}

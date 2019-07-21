using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using LearnAutoFixture;
using Xunit;

namespace LearnAutoFixure.UnitTests
{
    public class AnotherEmailMessageBufferTests
    {
        [Fact]

        public void ShouldAddMessageToBuffer()
        {
            var sut = new AnotherEmailMessageBuffer();

            var message = new EmailMessage("praneet@gmail.com", "Hi, hope you are good", true, "Email Subject");

            sut.Add(message);
            Assert.Equal(1, sut.UnSentMessagesCount);


        }

        [Fact]

        public void ShouldRemoveMessageFromBufferWhenSent()
        {
            var sut = new AnotherEmailMessageBuffer();
            var message = new EmailMessage("praneet@gmail.com", "Hi, hope you are good", true, "Email Subject");

            sut.Add(message);

            sut.SendAll();

            Assert.Equal(0, sut.UnSentMessagesCount);
        }

        [Fact]

        public void ShouldSendOnlySpecificNumberOfMessages()
        {
            var sut = new AnotherEmailMessageBuffer();

            var message1 = new EmailMessage("praneet001@gmail.com", "Hi, hope you are good", true, "Email Subject");

            var message2 = new EmailMessage("praneet002@gmail.com", "Hi, hope you are good", true, "Email Subject");

            var message3 = new EmailMessage("praneet003@gmail.com", "Hi, hope you are good", true, "Email Subject");

            sut.Add(message1);
            sut.Add(message2);
            sut.Add(message3);

            sut.SendLimited(2);

            Assert.Equal(1, sut.UnSentMessagesCount);
        }

        [Fact]

        public void ShouldAddMessageToBufferAuto()
        {
            var fixture = new Fixture();
            var sut = new AnotherEmailMessageBuffer();

            sut.Add(fixture.Create<EmailMessage>());

            Assert.Equal(1, sut.UnSentMessagesCount);


        }

        [Fact]

        public void ShouldRemoveMessageFromBufferWhenSentAuto()
        {
            var fixture = new Fixture();
            var sut = new AnotherEmailMessageBuffer();

            sut.Add(fixture.Create<EmailMessage>());

            sut.SendAll();

            Assert.Equal(0, sut.UnSentMessagesCount);
        }

        [Fact]

        public void ShouldSendOnlySpecificNumberOfMessagesAuto()
        {
            var fixture = new Fixture();
            var sut = new AnotherEmailMessageBuffer();

            sut.Add(fixture.Create<EmailMessage>());
            sut.Add(fixture.Create<EmailMessage>());
            sut.Add(fixture.Create<EmailMessage>());

            sut.SendLimited(2);

            Assert.Equal(1, sut.UnSentMessagesCount);
        }
    }
}

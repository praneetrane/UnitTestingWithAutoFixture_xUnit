using AutoFixture;
using LearnAutoFixture;
using System.Collections.Generic;
using Xunit;

namespace LearnAutoFixure.UnitTests
{
    public class CollectionOfCustomTypes
    {
        [Fact]

        public void SequenceOfCustomObjects()
        {
            var fixture = new Fixture();

            //IEnumerable<EmailMessage> emails = fixture.CreateMany<EmailMessage>();

            IEnumerable<EmailMessage> emails = fixture.CreateMany<EmailMessage>(100);
        }

        [Fact]
        public void AddingToExistingList()
        {
            var fixture = new Fixture();
            var sut = new EmailMessageBuffer();

            fixture.AddManyTo(sut.Emails, 100);
        }

        [Fact]
        public void SequenceOfComplexTypes()
        {
            var fixture = new Fixture();
            IEnumerable<Order> orders = fixture.CreateMany<Order>(100);
        }
        
    }
}

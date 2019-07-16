using Xunit;
using AutoFixture;
using System.Collections.Generic;
using System.Diagnostics;
using System;

namespace LearnAutoFixure.UnitTests
{
    public class Collections
    {
        [Fact]
        public void SequenceOfStrings()
        {
            var fixure = new Fixture();

            IEnumerable<string> messages = fixure.CreateMany<string>();
            foreach(var message in messages)
            {
                Debug.WriteLine(message);
            }
        }

        [Fact]

        public void ExplicitNumberOfItems()
        {
            var fixture = new Fixture();

            IEnumerable<int> numbers = fixture.CreateMany<int>(6);

            foreach (var number in numbers)
            {
                Debug.WriteLine(number);
            }
        }

        [Fact]

        public void AddingToExistingList()
        {
            var fixture = new Fixture();
            var sut = new DebugMessageBuffer();

            fixture.AddManyTo(sut.Messages, 10);

            sut.WriteMessages();

        }

        [Fact]

        public void AddingToExistingListWithCreatorFunction()
        {
            var fixture = new Fixture();
            var sut = new DebugMessageBuffer();

            var random = new Random();

            // fixture.AddManyTo(sut.Messages,()=>"hi");
            fixture.AddManyTo(sut.Messages, () => random.Next(11).ToString());

            sut.WriteMessages();

        }
    }
}

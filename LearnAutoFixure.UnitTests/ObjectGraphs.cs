using AutoFixture;
using LearnAutoFixture;
using System;
using Xunit;

namespace LearnAutoFixure.UnitTests
{
    public class ObjectGraphs
    {
        [Fact]

        public void ManualCreation()
        {
            //arrange
            Customer customer = new Customer()
            {
                CustomerName="Praneet"
            };

            Order order = new Order(customer)
            {
                Id = 42,
                OrderDate = DateTime.Now,
                Items =
                {
                    new OrderItem
                    {
                        ProductName="Samco Hats",
                        Quantity=2
                    }
                }
            };

            //act

            //assert

        }

        [Fact]

        public void AutoCreation()
        {
            //arrange
            var fixture = new Fixture();
            Order order = fixture.Create<Order>();
            //act

            //assert
        }
    }
}

using AutoFixture;
using LearnAutoFixture;
using Xunit;

namespace LearnAutoFixure.UnitTests
{
    public class CustomizingAutoFixturePipeline
    {
        [Fact]

        public void Error()
        {
            var fixture = new Fixture();

            var flight = fixture.Create<FlightDetails>();
        }

        [Fact]
        public void CustomizedPipeLine()
        {
            var fixture = new Fixture();

            fixture.Customizations.Add(new AirportCodeSpecimenBuilder());

            var flight = fixture.Create<FlightDetails>();

            var airport = fixture.Create<Airport>();
        }
    }
}

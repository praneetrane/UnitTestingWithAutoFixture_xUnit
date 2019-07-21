using AutoFixture;
using LearnAutoFixture;
using Xunit;
using System;

namespace LearnAutoFixure.UnitTests
{
    public class CutomizingEntireFixtures
    {
        [Fact]
        public void Error()
        {
            var fixture = new Fixture();

            var flight = fixture.Create<FlightDetails>();         
        }

        [Fact]
        public void OmitSettingSpecificProperties()
        {
            var fixture = new Fixture();
            var flight = fixture.Build<FlightDetails>()
                 .Without(x=>x.ArrivalAirportCode)
                 .Without(x=>x.DepartureAirportCode)
                .Create();
        }

        [Fact]
        public void OmitSettingAllProperties()
        {
            var fixture = new Fixture();
            var flight = fixture.Build<FlightDetails>()
                .OmitAutoProperties()
                .Create();
        }


        [Fact]

        public void CustomizedBuilding()
        {
            var fixture = new Fixture();

            var flight = fixture.Build<FlightDetails>()
                            .With(x=> x.ArrivalAirportCode,"LAX")
                            .With(x => x.DepartureAirportCode, "LHR")
                             .Create();
        }

        [Fact]

        public void CustomizedBuildingWithActions()
        {
            var fixture = new Fixture();
            var flight = fixture.Build<FlightDetails>()
                 .With(x => x.DepartureAirportCode, "LHR")
                 .With(x => x.ArrivalAirportCode, "LAX")
                 .Without(x => x.MealOptions)
                 .Do(x=>x.MealOptions.Add("Chicken"))
                  .Do(x => x.MealOptions.Add("Fish"))
                  .Create();

        }

        [Fact]

        public void SettingValueForCustomType()
        {
            var fixture = new Fixture();
            fixture.Inject(new FlightDetails
            {
                DepartureAirportCode = "PER",
                ArrivalAirportCode = "LHR",
                FlightDuration = TimeSpan.FromHours(10),
                AirlineName = "Awesome Aero"

            });

            var flight1 = fixture.Create<FlightDetails>();
            var flight2 = fixture.Create<FlightDetails>();
        }
    }
}

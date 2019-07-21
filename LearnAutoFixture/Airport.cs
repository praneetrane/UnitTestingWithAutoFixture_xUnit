using System;

namespace LearnAutoFixture
{
    public class Airport
    {
        private string _airportCode;
        public string AirportCode
        {
            get { return _airportCode; }
            set
            {
                EnsureValidAirportCode(value);
                _airportCode = value;

            }
        }

        public string AirLineName { get; set; }

        private void EnsureValidAirportCode(string airportCode)
        {
            var isWrongLength = airportCode.Length != 3;
            var isWrongCase = airportCode != airportCode.ToUpperInvariant();

            if (isWrongLength|| isWrongCase)
            {
                throw new ApplicationException(airportCode + "is an invalid");
            }
        }
    }
}

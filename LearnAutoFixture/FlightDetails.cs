using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoFixture
{
    public class FlightDetails
    {
        private string _arrivalAirportCode;
        private string _departureAirportCode;
        //private string 

        public FlightDetails()
        {
            MealOptions = new List<string>();
        }

        public string DepartureAirportCode
        {
            get { return _departureAirportCode; }
            set
            {
                EnsureValidAirportCode(value);
                _departureAirportCode = value;
            }
        }

        public string ArrivalAirportCode
        {
            get { return _departureAirportCode; }
            set
            {
                EnsureValidAirportCode(value);
                _arrivalAirportCode = value;
            }
        }

        public TimeSpan FlightDuration { get; set; }
        public string AirlineName { get; set; }
        public List<string> MealOptions { get; set; }


        public void EnsureValidAirportCode(string airportCode)
        {
            var isWrongLength = airportCode.Length != 3;

            var isWrongCase = airportCode != airportCode.ToUpperInvariant();

            if (isWrongLength || isWrongCase)
            {
                throw new ApplicationException(airportCode + "is an invalid airport");
            }
        }
    }
}

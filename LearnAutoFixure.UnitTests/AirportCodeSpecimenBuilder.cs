using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using AutoFixture.Kernel;
using LearnAutoFixture;
using Xunit;

namespace LearnAutoFixure.UnitTests
{
    public class AirportCodeSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            //See if we are trying to create a value for a property
            var propertyInfo = request as PropertyInfo;

            if (propertyInfo ==null)
            {
                //this customization does not apply to current request
                //return new NoSpecimen(request);
                return new NoSpecimen();
            }

            //Now we know we are dealing with a property, are we creating 
            // a value for an airport code?
            var isAirportCodeProperty =
                propertyInfo.Name.Contains("AirportCode") &&
                propertyInfo.PropertyType == typeof(string);

            if (isAirportCodeProperty)
            {
                return RandomAirportCode();
            }
            //this customization does not apply to current request
            //return new NoSpecimen(request);
            return new NoSpecimen();
        }

        private string  RandomAirportCode()
        {
            if (DateTime .Now.Ticks%2==0)
            {
                return "AAA";
            }
            return "BBB";
        }
    }
}

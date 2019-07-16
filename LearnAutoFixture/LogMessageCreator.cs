using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoFixture
{
    public static class LogMessageCreator
    {
        public static LogMessage Create(string message, DateTime when)
        {

            return new LogMessage
            {
                Year = when.Year,
                Message = message
            };
        }
    }
}

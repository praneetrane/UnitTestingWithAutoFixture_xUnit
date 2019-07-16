using System.Collections.Generic;
using System.Diagnostics;

namespace LearnAutoFixure.UnitTests
{
    public  class DebugMessageBuffer
    {
        public DebugMessageBuffer()
        {
            Messages = new List<string>();
        }

        public List<string> Messages { get; set; }

        public void WriteMessages()
        {
            foreach(var message in Messages)
            {
                Debug.WriteLine(message);
            }
        }
    }
}
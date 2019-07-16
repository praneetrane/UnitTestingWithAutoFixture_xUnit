using System.Collections.Generic;
using System.Diagnostics;

namespace LearnAutoFixture
{
    public class EmailMessageBuffer
    {
        public EmailMessageBuffer()
        {
            Emails = new List<EmailMessage>();
        }

        public List<EmailMessage> Emails { get; set; }

        public void SendAll()
        {
            foreach(var email in Emails)
            {
                Debug.WriteLine(email);
            }
        }

        public void Add(EmailMessage message)
        {
            Emails.Add(message);
        }
    }
}

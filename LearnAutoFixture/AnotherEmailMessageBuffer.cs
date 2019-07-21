using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoFixture
{
    public class AnotherEmailMessageBuffer
    {
        private readonly List<EmailMessage> _emails = new List<EmailMessage>();

        public void SendAll()
        {
            for (int i = 0; i < _emails.Count; i++)
            {
                var email = _emails[i];
                Send(email);
            }
        }

        private void Send(EmailMessage email)
        {
            //simulate sending email

            Debug.WriteLine("Sending email to: " + email.ToAddress);

            _emails.Remove(email);
        }

        public void Add(EmailMessage message)
        {
            _emails.Add(message);
        }

        public int UnSentMessagesCount
        {
            get { return _emails.Count; }
        }

        public void SendLimited(int maximumMessagesToSend)
        {
            var limitedBatchOfMessages = _emails.Take(maximumMessagesToSend).ToArray();

            for (int i = 0; i < limitedBatchOfMessages.Length; i++)
            {
                Send(limitedBatchOfMessages[i]);
            }
        }
    }
}

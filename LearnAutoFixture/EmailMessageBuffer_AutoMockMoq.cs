using System.Collections.Generic;
using System.Linq;

namespace LearnAutoFixture
{
    public  class EmailMessageBuffer_AutoMockMoq
    {
        private readonly IEmailGateway _emailGateWay;
        private readonly List<EmailMessage> _emails = new List<EmailMessage>();

        public EmailMessageBuffer_AutoMockMoq(IEmailGateway emailGateWay)
        {
            _emailGateWay = emailGateWay;
        }

        public int UnSentMessageCount
        {
            get { return _emails.Count; }
        }

        public IEmailGateway EmailGateWay
        {
            get { return _emailGateWay; }
        }

        public void SendAll()
        {
            for(int i = 0; i < _emails.Count; i++)
            {
                var email = _emails[i];
                Send(email);

            }
        }

        private void Send(EmailMessage email)
        {
            _emailGateWay.Send(email);
            _emails.Remove(email);
        }

        public void Add(EmailMessage message)
        {
            _emails.Add(message);
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

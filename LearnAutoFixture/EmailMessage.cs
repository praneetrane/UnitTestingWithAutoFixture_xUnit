namespace LearnAutoFixture
{
    public class EmailMessage
    {
        private string _somePrivateField;
        public string _somePublicField;

        private string SomePrivateProperty { get; set; }

        public string ToAddress { get; set; }

        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public bool IsImportant { get; set; }
        
        public EmailMessage(string toAddress,string messageBody,bool isImportant,string subject)
        {
            ToAddress = toAddress;
            MessageBody = messageBody;
            IsImportant = isImportant;
            Subject = subject;

        }

    }
}

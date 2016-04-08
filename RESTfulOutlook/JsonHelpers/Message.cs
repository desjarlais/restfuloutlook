using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    public class Message
    {
        public string Subject { get; set; }
        public string Importance { get; set; }
        public Body Body { get; set; }
        public List<ToRecipient> ToRecipients { get; set; }
    }

    public class Body
    {
        public string ContentType { get; set; }
        public string Content { get; set; }
    }

    public class EmailAddress
    {
        public string Address { get; set; }
    }

    public class ToRecipient
    {
        public EmailAddress EmailAddress { get; set; }
    }

    public class RootObject
    {
        public Message Message { get; set; }
        public string SaveToSentItems { get; set; }
    }
}
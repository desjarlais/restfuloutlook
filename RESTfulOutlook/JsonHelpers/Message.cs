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

    public class Event
    {
        public string Subject { get; set; }
        public Body Body { get; set; }
        public Start Start { get; set; }
        public End End { get; set; }
        public List<Attendee> Attendees { get; set; }
    }

    public class Contact
    {
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public List<EmailAddress> EmailAddresses { get; set; }
        public List<string> BusinessPhones { get; set; }
    }

    public class Body
    {
        public string ContentType { get; set; }
        public string Content { get; set; }
    }

    public class Start
    {
        public string DateTime { get; set; }
        public string TimeZone { get; set; }
    }

    public class End
    {
        public string DateTime { get; set; }
        public string TimeZone { get; set; }
    }

    public class EmailAddress
    {
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class ToRecipient
    {
        public EmailAddress EmailAddress { get; set; }
    }

    public class Attendee
    {
        public EmailAddress EmailAddress { get; set; }
        public string Type { get; set; }
    }

    public class RootObject
    {
        public Message Message { get; set; }
        public string SaveToSentItems { get; set; }
    }
}
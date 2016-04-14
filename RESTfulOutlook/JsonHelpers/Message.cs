using Newtonsoft.Json;
using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    public class Message
    {
        public string subject { get; set; }
        public string importance { get; set; }
        public Body body { get; set; }
        public List<ToRecipient> toRecipients { get; set; }
        public List<Attachment> attachments { get; set; }
        public string receivedDateTime { get; set; }
        public string sentDateTime { get; set; }
        public bool hasAttachments { get; set; }
        public string bodyPreview { get; set; }
        public string parentFolderId { get; set; }
        public Sender sender { get; set; }
        public From from { get; set; }
        public List<CcRecipient> ccRecipients { get; set; }
        public List<BccRecipient> bccRecipients { get; set; }
        public List<ReplyTo> replyToCollection { get; set; }
        public string conversationId { get; set; }
        public UniqueBody uniqueBody { get; set; }
        public bool isDeliveryReceiptRequested { get; set; }
        public bool isReadReceiptRequested { get; set; }
        public bool isRead { get; set; }
        public bool isDraft { get; set; }
        public string webLink { get; set; }
        public string createdDateTime { get; set; }
        public string lastModifiedDateTime { get; set; }
        public string changeKey { get; set; }
    }

    public class Event
    {
        public string subject { get; set; }
        public Body body { get; set; }
        public Start start { get; set; }
        public End end { get; set; }
        public List<Attendee> attendees { get; set; }
    }

    public class Contact
    {
        public string givenName { get; set; }
        public string surname { get; set; }
        public List<EmailAddress> emailAddresses { get; set; }
        public List<string> businessPhones { get; set; }
    }

    public class Body
    {
        public string contentType { get; set; }
        public string content { get; set; }
    }

    public class Start
    {
        public string dateTime { get; set; }
        public string timeZone { get; set; }
    }

    public class End
    {
        public string dateTime { get; set; }
        public string timeZone { get; set; }
    }

    public class EmailAddress
    {
        public string address { get; set; }
        public string name { get; set; }
    }

    public class ToRecipient
    {
        public EmailAddress emailAddress { get; set; }
    }

    public class Attachment
    {
        [JsonProperty("@odata.type")]
        public string oDataType { get; set; }
        public string name { get; set; }
        public string contentBytes { get; set; }
        public string contentId { get; set; }
        public string contentLocation { get; set; }
        public string contentType { get; set; }
    }

    public class Attendee
    {
        public EmailAddress emailAddress { get; set; }
        public string type { get; set; }
    }

    public class Sender
    {
        public EmailAddress emailAddress { get; set; }
    }

    public class From
    {
        public EmailAddress emailAddress { get; set; }
    }

    public class CcRecipient
    {
        public EmailAddress emailAddress { get; set; }
    }

    public class BccRecipient
    {
        public EmailAddress emailAddress { get; set; }
    }

    public class ReplyTo
    {
        public EmailAddress emailAddress { get; set; }
    }

    public class UniqueBody
    {
        public string contentType { get; set; }
        public string content { get; set; }
    }

    public class RootObject
    {
        public Message message { get; set; }
        public string saveToSentItems { get; set; }
    }
}
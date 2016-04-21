using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Microsoft.Data;

namespace RESTfulOutlook.JsonHelpers
{
    public class Item
    {
        public string subject { get; set; }
        public string importance { get; set; }
        public Body body { get; set; }
        public List<Recipient> toRecipients { get; set; }
        public List<Attachment> attachments { get; set; }
        public DateTimeOffset receivedDateTime { get; set; }
        public string sentDateTime { get; set; }
        public bool hasAttachments { get; set; }
        public string bodyPreview { get; set; }
        public string parentFolderId { get; set; }
        public Recipient sender { get; set; }
        public Recipient from { get; set; }
        public List<Recipient> ccRecipients { get; set; }
        public List<Recipient> bccRecipients { get; set; }
        public List<Recipient> replyToCollection { get; set; }
        public string conversationId { get; set; }
        public UniqueBody uniqueBody { get; set; }
        public bool isDeliveryReceiptRequested { get; set; }
        public bool isReadReceiptRequested { get; set; }
        public bool isRead { get; set; }
        public bool isDraft { get; set; }
        public string webLink { get; set; }
        public DateTimeOffset createdDateTime { get; set; }
        public DateTimeOffset lastModifiedDateTime { get; set; }
        public string changeKey { get; set; }
        public string id { get; }
    }

    /// <summary>
    /// Calendar "extension" class off the Item
    /// </summary>
    public class Event
    {
        public string subject { get; set; }
        public Body body { get; set; }
        public DateTimeTimeZone start { get; set; }
        public DateTimeTimeZone end { get; set; }
        public List<Attendee> attendees { get; set; }
        public string id { get; }
        public string bodyPreview { get; set; }
        public List<string> categories { get; set; }
        public string changeKey { get; set; }
        public DateTimeOffset createdDateTime { get; set; }
        public bool hasAttachments { get; set; }
        public string iCalUId { get; set; }
        public string importance { get; set; }
        public bool isAllDay { get; set; }
        public bool isCancelled { get; set; }
        public bool isOrganizer { get; set; }
        public bool isReminderOn { get; set; }
        public DateTimeOffset lastModifiedDateTime { get; set; }
        public Location location { get; set; }
        public Recipient organizer { get; set; }
        public string originalEndTimeZone { get; set; }
        public DateTimeOffset originalStart { get; set; }
        public string originalStartTimeZone { get; set; }
        public PatternedRecurrence recurrence { get; set; }
        public int reminderMinutesBeforeStart { get; set; }
        public bool responseRequested { get; set; }
        public ResponseStatus response { get; set; }
        public string sensitivity { get; set; }
        public string seriesMasterId { get; set; }
        public string showAs { get; set; }
        public string webLink { get; set; }

    }

    /// <summary>
    /// Contact "extension" class off the item
    /// </summary>
    public class Contact
    {
        public string givenName { get; set; }
        public string surname { get; set; }
        public List<EmailAddress> emailAddresses { get; set; }
        public List<string> businessPhones { get; set; }
        public string assistantName { get; set; }
        public DateTimeOffset birthday { get; set; }
        public List<PhysicalAddress> businessAddress { get; set; }
        public string businessHomePage { get; set; }
        public List<string> categories { get; set; }
        public string changeKey { get; set; }
        public List<string> children { get; set; }
        public string companyName { get; set; }
        public DateTimeOffset createdDateTime { get; set; }
        public string department { get; set; }
        public string displayName { get; set; }
        public string fileAs { get; set; }
        public string generation { get; set; }
        public List<PhysicalAddress> homeAddress { get; set; }
        public List<string> homePhones { get; set; }
        public List<string> imAddresses { get; set; }
        public string initials { get; set; }
        public string jobTitle { get; set; }
        public DateTimeOffset lastModifiedDateTime { get; set; }
        public string manager { get; set; }
        public string middleName { get; set; }
        public string mobilePhone { get; set; }
        public string nickName { get; set; }
        public string officeLocation { get; set; }
        public List<PhysicalAddress> otherAddress { get; set; }
        public string id { get; }
        public string parentFolderId { get; set; }
        public string personalNotes { get; set; }
        public string profession { get; set; }
        public string spouseName { get; set; }
        public string title { get; set; }
        public string yomiCompanyName { get; set; }
        public string yomiGivenName { get; set; }
        public string yomiSurname { get; set; }
    }

    public class Location
    {
        public List<PhysicalAddress> address { get; set; }
        public string displayName { get; set; }
    }

    public class PatternedRecurrence
    {
        public RecurrencePattern pattern { get; set; }
        public RecurrenceRange range { get; set; }
    }

    public class RecurrencePattern
    {
        public int dayOfMonth { get; set; }
        public List<string> daysOfWeek { get; set; }
        public string firstDayOfWeek { get; set; }
        public string index { get; set; }
        public int interval { get; set; }
        public int month { get; set; }
        public string type { get; set; }
    }

    public class RecurrenceRange
    {
        public DateTime endDate { get; set; }
        public int numberOfOccurrences { get; set; }
        public DateTime startDate { get; set; }
        public string type { get; set; }
    }

    public class ResponseStatus
    {
        public string response { get; set; }
        public DateTimeOffset time { get; set; }
    }

    public class PhysicalAddress
    {
        public string city { get; set; }
        public string countryOrRegion { get; set; }
        public string postalCode { get; set; }
        public string state { get; set; }
        public string street { get; set; }
    }

    public class DateTimeTimeZone
    {
        public DateTimeOffset dateTime { get; set; }
        public string timeZone { get; set; }
    }

    public class Body
    {
        public string contentType { get; set; }
        public string content { get; set; }
    }

    public class EmailAddress
    {
        public string address { get; set; }
        public string name { get; set; }
    }

    public class Recipient
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

    public class UniqueBody
    {
        public string contentType { get; set; }
        public string content { get; set; }
    }

    public class RootObject
    {
        public Item message { get; set; }
        public string saveToSentItems { get; set; }
    }
}
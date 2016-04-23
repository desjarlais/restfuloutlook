using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    public class OutlookItem
    {
        public List<string> categories { get; set; }
        public string changeKey { get; set; }
        public DateTimeOffset? createdDateTime { get; set; }
        public string id { get; }
        public DateTimeOffset? lastModifiedDateTime { get; set; }
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
        public string contentBytes { get; set; }
        public string contentId { get; set; }
        public string contentLocation { get; set; }
        public string name { get; set; }
        public string contentType { get; set; }
        public bool? isInline { get; set; }
        public int? size { get; set; }
        public DateTimeOffset? lastModifiedDateTime { get; set; }
        public string id { get; }
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
        public OutlookItem message { get; set; }
        public string saveToSentItems { get; set; }
    }
}

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

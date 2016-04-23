using System;
using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    class Event : OutlookItem
    {
        public List<Attachment> attachments { get; set; }
        public string bodyPreview { get; set; }
        public string subject { get; set; }
        public string importance { get; set; }
        public Body body { get; set; }
        public DateTimeTimeZone start { get; set; }
        public DateTimeTimeZone end { get; set; }
        public List<Attendee> attendees { get; set; }
        public string iCalUId { get; set; }
        public bool isAllDay { get; set; }
        public bool isCancelled { get; set; }
        public bool isOrganizer { get; set; }
        public bool isReminderOn { get; set; }
        public Location location { get; set; }
        public Recipient organizer { get; set; }
        public string originalEndTimeZone { get; set; }
        public DateTimeOffset originalStart { get; set; }
        public string originalStartTimeZone { get; set; }
        public PatternedRecurrence recurrence { get; set; }
        public int reminderMinutesBeforeStart { get; set; }
        public bool responseRequested { get; set; }
        public ResponseStatus responseStatus { get; set; }
        public string sensitivity { get; set; }
        public string seriesMasterId { get; set; }
        public string showAs { get; set; }
        public bool hasAttachments { get; set; }
        public string type { get; set; }
        public string webLink { get; set; }
    }
}

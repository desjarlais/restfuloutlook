using System;
using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    class EventMessage : Event
    {
        public List<Recipient> toRecipients { get; set; }
        public DateTimeOffset? receivedDateTime { get; set; }
        public string sentDateTime { get; set; }
        public string parentFolderId { get; set; }
        public Recipient sender { get; set; }
        public Recipient from { get; set; }
        public List<Recipient> ccRecipients { get; set; }
        public List<Recipient> bccRecipients { get; set; }
        public List<Recipient> replyTo { get; set; }
        public string conversationId { get; set; }
        public UniqueBody uniqueBody { get; set; }
        public bool isDeliveryReceiptRequested { get; set; }
        public bool isReadReceiptRequested { get; set; }
        public bool isRead { get; set; }
        public bool isDraft { get; set; }
    }
}

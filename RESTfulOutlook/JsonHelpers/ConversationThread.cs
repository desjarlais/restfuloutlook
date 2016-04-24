using System;
using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    class ConversationThread : Post
    {
        public List<Recipient> toRecipients { get; set; }
        public List<Recipient> ccRecipients { get; set; }
        public string topic { get; set; }
        public bool hasAttachments { get; set; }
        public DateTimeOffset? lastDeliveredDateTime { get; set; }
        public List<string> uniqueSenders { get; set; }
        public string preview { get; set; }
        public bool isLocked { get; set; }
    }
}

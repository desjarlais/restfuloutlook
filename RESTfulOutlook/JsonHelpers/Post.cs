using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfulOutlook.JsonHelpers
{
    class Post : OutlookItem
    {
        public string conversationId { get; set; }
        public string conversationThreadId { get; set; }
        public Recipient from { get; set; }
        public Recipient sender { get; set; }
        public DateTimeOffset receivedDateTime { get; set; }
        public Recipient newParticipants { get; set; }
    }
}

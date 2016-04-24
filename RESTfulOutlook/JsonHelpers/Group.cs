using System;
using System.Collections.Generic;

namespace RESTfulOutlook.JsonHelpers
{
    class Group
    {
        public bool allowExternalSenders { get; set; }
        public bool autoSubscribeNewMembers { get; set; }
        public string description { get; set; }
        public string displayName { get; set; }
        public List<string> groupTypes { get; set; }
        public string id { get; }
        public bool isSubscribedByMail { get; set; }
        public string mail { get; set; }
        public bool mailEnabled { get; set; }
        public string mailNickname { get; set; }
        public DateTimeOffset onPremisesLastSyncDateTime { get; set; }
        public string onPremisesSecurityIdentifier { get; set; }
        public bool onPremisesSyncEnabled { get; set; }
        public List<string> proxyAddresses { get; set; }
        public bool securityEnabled { get; set; }
        public int unseenCount { get; set; }
        public string visibility { get; set; }
    }
}

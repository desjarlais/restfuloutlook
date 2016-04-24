using System;

namespace RESTfulOutlook.JsonHelpers
{
    class ContactFolder
    {
        public string displayName { get; set; }
        public string id { get; }
        public string parentFolderId { get; }
    }
}

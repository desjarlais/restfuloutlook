using System;

namespace RESTfulOutlook.JsonHelpers
{
    class MailFolder : ContactFolder
    {
        public int childFolderCount { get; }
        public int totalItemCount { get; }
        public int unreadItemCount { get; }
    }
}

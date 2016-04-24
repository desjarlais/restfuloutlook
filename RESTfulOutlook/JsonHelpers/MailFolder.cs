using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfulOutlook.JsonHelpers
{
    class MailFolder
    {
        public int childFolderCount { get; }
        public string displayName { get; set; }
        public string id { get; }
        public string parentFolderId { get; }
        public int totalItemCount { get; }
        public int unreadItemCount { get; }
    }
}

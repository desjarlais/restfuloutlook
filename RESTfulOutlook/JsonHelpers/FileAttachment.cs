using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfulOutlook.JsonHelpers
{
    class FileAttachment : Attachment
    {
        public string contentBytes { get; set; }
        public string contentId { get; set; }
        public string contentLocation { get; set; }
    }
}

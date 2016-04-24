using Newtonsoft.Json;
using System;

namespace RESTfulOutlook.JsonHelpers
{
    public class Attachment
    {
        [JsonProperty("@odata.type")]
        public string oDataType { get; set; }
        public string name { get; set; }
        public string contentType { get; set; }
        public bool? isInline { get; set; }
        public int? size { get; set; }
        public DateTimeOffset? lastModifiedDateTime { get; set; }
        public string id { get; }
    }
}

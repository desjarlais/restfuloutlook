using Newtonsoft.Json;
using System;

namespace RESTfulOutlook.JsonHelpers
{
    public class Notifications
    {
        [JsonProperty("@odata.type")]
        public string oDataType { get; set; }
        public string resource { get; set; }
        public string notificationURL { get; set; }
        public string changeType { get; set; }
        public string clientState { get; set; }
        public string id { get; }
        public DateTime expirationDateTime { get; set; }
    }
}

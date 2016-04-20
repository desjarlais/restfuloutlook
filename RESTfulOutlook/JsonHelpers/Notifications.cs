using Newtonsoft.Json;

namespace RESTfulOutlook.JsonHelpers
{
    public class Notifications
    {
        [JsonProperty("@odata.type")]
        public string oDataType { get; set; }
        public string Resource { get; set; }
        public string NotificationURL { get; set; }
        public string ChangeType { get; set; }
        public string ClientState { get; set; }
    }
}

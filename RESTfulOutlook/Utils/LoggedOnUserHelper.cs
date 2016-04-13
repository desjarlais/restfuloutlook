using System;

namespace RESTfulOutlook.Utils
{
    public class LoggedOnUserHelper
    {
        public string DisplayableId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string AccessToken { get; set; }
        public string IdToken { get; set; }
        public DateTimeOffset ExpiresOn { get; set; }
        public string AccessTokenType { get; set; }

        public void Clear()
        {
            DisplayableId = "";
            GivenName = "";
            FamilyName = "";
            AccessToken = "";
            IdToken = "";
            AccessTokenType = "";
            ExpiresOn = new DateTime();             
        }
    }
}

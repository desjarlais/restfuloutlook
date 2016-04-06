using System;

namespace RESTfulOutlook.Utils
{
    public class ConfigHelper
    {
        private string _clientId;
        private string _graphEndpoint;
        private string _tenantId;
        private string _authority;
        private string _redirectUri;

        public string clientId
        {
            get { return _clientId; }
            set { _clientId = value; }
        }

        public string graphEndpoint
        {
            get { return _graphEndpoint; }
            set { _graphEndpoint = value; }
        }
        public string tenantId
        {
            get { return _tenantId; }
            set { _tenantId = value; }
        }
        public string authority
        {
            get { return _authority; }
            set { _authority = value; }
        }
        public string redirectUri
        {
            get { return _redirectUri; }
            set { _redirectUri = value; }
        }

        public static string AzureAdGraphResourceId
        {
            get { return "https://graph.windows.net"; }
        }

        public static string MicrosoftGraphEndpoint
        {
            get { return "https://graph.microsoft.com"; }
        }
    }
}

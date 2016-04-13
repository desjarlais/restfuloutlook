using System;

namespace RESTfulOutlook.Utils
{
    public class ConfigHelper
    {
        private string _clientId;
        private string _graphEndpoint;
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

        public string redirectUri
        {
            get { return _redirectUri; }
            set { _redirectUri = value; }
        }

        public string aadGraphResourceId
        {
            get { return "https://graph.windows.net"; }
        }

        public string msGraphEndpoint
        {
            get { return "https://graph.microsoft.com"; }
        }

        public string aadInstance
        {
            get { return "https://login.microsoftonline.com/{0}"; }
        }
    }
}

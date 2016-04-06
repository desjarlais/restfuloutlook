using Microsoft.Graph;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;

namespace RESTfulOutlook.Utils
{
    class AuthenticationHelper
    {
        public static string TokenForUser;

        /// <summary>
        /// Get Token for User.
        /// </summary>
        /// <returns>Token for user.</returns>
        public static string GetTokenForUser()
        {
            if (TokenForUser == null)
            {
                //var redirectUri = new Uri(SettingsHelper.RedirectUri);
                //string authority = "https://login.microsoftonline.com/common";
                //AuthenticationContext authenticationContext = new AuthenticationContext(authority, false);
                //AuthenticationResult userAuthnResult = authenticationContext.AcquireToken(SettingsHelper.GraphEndpoint,
                //    SettingsHelper.ClientId, redirectUri, PromptBehavior.RefreshSession);
                //TokenForUser = userAuthnResult.AccessToken;
            }

            return TokenForUser;
        }
    }
}

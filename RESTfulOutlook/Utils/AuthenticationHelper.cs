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
                // need to implement manually handling auth outside adal.net for test purposes
                    
            }

            return TokenForUser;
        }
    }
}

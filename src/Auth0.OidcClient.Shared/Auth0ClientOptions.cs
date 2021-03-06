﻿namespace Auth0.OidcClient
{
    public class Auth0ClientOptions
    {
#if __ANDROID__
        /// <summary>
        /// The Android Activity from which the login process is initiated.
        /// </summary>
        public Android.App.Activity Activity { get; set; }
#endif

        /// <summary>
        /// Your Auth0 Client ID.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Your Auth0 Client Secret.
        /// </summary>
        public string ClientSecret { get; set; }

#if __IOS__
        /// <summary>
        /// The View Controller from which the login process is initiated
        /// </summary>
        public UIKit.UIViewController Controller { get; set; }
#endif

        /// <summary>
        /// Your Auth0 tenant domain.
        /// </summary>
        /// <remarks>
        /// e.g. tenant.auth0.com
        /// </remarks>
        public string Domain { get; set; }

        /// <summary>
        /// Indicates whether the user profile should be loaded from the /userinfo endpoint.
        /// </summary>
        /// <remarks>
        /// Defaults to true.
        /// </remarks>
        public bool LoadProfile { get; set; }

        /// <summary>
        /// The scopes you want to request.
        /// </summary>
        public string Scope { get; set; }

        public Auth0ClientOptions()
        {
            LoadProfile = true;
            Scope = "openid profile";
        }
    }
}
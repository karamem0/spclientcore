//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Resources;
using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.OAuth
{

    public class AadOAuthTokenProvider : OAuthTokenProvider
    {

        private readonly AadOAuthContext oAuthContext;

        private AadOAuthToken oAuthToken;

        public AadOAuthTokenProvider(AadOAuthContext oAuthContext, AadOAuthToken oAuthToken)
        {
            this.oAuthContext = oAuthContext ?? throw new ArgumentNullException(nameof(oAuthContext));
            this.oAuthToken = oAuthToken ?? throw new ArgumentNullException(nameof(oAuthToken));
        }

        public override string CurrentAceessToken => this.oAuthToken.AccessToken;

        public override string GetAccessToken()
        {
            var jwtToken = new JsonWebToken(this.oAuthToken.AccessToken);
            var jwtExpireIn = jwtToken.GetPayloadValue<double>("exp");
            var jwtExpireOn = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(jwtExpireIn);
            if (jwtExpireOn <= DateTime.UtcNow)
            {
                if (this.oAuthToken.RefreshToken == null)
                {
                    throw new InvalidOperationException(StringResources.ErrorAccessTokenExpired);
                }
                var oAuthMessage = this.oAuthContext.AcquireTokenByRefreshToken(this.oAuthToken.RefreshToken);
                if (oAuthMessage is AadOAuthToken oAuthToken)
                {
                    this.oAuthToken = oAuthToken;
                    AadOAuthTokenStore.Add(oAuthToken);
                }
                if (oAuthMessage is OAuthError oAuthError)
                {
                    throw new InvalidOperationException(oAuthError.ErrorDescription);
                }
            }
            return this.oAuthToken.AccessToken;
        }

    }

}

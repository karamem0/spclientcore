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

    public static class AadOAuthTokenStore
    {

        public static AadOAuthToken Get(string audience)
        {
            _ = audience ?? throw new ArgumentNullException(nameof(audience));
            if (AadOAuthTokenDictionary.Load().TryGetValue(audience, out var oAuthToken))
            {
                return oAuthToken;
            }
            throw new InvalidOperationException(StringResources.ErrorAccessTokenIsNotCached);
        }

        public static void Add(AadOAuthToken oAuthToken)
        {
            _ = oAuthToken ?? throw new ArgumentNullException(nameof(oAuthToken));
            var oAuthTokens = AadOAuthTokenDictionary.Load();
            var jwtToken = new JsonWebToken(oAuthToken.AccessToken);
            var jwtAudience = jwtToken.GetPayloadValue<string>("aud");
            oAuthTokens[jwtAudience] = oAuthToken;
            oAuthTokens.Save();
        }

        public static void Remove(string audience)
        {
            _ = audience ?? throw new ArgumentNullException(nameof(audience));
            var oAuthTokens = AadOAuthTokenDictionary.Load();
            _ = oAuthTokens.Remove(audience);
            oAuthTokens.Save();
        }

    }

}

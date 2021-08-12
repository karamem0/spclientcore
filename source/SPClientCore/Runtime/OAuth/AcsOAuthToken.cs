//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.OAuth
{

    [JsonObject()]
    public class AcsOAuthToken : OAuthMessage
    {

        public AcsOAuthToken()
        {
        }

        [JsonProperty("token_type")]
        public string TokenType { get; private set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; private set; }

        [JsonProperty("not_before")]
        public int NotBefore { get; private set; }

        [JsonProperty("expires_on")]
        public int ExpiresOn { get; private set; }

        [JsonProperty("resource")]
        public string Resource { get; private set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; private set; }

    }

}

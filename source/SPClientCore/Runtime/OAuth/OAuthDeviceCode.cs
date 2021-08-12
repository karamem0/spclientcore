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
    public class OAuthDeviceCode : OAuthMessage
    {

        public OAuthDeviceCode()
        {
        }

        [JsonProperty("user_code")]
        public string UserCode { get; private set; }

        [JsonProperty("device_code")]
        public string DeviceCode { get; private set; }

        [JsonProperty("verification_url")]
        public string VerificationUrl { get; private set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; private set; }

        [JsonProperty("interval")]
        public int Interval { get; private set; }

        [JsonProperty("message")]
        public string Message { get; private set; }

    }

}

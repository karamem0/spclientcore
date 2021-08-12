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
    public class OAuthError : OAuthMessage
    {

        public OAuthError()
        {
        }

        [JsonProperty("error")]
        public string Error { get; private set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; private set; }

        [JsonProperty("error_codes")]
        public int[] ErrorCodes { get; private set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; private set; }

        [JsonProperty("trace_id")]
        public string TraceId { get; private set; }

        [JsonProperty("correlation_id")]
        public string CorrelationId { get; private set; }

    }

}

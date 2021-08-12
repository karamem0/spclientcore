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

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [JsonObject()]
    public class ClientResultError
    {

        [JsonProperty()]
        public string ErrorMessage { get; private set; }

        [JsonProperty()]
        public string ErrorValue { get; private set; }

        [JsonProperty()]
        public string TraceCorrelationId { get; private set; }

        [JsonProperty()]
        public int ErrorCode { get; private set; }

        [JsonProperty()]
        public string ErrorTypeName { get; private set; }

    }

}

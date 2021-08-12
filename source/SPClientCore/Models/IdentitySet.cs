//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Models
{

    [JsonObject()]
    public class IdentitySet : ODataV2Object
    {

        public IdentitySet()
        {
        }

        [JsonProperty("application")]
        public virtual Identity Application { get; protected set; }

        [JsonProperty("device")]
        public virtual Identity Device { get; protected set; }

        [JsonProperty("group")]
        public virtual Identity Group { get; protected set; }

        [JsonProperty("user")]
        public virtual Identity User { get; protected set; }

    }

}

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

    [ClientObject(Name = "SP.TimeZoneInformation", Id = "{09e18222-7e4d-488b-811d-6ef43f31d17f}")]
    [JsonObject()]
    public class TimeZoneInformation : ClientValueObject
    {

        public TimeZoneInformation()
        {
        }

        [JsonProperty()]
        public virtual int Bias { get; protected set; }

        [JsonProperty()]
        public virtual int DaylightBias { get; protected set; }

        [JsonProperty()]
        public virtual int StandardBias { get; protected set; }

    }

}

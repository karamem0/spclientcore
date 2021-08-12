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

    [ClientObject(Name = "SP.UserIdInfo", Id = "{c5c3ae1a-63b6-4f25-a887-54b0b20a28e2}")]
    [JsonObject()]
    public class UserIdInfo : ClientValueObject
    {

        public UserIdInfo()
        {
        }

        [JsonProperty()]
        public virtual string NameId { get; protected set; }

        [JsonProperty()]
        public virtual string NameIdIssuer { get; protected set; }

    }

}

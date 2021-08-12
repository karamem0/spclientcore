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

    [ClientObject(Name = "SP.ChangeToken", Id = "{41c5be82-b5bf-4b5a-9712-97111fb87686}")]
    [JsonObject()]
    public class ChangeToken : ClientValueObject
    {

        public ChangeToken()
        {
        }

        [JsonProperty()]
        public virtual string StringValue { get; protected set; }

    }

}

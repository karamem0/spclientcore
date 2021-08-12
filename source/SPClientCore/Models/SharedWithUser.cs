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

    [ClientObject(Name = "SP.SharedWithUser", Id = "{01d693d9-72c2-4531-9fb9-105c88b6706b}")]
    [JsonObject()]
    public class SharedWithUser : ClientValueObject
    {

        public SharedWithUser()
        {
        }

        [JsonProperty()]
        public virtual string Email { get; protected set; }

        [JsonProperty()]
        public virtual string Name { get; protected set; }

    }

}

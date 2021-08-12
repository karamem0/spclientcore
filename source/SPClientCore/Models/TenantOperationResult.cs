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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.SpoOperation", Id = "{7b4f9325-299b-48a7-b390-5c16b4f47cbc}")]
    [JsonObject()]
    public class TenantOperationResult : ClientObject
    {

        public TenantOperationResult()
        {
        }

        [JsonProperty()]
        public virtual bool HasTimedout { get; protected set; }

        [JsonProperty()]
        public virtual bool IsComplete { get; protected set; }

        [JsonProperty()]
        public virtual int PollingInterval { get; protected set; }

    }

}

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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.SPOTenantWebTemplate", Id = "{fd9d5ea3-4b21-481a-9a1d-e27e14db87d0}")]
    [JsonObject()]
    public class TenantSiteTemplate : ClientObject
    {

        [JsonProperty()]
        public virtual int CompatibilityLevel { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual string DisplayCategory { get; protected set; }

        [JsonProperty()]
        public virtual int Id { get; protected set; }

        [JsonProperty()]
        public virtual uint Lcid { get; protected set; }

        [JsonProperty()]
        public virtual string Name { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

    }

}

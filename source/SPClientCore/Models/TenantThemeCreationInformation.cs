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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Models
{

    [JsonObject()]
    public class TenantThemeCreationInformation : ClientValueObject
    {

        public TenantThemeCreationInformation()
        {
        }

        public TenantThemeCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty("isInverted")]
        public virtual bool IsInverted { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; protected set; }

        [JsonProperty("palette")]
        public virtual Hashtable Palette { get; protected set; }

    }

}

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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantManagement.ThemeProperties", Id = "{ce4f6bf8-b123-4cbf-b8be-90a8abb881ee}")]
    [JsonObject()]
    public class TenantTheme : ClientObject
    {

        public TenantTheme()
        {
        }

        [JsonProperty()]
        public virtual bool IsInverted { get; protected set; }

        [JsonProperty()]
        public virtual string Name { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyDictionary<string, string> Palette { get; protected set; }

    }

}

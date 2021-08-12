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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.HubSitePermission", Id = "{deb4ced4-aed3-4ba2-ad63-a785d606dea4}")]
    [JsonObject()]
    public class HubSitePermission : ClientValueObject
    {

        public HubSitePermission()
        {
        }

        [JsonProperty()]
        public virtual string DisplayName { get; protected set; }

        [JsonProperty()]
        public virtual string PrincipalName { get; protected set; }

        [JsonProperty()]
        public virtual HubSiteUserRights Rights { get; protected set; }

    }

}

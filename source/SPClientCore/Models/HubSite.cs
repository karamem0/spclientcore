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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.HubSiteProperties", Id = "{ac013530-0896-414d-af66-ee9171a3b54e}")]
    [JsonObject()]
    public class HubSite : ClientObject
    {

        public HubSite()
        {
        }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual bool EnablePermissionsSync { get; protected set; }

        [JsonProperty()]
        public virtual bool HideNameInNavigation { get; protected set; }

        [JsonProperty("ID")]
        public virtual Guid Id { get; protected set; }

        [JsonProperty()]
        public virtual string LogoUrl { get; protected set; }

        [JsonProperty()]
        public virtual Guid ParentHubSiteId { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<HubSitePermission> Permissions { get; protected set; }

        [JsonProperty()]
        public virtual bool RequiresJoinApproval { get; protected set; }

        [JsonProperty("SiteId")]
        public virtual Guid SiteCollectionId { get; protected set; }

        [JsonProperty("SiteUrl")]
        public virtual string SiteCollectionUrl { get; protected set; }

        [JsonProperty()]
        public virtual Guid SiteDesignId { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

    }

}

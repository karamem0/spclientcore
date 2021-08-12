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

    [ClientObject(Name = "SP.HubSiteCreationInformation", Id = "{3e543825-fbf3-483a-be67-55a70dd9b992}")]
    [JsonObject()]
    public class HubSiteCreationInformation : ClientValueObject
    {

        public HubSiteCreationInformation()
        {
        }

        public HubSiteCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual bool EnablePermissionsSync { get; protected set; }

        [JsonProperty()]
        public virtual bool HideNameInNavigation { get; protected set; }

        [JsonProperty()]
        public virtual string LogoUrl { get; protected set; }

        [JsonProperty()]
        public virtual Guid ParentHubSiteId { get; protected set; }

        [JsonProperty("SiteId")]
        public virtual Guid SiteCollectionId { get; protected set; }

        [JsonProperty("SiteUrl")]
        public virtual string SiteCollectionUrl { get; protected set; }

        [JsonProperty()]
        public virtual string Targets { get; protected set; }

        [JsonProperty()]
        public virtual Guid TenantInstanceId { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

    }

}

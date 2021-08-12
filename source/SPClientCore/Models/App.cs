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

    [JsonObject()]
    public class App : ODataV1Object
    {

        public App()
        {
        }

        [JsonProperty()]
        public virtual Guid AadAppId { get; protected set; }

        [JsonProperty()]
        public virtual string AadPermissions { get; protected set; }

        [JsonProperty()]
        public virtual string AppCatalogVersion { get; protected set; }

        [JsonProperty()]
        public virtual bool CanUpgrade { get; protected set; }

        [JsonProperty()]
        public virtual bool ContainsTenantWideExtension { get; protected set; }

        [JsonProperty("CDNLocation")]
        public virtual string CdnLocation { get; protected set; }

        [JsonProperty()]
        public virtual bool CurrentVersionDeployed { get; protected set; }

        [JsonProperty()]
        public virtual bool Deployed { get; protected set; }

        [JsonProperty()]
        public virtual string ErrorMessage { get; protected set; }

        [JsonProperty("ID")]
        public virtual Guid Id { get; protected set; }

        [JsonProperty()]
        public virtual string InstalledVersion { get; protected set; }

        [JsonProperty()]
        public virtual bool IsEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool IsClientSideSolution { get; protected set; }

        [JsonProperty()]
        public virtual bool IsPackageDefaultSkipFeatureDeployment { get; protected set; }

        [JsonProperty()]
        public virtual bool IsValidAppPackage { get; protected set; }

        [JsonProperty()]
        public virtual Guid ProductId { get; protected set; }

        [JsonProperty()]
        public virtual string ShortDescription { get; protected set; }

        [JsonProperty()]
        public virtual bool SkipDeploymentFeature { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual string ThumbnailUrl { get; protected set; }

    }

}

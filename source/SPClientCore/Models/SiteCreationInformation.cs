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

    [ClientObject(Name = "SP.WebCreationInformation", Id = "{8f9e9fbe-189e-492f-884f-98f9ef9cc4d6}")]
    [JsonObject()]
    public class SiteCreationInformation : ClientValueObject
    {

        public SiteCreationInformation()
        {
        }

        public SiteCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty("Language")]
        public virtual uint Lcid { get; protected set; }

        [JsonProperty("Url")]
        public virtual string ServerRelativeUrl { get; protected set; }

        [JsonProperty("WebTemplate")]
        public virtual string Template { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual bool UseSamePermissionsAsParentSite { get; protected set; }

    }

}

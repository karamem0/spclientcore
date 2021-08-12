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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerableFilter", Id = "{b92aeee2-c92c-4b67-abcc-024e471bc140}")]
    [JsonObject()]
    public class TenantSiteCollectionFilter : ClientValueObject
    {

        public TenantSiteCollectionFilter()
        {
        }

        public TenantSiteCollectionFilter(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty()]
        public virtual string Filter { get; protected set; }

        [JsonProperty()]
        [SwitchParameterValue(TrueValue = 1, FalseValue = 2)]
        public virtual int GroupIdDefined { get; protected set; }

        [JsonProperty()]
        public virtual bool IncludeDetail { get; protected set; }

        [JsonProperty()]
        [SwitchParameterValue(TrueValue = PersonalSiteFilter.Include, FalseValue = PersonalSiteFilter.Exclude)]
        public virtual PersonalSiteFilter IncludePersonalSite { get; protected set; }

        [JsonProperty()]
        public virtual string StartIndex { get; protected set; }

        [JsonProperty()]
        public virtual string Template { get; protected set; }

    }

}

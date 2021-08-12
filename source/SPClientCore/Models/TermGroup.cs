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

    [ClientObject(Name = "SP.Taxonomy.TermGroup", Id = "{65d76872-0b65-42de-8ebd-d76f6d3491c6}")]
    [JsonObject()]
    public class TermGroup : TaxonomyItem
    {

        public TermGroup()
        {
        }

        [JsonProperty("ContributorPrincipalNames")]
        public virtual IReadOnlyList<string> Contributors { get; protected set; }

        [JsonProperty("CreatedDate")]
        public override DateTime Created { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty("GroupManagerPrincipalNames")]
        public virtual IReadOnlyList<string> GroupManagers { get; protected set; }

        [JsonProperty()]
        public override Guid Id { get; protected set; }

        [JsonProperty()]
        public virtual bool IsSiteCollectionGroup { get; protected set; }

        [JsonProperty()]
        public virtual bool IsSystemGroup { get; protected set; }

        [JsonProperty("LastModifiedDate")]
        public override DateTime LastModified { get; protected set; }

        [JsonProperty()]
        public override string Name { get; protected set; }

        [JsonProperty()]
        public override TermStore TermStore { get; protected set; }

    }

}

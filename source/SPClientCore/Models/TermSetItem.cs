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

    [ClientObject(Name = "SP.Taxonomy.TermSetItem", Id = "{a99e4a8f-010b-4e56-9b29-b7bd6ec51263}")]
    [JsonObject()]
    public class TermSetItem : TaxonomyItem
    {

        public TermSetItem()
        {
        }

        [JsonProperty("CreatedDate")]
        public override DateTime Created { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyDictionary<string, string> CustomProperties { get; protected set; }

        [JsonProperty()]
        public virtual string CustomSortOrder { get; protected set; }

        [JsonProperty()]
        public override Guid Id { get; protected set; }

        [JsonProperty()]
        public virtual bool IsAvailableForTagging { get; protected set; }

        [JsonProperty("LastModifiedDate")]
        public override DateTime LastModified { get; protected set; }

        [JsonProperty()]
        public override string Name { get; protected set; }

        [JsonProperty()]
        public virtual string Owner { get; protected set; }

    }

}

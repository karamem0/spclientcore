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

    [ClientObject(Name = "SP.Taxonomy.TermSet", Id = "{e26feb13-2940-4db9-a52b-12b160113a80}")]
    [JsonObject()]
    public class TermSet : TermSetItem
    {

        public TermSet()
        {
        }

        [JsonProperty()]
        public virtual string Contact { get; protected set; }

        [JsonProperty("CreatedDate")]
        public override DateTime Created { get; protected set; }

        [JsonProperty()]
        public override IReadOnlyDictionary<string, string> CustomProperties { get; protected set; }

        [JsonProperty()]
        public override string CustomSortOrder { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public override Guid Id { get; protected set; }

        [JsonProperty()]
        public override bool IsAvailableForTagging { get; protected set; }

        [JsonProperty()]
        public virtual bool IsOpenForTermCreation { get; protected set; }

        [JsonProperty("LastModifiedDate")]
        public override DateTime LastModified { get; protected set; }

        [JsonProperty()]
        public override string Name { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyDictionary<string, string> Names { get; protected set; }

        [JsonProperty()]
        public override string Owner { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyList<string> Stakeholders { get; protected set; }

        [JsonProperty()]
        public override TermStore TermStore { get; protected set; }

    }

}

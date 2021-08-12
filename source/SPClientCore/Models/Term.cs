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

    [ClientObject(Name = "SP.Taxonomy.Term", Id = "{5b8c81b7-7cd2-40dc-8525-5eca12a4eb73}")]
    [JsonObject()]
    public class Term : TermSetItem
    {

        public Term()
        {
        }

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
        public virtual bool IsDeprecated { get; protected set; }

        [JsonProperty()]
        public virtual bool IsKeyword { get; protected set; }

        [JsonProperty()]
        public virtual bool IsPinned { get; protected set; }

        [JsonProperty()]
        public virtual bool IsPinnedRoot { get; protected set; }

        [JsonProperty()]
        public virtual bool IsReused { get; protected set; }

        [JsonProperty()]
        public virtual bool IsRoot { get; protected set; }

        [JsonProperty()]
        public virtual bool IsSourceTerm { get; protected set; }

        [JsonProperty("LastModifiedDate")]
        public override DateTime LastModified { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyDictionary<string, string> LocalCustomProperties { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyList<Guid> MergedTermIds { get; protected set; }

        [JsonProperty()]
        public override string Name { get; protected set; }

        [JsonProperty()]
        public virtual string PathOfTerm { get; protected set; }

        [JsonProperty()]
        public override string Owner { get; protected set; }

        [JsonProperty()]
        public virtual int TermsCount { get; protected set; }

        [JsonProperty()]
        public override TermStore TermStore { get; protected set; }

    }

}

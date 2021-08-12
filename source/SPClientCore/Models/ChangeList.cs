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

    [ClientObject(Name = "SP.ChangeList", Id = "{d3ef3368-ff71-4de1-867c-19693c781587}")]
    [JsonObject()]
    public class ChangeList : Change
    {

        public ChangeList()
        {
        }

        [JsonProperty()]
        public virtual ListTemplateType BaseTemplate { get; protected set; }

        [JsonProperty()]
        public override ChangeToken ChangeToken { get; protected set; }

        [JsonProperty()]
        public override ChangeType ChangeType { get; protected set; }

        [JsonProperty()]
        public virtual User Creator { get; protected set; }

        [JsonProperty()]
        public virtual string Editor { get; protected set; }

        [JsonProperty()]
        public virtual bool Hidden { get; protected set; }

        [JsonProperty()]
        public virtual Guid ListId { get; protected set; }

        [JsonProperty()]
        public override string RelativeTime { get; protected set; }

        [JsonProperty()]
        public virtual string RootFolderUrl { get; protected set; }

        [JsonProperty("SiteId")]
        public override Guid SiteCollectionId { get; protected set; }

        [JsonProperty("WebId")]
        public virtual Guid SiteId { get; protected set; }

        [JsonProperty()]
        public override DateTime Time { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

    }

}

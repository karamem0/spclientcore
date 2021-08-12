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

    [ClientObject(Name = "SP.ChangeFile", Id = "{59dd36eb-9235-4dad-a8fd-26d3c11a6a18}")]
    [JsonObject()]
    public class ChangeFile : Change
    {

        public ChangeFile()
        {
        }

        [JsonProperty()]
        public override ChangeToken ChangeToken { get; protected set; }

        [JsonProperty()]
        public override ChangeType ChangeType { get; protected set; }

        [JsonProperty()]
        public override string RelativeTime { get; protected set; }

        [JsonProperty("SiteId")]
        public override Guid SiteCollectionId { get; protected set; }

        [JsonProperty("WebId")]
        public virtual Guid SiteId { get; protected set; }

        [JsonProperty()]
        public override DateTime Time { get; protected set; }

        [JsonProperty()]
        public virtual Guid UniqueId { get; protected set; }

    }

}

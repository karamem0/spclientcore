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

    [ClientObject(Name = "SP.Change", Id = "{c717121b-f82f-4afb-a2b7-25f67522120f}")]
    [JsonObject()]
    public class Change : ClientObject
    {

        public Change()
        {
        }

        [JsonProperty()]
        public virtual ChangeToken ChangeToken { get; protected set; }

        [JsonProperty()]
        public virtual ChangeType ChangeType { get; protected set; }

        [JsonProperty()]
        public virtual string RelativeTime { get; protected set; }

        [JsonProperty("SiteId")]
        public virtual Guid SiteCollectionId { get; protected set; }

        [JsonProperty()]
        public virtual DateTime Time { get; protected set; }

    }

}

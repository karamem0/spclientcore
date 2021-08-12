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

    [ClientObject(Name = "SP.ListItem", Id = "{53cc48c0-1777-47b7-99ca-729390f06602}")]
    [JsonObject()]
    public class ListItem : SecurableObject
    {

        public ListItem()
        {
        }

        [JsonProperty()]
        public virtual ColumnUserValue Author { get; protected set; }

        [JsonProperty()]
        public virtual DateTime Created { get; protected set; }

        [JsonProperty()]
        public virtual ColumnUserValue Editor { get; protected set; }

        [JsonProperty()]
        public virtual FileSystemObjectType FileSystemObjectType { get; protected set; }

        [JsonProperty()]
        public override bool HasUniqueRoleAssignments { get; protected set; }

        [JsonProperty()]
        public virtual int Id { get; protected set; }

        [JsonProperty()]
        public virtual DateTime Modified { get; protected set; }

        [JsonProperty()]
        public virtual string ServerRedirectedEmbedUrl { get; protected set; }

        [JsonProperty("DisplayName")]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual Guid UniqueId { get; protected set; }

    }

}

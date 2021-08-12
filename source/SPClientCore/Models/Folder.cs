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

    [ClientObject(Name = "SP.Folder", Id = "{dbe8175a-505d-4eff-bec4-6c809709808b}")]
    [JsonObject()]
    public class Folder : ClientObject
    {

        public Folder()
        {
        }

        [JsonProperty()]
        public virtual IReadOnlyCollection<ContentTypeId> ContentTypeOrder { get; protected set; }

        [JsonProperty("TimeCreated")]
        public virtual DateTime Created { get; protected set; }

        [JsonProperty()]
        public virtual bool Exists { get; protected set; }

        [JsonProperty()]
        public virtual bool IsWOPIEnabled { get; protected set; }

        [JsonProperty()]
        public virtual int ItemCount { get; protected set; }

        [JsonProperty("TimeLastModified")]
        public virtual DateTime LastModified { get; protected set; }

        [JsonProperty()]
        public virtual string Name { get; protected set; }

        [JsonProperty("ProgID")]
        public virtual string ProgId { get; protected set; }

        [JsonProperty()]
        public virtual string ServerRelativeUrl { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<ContentTypeId> UniqueContentTypeOrder { get; protected set; }

        [JsonProperty()]
        public virtual Guid UniqueId { get; protected set; }

        [JsonProperty()]
        public virtual string WelcomePage { get; protected set; }

    }

}

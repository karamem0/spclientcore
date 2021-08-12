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

    [ClientObject(Name = "SP.ChangeItem", Id = "{3e4716ac-a622-4d48-bc14-3fecabd52e21}")]
    [JsonObject()]
    public class ChangeItem : Change
    {

        public ChangeItem()
        {
        }

        [JsonProperty()]
        public override ChangeToken ChangeToken { get; protected set; }

        [JsonProperty()]
        public override ChangeType ChangeType { get; protected set; }

        [JsonProperty()]
        public virtual string Editor { get; protected set; }

        [JsonProperty()]
        public virtual string EditorEmailHint { get; protected set; }

        [JsonProperty()]
        public virtual string EditorLoginName { get; protected set; }

        [JsonProperty()]
        public virtual FileSystemObjectType FileSystemObjectType { get; protected set; }

        [JsonProperty()]
        public virtual string FileType { get; protected set; }

        [JsonProperty()]
        public virtual string HashTag { get; protected set; }

        [JsonProperty()]
        public virtual bool Hidden { get; protected set; }

        [JsonProperty()]
        public virtual int ItemId { get; protected set; }

        [JsonProperty()]
        public virtual Guid ListId { get; protected set; }

        [JsonProperty()]
        public virtual ListTemplateType ListTemplate { get; protected set; }

        [JsonProperty()]
        public virtual string ListTitle { get; protected set; }

        [JsonProperty()]
        public override string RelativeTime { get; protected set; }

        [JsonProperty()]
        public virtual string ServerRelativeUrl { get; protected set; }

        [JsonProperty("SharedByUser")]
        public virtual SharedWithUser SharedWithUser { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<SharedWithUser> SharedWithUsers { get; protected set; }

        [JsonProperty("SiteId")]
        public override Guid SiteCollectionId { get; protected set; }

        [JsonProperty("WebId")]
        public virtual Guid SiteId { get; protected set; }

        [JsonProperty()]
        public override DateTime Time { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual Guid UniqueId { get; protected set; }

    }

}

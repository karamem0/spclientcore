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

    [ClientObject(Name = "SP.File", Id = "{df28be1e-74b5-4b21-b73a-2bbac0a23d8a}")]
    [JsonObject()]
    public class File : ClientObject
    {

        public File()
        {
        }

        [JsonProperty()]
        public virtual User Author { get; protected set; }

        [JsonProperty()]
        public virtual string CheckInComment { get; protected set; }

        [JsonProperty()]
        public virtual CheckOutType CheckOutType { get; protected set; }

        [JsonProperty("CheckedOutByUser")]
        public virtual User CheckOutUser { get; protected set; }

        [JsonProperty()]
        public virtual string ContentTag { get; protected set; }

        [JsonProperty("TimeCreated")]
        public virtual DateTime Created { get; protected set; }

        [JsonProperty()]
        public virtual int CustomizedPageStatus { get; protected set; }

        [JsonProperty("ModifiedBy")]
        public virtual User Editor { get; protected set; }

        [JsonProperty()]
        public virtual string ETag { get; protected set; }

        [JsonProperty()]
        public virtual bool Exists { get; protected set; }

        [JsonProperty()]
        public virtual bool IrmEnabled { get; protected set; }

        [JsonProperty("TimeLastModified")]
        public virtual DateTime LastModified { get; protected set; }

        [JsonProperty()]
        public virtual long Length { get; protected set; }

        [JsonProperty()]
        public virtual byte Level { get; protected set; }

        [JsonProperty()]
        public virtual string LinkingUri { get; protected set; }

        [JsonProperty()]
        public virtual string LinkingUrl { get; protected set; }

        [JsonProperty("LockedByUser")]
        public virtual User LockUser { get; protected set; }

        [JsonProperty()]
        public virtual int MajorVersion { get; protected set; }

        [JsonProperty()]
        public virtual int MinorVersion { get; protected set; }

        [JsonProperty()]
        public virtual string Name { get; protected set; }

        [JsonProperty()]
        public virtual string ServerRelativeUrl { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual int UIVersion { get; protected set; }

        [JsonProperty()]
        public virtual string UIVersionLabel { get; protected set; }

        [JsonProperty()]
        public virtual Guid UniqueId { get; protected set; }

    }

}

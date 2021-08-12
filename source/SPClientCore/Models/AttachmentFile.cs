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

    [ClientObject(Name = "SP.Attachment", Id = "{abd102de-1731-4be2-ae7e-3515371cc5c7}")]
    [JsonObject()]
    public class AttachmentFile : ClientObject
    {

        public AttachmentFile()
        {
        }

        [JsonProperty()]
        public virtual string FileName { get; protected set; }

        [JsonProperty()]
        public virtual ResourcePath FileNameAsPath { get; protected set; }

        [JsonProperty()]
        public virtual ResourcePath ServerRelativePath { get; protected set; }

        [JsonProperty()]
        public virtual string ServerRelativeUrl { get; protected set; }

    }

}

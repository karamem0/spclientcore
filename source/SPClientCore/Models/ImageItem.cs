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

    [JsonObject()]
    public class ImageItem : ODataV1Object
    {

        public ImageItem()
        {
        }

        [JsonProperty("Name")]
        public virtual string Name { get; protected set; }

        [JsonProperty("ServerRelativeUrl")]
        public virtual string ServerRelativeUrl { get; protected set; }

        [JsonProperty("UniqueId")]
        public virtual Guid UniqueId { get; protected set; }

    }

}

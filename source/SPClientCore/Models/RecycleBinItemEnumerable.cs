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

    [ClientObject(Name = "SP.RecycleBinItemCollection", Id = "{9bfb60cf-1aca-484c-a845-5f2d4ef20865}")]
    [JsonObject()]
    public class RecycleBinItemEnumerable : ClientObjectEnumerable<RecycleBinItem>
    {

        public RecycleBinItemEnumerable()
        {
        }

        [JsonProperty()]
        public virtual ListItemCollectionPosition ListItemCollectionPosition { get; protected set; }

    }

}

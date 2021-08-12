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

    [ClientObject(Name = "SP.ListItemCollection", Id = "{1722df25-a4d3-44bb-a1c6-04dbb90e9d91}")]
    [JsonObject()]
    public class ListItemEnumerable : ClientObjectEnumerable<ListItem>
    {

        public ListItemEnumerable()
        {
        }

        [JsonProperty()]
        public virtual ListItemCollectionPosition ListItemCollectionPosition { get; protected set; }

    }

}

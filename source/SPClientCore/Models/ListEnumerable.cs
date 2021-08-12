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

    [ClientObject(Name = "SP.ListCollection", Id = "{1e78b736-61f0-441c-a785-10fc25387c8d}")]
    [JsonObject()]
    public class ListEnumerable : ClientObjectEnumerable<List>
    {

        public ListEnumerable()
        {
        }

    }

}

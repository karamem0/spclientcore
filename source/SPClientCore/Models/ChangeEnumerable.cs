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

    [ClientObject(Name = "SP.ChangeCollection", Id = "{2ba7a459-eeda-42d0-90e2-fad3487ad0d3}")]
    [JsonObject()]
    public class ChangeEnumerable : ClientObjectEnumerable<Change>
    {

        public ChangeEnumerable()
        {
        }

    }

}

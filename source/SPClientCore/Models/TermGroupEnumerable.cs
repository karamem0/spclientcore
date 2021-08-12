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

    [ClientObject(Name = "SP.Taxonomy.TermGroupCollection", Id = "{fef2acdd-8fb1-40b9-a8b0-ccd9512a9105}")]
    [JsonObject()]
    public class TermGroupEnumerable : ClientObjectEnumerable<TermGroup>
    {

        public TermGroupEnumerable()
        {
        }

    }

}

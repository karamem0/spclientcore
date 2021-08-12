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

    [ClientObject(Name = "SP.GroupCollection", Id = "{0b9f0e6c-2c15-425e-b0b2-961f78bf1ecf}")]
    [JsonObject()]
    public class GroupEnumerable : ClientObjectEnumerable<Group>
    {

        public GroupEnumerable()
        {
        }

    }

}

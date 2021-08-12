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

    [ClientObject(Name = "SP.RoleAssignmentCollection", Id = "{2690207a-e174-4d49-b2ca-cff663225dc1}")]
    [JsonObject()]
    public class RoleAssignmentEnumerable : ClientObjectEnumerable<RoleAssignment>
    {

        public RoleAssignmentEnumerable()
        {
        }

    }

}

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

    [ClientObject(Name = "SP.RoleDefinitionCollection", Id = "{964b9ab0-d026-4487-99d1-e06450963cc9}")]
    [JsonObject()]
    public class RoleDefinitionEnumerable : ClientObjectEnumerable<RoleDefinition>
    {

        public RoleDefinitionEnumerable()
        {
        }

    }

}

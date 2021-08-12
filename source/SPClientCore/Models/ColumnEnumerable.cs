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

    [ClientObject(Name = "SP.FieldCollection", Id = "{d449d756-e113-4d27-a5e7-609cbc3eba7e}")]
    [JsonObject()]
    public class ColumnEnumerable : ClientObjectEnumerable<Column>
    {

        public ColumnEnumerable()
        {
        }

    }

}

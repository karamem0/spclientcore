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

    [ClientObject(Name = "SP.DocumentSet.SharedFieldCollection", Id = "{1554af8c-7213-418c-a4a8-b06e7603c68a}")]
    [JsonObject()]
    public class SharedColumnEnumerable : ClientObjectEnumerable<Column>
    {

        public SharedColumnEnumerable()
        {
        }

    }

}

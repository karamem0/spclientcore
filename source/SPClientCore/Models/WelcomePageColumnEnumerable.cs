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

    [ClientObject(Name = "SP.DocumentSet.WelcomePageFieldCollection", Id = "{d9662ecf-16a1-4530-84ea-029e69ff60aa}")]
    [JsonObject()]
    public class WelcomePageColumnEnumerable : ClientObjectEnumerable<Column>
    {

        public WelcomePageColumnEnumerable()
        {
        }

    }

}

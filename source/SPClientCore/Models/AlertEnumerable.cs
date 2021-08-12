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

    [ClientObject(Name = "SP.AlertCollection", Id = "{86531f9b-b741-453d-96fc-5f05f038000a}")]
    [JsonObject()]
    public class AlertEnumerable : ClientObjectEnumerable<Alert>
    {

        public AlertEnumerable()
        {
        }

    }

}

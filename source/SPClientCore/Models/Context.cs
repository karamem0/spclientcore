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

    [ClientObject(Name = "SP.RequestContext", Id = "{3747adcd-a3c3-41b9-bfab-4a64dd2f1e0a}")]
    [JsonObject()]
    public class Context : ClientObject
    {

        public Context()
        {
        }

    }

}

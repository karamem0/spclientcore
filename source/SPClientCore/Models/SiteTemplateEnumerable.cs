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

    [ClientObject(Name = "SP.WebTemplateCollection", Id = "{15c2ecda-d49e-4fda-97c8-c538a203dfb5}")]
    [JsonObject()]
    public class SiteTemplateEnumerable : ClientObjectEnumerable<SiteTemplate>
    {

        public SiteTemplateEnumerable()
        {
        }

    }

}

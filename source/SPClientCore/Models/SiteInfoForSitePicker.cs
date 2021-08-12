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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.SiteInfoForSitePicker", Id = "{40b06fa6-9d25-4345-af79-ed71fd7462f1}")]
    [JsonObject()]
    public class SiteInfoForSitePicker : ClientObject
    {

        public SiteInfoForSitePicker()
        {
        }

    }

}

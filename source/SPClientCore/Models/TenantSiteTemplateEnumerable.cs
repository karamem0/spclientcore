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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.SPOTenantWebTemplateCollection", Id = "{ee98fc5c-6361-4e53-bd91-3368079cdefb}")]
    [JsonObject()]
    public class TenantSiteTemplateEnumerable : ClientObjectEnumerable<TenantSiteTemplate>
    {

        public TenantSiteTemplateEnumerable()
        {
        }

    }

}

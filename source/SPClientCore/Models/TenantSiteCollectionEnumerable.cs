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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable", Id = "{2738ec84-50c0-4f51-80f2-2a123f63d0b3}")]
    [JsonObject()]
    public class TenantSiteCollectionEnumerable : ClientObjectEnumerable<TenantSiteCollection>
    {

        public TenantSiteCollectionEnumerable()
        {
        }

    }

}

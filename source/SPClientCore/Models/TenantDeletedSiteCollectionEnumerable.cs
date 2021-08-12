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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable", Id = "{15e69cc5-cabb-4052-b165-cb223e924c84}")]
    [JsonObject()]
    public class TenantDeletedSiteCollectionsEnumerable : ClientObjectEnumerable<TenantDeletedSiteCollection>
    {

        public TenantDeletedSiteCollectionsEnumerable()
        {
        }

    }

}

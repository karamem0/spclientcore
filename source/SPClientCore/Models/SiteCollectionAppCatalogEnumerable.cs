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

    [ClientObject(Name = "Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.SiteCollectionAppCatalogAllowedCollection", Id = "{e6a14f02-4a7b-4bd2-b869-23a0a63283db}")]
    [JsonObject()]
    public class SiteCollectionAppCatalogEnumerable : ClientObjectEnumerable<SiteCollectionAppCatalog>
    {

        public SiteCollectionAppCatalogEnumerable()
        {
        }

    }

}

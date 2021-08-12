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

    [ClientObject(Name = "SP.DocumentSet.AllowedContentTypeCollection", Id = "{60664bb3-3d6d-49c5-9573-1d524ee82e34}")]
    [JsonObject()]
    public class AllowedContentTypeEnumerable : ClientObjectEnumerable<ContentTypeId>
    {

        public AllowedContentTypeEnumerable()
        {
        }

    }

}

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

    [ClientObject(Name = "SP.DocumentSet.DefaultDocumentCollection", Id = "{36d215c9-7f02-426f-9689-e08bea511d74}")]
    [JsonObject()]
    public class DefaultDocumentEnumerable : ClientObjectEnumerable<DefaultDocument>
    {

        public DefaultDocumentEnumerable()
        {
        }

    }

}

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

    [ClientObject(Name = "SP.FieldLinkCollection", Id = "{6d87e76a-b8a8-4634-8170-082b1d454bfd}")]
    [JsonObject()]
    public class ContentTypeColumnEnumerable : ClientObjectEnumerable<ContentTypeColumn>
    {

        public ContentTypeColumnEnumerable()
        {
        }

    }

}

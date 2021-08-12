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

    [ClientObject(Name = "SP.ViewFieldCollection", Id = "{af975f76-8a94-4e6d-8325-bd1e20b7c301}")]
    [JsonObject()]
    public class ViewColumnEnumerable : ClientObjectEnumerable<string>
    {

        public ViewColumnEnumerable()
        {
        }

        [JsonProperty()]
        public virtual string SchemaXml { get; protected set; }

    }

}

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

    [ClientObject(Name = "SP.Feature", Id = "{4e46b28c-e27f-4964-a8d4-fc25658d86d1}")]
    [JsonObject()]
    public class Feature : ClientObject
    {

        public Feature()
        {
        }

        [JsonProperty()]
        public virtual Guid DefinitionId { get; protected set; }

        [JsonProperty()]
        public virtual string DisplayName { get; protected set; }

    }

}

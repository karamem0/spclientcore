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

    [ClientObject(Name = "SP.RoleDefinition", Id = "{aa7ecb4a-9c7e-4ad9-bd20-58a2775e5ad7}")]
    [JsonObject()]
    public class RoleDefinition : ClientObject
    {

        public RoleDefinition()
        {
        }

        [JsonProperty("BasePermissions")]
        public virtual BasePermission BasePermission { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual bool Hidden { get; protected set; }

        [JsonProperty()]
        public virtual int Id { get; protected set; }

        [JsonProperty()]
        public virtual string Name { get; protected set; }

        [JsonProperty()]
        public virtual int Order { get; protected set; }

        [JsonProperty()]
        public virtual RoleType RoleTypeKind { get; protected set; }

    }

}

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

    [ClientObject(Name = "SP.RoleDefinitionCreationInformation", Id = "{59eddf82-1018-4677-8067-69e16efd3495}")]
    [JsonObject()]
    public class RoleDefinitionCreationInformation : ClientValueObject
    {

        public RoleDefinitionCreationInformation()
        {
        }

        public RoleDefinitionCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty("BasePermissions")]
        public virtual BasePermission BasePermission { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual string Name { get; protected set; }

        [JsonProperty()]
        public virtual int Order { get; protected set; }

    }

}

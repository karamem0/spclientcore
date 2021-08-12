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

    [ClientObject(Name = "SP.UserCreationInformation", Id = "{6ecd8af6-bed3-4a74-be76-1ec981b350e1}")]
    [JsonObject()]
    public class UserCreationInformation : ClientValueObject
    {

        public UserCreationInformation()
        {
        }

        public UserCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty()]
        public virtual string Email { get; protected set; }

        [JsonProperty()]
        public virtual string LoginName { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

    }

}

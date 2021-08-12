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

    [JsonObject()]
    public class SharingPrincipal : ODataV1Object
    {

        public SharingPrincipal()
        {
        }

        [JsonProperty("email")]
        public virtual string Email { get; protected set; }

        [JsonProperty("expiration")]
        public virtual string Expiration { get; protected set; }

        [JsonProperty("id")]
        public virtual int Id { get; protected set; }

        [JsonProperty("isActive")]
        public virtual bool IsActive { get; protected set; }

        [JsonProperty("isExternal")]
        public virtual bool IsExternal { get; protected set; }

        [JsonProperty("jobTitle")]
        public virtual string JobTitle { get; protected set; }

        [JsonProperty("loginName")]
        public virtual string LoginName { get; protected set; }

        [JsonProperty("name")]
        public virtual string Name { get; protected set; }

        [JsonProperty("principalType")]
        public virtual PrincipalType PrincipalType { get; protected set; }

        [JsonProperty("userId")]
        public virtual string UserId { get; protected set; }

        [JsonProperty("userPrincipalName")]
        public virtual string UserPrincipalName { get; protected set; }

    }

}

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

    [ClientObject(Name = "SP.Group", Id = "{e54ad5f1-ce4e-453b-b7f7-aea6556c9c40}")]
    [JsonObject()]
    public class Group : Principal
    {

        public Group()
        {
        }

        [JsonProperty()]
        public virtual bool AllowMembersEditMembership { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowRequestToJoinLeave { get; protected set; }

        [JsonProperty()]
        public virtual bool AutoAcceptRequestToJoinLeave { get; protected set; }

        [JsonProperty()]
        public virtual bool CanCurrentUserEditMembership { get; protected set; }

        [JsonProperty()]
        public virtual bool CanCurrentUserManageGroup { get; protected set; }

        [JsonProperty()]
        public virtual bool CanCurrentUserViewMembership { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public override int Id { get; protected set; }

        [JsonProperty()]
        public virtual bool IsHiddenInUI { get; protected set; }

        [JsonProperty()]
        public override string LoginName { get; protected set; }

        [JsonProperty()]
        public virtual string OwnerTitle { get; protected set; }

        [JsonProperty()]
        public virtual bool OnlyAllowMembersViewMembership { get; protected set; }

        [JsonProperty()]
        public override PrincipalType PrincipalType { get; protected set; }

        [JsonProperty()]
        public virtual string RequestToJoinLeaveEmailSetting { get; protected set; }

        [JsonProperty()]
        public override string Title { get; protected set; }

    }

}

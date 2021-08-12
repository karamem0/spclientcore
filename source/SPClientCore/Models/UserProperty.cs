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

    [ClientObject(Name = "SP.UserProfiles.PersonProperties", Id = "{9a467bf8-bbfb-4a76-9c41-0753ecf7218f}")]
    [JsonObject()]
    public class UserProperty : ClientObject
    {

        public UserProperty()
        {
        }

        [JsonProperty()]
        public virtual IReadOnlyCollection<string> DirectReports { get; protected set; }

        [JsonProperty()]
        public virtual string DisplayName { get; protected set; }

        [JsonProperty()]
        public virtual string Email { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<string> ExtendedManagers { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<string> ExtendedReports { get; protected set; }

        [JsonProperty()]
        public virtual bool IsFollowed { get; protected set; }

        [JsonProperty()]
        public virtual string LatestPost { get; protected set; }

        [JsonProperty("AccountName")]
        public virtual string LoginName { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<string> Peers { get; protected set; }

        [JsonProperty()]
        public virtual string PersonalSiteHostUrl { get; protected set; }

        [JsonProperty()]
        public virtual string PersonalUrl { get; protected set; }

        [JsonProperty()]
        public virtual string PictureUrl { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyDictionary<string, string> UserProfileProperties { get; protected set; }

        [JsonProperty()]
        public virtual string UserUrl { get; protected set; }

    }

}

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

    [ClientObject(Name = "SP.CustomActionElement", Id = "{7295eb25-e721-42b6-aac9-cbb6c39afc54}")]
    [JsonObject()]
    public class CustomActionElement : ClientObject
    {

        public CustomActionElement()
        {
        }

        [JsonProperty()]
        public virtual Guid ClientSideComponentId { get; protected set; }

        [JsonProperty()]
        public virtual string ClientSideComponentProperties { get; protected set; }

        [JsonProperty()]
        public virtual string CommandUIExtension { get; protected set; }

        [JsonProperty()]
        public virtual string Id { get; protected set; }

        [JsonProperty()]
        public virtual string EnabledScript { get; protected set; }

        [JsonProperty()]
        public virtual string ImageUrl { get; protected set; }

        [JsonProperty()]
        public virtual string Location { get; protected set; }

        [JsonProperty()]
        public virtual string RegistrationId { get; protected set; }

        [JsonProperty()]
        public virtual int RegistrationType { get; protected set; }

        [JsonProperty()]
        public virtual bool RequireSiteAdministrator { get; protected set; }

        [JsonProperty()]
        public virtual BasePermission Rights { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual string UrlAction { get; protected set; }

    }

}

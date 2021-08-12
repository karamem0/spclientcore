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

    [ClientObject(Name = "SP.ListTemplate", Id = "{d772ecd1-daa3-4cb1-9ea1-feea1e383fb2}")]
    [JsonObject()]
    public class ListTemplate : ClientObject
    {

        public ListTemplate()
        {
        }

        [JsonProperty()]
        public virtual bool AllowsFolderCreation { get; protected set; }

        [JsonProperty()]
        public virtual BaseType BaseType { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual Guid FeatureId { get; protected set; }

        [JsonProperty()]
        public virtual bool Hidden { get; protected set; }

        [JsonProperty()]
        public virtual string ImageUrl { get; protected set; }

        [JsonProperty("InternalName")]
        public virtual string Name { get; protected set; }

        [JsonProperty()]
        public virtual bool IsCustomTemplate { get; protected set; }

        [JsonProperty()]
        public virtual int ListTemplateTypeKind { get; protected set; }

        [JsonProperty("Name")]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual bool OnQuickLaunch { get; protected set; }

        [JsonProperty()]
        public virtual bool Unique { get; protected set; }

    }

}

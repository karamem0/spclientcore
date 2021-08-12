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

    [ClientObject(Name = "SP.ContentType", Id = "{91b5bd2d-e133-486f-b727-197ce5eb2c0d}")]
    [JsonObject()]
    public class ContentType : ClientObject
    {

        public ContentType()
        {
        }

        [JsonProperty()]
        public virtual string ClientFormCustomFormatter { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual string DisplayFormTemplateName { get; protected set; }

        [JsonProperty()]
        public virtual string DisplayFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual string DocumentTemplate { get; protected set; }

        [JsonProperty()]
        public virtual string DocumentTemplateUrl { get; protected set; }

        [JsonProperty()]
        public virtual string EditFormTemplateName { get; protected set; }

        [JsonProperty()]
        public virtual string EditFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual string Group { get; protected set; }

        [JsonProperty()]
        public virtual bool Hidden { get; protected set; }

        [JsonProperty()]
        public virtual ContentTypeId Id { get; protected set; }

        [JsonProperty()]
        public virtual string JSLink { get; protected set; }

        [JsonProperty()]
        public virtual string MobileDisplayFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual string MobileEditFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual string MobileNewFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual string Name { get; protected set; }

        [JsonProperty()]
        public virtual string NewFormTemplateName { get; protected set; }

        [JsonProperty()]
        public virtual string NewFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool ReadOnly { get; protected set; }

        [JsonProperty()]
        public virtual string SchemaXml { get; protected set; }

        [JsonProperty()]
        public virtual string SchemaXmlWithResourceTokens { get; protected set; }

        [JsonProperty()]
        public virtual string Scope { get; protected set; }

        [JsonProperty()]
        public virtual bool Sealed { get; protected set; }

        [JsonProperty()]
        public virtual string StringId { get; protected set; }

    }

}

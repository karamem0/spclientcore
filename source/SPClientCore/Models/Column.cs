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

    [ClientObject(Name = "SP.Field", Id = "{c4121b04-0f57-4b1d-a145-d25426b16480}")]
    [JsonObject()]
    public class Column : ClientObject
    {

        public Column()
        {
        }

        [JsonProperty()]
        public virtual bool AutoIndexed { get; protected set; }

        [JsonProperty()]
        public virtual bool CanBeDeleted { get; protected set; }

        [JsonProperty()]
        public virtual string ClientSideComponentId { get; protected set; }

        [JsonProperty()]
        public virtual string ClientSideComponentProperties { get; protected set; }

        [JsonProperty()]
        public virtual string ClientValidationFormula { get; protected set; }

        [JsonProperty()]
        public virtual string ClientValidationMessage { get; protected set; }

        [JsonProperty("FieldTypeKind")]
        public virtual ColumnType ColumnType { get; protected set; }

        [JsonProperty()]
        public virtual string CustomFormatter { get; protected set; }

        [JsonProperty()]
        public virtual string DefaultFormula { get; protected set; }

        [JsonProperty()]
        public virtual string DefaultValue { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual string Direction { get; protected set; }

        [JsonProperty()]
        public virtual bool EnforceUniqueValues { get; protected set; }

        [JsonProperty()]
        public virtual string EntityPropertyName { get; protected set; }

        [JsonProperty()]
        public virtual bool Filterable { get; protected set; }

        [JsonProperty()]
        public virtual bool FromBaseType { get; protected set; }

        [JsonProperty()]
        public virtual string Group { get; protected set; }

        [JsonProperty()]
        public virtual bool Hidden { get; protected set; }

        [JsonProperty()]
        public virtual Guid Id { get; protected set; }

        [JsonProperty()]
        public virtual bool Indexed { get; protected set; }

        [JsonProperty()]
        public virtual IndexStatus IndexStatus { get; protected set; }

        [JsonProperty()]
        public virtual bool IsModern { get; protected set; }

        [JsonProperty()]
        public virtual string JSLink { get; protected set; }

        [JsonProperty("InternalName")]
        public virtual string Name { get; protected set; }

        [JsonProperty()]
        public virtual bool NoCrawl { get; protected set; }

        [JsonProperty()]
        public virtual bool PinnedToFiltersPane { get; protected set; }

        [JsonProperty("ReadOnlyField")]
        public virtual bool ReadOnly { get; protected set; }

        [JsonProperty()]
        public virtual bool Required { get; protected set; }

        [JsonProperty()]
        public virtual string SchemaXml { get; protected set; }

        [JsonProperty()]
        public virtual string SchemaXmlWithResourceTokens { get; protected set; }

        [JsonProperty()]
        public virtual string Scope { get; protected set; }

        [JsonProperty()]
        public virtual bool Sealed { get; protected set; }

        [JsonProperty()]
        public virtual bool ShowInFiltersPane { get; protected set; }

        [JsonProperty()]
        public virtual bool Sortable { get; protected set; }

        [JsonProperty()]
        public virtual string StaticName { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual string TypeAsString { get; protected set; }

        [JsonProperty()]
        public virtual string TypeDisplayName { get; protected set; }

        [JsonProperty()]
        public virtual string TypeShortDescription { get; protected set; }

        [JsonProperty()]
        public virtual string ValidationFormula { get; protected set; }

        [JsonProperty()]
        public virtual string ValidationMessage { get; protected set; }

    }

}

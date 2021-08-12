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

    [ClientObject(Name = "SP.NavigationNodeCreationInformation", Id = "{7aaaa605-79a9-4fda-ae1e-db952e5083e0}")]
    [JsonObject()]
    public class NavigationNodeCreationInformation : ClientValueObject
    {

        public NavigationNodeCreationInformation()
        {
        }

        public NavigationNodeCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty()]
        public virtual bool AsLastNode { get; protected set; }

        [JsonProperty()]
        public virtual bool IsExternal { get; protected set; }

        [JsonProperty()]
        public virtual NavigationNode PreviousNode { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual string Url { get; protected set; }

    }

}

//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [JsonObject()]
    public abstract class ODataObject
    {

        protected ODataObject()
        {
            this.ExtensionProperties = new Dictionary<string, JToken>();
        }

        [JsonIgnore()]
        public object this[string key] => this.ExtensionProperties[key];

        [JsonIgnore()]
        public IEnumerable<string> ExtensionKeys => this.ExtensionProperties.Select(item => item.Key);

        [JsonExtensionData()]
        protected Dictionary<string, JToken> ExtensionProperties { get; private set; }

    }

}

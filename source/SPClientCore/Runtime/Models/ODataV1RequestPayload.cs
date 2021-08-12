//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [JsonObject()]
    public class ODataV1RequestPayload<T> where T : ODataV1Object
    {

        public ODataV1RequestPayload(IReadOnlyDictionary<string, object> parameters)
        {
            this.Entity = Activator.CreateInstance<T>();
            foreach (var property in this.Entity.GetType().GetDeclaringProperties())
            {
                if (parameters.TryGetValue(property.Name, out var value))
                {
                    property.SetValue(this.Entity, value);
                }
            }
        }

        [JsonProperty("parameters")]
        public T Entity { get; private set; }

    }

}

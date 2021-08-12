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

    [ClientObject(Name = "SP.FieldLookupValue", Id = "{f1d34cc0-9b50-4a78-be78-d5facfcccfb7}")]
    [JsonObject()]
    public class ColumnLookupValue : ClientValueObject
    {

        public ColumnLookupValue()
        {
        }

        public ColumnLookupValue(int lookupId, string lookupValue)
        {
            this.LookupId = lookupId;
            this.LookupValue = lookupValue;
        }

        [JsonProperty()]
        public virtual int LookupId { get; protected set; }

        [JsonProperty()]
        public virtual string LookupValue { get; protected set; }

    }

}

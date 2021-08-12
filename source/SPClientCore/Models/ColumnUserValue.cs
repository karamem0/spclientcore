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

    [ClientObject(Name = "SP.FieldUserValue", Id = "{c956ab54-16bd-4c18-89d2-996f57282a6f}")]
    [JsonObject()]
    public class ColumnUserValue : ClientValueObject
    {

        public ColumnUserValue()
        {
        }

        public ColumnUserValue(int lookupId, string lookupValue, string email)
        {
            this.LookupId = lookupId;
            this.LookupValue = lookupValue;
            this.Email = email;
        }

        [JsonProperty()]
        public virtual string Email { get; protected set; }

        [JsonProperty()]
        public virtual int LookupId { get; protected set; }

        [JsonProperty()]
        public virtual string LookupValue { get; protected set; }

    }

}

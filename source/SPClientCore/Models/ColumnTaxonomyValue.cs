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

    [ClientObject(Name = "SP.Taxonomy.TaxonomyFieldValue", Id = "{19e70ed0-4177-456b-8156-015e4d163ff8}")]
    [JsonObject()]
    public class ColumnTaxonomyValue : ClientValueObject
    {

        public ColumnTaxonomyValue()
        {
        }

        public ColumnTaxonomyValue(string label, string termGuid, int wssId)
        {
            this.Label = label;
            this.TermGuid = termGuid;
            this.WssId = wssId;
        }

        [JsonProperty()]
        public virtual string Label { get; protected set; }

        [JsonProperty()]
        public virtual string TermGuid { get; protected set; }

        [JsonProperty()]
        public virtual int WssId { get; protected set; }

    }

}

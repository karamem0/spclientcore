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

    [ClientObject(Name = "SP.Taxonomy.TermStoreCollection", Id = "{e4a57a1e-7778-43ff-a88a-d5a61b231afa}")]
    [JsonObject()]
    public class TermStoreEnumerable : ClientObjectEnumerable<TermStore>
    {

        public TermStoreEnumerable()
        {
        }

    }

}
